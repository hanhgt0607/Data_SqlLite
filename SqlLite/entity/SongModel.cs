using DEMO_SQLLite.entity;
using Microsoft.Data.Sqlite;
using SqlLite.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_SQLLite
{
    class SongModel
    {
        public static void Add(Song song)
        {
            using (SqliteConnection db =
            new SqliteConnection(DataAccess.SQLITE_CONNECTION))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                // Use parameterized query to prevent SQL injection attacks
                insertCommand.CommandText = "INSERT INTO Songs (name, thumbnail) VALUES (@name, @thumbnail);";
                insertCommand.Parameters.AddWithValue("@name", song.name);
                insertCommand.Parameters.AddWithValue("@thumbnail", song.thumbnail);
                insertCommand.ExecuteReader();
                db.Close();
            }
        }

        public static List<Song> GetData()
        {
            List<Song> music = new List<Song>();

            using (SqliteConnection db =
                new SqliteConnection(DataAccess.SQL_CONECTION_STRING))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * from Songs", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    var song = new Song();
                    song.name = query["name"].ToString();
                    song.thumbnail = query["thumbnail"].ToString();
                    music.Add(song);
                }

                db.Close();
            }

            return music;
        }
    }

}
