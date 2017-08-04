using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewLiveUpdate.Services;
using ViewLiveUpdate.ViewDatas;

namespace ViewLiveUpdate.Main.Controllers
{
    public class HomeController : Controller
    {
        HomeService _homeService;

        public HomeController(HomeService homeService)
        {
            _homeService = homeService;
        }

        public IActionResult Index()
        {
            var result = _homeService.GetPerson();
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
