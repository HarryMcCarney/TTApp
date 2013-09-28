using TTApp.Model;

namespace TTApp.BL
{
    public class AwardPoint
    {
        public void Award(int WinningShot)
        {
            if (WinningShot%2 == 0)
            {
                Settings.Instance.CurrentMatch.OpponentPoints += 1;

            }
            else
            {
                Settings.Instance.CurrentMatch.PlayerPoints += 1;
            }


         }

        }
}
