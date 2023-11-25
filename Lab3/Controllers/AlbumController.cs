using Lab3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata.Ecma335;

namespace Lab3.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IAlbumService _albumService;

        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public IActionResult Index()
        {
            return View(_albumService.FindAll());
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
                _albumService.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_albumService.FindById(id));
        }

        [HttpPost]
        public IActionResult Update(Album model)
        {
            if (ModelState.IsValid)
            {
                _albumService.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_albumService.FindById(id));
        }

        [HttpPost]
        public IActionResult Delete(Album model)
        {
            _albumService.Delete(model.Id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(_albumService.FindById(id));
        }
    }

}
