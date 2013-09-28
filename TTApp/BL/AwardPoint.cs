using System.Collections.Generic;
using TTApp.Model;

namespace TTApp.BL
{
    public class AwardPoint
    {
        public void Award(int WinningShot)
        {

            var match = Settings.Instance.CurrentMatch;
            match.Points.Add(new Point(){LastShot = WinningShot});

            
            if (WinningShot % 2 == 0)
            {
                match.OpponentPoints += 1;

            }
            else
            {
                match.PlayerPoints += 1;
            }


         }

        }
}
