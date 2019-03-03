using logisticTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logisticTracker.Data
{
    public class LogisticTrackerDataContext:DbContext
    {
        public LogisticTrackerDataContext():base("name=LogisticTrackerConnection")
        {

        }

        public DbSet<Trip> Trips { get; set; }
    }
}
