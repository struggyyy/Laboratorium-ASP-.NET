using Lab3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Lab3.Controllers
{
    public class AlbumController : Controller
    {

        static readonly Dictionary<int, Album> _albums = new Dictionary<int, Album>();
        static int id = 1;

        public IActionResult Index()
        {
            return View(_albums);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Album model)
        {
            if (ModelState.IsValid)
            {
                model.Id = id++;
                _albums[model.Id] = model;

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_albums[id]);
        }

        [HttpPost]
        public IActionResult Update(Album model)
        {
            if (ModelState.IsValid)
            {
                _albums[model.Id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_albums[id]);
        }

        [HttpPost]
        public IActionResult Delete(Album model)
        {
            _albums.Remove(model.Id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_albums[id]);

        }

        [HttpPost]
        public void Details(Album model)
        {

        }
    }

}
