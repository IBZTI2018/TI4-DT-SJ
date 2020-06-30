﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

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
    private Database() { }

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
    /// </summary>
    public void connect()
    {
      string databaseHost = ConfigurationManager.AppSettings["databaseHost"];
      string databaseUser = ConfigurationManager.AppSettings["databaseUser"];
      string databasePass = ConfigurationManager.AppSettings["databasePass"];
      string databaseName = ConfigurationManager.AppSettings["databaseName"];

      connection = new SqlConnection($"Data Source={databaseHost};Initial Catalog={databaseName};User ID={databaseUser};Password={databasePass}");

      try
      {
        connection.Open();
      } catch
      {
        MessageBox.Show($"Failed to connect to database {databaseName} at {databaseHost} with user {databaseUser}!");
        System.Environment.Exit(1);
      }
    }
  }
}
