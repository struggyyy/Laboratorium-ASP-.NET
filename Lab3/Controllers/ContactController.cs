using Microsoft.AspNetCore.Mvc;
using Lab3.Models;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.Rendering;
using Data.Migrations;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authorization;

namespace Lab3.Controllers
{
    [Authorize(Roles = "admin")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_contactService.FindAll());
        }

        public IActionResult PagedIndex(int page = 1, int size = 1)
        {
            if (size < 1) return BadRequest();
            return View(_contactService.FindPage(page, size));
        }

        private List<SelectListItem> CreateOrganizationItemList()
        {
            var gr = new SelectListGroup()
            {
                Name = "Organizacje",
            };
            var group = new SelectListGroup()
            {
                Name = "Brak",
            };
            return _contactService.FindAllOrganizations().Select(e => new SelectListItem()
            {
                Text = e.Name,
                Value = e.Id.ToString(),
                Group = gr,
            }).Append(new SelectListItem()
            {
                Text = "Brak organizacji",
                Value = "",
                Selected = true,
                Group = group,
            }).ToList();
        }
        [HttpGet]
        public IActionResult Create()
        {
            Contact model = new Contact();
            model.OrganizationList = CreateOrganizationItemList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var contact = _contactService.FindById(id);
            if (contact != null)
                contact.OrganizationList = CreateOrganizationItemList();
            return View(contact);
        }

        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_contactService.FindById(id));
        }

        [HttpPost]
        public IActionResult Delete(Contact model)
        {
            _contactService.DeleteById(model.Id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var model = _contactService.FindById(id);

            return model is null ? NotFound() : View(model);
        }


        public ActionResult CreateApi(Contact c)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(c);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
