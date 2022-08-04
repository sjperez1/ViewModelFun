using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    // generated
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }



    // my code
    [HttpGet("")]
        public IActionResult Index()
        {
            string message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            return View("Index", message);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[]
            {
                1,
                2,
                3,
                10,
                43,
                5
            };
            return View(numbers);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            User moose = new User()
            {
                firstName = "Moose",
                lastName = "Phillips"
            };

            User sarah = new User()
            {
                firstName = "Sarah"
            };

            User jerry = new User()
            {
                firstName = "Jerry"
            };

            User rene = new User()
            {
                firstName = "Rene",
                lastName = "Ricky"
            };

            User barbarah = new User()
            {
                firstName = "Barbarah"
            };

            List<User> users = new List<User>()
            {
                moose, sarah, jerry, rene, barbarah
            };
            return View(users);
        }

        [HttpGet("user")]
        public IActionResult User()
        {
            User moose = new User()
            {
                firstName = "Moose",
                lastName = "Phillips"
            };
            return View(moose);
        }



    // generated
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
