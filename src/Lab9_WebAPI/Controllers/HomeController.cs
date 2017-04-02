using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab9_WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserModel model)
        {
            if (ModelState.IsValid)
            {
                UserData.users.Add(new User()
                {
                    firstName = model.firstName,
                    lastName = model.lastName,
                    city = model.city,
                    date = model.date
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
