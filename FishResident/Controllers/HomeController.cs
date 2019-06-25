using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FishResident.Models;
using FishResident.Services;

namespace FishResident.Controllers
{
    public class HomeController : Controller
    {

        private readonly IMailSenderService mailSenderService;

        public HomeController(IMailSenderService mailSenderService)
        {
            this.mailSenderService = new MailSenderService();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            //mailSenderService.MailSend("kentok2012@gmail.com","TEEEEEST", "Try sending message to mail", null);
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
