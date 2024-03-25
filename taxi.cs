using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_3
{
    class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public Taxi(){}

        public void TaxiInfo()
        {
            Console.WriteLine($"Driver name: {DriverName}\nOn Duty: {(OnDuty ? "yes" : "no")}\nNumber of Passenger: {NumPassenger}\n");
        }

        public void PickUpPassenger()
        {
            if (!OnDuty)
            {
                Console.WriteLine($"Taxi is not on duty. {DriverName} cannot pick up passengers.");
                return;
            }

            Console.WriteLine($"{DriverName} sedang menjemput penumpang");
        }

        public void DropOffPassenger()
        {
            if (!OnDuty)
            {
                Console.WriteLine($"Taxi is not on duty. {DriverName} cannot drop off passengers.");
                return;
            }

            Console.WriteLine($"{DriverName} selesai mengantar penumpang");
        }
    }
}
