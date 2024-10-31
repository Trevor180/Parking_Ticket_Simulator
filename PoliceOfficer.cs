using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WootenT_TicketSim
{
    internal class PoliceOfficer
    {

        //Making constructor
        public PoliceOfficer(string name, int badge, ParkedCar car, ParkingMeter meter)
        {
            //Attributes
            Name = name;
            Badge = badge;
            Car = car;
            Meter = meter;
        
        }

        //Making properties 
        public string Name { get;}
        public int Badge { get;}

        public ParkedCar Car { get;}

        public ParkingMeter Meter { get;}

        //Making this have a setter because it will need
        //to be initialized later
        public ParkingTicket Ticket { get; set; }

    }
}
