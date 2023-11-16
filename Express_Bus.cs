using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    internal class Express_Bus : Bus
    {
        double speed;
        string brand;
        public Express_Bus(int number_passenger, double price_ticket, string brand, double speed)
        : base(number_passenger, price_ticket)
        {
            this.brand = brand;
            this.speed = speed;
        }
        public string Brand
        {
            get { return brand; }  
            set { brand = value; }
        }
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public override double total_price_seats()
        {
            // Increase the price of a ticket by 5% for every 10 km/h of speed.
            double price_increase = 0.05 * this.speed / 10;
            return (price_ticket + price_increase) * number_passenger;
        }
    }
}
