using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pra.ClassesAndObjects.Core
{
    public partial class Car
    {
        public override string ToString()
        {
            return $"{Brand} - {Color}";
        }

        public decimal PriceDifference(Car someCar)
        {
            return Math.Abs(Price - someCar.Price);
        }

        public static decimal PriceDifference(Car car1, Car car2)
        {
            return Math.Abs(car1.Price - car2.Price);
        }
    }
}



