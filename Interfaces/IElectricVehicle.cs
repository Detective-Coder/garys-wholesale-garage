using System;

namespace garys_wholesale_garage
{
  public interface IElectricVehicle
  {
     int CurrentChargePercentage { get; set;} 
     void ChargeBattery();
  
  }
}

// HINT: An example addition to your code might be an IElectricVehicle interface.

// need a property that represents CurrentChargePercentage

// need a ChargeBattery() method that changes CurrentChargePercentage to 100%