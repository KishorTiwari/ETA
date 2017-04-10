using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ETA.Data.DAL;
using ETA.Data.Models;

namespace ETA.Web.Controllers
{
    public class BaseController : Controller
    {
        public IRepository _repository;
        public BaseController(IRepository repository)
        {
            _repository = repository;
        }
    }
}