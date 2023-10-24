using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using webapiproject.Model;

namespace webapiproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaguesController : ControllerBase
    {
        public readonly ApplicationDbContext dbcontext;
        public LeaguesController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        [HttpGet]
        public IActionResult Indexleague()
        {
            return Ok(dbcontext.Leaguess.ToList());
        }
        [HttpPost]
        public IActionResult Addleague(Leagues league)
        {
            dbcontext.Add(league);
            dbcontext.SaveChanges();
            return Created("", league);
        }
        [HttpGet("{id}")]
        public IActionResult Searchleague(int id)
        {
            return Ok(dbcontext.Leaguess.Find(id));
        }
        [HttpPut("{id}")]
        public IActionResult Updateleague(int id,Leagues league)
        {
            var update = dbcontext.Leaguess.Find(id);
            update.LeagueName = league.LeagueName;
            update.LeagueCountry = league.LeagueCountry;
            update.MostChampTeam= league.MostChampTeam;
            update.NumbofTeams= league.NumbofTeams;
            dbcontext.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Deleteleague(int id)
        {
            var delete = dbcontext.Leaguess.Find(id);
            dbcontext.Remove(delete);
            dbcontext.SaveChanges();
            return NoContent();
        }
    }
}
