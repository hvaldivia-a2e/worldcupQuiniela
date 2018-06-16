using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization;


namespace WorldCupQuiniela
{
    /// <summary>
    /// 
    /// </summary>
    public class Quinielero
    {
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name;
        [DataMember(Name = "teams", EmitDefaultValue = false)]
        public List<string> teams;
        [DataMember(Name = "points", EmitDefaultValue = false)]
        public int points;
        [DataMember(Name = "played_games", EmitDefaultValue = false)]
        public int playedGames;
        [DataMember(Name = "team_records", EmitDefaultValue = false)]
        public Dictionary<string, TeamRecord> teamRecords;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Quinielero {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  teams: ").Append(string.Join(",", teams)).Append("\n");
            sb.Append("  played_games: ").Append(playedGames).Append("\n");
            sb.Append("  points: ").Append(points).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public void Reset()
        {
            points = 0;
            playedGames = 0;
            if (teamRecords == null) teamRecords = new Dictionary<string, TeamRecord>();
            else teamRecords.Clear();

            foreach (string teamName in teams)
                teamRecords.Add(teamName, new TeamRecord());
        }
    }

    //
    public class TeamRecord
    {
        public int Win;
        public int Lose;
        public int Tie;

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", Win, Lose, Tie);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class AccessToken
    {
        [DataMember(Name = "new_access_token", EmitDefaultValue = false)]
        public string new_access_token;
        [DataMember(Name = "expire_date", EmitDefaultValue = false)]
        public string expire_date;
        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        public string expires_in;
        [DataMember(Name = "expires_in_ms", EmitDefaultValue = false)]
        public int expires_in_ms;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessToken {\n");
            sb.Append("  new_access_token: ").Append(new_access_token).Append("\n");
            sb.Append("  expire_date: ").Append(expire_date).Append("\n");
            sb.Append("  expires_in: ").Append(expires_in).Append("\n");
            sb.Append("  expires_in_ms: ").Append(expires_in_ms).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

    public class FixtureResponse
    {
        [DataMember(Name = "docs", EmitDefaultValue = false)]
        public Fixture[] docs;
        [DataMember(Name = "pagination", EmitDefaultValue = false)]
        public Pagination pagination;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessToken {\n");
            sb.Append("  pagination: ").Append(pagination).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Fixture {
        [DataMember(Name = "_id", EmitDefaultValue = false)]
        public int _id;
        [DataMember(Name = "id_country", EmitDefaultValue = false)]
        public int id_country;
        [DataMember(Name = "id_league", EmitDefaultValue = false)]
        public int id_league;
        [DataMember(Name = "id_season", EmitDefaultValue = false)]
        public int id_season;
        [DataMember(Name = "id_stage", EmitDefaultValue = false)]
        public int id_stage;
        [DataMember(Name = "first_half_ended_at", EmitDefaultValue = false)]
        public DateTime first_half_ended_at;
        [DataMember(Name = "fixture_status", EmitDefaultValue = false)]
        public string fixture_status;
        [DataMember(Name = "fixture_status_short", EmitDefaultValue = false)]
        public string fixture_status_short;
        [DataMember(Name = "game_ended_at", EmitDefaultValue = false)]
        public DateTime game_ended_at;
        [DataMember(Name = "game_started_at", EmitDefaultValue = false)]
        public DateTime game_started_at;
        [DataMember(Name = "id_referee", EmitDefaultValue = false)]
        public int id_referee;
        [DataMember(Name = "id_team_season_away", EmitDefaultValue = false)]
        public int id_team_season_away;
        [DataMember(Name = "id_team_season_home", EmitDefaultValue = false)]
        public int id_team_season_home;
        [DataMember(Name = "lineup_confirmed", EmitDefaultValue = false)]
        public string lineup_confirmed;        
        [DataMember(Name = "number_goal_team_away", EmitDefaultValue = false)]
        public int number_goal_team_away;
        [DataMember(Name = "number_goal_team_home", EmitDefaultValue = false)]
        public int number_goal_team_home;
        [DataMember(Name = "referee_name", EmitDefaultValue = false)]
        public string referee_name;
        [DataMember(Name = "round", EmitDefaultValue = false)]
        public string round;
        [DataMember(Name = "schedule_date", EmitDefaultValue = false)]
        public DateTime schedule_date;
        [DataMember(Name = "second_half_ended_at", EmitDefaultValue = false)]
        public DateTime second_half_ended_at;
        [DataMember(Name = "second_half_started_at", EmitDefaultValue = false)]
        public DateTime second_half_started_at;
        [DataMember(Name = "spectators", EmitDefaultValue = false)]
        public int spectators;
        [DataMember(Name = "stadium", EmitDefaultValue = false)]
        public string stadium;
        [DataMember(Name = "team_season_away_name", EmitDefaultValue = false)]
        public string team_season_away_name;
        [DataMember(Name = "team_season_home_name", EmitDefaultValue = false)]
        public string team_season_home_name;
        [DataMember(Name = "elapsed", EmitDefaultValue = false)]
        public int elapsed;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessToken {\n");
            sb.Append("  _id: ").Append(_id).Append("\n");
            sb.Append("  id_country: ").Append(id_country).Append("\n");
            sb.Append("  id_league: ").Append(id_league).Append("\n");
            sb.Append("  id_season: ").Append(id_season).Append("\n");
            sb.Append("  id_stage: ").Append(id_stage).Append("\n");
            sb.Append("  elapsed: ").Append(elapsed).Append("\n");
            sb.Append("  first_half_ended_at: ").Append(first_half_ended_at).Append("\n");
            sb.Append("  fixture_status: ").Append(fixture_status).Append("\n");
            sb.Append("  fixture_status_short: ").Append(fixture_status_short).Append("\n");
            sb.Append("  game_ended_at: ").Append(game_ended_at).Append("\n");
            sb.Append("  game_started_at: ").Append(game_started_at).Append("\n");
            sb.Append("  id_referee: ").Append(id_referee).Append("\n");
            sb.Append("  id_team_season_away: ").Append(id_team_season_away).Append("\n");
            sb.Append("  id_team_season_home: ").Append(id_team_season_home).Append("\n");
            sb.Append("  lineup_confirmed: ").Append(lineup_confirmed).Append("\n");
            sb.Append("  number_goal_team_away: ").Append(number_goal_team_away).Append("\n");
            sb.Append("  number_goal_team_home: ").Append(number_goal_team_home).Append("\n");
            sb.Append("  referee_name: ").Append(referee_name).Append("\n");
            sb.Append("  round: ").Append(round).Append("\n");
            sb.Append("  schedule_date: ").Append(schedule_date).Append("\n");
            sb.Append("  second_half_ended_at: ").Append(second_half_ended_at).Append("\n");
            sb.Append("  second_half_started_at: ").Append(second_half_started_at).Append("\n");
            sb.Append("  stadium: ").Append(stadium).Append("\n");
            sb.Append("  spectators: ").Append(spectators).Append("\n");
            sb.Append("  team_season_away_name: ").Append(team_season_away_name).Append("\n");
            sb.Append("  team_season_home_name: ").Append(team_season_home_name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

    //
    public class Pagination
    {
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int total;
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int limit;
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public int page;
        [DataMember(Name = "pages", EmitDefaultValue = false)]
        public int pages;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessToken {\n");
            sb.Append("  total: ").Append(total).Append("\n");
            sb.Append("  limit: ").Append(limit).Append("\n");
            sb.Append("  page: ").Append(page).Append("\n");
            sb.Append("  pages: ").Append(pages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Team
    {
        public int id;
        public string Name;
        public int wins;
        public int lost;
        public int ties;
        public int points;
        public int goals;
        public int goalsAgainst;
    }
}
