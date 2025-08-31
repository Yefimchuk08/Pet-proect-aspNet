using DataAccess;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Pet_proect_take_3.Controllers
{
    public class JobController : Controller
    {
        Job_Board context;
        public JobController(Job_Board context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Jobs.ToList());
        }
        public IActionResult Create() 
        {
            LoadCompanies();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Job job)
        {
            context.Jobs.Add(job);

            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            var vacancy = context.Jobs.Find(id);

            if (vacancy == null) return NotFound();//404

            LoadCompanies();
            return View(vacancy);
        }
        [HttpPost]
        public IActionResult Edit(Job job)
        {
            context.Jobs.Update(job);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            var item = context.Jobs.Find(id);
            if (item == null) return NotFound();
            context.Jobs.Remove(item);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Details(int id)
        {
            if(id == 0) return BadRequest();

            var vacancy = context.Jobs.Find(id);

            if (vacancy == null) return NotFound();

            return View(vacancy);
        }
        public void LoadCompanies()
        {
            ViewBag.CompanyList = new SelectList(context.Companies.ToList(), nameof(Company.Id), nameof(Company.Name));
        }
    }
}
