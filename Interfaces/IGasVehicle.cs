using System;

namespace garys_wholesale_garage
{
  public interface IGasVehicle
  {
     int CurrentTankPercentage { get; set;} 
     void RefuelTank();
  
  }
}