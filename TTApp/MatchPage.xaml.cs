using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Phone.Controls;
using TTApp.BL;

namespace TTApp
{
    public partial class MatchPage : PhoneApplicationPage
    {
        public string score {
            get
            {
                return Settings.Instance.CurrentMatch.PlayerPoints.ToString() + "-" +
                Settings.Instance.CurrentMatch.OpponentPoints.ToString();
            } 
        }

        public MatchPage()
        {
            InitializeComponent();
            ScoreBoard.Text = score;
        }


        public void RecordScore(object sender, RoutedEventArgs e)
        {

            var button = sender as Button;
            var point = int.Parse(button.Tag as String);
            new AwardPoint().Award(point);
        
            ScoreBoard.Text = score;

            if (Settings.Instance.CurrentMatch.Finished)
                NavigationService.Navigate(new Uri("/ResultsPage.xaml", UriKind.Relative));


        }

        
        
    }
}