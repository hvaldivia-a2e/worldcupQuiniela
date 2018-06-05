using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WorldCupQuiniela.Usercontrols;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WorldCupQuiniela {

    public partial class MainWindow : Window {
        private List<Quinielero>    quinieleros;
        private AccessToken         authToken;
        private List<Fixture>       upcoming;
        private List<Fixture>       inPlay;
        static HttpClient           client = new HttpClient();
        private bool                refreshToken = true;
        private int                 currentInPlay = 0;
        System.Windows.Threading.DispatcherTimer refreshTokenTimer = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer refreshFeedTimer  = new System.Windows.Threading.DispatcherTimer();

        public MainWindow() {
            InitializeComponent(); 
            refreshTokenTimer.Tick += RefreshTokenTimer_Tick;
            refreshFeedTimer.Tick  += RefreshFeedTimer_Tick;
            quinieleros = JsonConvert.DeserializeObject<List<Quinielero>>(File.ReadAllText("quinieleros.json"));
        }

        private void RefreshFeedTimer_Tick(object sender, EventArgs e) { 
            if (refreshToken) RefreshToken();
            RefreshFromFeed();
            if(currentInPlay != inPlay.Count) RefreshRanking();
            currentInPlay = inPlay.Count;
            if (currentInPlay > 0)  refreshFeedTimer.Interval = TimeSpan.FromSeconds(10);
            else                    refreshFeedTimer.Interval = (upcoming[0].schedule_date.ToLocalTime() - DateTime.Now.ToLocalTime());
        }

        private void RefreshTokenTimer_Tick(object sender, EventArgs e) { refreshToken = true; refreshTokenTimer.Stop(); }

        private void Window_Loaded(object sender, RoutedEventArgs e) {

            if (refreshToken) RefreshToken();
            RefreshFromFeed();
            RefreshRanking();

            currentInPlay = inPlay.Count;
            if(inPlay.Count > 0)    refreshFeedTimer.Interval = TimeSpan.FromSeconds(10);
            else                    refreshFeedTimer.Interval = (upcoming[0].schedule_date.ToLocalTime() - DateTime.Now.ToLocalTime());

            refreshFeedTimer.Start();
        }

        private void RefreshFromFeed() {

            GetInProgress();
            fixturesGrid.Children.Clear();
            int fixturesDisplayed = 0;
            foreach(Fixture f in inPlay) {
                fixturesGrid.Children.Add(new fixtureControl(){
                    TeamAway    = f.team_season_away_name,
                    TeamHome    = f.team_season_home_name,
                    Stadium     = f.stadium,
                    Score       = string.Format("{0}-{1}", f.number_goal_team_away, f.number_goal_team_home),
                    Status      = f.fixture_status,
                    Width       = 800
                });
                if (++fixturesDisplayed == 3) break;
            }

            if(fixturesDisplayed < 3) {
                GetUpcomingFixtures();
                foreach (Fixture f in upcoming) {
                    fixturesGrid.Children.Add(new fixtureControl() {
                        TeamAway    = f.team_season_away_name,
                        TeamHome    = f.team_season_home_name,
                        Stadium     = f.stadium,
                        Score       = "0 - 0",
                        Status      = f.schedule_date.ToLocalTime().ToString(),
                        Width       = 800
                    });
                    if (++fixturesDisplayed == 3) break;
                }
            }
        }

        void RefreshToken() {
            client.BaseAddress = new Uri("https://api.sportdeer.com/v1/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add( new MediaTypeWithQualityHeaderValue("application/json"));

            string request = "accessToken?refresh_token=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VySWQiOiI1YjA4NjA0OTQ2MjNjNDU3ZjBjMDA4YjgiLCJpYXQiOjE1MjcyNzU3MTd9.XLxW4EfagQzqODlF6ZPHU3b2w6B88Jiav0zp55cKYW4";
            HttpResponseMessage response = client.GetAsync(request).Result;
            response.EnsureSuccessStatusCode();
            authToken = JsonConvert.DeserializeObject<AccessToken>(response.Content.ReadAsStringAsync().Result);
            refreshTokenTimer.Interval = TimeSpan.FromMilliseconds(authToken.expires_in_ms - 120000);
            refreshTokenTimer.Start();
            refreshToken = false;
        }

        private void RefreshRanking() {
            CalculatePoints();
            var ordered = quinieleros.OrderByDescending(q => q.points);
            foreach(Quinielero q in ordered) quinielerosGrid.Children.Add(new Playercontrol() { Name = q.Name, Points = q.points, Teams = q.teams.ToArray()});
        }

        private void GetInProgress() {
            string request = string.Format("seasons/296/inplay?access_token={0}", authToken.new_access_token);
            HttpResponseMessage response = client.GetAsync(request).Result;
            response.EnsureSuccessStatusCode();
            FixtureResponse fixtureResponse = JsonConvert.DeserializeObject<FixtureResponse>(response.Content.ReadAsStringAsync().Result);
            inPlay = fixtureResponse.docs.ToList();
        }

        private void GetUpcomingFixtures() {
            string request = string.Format("seasons/296/upcoming?access_token={0}", authToken.new_access_token);
            HttpResponseMessage response = client.GetAsync(request).Result;
            response.EnsureSuccessStatusCode();
            FixtureResponse fixtureResponse = JsonConvert.DeserializeObject<FixtureResponse>(response.Content.ReadAsStringAsync().Result);
            upcoming = fixtureResponse.docs.ToList();
        }

        private void CalculatePoints() {
            bool done = false;
            int  page = 1;
            List<Fixture> finished = new List<Fixture>();
            List<string> validRounds = new List<string>() { "1", "2", "3"};

            do {
                string request = string.Format("seasons/296/fixtures?page={0}&access_token={1}", page, authToken.new_access_token);
                HttpResponseMessage response = client.GetAsync(request).Result;
                response.EnsureSuccessStatusCode();
                FixtureResponse fixtureResponse = JsonConvert.DeserializeObject<FixtureResponse>(response.Content.ReadAsStringAsync().Result);
                finished.AddRange(fixtureResponse.docs.ToList().Where( f => (f.fixture_status_short == "FIN" && validRounds.Contains(f.round))).ToList());
                done = (page == fixtureResponse.pagination.pages);
                page++;

            } while (!done);

            foreach (Quinielero q in quinieleros) q.points = 0;
            foreach(Fixture f in finished) {
                if(f.number_goal_team_away == f.number_goal_team_home) {
                    quinieleros.Where(q => q.teams.Contains(f.team_season_away_name)).First().points += 1;
                    quinieleros.Where(q => q.teams.Contains(f.team_season_home_name)).First().points += 1;
                }
                else if(f.number_goal_team_away > f.number_goal_team_home) quinieleros.Where(q => q.teams.Contains(f.team_season_away_name)).First().points += 3;
                else quinieleros.Where(q => q.teams.Contains(f.team_season_home_name)).First().points += 3;
            }
        }
    }    
}
