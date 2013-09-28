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
        [Ignore]
        public List<Point> Points { get; set; }

        [Ignore]
        public List<Shot> Shots { get; set; }

        public bool ServeFirst { get; set; }


        public Match Create()
        {
            var match = new Match(){ServeFirst = true, Points = new List<Point>(),
                Shots = new List<Shot>()
                    {
                        new Shot(){Position =0 },
                        new Shot(){Position =1 },
                        new Shot(){Position =2},
                        new Shot(){Position =3 },
                        new Shot(){Position =4 },
                        new Shot(){Position =5 },
                        new Shot(){Position =10 }
                    }
            
            };
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
