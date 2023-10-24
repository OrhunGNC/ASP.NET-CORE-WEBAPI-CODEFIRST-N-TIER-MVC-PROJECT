using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapiproject.Model
{
    public class Managers
    {
        [Key]
        public int ManagersId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public int TeamsId { get; set; }
        [ForeignKey("TeamsId")]
        public Teams Teams { get; set; }
    }
}
