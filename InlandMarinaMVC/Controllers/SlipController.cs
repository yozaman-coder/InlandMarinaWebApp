using InlandMarinaData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlandMarinaMVC.Controllers
{
    public class SlipController : Controller
    {
        // Called from the ajax function
        public ActionResult GetUnleasedSlipsByDock(int id)
        {
            return ViewComponent("SlipsByDock", id);
        }

        // Auxillary method
        public IEnumerable GetDocksWithAll()
        {
            // Converts dock list into Select List and appends "All" selection
            var docks = DockManager.GetAllDockNamesAsKeyValuePairs();
            var list = new SelectList(docks, "Value", "Text").ToList();
            list.Insert(0, new SelectListItem { Text = "All", Value = "All" });
            ViewBag.Docks = list;
            return list;

        }
        // GET: SlipController
        public ActionResult Index(int id = 0)
        {
            try
            {
                // Gives veiw all docks in select list
                ViewBag.Docks = GetDocksWithAll();
            }
            catch (Exception)
            {
                TempData["IsError"] = true;
                TempData["Message"] = "Database connection error. Try again later...";
                return RedirectToAction("Index");
            }
            return View();
        }

        //    // GET: SlipController/Create
      
        

        // POST: SlipController/Create
        

        // GET: SlipController/Details/5
        //    public ActionResult Details()
        //    {
        //        return View();
        //    }


 



        //    // GET: SlipController/Edit/5
        //    public ActionResult Edit(int id)
        //    {
        //        return View();
        //    }

        //    // POST: SlipController/Edit/5
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Edit(int id, IFormCollection collection)
        //    {
        //        try
        //        {
        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }

        //    // GET: SlipController/Delete/5
        //    public ActionResult Delete(int id)
        //    {
        //        return View();
        //    }

        //    // POST: SlipController/Delete/5
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Delete(int id, IFormCollection collection)
        //    {
        //        try
        //        {
        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }
    }
}
