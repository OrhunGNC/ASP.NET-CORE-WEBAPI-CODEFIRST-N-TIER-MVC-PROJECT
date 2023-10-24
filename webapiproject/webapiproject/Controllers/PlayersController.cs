using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using webapiproject.Model;

namespace webapiproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        public readonly ApplicationDbContext dbcontext;
        public PlayersController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        [HttpGet]
        public IActionResult Indexplayers()
        {
            return Ok(dbcontext.Playerss.ToList());
        }
        [HttpPost]
        public IActionResult Addplayers(Players players)
        {
            dbcontext.Playerss.Add(players);
            dbcontext.SaveChanges();
            return Created("", players);
        }
        [HttpGet("{id}")]
        public IActionResult Searchplayers(int id)
        {
            return Ok(dbcontext.Playerss.Find(id));
        }
        [HttpPut("{id}")]
        public IActionResult Updateplayers(int id, Players players)
        {
            var update = dbcontext.Playerss.Find(id);
            update.PlayerName = players.PlayerName;
            update.PlayerSalary = players.PlayerSalary;
            update.MarketValue = players.MarketValue;
            update.DateofBirth = players.DateofBirth;
            update.Nationality = players.Nationality;
            update.TeamsId = players.TeamsId;
            dbcontext.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Deleteplayers(int id)
        {
            var delete = dbcontext.Playerss.Find(id);
            dbcontext.Remove(delete);
            dbcontext.SaveChanges();
            return NoContent();
        }
    }
}
