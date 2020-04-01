using System;
using System.Collections.Generic;
namespace empWageComputationProgram
{
    class Program
    {
        //constant
        private static int EMP_WAGE_PER_HOUR = 20;
        private static int EMP_FULL_DAY_HOUR = 8;
        private static int EMP_PART_TIME_HOUR = 4;
        private static int NO_WAGE = 0;
        private static int EMP_FULL_TIME = 2;
        private static int EMP_PART_TIME = 1;
        private static int NUM_OF_WORKING = 20;
        private static int MONTHLY_MAX_WORKING_HOURS = 100;
        //variable
        private static int totalEmpHrs = 0;
        private static int day = 1;
        private static int wagePerDay = 0;
        private static int empType;
        private static int isEmpRandom;
        private static int workHours=0;
        private static int totalWage;
        Random random = new Random();
        Dictionary<int, int> EmpDailyWageKeyValue = new Dictionary<int, int>();
        static void Main(string[] args)
        {
            Program emp =new Program();
            
            Console.WriteLine("Welcome to Employee Wage Computation");
            int empMonthlyWage=emp.getWorkHoursOrDay();
            Console.WriteLine("wage per day : " + empMonthlyWage);
        }
        //function to Calculate Wages till a condition of get function total working hours or days is reached for a month 
        public int getWorkHoursOrDay()
        {
            while (totalEmpHrs < MONTHLY_MAX_WORKING_HOURS && day < NUM_OF_WORKING)
            {
                isEmpRandom = random.Next(0, 3);
                empType = (isEmpRandom % 3);
                switch (empType)
                {
                    case 1:
                        workHours = EMP_PART_TIME_HOUR;
                       
                        break;
                    case 2:
                        workHours = EMP_FULL_DAY_HOUR;
                        break;
                    default:
                        break;
                }
     
                if (empType == EMP_FULL_TIME)
                {
                    Console.WriteLine("Employee is present for full time");
                    wagePerDay = EMP_WAGE_PER_HOUR * workHours;
                    dailyWageDict(day, wagePerDay);
                }
                else if (empType == EMP_PART_TIME)
                {
                    Console.WriteLine("Employee is present for part time");
                    wagePerDay = EMP_WAGE_PER_HOUR * workHours;
                    dailyWageDict(day, wagePerDay);
                }
                else
                {
                    Console.WriteLine("Emloyee is absent");
                    wagePerDay = NO_WAGE;

                }
                
                totalWage = totalWage + wagePerDay;//calculate total wage 
                day++;
            }
            //print the day and daily wage
            foreach (KeyValuePair<int, int> wage in EmpDailyWageKeyValue)
            {
                Console.WriteLine("Day:{0}  wage: {1}", wage.Key, wage.Value);
            }
            ////return employee wage for month 
            return totalWage;
        }
        //method to stored daily wage in dictinary
        public void dailyWageDict(int day, int wagePerDay)
        {
            EmpDailyWageKeyValue.Add(day, wagePerDay);
        }

    }
}
