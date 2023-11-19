using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    public class Sofa : Furniture
    {
        int area = 0;
        public Sofa(int area)
        {
            this.area = area;
            name = "Диван";
        }
        public override string Show()
        {
            return "Фурнітура - " + name + " Площа = " + area.ToString();
        }
        public override double CalculateCost()
        {
            return area * 0.66 + 5000;
        }
    }
}
