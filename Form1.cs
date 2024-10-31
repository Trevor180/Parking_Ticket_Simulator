using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WootenT_TicketSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Closing application
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Variables to hold time
            int time;
            int timePaid;

            try
            {
                
                //Checking if time can convert to an int
                if (int.TryParse(timeTextBox.Text, out time) && (int.TryParse(timePaidtextBox.Text, out timePaid)))
                {
                    //Making new objects
                    var car = new ParkedCar(makeTextBox.Text, modelTextBox.Text, colorTextBox.Text, licenseTextBox.Text, time);
                    var meter = new ParkingMeter(timePaid);

                    //Making ticket if there needs to be one
                    if (car.Mins >  meter.ParkingTime)
                    {
                        //Clearing label
                        fineInfoLabel.Text = "";

                        //Making officer object that holds all objects
                        var officer = new PoliceOfficer(officerTextBox.Text, int.Parse(badgeTextBox.Text), car, meter);

                        //Making ticket
                        var ticket = new ParkingTicket(car, officer, meter);

                        //Assigning ticket object to officer object
                        officer.Ticket = ticket;

                        //Calculating fine
                        // Adds currency formatting
                        fineInfoLabel.Text = "Fine: " + officer.Ticket.Fine().ToString("C");  
                        fineInfoLabel.Text += "\n" + officer.Ticket.ToString();

                    }
                    else
                    {
                        //Clearing label
                        fineInfoLabel.Text = "";

                        //If not fine needed
                        fineInfoLabel.Text = "No fine required.";

                    }
                    

                }
                else
                {
                    //If any other error occurrs
                    MessageBox.Show("Please enter correct information");

                }
               

            }
            catch 
            {
                //If correct times not entered
                MessageBox.Show("Please enter correct information");
            }


          

        }
    }
}
