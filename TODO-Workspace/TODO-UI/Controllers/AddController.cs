using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TODO_DAL;

namespace TODO_UI.Controllers
{
    public class AddController : Controller
    {
        private IToDo _iToDo;
        public AddController(IToDo iToDo)
        {
            _iToDo = iToDo;
        }

        // GET: Add
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddToDo(ToDo @toDo)
        {
            TempData["Message"] = _iToDo.AddToDo(@toDo);
            return RedirectToAction("Index", controllerName: "Home");
        }
    }
}