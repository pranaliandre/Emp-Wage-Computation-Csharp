using System;

namespace empWageComputationProgram
{
    class Program
    {
        //constant
        private static int EMP_WAGE_PER_HOUR = 20;
        private static int EMP_FULL_DAY_HOUR = 8;
        private static int NO_WAGE = 0;
        //variable
        private static int wagePerDay = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            Random random = new Random();
            int isEmpPresent = random.Next(0, 2);
            empAttendanceCheck(isEmpPresent);
        }
        //Method to check employee present or not If present then calulate the wagePerDay
        public static void empAttendanceCheck(int isEmpPresent)
        {
            if ( (isEmpPresent % 2) == 1)
            {
                Console.WriteLine("Employee is present");
                wagePerDay = EMP_WAGE_PER_HOUR * EMP_FULL_DAY_HOUR;
                Console.WriteLine("Wage per day" +wagePerDay);
            }
            else
            {
                Console.WriteLine("Employee is absent");
                wagePerDay = EMP_WAGE_PER_HOUR * NO_WAGE ;
                Console.WriteLine(" Wages per day "+wagePerDay);
            }
        }
    }
}
