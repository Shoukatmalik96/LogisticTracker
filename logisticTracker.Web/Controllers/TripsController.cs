using logisticTracker.Entities;
using logisticTracker.Servcies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace logisticTracker.Web.Controllers
{
    public class TripsController : Controller
    {
        TripsService TripsService = new TripsService();

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Trip trip)
        {
            TripsService.SaveTrip(trip);
            return View("Index");
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var trip = TripsService.GetTripByID(ID);
            return View(trip);
        }
        [HttpPost]
        public ActionResult Edit(Trip trip)
        {
            TripsService.UpdateTrip(trip);
            return View("Index");
        }
        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var trip = TripsService.GetTripByID(ID);
            return View(trip);
        }
        [HttpPost]
        public ActionResult Delete(Trip trip)
        {
            TripsService.DeleteTrip(trip);
            return View("Index");
        }

    }
}