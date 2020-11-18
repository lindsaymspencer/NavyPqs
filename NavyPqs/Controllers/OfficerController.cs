using NavyPqs.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace NavyPqs.Controllers
{
    public class OfficerController : Controller
    {
        private readonly List<Officer> Officers = SessionSingleton.Current.Officers;

        // GET: Officers
        public ActionResult Index()
        {
            return View(Officers);
        }

        // GET: Officer/Details/5
        public ActionResult Details(int id)
        {
            var officer = Officers.FirstOrDefault(m => m.Id == id);
            return View(officer);
        }

        // GET: Officer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Officer/Create
        [HttpPost]
        public ActionResult Create(Officer officer)
        {
            try
            {
                officer.Id = SessionSingleton.Current.GetNextOfficerId();
                Officers.Add(officer);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Officer/Edit/5
        public ActionResult Edit(int id)
        {
            var officer = Officers.FirstOrDefault(m => m.Id == id);
            return View(officer);
        }

        // POST: Officer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Officer officer)
        {
            try
            {
                int index = Officers.FindIndex(m => m.Id == id);
                Officer toUpdate = Officers.First(x => x.Id == index);
                Officer merged = Officer.CopyOfficer(toUpdate, officer);
                Officers[index] = merged;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Officer/Delete/5
        public ActionResult Delete(int id)
        {
            var officer = Officers.FirstOrDefault(m => m.Id == id);
            return View(officer);
        }

        // POST: Officer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                int index = Officers.FindIndex(m => m.Id == id);
                Officers.RemoveAt(index);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
