using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace WorldCupQuiniela.Usercontrols
{
    /// <summary>
    /// Interaction logic for Playercontrol.xaml
    /// </summary>
    public partial class Playercontrol : UserControl
    {
        public string QuinieleroName { get; set; }
        public int Points { get; set; }
        public string[] Teams { get; set; }
        public string team0Record { get; set; }
        public string team1Record { get; set; }

        public Playercontrol()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            lbName.Content = QuinieleroName;
            lbPoints.Content = Points.ToString();

            // put flags there!
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.UriSource = new Uri(System.IO.Path.GetFullPath(string.Format("./world-cup-flags/{0}.gif", Teams[0])));
            image.EndInit();
            imgTeam1.Source = image;

            image = new BitmapImage();
            image.BeginInit();
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.UriSource = new Uri(System.IO.Path.GetFullPath(string.Format("./world-cup-flags/{0}.gif", Teams[1])));
            image.EndInit();
            imgTeam2.Source = image;

            Team0Record.Content = team0Record;
            Team1Record.Content = team1Record;
        }
    }
}
