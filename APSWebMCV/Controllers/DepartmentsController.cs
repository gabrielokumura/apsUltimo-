using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APSWebMCV.Models;

namespace APSWebMCV.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Ciencia da Computação" });
            list.Add(new Department { Id = 1, Name = "Administração" });


            return View(list);
        }
    }
}
