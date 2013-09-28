using SQLite;

namespace TTApp.Model
{
    public class Point
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public int LastShot { get; set; }
    }
}
