using ListagemMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace ListagemMVC.Controllers
{
    public class HoloJPController : Controller
    {
        string baseUrl = "https://matvini0601.github.io/";
        public async Task<String> Request(string resource)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage Res = await client.GetAsync($"Data/HoloJP/{resource}.json");
            var holoRes = Res.Content.ReadAsStringAsync().Result;
            return holoRes;
        }

        public async Task<IActionResult> Gen0()
        {
            List<HoloJP> gen0 = new List<HoloJP>();
            string holoRes = await Request("Gen0");
            gen0 = JsonConvert.DeserializeObject<List<HoloJP>>(holoRes);
            return View(gen0);
        }

        public async Task<IActionResult> Gen1()
        {
            List<HoloJP> gen1 = new List<HoloJP>();
            string holoRes = await Request("Gen1");
            gen1 = JsonConvert.DeserializeObject<List<HoloJP>>(holoRes);
            return View(gen1);
        }

        public async Task<IActionResult> Gen2()
        {
            List<HoloJP> gen2 = new List<HoloJP>();
            string holoRes = await Request("Gen2");
            gen2 = JsonConvert.DeserializeObject<List<HoloJP>>(holoRes);
            return View(gen2);
        }

        public async Task<IActionResult> Gen3()
        {
            List<HoloJP> gen3 = new List<HoloJP>();
            string holoRes = await Request("Gen3");
            gen3 = JsonConvert.DeserializeObject<List<HoloJP>>(holoRes);
            return View(gen3);
        }

        public IActionResult Gamers()
        {
            return View();
        }

        public IActionResult Gen4()
        {
            return View();
        }

        public IActionResult Gen5()
        {
            return View();
        }

        public IActionResult Gen6()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
