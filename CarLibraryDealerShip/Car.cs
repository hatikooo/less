using System;

namespace CarLibraryDealerShip
{
    //Remember always to have an empty constructor in a Class that could be serialized
    //If no constructor is defined, an empty constructor is default
    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string RegistrationNumber { get; set; }
    }
}
