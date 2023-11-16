using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    internal class Bus
    {
        protected int number_passenger;
        protected double price_ticket;
        public Bus(int number_passenger, double price_ticket)
        {
            this.number_passenger = number_passenger;
            this.price_ticket = price_ticket;
        }
        public int Number_Passenger
        {
            get { return number_passenger; }
            set { number_passenger = value; }
        }
        public double Price_Ticket
        {
            get { return price_ticket; }
            set { price_ticket = value; }
        }
        public virtual double total_price_seats() { return price_ticket * number_passenger; }
    }
}
