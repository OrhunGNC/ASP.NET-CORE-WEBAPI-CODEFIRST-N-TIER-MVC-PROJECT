using coremvcproject.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
namespace coremvcproject.Controllers
{
    public class LeaguesController : Controller
    {
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync("https://localhost:44306/api/Leagues").Result;
            List<Leagues> league;
            league = JsonConvert.DeserializeObject<List<Leagues>>(response.Content.ReadAsStringAsync().Result);
            return View(league);
        }

        public IActionResult Create()
        {
            return View(new Leagues());
        }
        [HttpPost]
        public IActionResult Create(Leagues league)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(league),System.Text.Encoding.UTF8,"application/json");
            var response = client.PostAsync("https://localhost:44306/api/Leagues", content).Result;
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync($"https://localhost:44306/api/Leagues/{id}").Result;
            var leagues = JsonConvert.DeserializeObject<Leagues>(response.Content.ReadAsStringAsync().Result);
            return View(leagues);
        }
        [HttpPost]
        public IActionResult Edit(Leagues leagues)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(leagues), System.Text.Encoding.UTF8, "application/json");
            var response = client.PutAsync($"https://localhost:44306/api/Leagues/{leagues.LeaguesId}",content).Result;
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            HttpClient client = new HttpClient();
            var response = client.DeleteAsync($"https://localhost:44306/api/Leagues/{id}").Result;
            return RedirectToAction("Index");
        }
    }
}
