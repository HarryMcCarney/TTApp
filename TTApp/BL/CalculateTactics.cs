using System.Linq;

namespace TTApp.BL
{
   public class CalculateTactics
    {

       public void calc()
       {
           var match = Settings.Instance.CurrentMatch;


           var totalPoints = match.Points.Count;

           foreach (var shot in match.Shots)
           {
               shot.WinPercent = (from x in match.Points where x.LastShot == shot.Position select x).Count() / totalPoints * 100;

           }


       }
    }
}
