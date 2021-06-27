using Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SampleWebContactExample.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebContactExample.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var cities = ContactFacade.GetAllCities().ToList();
            var citiesData = new List<SelectListItem>();

            foreach (var item in cities)
            {
                citiesData.Add(new SelectListItem { Text = item });
            }
            ViewBag.Cities = citiesData;
            return View();
        }
        [HttpPost]
        public IActionResult Contact(ContactDto contactDto)
        {
            if (contactDto != null)
            {
                var contact = ContactFacade.SendMessage(contactDto);
                return View(contact);
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
