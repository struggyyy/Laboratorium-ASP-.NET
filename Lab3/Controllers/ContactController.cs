using Lab3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace Lab3.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            return View(_contactService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<SelectListItem> organizations =
                _contactService.FindAllOrganizations()
                .Select(e=> new SelectListItem()
                {
                    Text = e.Name,
                    Value = e.Id.ToString()
                })
                .ToList();
            Contact model = new Contact();
            model.OrganizationList = organizations;
            return View(model);
        }
        private List<SelectListItem> CreateOrganizationItemList()
        {
            var gr = new SelectListGroup()
            {
                Name = "Organizacje",
            };
            return _contactService.FindAllOrganizations().Select(e=> new SelectListItem()
            {
                Text = e.Name,
                Value = e.Id.ToString(),
                Group = gr
            })
                .Append(new SelectListItem()
                {
                    Text = "Brak Organizacji",
                    Value = "",
                    Selected = true,
                    Group = new SelectListGroup()
                    {
                        Name = "Brak"
                    }
                })
                .ToList();
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(model);
                return RedirectToAction("Index");
            }
            model.OrganizationList = CreateOrganizationItemList();
            return View(model);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_contactService.FindById(id));
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
            _contactService.Delete(model.Id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(_contactService.FindById(id));
        }
    }
}
 