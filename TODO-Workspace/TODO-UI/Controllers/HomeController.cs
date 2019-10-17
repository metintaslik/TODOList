using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TODO_DAL;

namespace TODO_UI.Controllers
{
    public class HomeController : Controller
    {
        IToDo _iToDo;

        public HomeController(IToDo itoDo)
        {
            _iToDo = itoDo;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View(_iToDo.GetAllToDo());
        }

        public ActionResult AddIndex()
        {
            return View();
        }

        public ActionResult AddToDo(ToDo @toDo)
        {
            TempData["Message"] = _iToDo.AddToDo(@toDo);
            return RedirectToAction("Index");
        }

        public ActionResult EditIndex(int id)
        {
            return View(_iToDo.ToDoFindById(id));
        }
    }
}