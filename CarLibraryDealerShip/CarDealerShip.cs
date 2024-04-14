using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibraryDealerShip
{
    public class CarDealerShip
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Car> Cars { get; set; }

        //Makes sure the Cars list is always initialized
        //Remember always to have an empty constructor in a Class that could be serialized
        //If no constructor is defined, an empty constructor is default
        public CarDealerShip()
        {
            Cars = new List<Car>();
        }
    }
}
