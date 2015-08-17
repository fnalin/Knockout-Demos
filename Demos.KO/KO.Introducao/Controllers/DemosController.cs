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
            var view = _demos.FirstOrDefault(d=>d.ID==id);

            if (view == null)
                throw new Exception("Demo não encontrada");

            return View(view.View);
        }
    }
}