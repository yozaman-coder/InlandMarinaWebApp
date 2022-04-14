using InlandMarinaData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlandMarinaMVC.Controllers
{
    public class LeaseController : Controller
    {
        // GET: LeaseController
        public ActionResult Index()
        {
            // Checks if someone is signed in.
            // If someone somehow got to this page when not signed in it would just show them blank data.
            int? customer = HttpContext.Session.GetInt32("CurrentCustomer");
            if (customer == null)
                customer = 0;
            var lease = LeaseManager.GetLeasesForCustomer((int)customer);
            return View(lease);
        }

        [Authorize]
        public ActionResult Create(int slipID, int dockID)
        {
            try
            {
                //Gets customer, if somehow null displays an error
                int? customerID = HttpContext.Session.GetInt32("CurrentCustomer");
                if (customerID == null)
                {
                    TempData["IsError"] = true;
                    TempData["Message"] = "Error no customer found. Try again later...";
                    return RedirectToAction("Index");
                }
                //Gets slip and dock information and passes it to view
                ViewBag.Slip = SlipManager.GetSlipWithID(slipID);
                ViewBag.Dock = DockManager.FindDockWithID(dockID);
                //Gets customer id and passes it to view
                ViewBag.CustomerID = customerID;
                return View(new Lease());
            }
            catch
            {
                // Db error
                TempData["IsError"] = true;
                TempData["Message"] = "Database connection error. Try again later...";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create(Lease lease)
        {
            try
            {
                // Adds new lease to db
                LeaseManager.AddLease(lease);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                TempData["IsError"] = true;
                TempData["Message"] = "Database connection error. Try again later...";
                return RedirectToAction("Index");
            }
        }

        //// GET: LeaseController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: LeaseController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: LeaseController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: LeaseController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: LeaseController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: LeaseController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: LeaseController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
