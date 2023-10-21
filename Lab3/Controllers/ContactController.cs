using Lab3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Lab3.Controllers
{
    public class ContactController : Controller
    {

        static readonly Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();
        static int id = 1;

        public IActionResult Index()
        {
            return View(_contacts);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                model.Id = id++;
                _contacts[model.Id] = model;

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_contacts[id]);
        }

        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contacts[model.Id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_contacts[id]);
        }

        [HttpPost]
        public IActionResult Delete(Contact model)
        {
            _contacts.Remove(model.Id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_contacts[id]);

        }

        [HttpPost]
        public void Details(Contact model)
        {
            
        }
    }

}
