using ListagemMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListagemMVC.Controllers
{

    public class ViewModelJP
    {
        public List<HoloJP> _talentsJP0 { get; set; }
        public List<HoloJP> _talentsJP1 { get; set; }
        public List<HoloJP> _talentsJP2 { get; set; }
        public List<HoloJP> _talentsJP3 { get; set; }
        public List<HoloJP> _talentsJP4 { get; set; }
        public List<HoloJP> _talentsJP5 { get; set; }
        public List<HoloJP> _talentsJP6 { get; set; }
        public List<HoloJP> _talentsJPGamers { get; set; }
        public List<HoloJP> _talentsJPInonaka { get; set; }
        public List<Units> _units { get; set; }
}
    public class HoloJPController : Controller
    {
        private static List<HoloJP> _talentsJP0;
        private static List<HoloJP> _talentsJP1;
        private static List<HoloJP> _talentsJP2;
        private static List<HoloJP> _talentsJP3;
        private static List<Units> _units;
        public HoloJPController()
        {
            if (_talentsJP0 == null)
            {
                var holoJP = new HoloJP();
                _talentsJP0 = holoJP.getAllGen0();
                _talentsJP1 = holoJP.getAllGen1();
                _talentsJP2 = holoJP.getAllGen2();
                _talentsJP3 = holoJP.getAllGen3();
                _units = new Units().getUnitsJP();
            }
        }

        public IActionResult HoloJP()
        {
            var model = new ViewModelJP();
            model._talentsJP0 = _talentsJP0;
            model._talentsJP1 = _talentsJP1;
            model._talentsJP2 = _talentsJP2;
            model._talentsJP3 = _talentsJP3;
            model._units = _units;
            return View(model);
        }

        public IActionResult Gen0()
        {
            return View();
        }

        public IActionResult Gen1()
        {
            return View();
        }

        public IActionResult Gen2()
        {
            return View();
        }

        public IActionResult Fantasy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
