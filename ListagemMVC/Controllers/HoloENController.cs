using ListagemMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace ListagemMVC.Controllers
{

    public class ViewModelEN
    {
        public List<HoloEN> _talentsMyth { get; set; }
        public List<HoloEN> _talentsCouncil { get; set; }
        public List<HoloEN> _talentsHOPE { get; set; }
        public List<Units> _units { get; set; }
    }
    public class HoloENController : Controller
    {
        string baseUrl = "https://matvini0601.github.io/";

        public async Task<String> Request(string resource)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage Res = await client.GetAsync($"Data/HoloEN/{resource}.json");
            var holoRes = Res.Content.ReadAsStringAsync().Result;
            return holoRes;
        }

        public IActionResult About()
        {
            return View();
        }

        public async Task<IActionResult> HoloMyth()
        {
            List<HoloEN> holoEN = new List<HoloEN>();
            string holoRes = await Request("Myth");
            holoEN = JsonConvert.DeserializeObject<List<HoloEN>>(holoRes);

            return View(holoEN);

        }

        public async Task<IActionResult> HoloCouncil()
        {
            List<HoloEN> holoCouncil = new List<HoloEN>();
            string holoRes = await Request("Council");
            holoCouncil = JsonConvert.DeserializeObject<List<HoloEN>>(holoRes);

            return View(holoCouncil);

        }

        public async Task<IActionResult> ProjectHOPE()
        {
            List<HoloEN> hope = new List<HoloEN>();
            string holoRes = await Request("HOPE");
            hope = JsonConvert.DeserializeObject<List<HoloEN>>(holoRes);

            return View(hope);
        }
    }
}