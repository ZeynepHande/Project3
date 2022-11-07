using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project3.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Iletisim()
        {
            return View();
        }
        public IActionResult Info()
        {
            var jsonPersons = JsonConvert.SerializeObject(persons);
            return Json(jsonPersons);
        }
        public static List<Person> persons = new List<Person>
        {
            new Person
            {
                Ad = "Hande",
                Soyad = "Altuner",
                Tarih = DateTime.Today,
                Yas = 32,
                YasadigiSehir = "İstanbul"
            }
        };
    }
}
