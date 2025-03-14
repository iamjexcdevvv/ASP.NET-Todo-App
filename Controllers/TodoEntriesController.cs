using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TodoEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TodoEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult TaskForm()
        {
            return View();
        }
        public IActionResult Index()
        {
            List<Todo> objTodosList = _db.TodoEntries.ToList();
            return View(objTodosList);
        }

        [HttpPost]
        public IActionResult TaskForm(Todo obj)
        {
            _db.TodoEntries.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index", "TodoEntries");
        }
        public IActionResult EditTodo(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Todo? todoEntry = _db.TodoEntries.Find(id);

            if (todoEntry == null)
            {
                return NotFound();
            }

            return View(todoEntry);
        }
        [HttpPost]
        public IActionResult EditTodo(Todo obj)
        {
            _db.TodoEntries.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index", "TodoEntries");
        }
        public IActionResult DeleteTodo(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Todo? todoEntry = _db.TodoEntries.Find(id);

            if (todoEntry == null)
            {
                return NotFound();
            }

            return View(todoEntry);
        }

        [HttpPost]
        public IActionResult DeleteTodo(Todo obj)
        {
            _db.TodoEntries.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index", "TodoEntries");
        }
    }
}
