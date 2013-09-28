using System.IO;
using TTApp.Model;
using Windows.Storage;

namespace TTApp
{
    public class Settings
    {
        private static Settings instance;
        public string dbPath { get; set; }
        public Match CurrentMatch { get; set; }

        private Settings()
        {
          var documents = ApplicationData.Current.LocalFolder.Path;
          var _pathToDatabase = Path.Combine(documents, "db_sqlite-net.db");
          dbPath = _pathToDatabase;
        }
        public static Settings Instance
        {
        get { return instance ?? (instance = new Settings()); }
        }
    }
}
