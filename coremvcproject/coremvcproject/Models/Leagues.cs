using System.ComponentModel.DataAnnotations;

namespace coremvcproject.Model
{
    public class Leagues
    {
        [Key]
        public int LeaguesId { get; set; }
        public string LeagueName { get; set;}
        public string LeagueCountry { get; set;}
        public string MostChampTeam { get; set;}
        public int NumbofTeams { get; set;}
    }
}
