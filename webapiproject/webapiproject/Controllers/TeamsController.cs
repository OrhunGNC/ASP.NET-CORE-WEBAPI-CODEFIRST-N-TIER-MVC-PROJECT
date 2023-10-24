using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using webapiproject.Model;

namespace webapiproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        public readonly ApplicationDbContext dbcontext;
        public TeamsController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        [HttpGet]
        public IActionResult Indexteams()
        {

            return Ok(dbcontext.Teamss.ToList());
        }
        [HttpPost]
        public IActionResult Addteams(Teams teams)
        {
            dbcontext.Add(teams);
            dbcontext.SaveChanges();
            return Created("", teams);
        }
        [HttpGet("{id}")]
        public IActionResult Searchteams(int id)
        {
            return Ok(dbcontext.Teamss.Find(id));
        }
        [HttpPut("{id}")]
        public IActionResult Updateteams(Teams teams)
        {
            dbcontext.Update(teams);
            dbcontext.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Deleteteams(int id)
        {
            var delete = dbcontext.Teamss.Find(id);
            dbcontext.Remove(delete);
            dbcontext.SaveChanges();
            return NoContent();
        }
    }
}
