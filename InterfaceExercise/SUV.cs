using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle , ICompany
    {

        //In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */

        public SUV()
        {

        }

        public static void SUVTrunk() { Console.WriteLine("Cargo size"); }
        public static void SUVGas() { Console.WriteLine("Diesel"); }

        public void Wheels() { Console.WriteLine("Biggest diameter"); }
        public void Steering() { Console.WriteLine("Biggest steering"); }
        public bool Automatic(bool answer) { return true; }
        public bool Electric(bool answer) { return false; }

        string logo = "Purple blue";
        public string Logo { 
            get {return logo; } 
            set {logo = value; } 
        }
        string type = "Tech sompany";
        public string CompanyType {
            get { return type; }
            set { type = value; }
        }

    }
}
