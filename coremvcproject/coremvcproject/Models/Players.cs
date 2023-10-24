using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coremvcproject.Model
{
    public class Players
    {
        [Key]
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public decimal PlayerSalary { get; set; }
        public decimal MarketValue { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Nationality { get; set; }
        public int TeamsId { get; set; }
        [ForeignKey("TeamsId")]
        public Teams Teams { get; set; }
    }
}
