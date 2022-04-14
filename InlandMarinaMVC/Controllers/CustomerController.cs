using InlandMarinaData;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace InlandMarinaMVC.Controllers
{
    public class CustomerController : Controller
    {
        // Route: /Customer/Login
        public IActionResult Login(string returnUrl)
        {
            if (returnUrl != null) //Return url exists
                TempData["ReturnUrl"] = returnUrl; // Set tempdata to returnUrl
            else
                TempData["ReturnUrl"] = null;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(Customer customer)
        {
            Customer cst = CustomerManager.Authenticate(customer.Username, customer.Password);
            if (cst == null) // Authentication has failed
            {
                //Display error
                TempData["IsError"] = true;
                TempData["Message"] = "Your login information is incorrect!";
                return View(); // Stay on the login page
            }

            HttpContext.Session.SetInt32("CurrentCustomer", (int)cst.ID); // Set session data for customer ID
            // User != null therefore authentication passed! YAY!!!!
            List<Claim> claims = new List<Claim>
            {
                // Make new claim for user
                new Claim(ClaimTypes.Name, cst.Username),
                new Claim("FirstName", cst.FirstName),
                new Claim("LastName", cst.LastName),
            };

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Cookies"); // Cookies authentication
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity); // Cookies authentication

            await HttpContext.SignInAsync("Cookies", claimsPrincipal);


            if (TempData["ReturnUrl"] == null) // No return url
            {
                return RedirectToAction("Index", "Home");                   
            }
            else
            {
                // Redirect user to ReturnUrl
                Debug.WriteLine(Redirect(TempData["ReturnUrl"].ToString()));
                return Redirect(TempData["ReturnUrl"].ToString());
            }
        }
        
        public async Task<IActionResult> LogoutAsync()
        {
            // Logs out user and clears session data / cookies on logout
            await HttpContext.SignOutAsync("Cookies");
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Create()
        {
            try
            {
               if(HttpContext.Session.GetInt32("CurrentCustomer") != null) // There is a customer already signed in
                {
                    TempData["IsError"] = true;
                    TempData["Message"] = "You are already signed in!";
                    return RedirectToAction("Index", "Home");
                }
                
                return View();
            }
            catch
            {
                TempData["IsError"] = true;
                TempData["Message"] = "Database connection error. Try again later...";
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: LeaseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            try
            {
                // Adds new customer with form data
                CustomerManager.AddCustomer(customer);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                // For debugging
                Debug.WriteLine(ex.InnerException.Message);
                TempData["IsError"] = true;
                TempData["Message"] = "Database connection error. Try again later...";
                return RedirectToAction("Index", "Home");
            }
        }


    }
}

