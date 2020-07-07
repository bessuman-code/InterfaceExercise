using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car
    {

        //In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */

        public static void CarTrunk() { Console.WriteLine("Bed size"); }
        public static void CarGas() { Console.WriteLine("Regular"); }

        public void Wheels() { Console.WriteLine("Smallest diameter"); }
        public void Steering() { Console.WriteLine("Smallest steering"); }
        public bool Automatic(bool answer) { return true; }
        public bool Electric(bool answer) { return false; }

        string logo = "Tan";
        public string Logo
        {
            get { return logo; }
            set { logo = value; }
        }
        string type = "Tech and insurance";
        public string CompanyType
        {
            get { return type; }
            set { type = value; }
        }

    }
}

