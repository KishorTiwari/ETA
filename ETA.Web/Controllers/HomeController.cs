using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ETA.Data.DAL;
using ETA.Data.Models;

namespace ETA.Web.Controllers
{
    public class HomeController: BaseController
    {
        public HomeController(IRepository repo) : base(repo)
        {

        }

        public IActionResult Index()
        {
            
            _repository.AddGroup(new Group
            {
                GroupName = "Volt",
                DateCreated = DateTime.Now,
                IsActive = true
            });

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
