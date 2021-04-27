using System;
using System.Collections.Generic;

namespace garys_wholesale_garage
{
    class Program
    {
        static void Main (string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();
            

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"Charge percentage: {ev.CurrentChargePercentage}%");
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"The battery is now at {ev.CurrentChargePercentage}%");
            }

            /***********************************************/
            Console.WriteLine();
            Ram ram = new Ram ();
            Cessna cessna150 = new Cessna ();

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"Gas level: {gv.CurrentTankPercentage}%");
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"Gas Level: {gv.CurrentTankPercentage}%");
            }
        }
    }
}

// Your challenge is to replace your Main method with the following code and make the appropriate changes and additions to your project in order to make this Main method work.

// HINT: An example addition to your code might be an IElectricVehicle interface.
