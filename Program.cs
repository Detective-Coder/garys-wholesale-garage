using System;

namespace garys_wholesale_garage
{
    class Program
    {
        static void Main(string[] args)
        {
          Zero fxs = new Zero ();
          Tesla modelS = new Tesla ();
          Cessna mx410 = new Cessna ();
          Ram f150 = new Ram ();

          fxs.Drive();
          modelS.Drive();
          mx410.Drive();
          f150.Drive();
        }
    }
}
