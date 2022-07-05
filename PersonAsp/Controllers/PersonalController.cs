using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonAsp.Controllers
{
    public class PersonalController : Controller
    {
        
        public IActionResult Index() => View(); 
        public IActionResult Index1(int id) => View(People.GetPersons().FirstOrDefault(a => a.id == id));   
    }
}
