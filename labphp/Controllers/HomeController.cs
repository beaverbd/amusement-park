﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AmusementPark.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AmusementPark.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
            Select.names.Clear();
            foreach (var item in db.Subscriptions)
            {
                Select.names.Add(new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                });
            }
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            if (db.Clients.Any(ph => ph.PhoneNumber == booking.PhoneNumber))
            {
                booking.Checked = false;
                booking.Accepted = false;

                db.Booking.Add(booking);
                db.SaveChanges();
            }

            else
            {
                db.Clients.Add(new Clients() 
                { 
                    PhoneNumber = booking.PhoneNumber,
                    Link = "linkdasdas"
                });

                booking.Checked = false;
                booking.Accepted = false;

                db.Booking.Add(booking);

                db.SaveChanges();
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
