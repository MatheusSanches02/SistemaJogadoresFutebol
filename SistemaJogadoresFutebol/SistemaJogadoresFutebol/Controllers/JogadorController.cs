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

        // GET: JogadorController/Details/5
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
        [ValidateAntiForgeryToken]
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

        // GET: JogadorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JogadorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
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

        // GET: JogadorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JogadorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
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
