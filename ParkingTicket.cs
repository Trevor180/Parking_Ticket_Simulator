using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WootenT_TicketSim
{
    internal class ParkingTicket
    {
        //Making constructor
        public ParkingTicket(ParkedCar car, PoliceOfficer officer, ParkingMeter meter) 
        { 
            this.Car = car;
            Officer = officer;
            ParkingMeter = meter;
        
        }

        //Making properties
        public ParkedCar Car { get; }
        public PoliceOfficer Officer { get;}
        public ParkingMeter ParkingMeter { get;}



        //Override string to add to label
        public override string ToString()
        {
            return $"Make: {Car.Make}\n Model: {Car.Model}\n Color: {Car.Color}\n License Plate : {Car.License.ToUpper()}\n Police Officer: {Officer.Name}\n Badge Number: {Officer.Badge}\n ";

        }

        //Calculating fine
        public double Fine()
        {
            //Getting whats overdue
            double overdue = Car.Mins - ParkingMeter.ParkingTime;

            // Calculate the total fine:
            // $25 for the first hour, plus $10 for every additional hour or part of an hour
            return 25 + (10 * (int)Math.Ceiling((overdue - 60) / 60.0));
        }




    }
}
