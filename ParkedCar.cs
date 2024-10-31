using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WootenT_TicketSim
{
    internal class ParkedCar
    {
        //Making constructor
        public ParkedCar(string make, string model, string color, string license, int mins) 
        {
            //arguments
            this.Make = make;
            this.Model = model;
            this.Color = color;
            this.License = license;
            this.Mins = mins;
        
        
        }


        //Making properties

        public string Make { get; }
        public string Model { get; }
        public string Color { get; }
        public string License { get; }
        public int Mins { get;}
    }
}
