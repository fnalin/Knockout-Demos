using KO.Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KO.Introducao.Controllers
{
    public class DemosController : Controller
    {
        private readonly IList<Demo> _demos;

        public DemosController()
        {
            _demos = Dados.Demos;
        }

        public ActionResult Index()
        {
            return View(_demos);
        }

        public ActionResult Visualizar(int id)
        {
            var view = string.Empty;


            switch (id)
            {
                case 1:
                    view = "Introducao1";
                    break;
                default:
                    break;
            }

            return View(view);
        }
    }
}