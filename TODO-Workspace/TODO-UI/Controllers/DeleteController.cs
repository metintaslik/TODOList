using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TODO_DAL;

namespace TODO_UI.Controllers
{
    public class DeleteController : Controller
    {
        private IToDo _iToDo;

        public DeleteController(IToDo iToDo)
        {
            _iToDo = iToDo;
        }

        // GET: Delete
        public ActionResult Index(int id)
        {
            TempData["Message"] = _iToDo.DeleteToDo(id);
            return RedirectToAction("Index", controllerName: "Home");
        }
    }
}