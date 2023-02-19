using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using Nauka.Models;
using Nauka.Models.Domains;
using Nauka.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Nauka.Controllers
{
    public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
            var vm = new List<UsersViewModel>
            {
                new UsersViewModel
                {
                    Users = new List<User>
                    {
                        new User { Id = 1, Name = "User-1", Groups = new List<Group>{ new Group { Id = 1, NameOfGroup = "Group-1" } } },
                        new User { Id = 2, Name = "User-2", Groups = new List<Group>{ new Group { Id = 2, NameOfGroup = "Group-2" } } },
						new User { Id = 3, Name = "User-3", Groups = new List<Group>{ new Group { Id = 3, NameOfGroup = "Group-3" } } },
					}
                },
                new UsersViewModel
                {
                    Users = new List<User>
                    {
                        new User { Id = 2, Name = "User-2", Groups = new List<Group>{ new Group { Id = 4, NameOfGroup = "Group-2" } } }
                    }
                },
                new UsersViewModel
                {
                    Users = new List<User>
                    {
                        new User { Id = 3, Name = "User-3", Groups = new List<Group>{ new Group { Id = 5, NameOfGroup = "Group-3" } } }
					}
                }
            };

			return View(vm);
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
