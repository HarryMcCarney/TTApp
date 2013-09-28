using System.IO;
using TTApp.Model;
using Windows.Storage;

namespace TTApp.BL
{
    public class BeginMatch
    {
        public Match Begin()
        {
        var match = new Match().Create();
        var _pathToDatabase = Settings.Instance.dbPath;

        using (var conn = new SQLite.SQLiteConnection(_pathToDatabase))
        {
            conn.Insert(match);
        }
        Settings.Instance.CurrentMatch = match;
        return match;
        
        }
    }
}
