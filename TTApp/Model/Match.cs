using System;
using System.Collections.Generic;
using SQLite;

namespace TTApp.Model
{
    public class Match
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public int PlayerPoints { get; set; }
        public int OpponentPoints { get; set; }

        //public Point[] Points { get; set; }
        public bool ServeFirst { get; set; }


        public Match Create()
        {
            var match = new Match(){ServeFirst = true};
            return match;


        }

        public bool Finished {
            get
            {
                return Math.Max(PlayerPoints, OpponentPoints) > 10 && Math.Abs(PlayerPoints - OpponentPoints) > 1;
            }
        }

    }
}
