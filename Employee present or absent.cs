using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_problems_8
{
    class Employee_present_or_absent
    {
        public static void GetAttendance()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
            Console.ReadKey();
        }

    }
}
    

