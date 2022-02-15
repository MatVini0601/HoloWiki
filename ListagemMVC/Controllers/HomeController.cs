using ListagemMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ListagemMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}