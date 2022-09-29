using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SistemaJogadoresFutebol.Controllers
{
    public class JogadorController : Controller
    {
        // GET: JogadorController
        public ActionResult Index()
        {
            return View();
        }

        // GET: JogadorController/Details/id
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JogadorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JogadorController/Create
        [HttpPost]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JogadorController/Edit/id
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JogadorController/Edit/id
        [HttpPost]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JogadorController/Delete/id
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JogadorController/Delete/id
        [HttpPost]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
