using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Easy_2_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Cal cal = new Cal();
            cal.setMass(90);
            Console.WriteLine(cal.getMass());

            // Suspend the console.
            Console.ReadKey();
        }
    }
}
