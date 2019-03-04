using logisticTracker.Entities;
using logisticTracker.Servcies;
using logisticTracker.Web.ViewModels;
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
			TripListingViewModels model = new TripListingViewModels();

			model.Trips = TripsService.GetTrips();
			return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(Trip trip)
        {
            TripsService.SaveTrip(trip);
            return RedirectToAction("Index");
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
            return RedirectToAction("Index");
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
            return RedirectToAction("Index");
		}

    }
}