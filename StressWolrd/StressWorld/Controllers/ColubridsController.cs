using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StressWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace StressWorld.Controllers
{
    public class ColubridsController : Controller
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

        // POST: ColubridsController/Create
        [HttpPost]
        public List<ColubridsViewModel> Create()
        {
            List<ColubridsViewModel> colubrids = new List<ColubridsViewModel>();
            try
            {
                int fistLine = 0;
                using (var reader = new StreamReader(@"F:\StressWolrd2.0\StressWorld2.0\StressWolrd\StressWorld\wwwroot\csv\colubrid.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        
                        var line = reader.ReadLine();
                        if (fistLine == 0)
                        {
                            fistLine++;
                            continue;
                        }
                        var values = line.Split(',');
                        if (!string.IsNullOrEmpty(line)) { 
                            ColubridsViewModel colubrid = new ColubridsViewModel();
                            colubrid.Spicies = values[0];
                            colubrid.Morph = values[1];
                            colubrid.ImportFrom = values[2];
                            colubrid.ImportPrice = Int32.Parse(values[3]);
                            colubrid.SellPrice = Int32.Parse(values[4]);
                            colubrid.Sex = values[5];
                            colubrid.Size = values[6];
                            colubrid.Status = values[7];
                            colubrid.CustomerPhone = values[8];
                            colubrid.CustomerName = values[9];
                            colubrid.CustomerLocation = values[10];
                            colubrid.ImportDate = DateTime.Parse(values[11]);
                            colubrid.SellDate = DateTime.Parse(values[12]);
                            colubrids.Add(colubrid);
                        }
                        fistLine++;
                    }
                }
            }
            catch (Exception ex) {
                throw ex;
            }
            return colubrids;
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
