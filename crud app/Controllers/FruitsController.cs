using crud_app.Data;
using crud_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace crud_app.Controllers
{
    public class FruitsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public FruitsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var list =  _dbContext.Fruits.ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Fruit fruits) 
        {
            _dbContext.Fruits.Add(fruits);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id) 
        {
            var list = _dbContext.Fruits.Where(fr => fr.Id == id).FirstOrDefault();
            return View(list);
        }
        [HttpPost]
        public IActionResult Edit(Fruit fruits)
        {
            var update = _dbContext.Fruits.Find(fruits.Id);
            update.Name = fruits.Name;
            update.Price = fruits.Price;
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int Id)
        {
            var data = _dbContext.Fruits.Find(Id);
            _dbContext.Fruits.Remove(data);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Back()
        { 
            return RedirectToAction("Index");
        }
    }
}
