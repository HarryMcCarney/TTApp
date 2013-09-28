using System;
using System.IO;
using TTApp.Model;
using Windows.Storage;

namespace TTApp
{
    public static class SetupDb
    {


        public static void init()
        {
            var _pathToDatabase = Settings.Instance.dbPath;

            using (var conn = new SQLite.SQLiteConnection(_pathToDatabase))
            {
                conn.CreateTable<Point>();
                conn.CreateTable<Match>();
            }

        }

    }
}
