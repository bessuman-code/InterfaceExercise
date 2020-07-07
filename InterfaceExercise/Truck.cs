using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck
    {
        //In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */
        public static void TruckTrunk() { Console.WriteLine("Trunk size"); }
        public static void TruckGas() { Console.WriteLine("Diesel type B"); }

        public void Wheels() { Console.WriteLine("Bigger diameter"); }
        public void Steering() { Console.WriteLine("Bigger steering"); }
        public bool Automatic(bool answer) { return true; }
        public bool Electric(bool answer) { return false; }

        string logo = "White stripes in black";
        public string Logo
        {
            get { return logo; }
            set { logo = value; }
        }
        string type = "Part of insurance sompany";
        public string CompanyType
        {
            get { return type; }
            set { type = value; }
        }

    }
}
