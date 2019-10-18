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
        private IToDo _iToDo;
        public static List<ToDo> ToDo;

        public HomeController(IToDo iToDo)
        {
            _iToDo = iToDo;
        }

        // GET: Home
        public ActionResult Index()
        {
            ToDo = _iToDo.Alert();
            return View(_iToDo.GetAllToDo());
        }
    }
}