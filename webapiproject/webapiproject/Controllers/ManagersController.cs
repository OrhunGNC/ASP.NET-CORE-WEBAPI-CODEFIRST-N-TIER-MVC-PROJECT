using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using webapiproject.Model;

namespace webapiproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagersController : ControllerBase
    {
        public readonly ApplicationDbContext dbcontext;
        public ManagersController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        [HttpGet]
        public IActionResult Indexmanagers()
        {
            return Ok(dbcontext.Managerss.ToList());
        }
        [HttpPost]
        public IActionResult Addmanagers(Managers manager)
        {
            dbcontext.Add(manager);
            dbcontext.SaveChanges();
            return Created("", manager);
        }
        [HttpGet("{id}")]
        public IActionResult Searchmanagers(int id)
        {
            return Ok(dbcontext.Managerss.Find(id));
        }
        [HttpPut("{id}")]
        public IActionResult Updatemanagers(Managers managers)
        {
            dbcontext.Update(managers);
            dbcontext.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Deletemanagers(int id)
        {
            var delete = dbcontext.Managerss.Find(id);
            dbcontext.Remove(delete);
            dbcontext.SaveChanges();
            return NoContent();
        }
    }
}
