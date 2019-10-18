using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TODO_DAL;

namespace TODO_UI.Controllers
{
    public class EditController : Controller
    {
        private IToDo _iToDo;

        public EditController(IToDo iToDo)
        {
            _iToDo = iToDo;
        }
        // GET: Edit
        public ActionResult Index(int id)
        {
            return View(_iToDo.ToDoFindById(id));
        }

        public ActionResult UpdateToDo(ToDo toDo)
        {
            toDo.ModifiedDate = DateTime.Now.Date;
            TempData["Message"] = _iToDo.UpdateToDo(toDo);
            return RedirectToAction("Index", controllerName: "Home");
        }
    }
}