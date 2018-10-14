using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace DEMO_SQLLite.entity
{
    public static class DataAccess
    {
        public static string SQL_CONECTION_STRING = "Filename=demo.db";

        public static string SQLITE_CONNECTION { get; internal set; }

        public static void InitializeDatabase()
        {
            using (SqliteConnection db =
                new SqliteConnection(SQL_CONECTION_STRING))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                                      "EXISTS Songs (id INTEGER PRIMARY KEY, " +
                                      "name NVARCHAR(250), thumbnail NVARCHAR(50))";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }
    }
}
