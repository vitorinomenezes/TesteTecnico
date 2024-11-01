using System.Net.Http.Headers;
public class Program
{
    public static string BaseAddress { get { return "https://jsonmock.hackerrank.com"; } }
    public class Details
    {
        public string competition { get; set; }
        public int year { get; set; }

        public string round { get; set; }
        public string? team1 { get; set; }

        public string? team2 { get; set; }

        public int team1goals { get; set; }

        public int team2goals { get; set; }

    }

    public class Competitions
    {
        public int page { get; set; }

        public int per_page { get; set; }

        public int total { get; set; }

        public int total_pages { get; set; }
        public List<Details> data { get; set; }      
        
    }

    public static async Task Main()
    {
        string teamName = "Paris Saint-Germain";
        int year = 2013;
        int totalGoals = await GetTotalScoredGoals(teamName, year);

        Console.WriteLine("Team "+ teamName +" scored "+ totalGoals.ToString() + " goals in "+ year);

        teamName = "Chelsea";
        year = 2014;
        totalGoals = await GetTotalScoredGoals(teamName, year);

        Console.WriteLine("Team " + teamName + " scored " + totalGoals.ToString() + " goals in " + year);

        // Output expected:
        // Team Paris Saint - Germain scored 109 goals in 2013
        // Team Chelsea scored 92 goals in 2014
    }

    public static async Task<int> GetTotalScoredGoals(string team, int year)
    {
        Competitions _data = await GetCompetitionsAsync(team, year);

        return _data.data.Sum(X => X.team1goals);
    }

    static async Task<Competitions> GetCompetitionsAsync(string team, int year)
    {
        Competitions _data=new Competitions();
        using (var client = new HttpClient())
        {
            List<Competitions> Items = new List<Competitions>();
            client.BaseAddress = new System.Uri(BaseAddress);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string _method = string.Format("api/football_matches?year={0}&team1={1}",year, team);
            HttpResponseMessage response = await client.GetAsync(_method);
            if (response.IsSuccessStatusCode)
            { 
                 _data = await response.Content.ReadAsAsync<Competitions>();
                return _data;
            }
            
        }
        return _data;
    }

}