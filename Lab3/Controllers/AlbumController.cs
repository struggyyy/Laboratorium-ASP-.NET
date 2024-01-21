using Lab3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;
using System.Text.Json;

namespace Lab3.Controllers
{
    [Authorize(Roles = "admin")]
    public class AlbumController : Controller
    {
        private readonly IAlbumService _albumService;
        private readonly IDateTimeProvider _dateTimeProvider;

        public AlbumController(IAlbumService albumService, IDateTimeProvider dateTimeProvider)
        {
            _albumService = albumService;
            _dateTimeProvider = dateTimeProvider;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_albumService.FindAll());
        }

        public IActionResult PagedIndex(int page = 1, int size = 1)
        {
            if (size < 1) return BadRequest();
            return View(_albumService.FindPage(page, size));
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Album model)
        {
            model.PublicationDate = _dateTimeProvider.dateNow();
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
                return RedirectToAction("PagedIndex");
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
            return RedirectToAction("PagedIndex");
        }

        
        [HttpGet]
        public IActionResult Details(int id)
        {
            var model = _albumService.FindById(id);
            return model is null ? NotFound() : View(model);
        }
    }

}
