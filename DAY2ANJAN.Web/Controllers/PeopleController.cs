using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAY2ANJAN.Web.Data;
using Microsoft.AspNetCore.Mvc;

namespace DAY2ANJAN.WebApp.Controllers
{
    public class PeopleController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PeopleController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetPeopleList()
        {
            var people = _context.Peoples.ToList();
            return View(people);
        }

        [HttpGet]
        public IActionResult CreatePeople()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePeople(CreatePeopleViewModel createPeopleViewModel)
        {
            var people = new People
            {
                Name = createPeopleViewModel.Name,
                City = createPeopleViewModel.City
            };
            _context.Peoples.Add(people);
            _context.SaveChanges();
            return RedirectToAction("GetPeopleList");
        }

        [HttpGet]
        public IActionResult EditPeople(int id)
        {
            var people = _context.Peoples.FirstOrDefault(x => x.ID == id);
            return View(people);
        }

        [HttpPost]
        public IActionResult EditPeople(People editModel)
        {
            var people = _context.Peoples.FirstOrDefault(x => x.ID == editModel.ID);
            if(people != null)
            {
                people.Name = editModel.Name;
                people.City = editModel.City;
                _context.SaveChanges();
            }
            return RedirectToAction("GetPeopleList", "People");
        }

        [HttpPost]
        public IActionResult DeletePeople(People editModel)
        {
            var people = _context.Peoples
            .FirstOrDefault(x => x.ID == editModel.ID);
            if(people != null)
            {
                _context.Peoples.Remove(people);
                _context.SaveChanges();
            }
            return RedirectToAction("GetPeopleList", "People");
        }
        
    }
}