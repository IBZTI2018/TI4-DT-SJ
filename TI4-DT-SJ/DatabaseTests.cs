using System;
using System.Data.SqlClient;

namespace TI4_DT_SJ
{
  class DatabaseTests
  {
    public static bool testCreatingANewOrtWorksFine()
    {
      bool success = true;

      // Arrange
      Database.Instance.runCommand("INSERT INTO ort (id, plz, ort) VALUES(1, 8804, 'Au')");
      
      // Act+Assert
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM ort").ExecuteReader();
      while (reader.Read())
      {
        if (reader.GetInt32(0) != 1) success = false;
        if (reader.GetInt32(1) != 8804) success = false;
        if (reader.GetString(2) != "Au") success = false;
      }
      reader.Close();

      return success;
    }
  }
}
