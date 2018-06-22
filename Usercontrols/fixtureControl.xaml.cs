﻿using System;
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
    /// Interaction logic for fixtureControl.xaml
    /// </summary>
    public partial class fixtureControl : UserControl
    {
        public String TeamAway { get; set; }
        public string TeamHome { get; set; }
        public string Stadium { get; set; }
        public string Status { get; set; }
        public string Score { get; set; }
        public string Elapsed { get; set; }

        public fixtureControl()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            lbTeamAway.Content = TeamAway;
            lbTeamHome.Content = TeamHome;
            lbScore.Content = Score;
            lbStadium.Content = Stadium;
            lbTimestamp.Content = Status;
            lbElapsed.Content = Elapsed;


            // flags!
            if (File.Exists(System.IO.Path.GetFullPath(string.Format("./world-cup-flags/{0}.gif", TeamAway)))) {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = new Uri(System.IO.Path.GetFullPath(string.Format("./world-cup-flags/{0}.gif", TeamAway)));
                image.EndInit();
                imgTeamAway.Source = image;
            }

            if (File.Exists(System.IO.Path.GetFullPath(string.Format("./world-cup-flags/{0}.gif", TeamHome)))) {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = new Uri(System.IO.Path.GetFullPath(string.Format("./world-cup-flags/{0}.gif", TeamHome)));
                image.EndInit();
                imgTeamHome.Source = image;
            }
        }
    }
}
