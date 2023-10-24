using coremvcproject.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace coremvcproject.Controllers
{
    public class PlayersController : Controller
    {
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync("https://localhost:44306/api/Players").Result;
            List<Players> players;
            players = JsonConvert.DeserializeObject<List<Players>>(response.Content.ReadAsStringAsync().Result);
            return View(players);
        }
        public IActionResult Create()
        {
            return View(new Players());
        }
        [HttpPost]
        public IActionResult Create(Players player)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(player), System.Text.Encoding.UTF8, "application/json");
            var response = client.PostAsync("https://localhost:44306/api/Players", content).Result;
            return RedirectToAction("Index");
        }
        public IActionResult Edit (int id)
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync($"https://localhost:44306/api/Players/{id}").Result;
            var players = JsonConvert.DeserializeObject<Players>(response.Content.ReadAsStringAsync().Result);
            return View(players);
        }
        [HttpPost]
        public IActionResult Edit(Players players)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(players),System.Text.Encoding.UTF8,"application/json");
            var response = client.PutAsync($"https://localhost:44306/api/Players/{players.PlayerId}", content).Result;
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            HttpClient client = new HttpClient();
            var response = client.DeleteAsync($"https://localhost:44306/api/Players/{id}").Result;
            return RedirectToAction("Index");
        }
    }
}
