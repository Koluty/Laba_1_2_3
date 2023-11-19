using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    public abstract class Furniture
    {
        protected string name;
        public abstract double CalculateCost();
        public abstract string Show();
    }
}
