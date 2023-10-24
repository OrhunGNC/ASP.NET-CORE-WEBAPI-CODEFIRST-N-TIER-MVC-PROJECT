using coremvcproject.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace coremvcproject.Controllers
{
    public class ManagersController : Controller
    {
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync("https://localhost:44306/api/Managers").Result;
            List<Managers> managers;
            managers = JsonConvert.DeserializeObject<List<Managers>>(response.Content.ReadAsStringAsync().Result);
            return View(managers);
        }
        public IActionResult Create()
        {
            return View(new Managers());
        }
        [HttpPost]
        public IActionResult Create(Managers managers)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(managers),System.Text.Encoding.UTF8,"application/json");
            var response = client.PostAsync("https://localhost:44306/api/Managers", content).Result;
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync($"https://localhost:44306/api/Managers/{id}").Result;
            var managers=JsonConvert.DeserializeObject<Managers>(response.Content.ReadAsStringAsync().Result);
            return View(managers);
        }
        [HttpPost]
        public IActionResult Edit(Managers managers)
        {
            HttpClient client = new HttpClient();
            StringContent content =new StringContent(JsonConvert.SerializeObject(managers), System.Text.Encoding.UTF8,"application/json");
            var response = client.PutAsync($"https://localhost:44306/api/Managers/{managers.ManagersId}",content).Result;
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            HttpClient client = new HttpClient();
            var response = client.DeleteAsync($"https://localhost:44306/api/Managers/{id}").Result;
            return RedirectToAction("Index");
        }
    }
}
