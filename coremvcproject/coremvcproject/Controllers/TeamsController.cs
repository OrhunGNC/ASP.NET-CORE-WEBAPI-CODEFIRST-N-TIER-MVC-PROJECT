using coremvcproject.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace coremvcproject.Controllers
{
    public class TeamsController : Controller
    {
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync("https://localhost:44306/api/Teams").Result;
            List<Teams> teams;
            teams= JsonConvert.DeserializeObject<List<Teams>>(response.Content.ReadAsStringAsync().Result);
            return View(teams);
        }
        public IActionResult Create()
        {
            return View(new Teams());
        }
        [HttpPost]
        public IActionResult Create(Teams teams)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(teams), System.Text.Encoding.UTF8, "application/json");
            var response = client.PostAsync("https://localhost:44306/api/Teams", content).Result;
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync($"https://localhost:44306/api/Teams/{id}").Result;
            var teams = JsonConvert.DeserializeObject<Teams>(response.Content.ReadAsStringAsync().Result);
            return View(teams);
        }
        [HttpPost]
        public IActionResult Edit(Teams teams)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(teams), System.Text.Encoding.UTF8, "application/json");
            var response = client.PutAsync($"https://localhost:44306/api/Teams/{teams.TeamId}",content).Result;
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            HttpClient client = new HttpClient();
            var response = client.DeleteAsync($"https://localhost:44306/api/Teams/{id}").Result;
            return RedirectToAction("Index");
        }
    }
}
