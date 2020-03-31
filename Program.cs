using System;

namespace empWageComputationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            Random random = new Random();
            int isEmpPresent = random.Next(0, 2);
            empAttendanceCheck(isEmpPresent);
        }
        //Method to check employee present or not
        public static void empAttendanceCheck(int isEmpPresent)
        {         
            if ( (isEmpPresent % 2) == 1)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
        
    }
}
