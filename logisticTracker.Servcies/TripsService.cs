using logisticTracker.Data;
using logisticTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logisticTracker.Servcies
{
    public class TripsService
    {
        LogisticTrackerDataContext context = new LogisticTrackerDataContext();

        public Trip GetTripByID(int ID)
        {
            return context.Trips.Find(ID);
        }
        public List<Trip> GetTrips()
        {
            return context.Trips.ToList();
        }
        public void SaveTrip(Trip trip)
        {
            context.Trips.Add(trip);
            context.SaveChanges();
        }
        public void UpdateTrip(Trip trip)
        {
            context.Entry(trip).State =System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteTrip(Trip trip)
        {
            context.Entry(trip).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
