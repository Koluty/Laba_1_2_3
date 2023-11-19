using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    public class Wardrobe : Furniture
    {
        int volume = 0;
        public Wardrobe(int volume)
        {
            this.volume = volume;
            name = "Шафа";
        }

        public override double CalculateCost()
        {
            return 75.0 * volume;
        }
        public override string Show()
        {
            return "Фурнітура - " + name + " Об'єм = " + volume.ToString();
        }
    }
}
