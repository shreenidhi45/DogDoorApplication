using DogDoorApplication.Model.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int returnBeforeDoorClose = 2000;
            int returnAfterDoorClose = 13000;
            bool ownersResponsive = true;

            // Owners are responsive
            
            DogDoorSimulator.DogDoorTestPath(returnBeforeDoorClose, ownersResponsive);
            
            DogDoorSimulator.DogDoorTestPath(returnAfterDoorClose, ownersResponsive);


            // Owners are not responsive
            
            DogDoorSimulator.DogDoorTestPath(returnBeforeDoorClose, !ownersResponsive);
            
            DogDoorSimulator.DogDoorTestPath(returnAfterDoorClose, !ownersResponsive);

            Console.WriteLine("\nTest passed! Press any key to continue.\n");

            Console.ReadKey();
        }
    }
}
