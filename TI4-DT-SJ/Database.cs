using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace TI4_DT_SJ
{
  class Database
  {

    /// The singleton instance of the database class
    private static Database instance = null;

    /// The connection to the database
    private SqlConnection connection;

    /// <summary>
    /// Internal empty constructor
    /// </summary>
    public Database() { }

    public static Database Instance
    {
      get
      {
        if (instance == null) instance = new Database();
        return instance;
      }
    }

    /// <summary>
    /// Connect to an MSSQL database on the local host. 
    /// 
    /// This method must be called once before any other database action.
    /// 
    /// We assume that a failure to connect to the database renders the program unusable for this simple proof
    /// of concept implementation. Proper error handling and db connection settings could be added later
    /// <param name="withDatabase"/>Whether or not the casestudy database should be selected</param>
    /// </summary>
    public Database connect(bool withDatabase, string username = null, string password = null)
    {
      string databaseHost = ConfigurationManager.AppSettings["databaseHost"];
      string databaseUser = ConfigurationManager.AppSettings["databaseUser"];
      string databasePass = ConfigurationManager.AppSettings["databasePass"];
      string databaseName = ConfigurationManager.AppSettings["databaseName"];

      if (username != null) databaseUser = username;
      if (password != null) databasePass = password;

      String catalogString = (withDatabase) ? $"Initial Catalog={databaseName};" : "";
      connection = new SqlConnection($"Data Source={databaseHost};{catalogString}User ID={databaseUser};Password={databasePass}");

      try
      {
        connection.Open();
      } catch (Exception e)
      {
        MessageBox.Show($"Failed to connect to database {databaseName} at {databaseHost} with user {databaseUser}!\n{e.Message}");
        System.Environment.Exit(1);
      }

      return this;
    }

    /// <summary>
    /// Disconnect the open database connection
    /// </summary>
    public Database disconnect()
    {
      // Happens when no role was selected
      if (this.connection == null) return this;

      this.connection.Close();
      return this;
    }

    /// <summary>
    /// Create an sql command with the current database connection information
    /// </summary>
    /// <param name="query">The SQL query to exectute</param>
    /// <returns>An SqlCommand object with the passed query</returns>
    public SqlCommand getCommand(String query)
    {
      return new SqlCommand(query, this.connection);
    }

    /// <summary>
    /// Create and run an insert command on a specific table with the given dictionary
    /// </summary>
    /// <param name="table">The name of the table to insert into</param>
    /// <param name="values">The values that should be inserted</param>
    /// <returns>The ID of the newly inserted row (or null if identity off)</returns>
    public int insertCommand(String table, Dictionary<String, dynamic> values)
    {
      String[] keys = values.Keys.ToArray();
      String fields = String.Join(", ", keys);
      String placeholders = "@" + String.Join(", @", keys);

      SqlCommand command = new SqlCommand(null, this.connection);
      command.CommandText = "INSERT INTO " + table + " (" + fields + ") VALUES (" + placeholders + "); SELECT SCOPE_IDENTITY();";
      
      foreach (String key in keys)
      {
        command.Parameters.AddWithValue("@" + key, values[key]);
      }

      object newId = command.ExecuteScalar();
      if (newId is null || newId is DBNull) return 0;
      return Convert.ToInt32(newId);
    }

    /// <summary>
    /// Create and run an update command on a specific table with the given dictionary
    /// </summary>
    /// <param name="table">The name of the table to insert into</param>
    /// <param name="id">The id of the row to update</param>
    /// <param name="values">The values that should be inserted</param>
    public void updateCommand(String table, int id, Dictionary<String, dynamic> values)
    {
      String[] keys = values.Keys.ToArray();
      String[] changes = new string[keys.Length];
      for (int i = 0; i < changes.Length; i++) {
        changes[i] = $"{keys[i]}=@{keys[i]}";
      }

      SqlCommand command = new SqlCommand(null, this.connection);
      command.CommandText = "UPDATE " + table + " SET " + String.Join(", ", changes) + " WHERE id=@id;";
      command.Parameters.AddWithValue("@id", id);

      foreach (String key in keys) {
        command.Parameters.AddWithValue("@" + key, values[key]);
      }

      command.ExecuteNonQuery();
    }

    /// <summary>
    /// Create and run a delete command on a specific table with the given id
    /// </summary>
    /// <param name="table">The name of the table to insert into</param>
    /// <param name="id">The id of the row to update</param>
    public void deleteCommand(String table, int id)
    {
      SqlCommand command = new SqlCommand(null, this.connection);
      command.CommandText = "DELETE FROM " + table + " WHERE id=@id;";
      command.Parameters.AddWithValue("@id", id);
      command.ExecuteNonQuery();
    }

    /// <summary>
    /// Get the reader for a single item fetched by its ID (could also be done scalar)
    /// </summary>
    /// <param name="table">The name of the table to select from</param>
    /// <param name="id">The id to select for</param>
    /// <returns>An SQL data reader with the first result fetched</returns>
    public object selectCommand(String table, int id, Type type)
    {
      SqlCommand command = this.prepareCommand("SELECT * FROM " + table + " WHERE id = @id", (cmd) =>
      {
        cmd.Parameters.AddWithValue("@id", id);
        return cmd;
      });

      SqlDataReader reader = command.ExecuteReader();
      reader.Read();
      object instance = Activator.CreateInstance(type, new object[] { reader });
      reader.Close();
      return instance;
    }

    /// <summary>
    /// Prepare a command for later execution
    /// </summary>
    /// <param name="query">The query string of the command</param>
    /// <param name="preparator">A preparator lambda that can fill out parameters</param>
    /// <returns></returns>
    public SqlCommand prepareCommand(String query, Func<SqlCommand, SqlCommand> preparator)
    {
      SqlCommand command = new SqlCommand(null, this.connection);
      command.CommandText = query;
      command = preparator(command);
      return command;
    }

    /// <summary>
    /// Fire and forget an sql command with the current database connection information
    /// </summary>
    /// <param name="query">The SQL query to exectute</param>
    /// <returns>An SqlCommand object with the passed query</returns>
    public void runCommand(String query)
    {
      SqlCommand command = new SqlCommand(query, this.connection);
      command.ExecuteNonQuery();
      command.Dispose();
    }
  }
}
