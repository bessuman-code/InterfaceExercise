using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {

        //In your IVehicle

        /* Create 4 members that Car, Truck, & SUV all have in common.
         * Example: All vehicles have a number of wheels... for now..
         */

        public void Wheels() { }
        public void Steering() { }
        public bool Automatic (bool answer) { return true; }
        public bool Electric (bool answer) { return false; }
    }
}
