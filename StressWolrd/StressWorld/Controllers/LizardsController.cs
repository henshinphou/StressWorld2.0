using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StressWorld.Controllers
{
    public class LizardsController : Controller
    {
        // GET: ColubridsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ColubridsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ColubridsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ColubridsController/Create
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

        // GET: ColubridsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ColubridsController/Edit/5
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

        // GET: ColubridsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ColubridsController/Delete/5
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
