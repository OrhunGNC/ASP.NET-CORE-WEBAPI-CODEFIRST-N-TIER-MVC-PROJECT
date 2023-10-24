using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coremvcproject.Model
{
    public class Teams
    {
        [Key]
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string TeamCountry { get; set; }
        public decimal TotalValue { get; set; }
        public int LeaguesId { get; set; }
        [ForeignKey("LeaguesId")]
        public Leagues Leagues { get; set; }
    }
}
