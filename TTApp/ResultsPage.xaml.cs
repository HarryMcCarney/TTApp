using System.Linq;
using Microsoft.Phone.Controls;

namespace TTApp
{
    public partial class ResultsPage : PhoneApplicationPage
    {
        public ResultsPage()
        {
            InitializeComponent();
            var shots = Settings.Instance.CurrentMatch.Shots;
            var shot1 = (from x in shots where x.Position == 0 select x.WinPercent).FirstOrDefault();
            if (shot1 != null)
                Postion0.Text = shot1.ToString();
            var default1 = (from x in shots where x.Position == 1 select x.WinPercent).FirstOrDefault();
            if (default1 != null)
                Postion1.Text = default1.ToString();
            var orDefault1 = (from x in shots where x.Position == 2 select x.WinPercent).FirstOrDefault();
            if (orDefault1 != null)
                Postion2.Text = orDefault1.ToString();
            var firstOrDefault1 = (from x in shots where x.Position == 3 select x.WinPercent).FirstOrDefault();
            if (firstOrDefault1 != null)
                Postion3.Text = firstOrDefault1.ToString();
            var shot = (from x in shots where x.Position == 4 select x.WinPercent).FirstOrDefault();
            if (shot != null)
                Postion4.Text = shot.ToString();
            var @default = (from x in shots where x.Position == 5 select x.WinPercent).FirstOrDefault();
            if (@default != null)
                Postion5.Text = @default.ToString();
            var orDefault = (from x in shots where x.Position == 10 select x.WinPercent).FirstOrDefault();
            if (orDefault != null)
                Postion10.Text = orDefault.ToString();
            var firstOrDefault = (from x in shots where x.Position == 11 select x.WinPercent).FirstOrDefault();
            if (firstOrDefault != null)
                Postion11.Text = firstOrDefault.ToString();
        }
    }
}