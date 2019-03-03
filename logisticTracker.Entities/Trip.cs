using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logisticTracker.Entities
{
    public class Trip: BaseEntity
    {
        public string VehicleNo { get; set; }
        public DateTime loadingDate { get; set; }
        public decimal  KarachiRent { get; set; }
        public string Details { get; set; }
        public int  Weight { get; set; }
    }
}
