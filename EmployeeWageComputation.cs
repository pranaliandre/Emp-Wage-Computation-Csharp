using System;
using System.Collections.Generic;
namespace empWageComputationProgram
{
    class EmployeeWageComputation
    {
        /// <summary>
        /// Constant
        /// </summary>
        const int EMPLOYEE_FULL_TIME = 2;
        const int EMPLOYEE_PART_TIME = 1;
        private static int EMPLOYEE_WAGE_PER_HOUR = 20;
        private static int EMPLOYEE_FULL_DAY_HOUR = 8;
        private static int EMPLOYEE_PART_TIME_HOUR = 4;
        private static int NUM_OF_WORKING_DAY = 20;
        private static int MONTHLY_MAX_WORKING_HOUR = 100;
        /// <summary>
        /// variable 
        /// </summary>
        private static int totalEmpHour = 0;
        private static int day = 1;
        private static int wagePerDay = 0;
        private static int employeeType;
        private static int isEmployeeRandom;
        private static int workHours=0;
        private static int totalWage;
        Random random = new Random();
        Dictionary<int, int> DailyWageKeyValue = new Dictionary<int, int>();
        static void Main(string[] args)
        {
            EmployeeWageComputation employee =new EmployeeWageComputation();
            Console.WriteLine("Welcome to Employee Wage Computation");
            int employeeMonthlyWage=employee.getWorkHoursOrDay();
            Console.WriteLine("Total day and daily wage : " + employeeMonthlyWage);
        }

        /// <summary>
        /// method to calculating daily wages
        /// </summary>
        /// <param name="workHours">employee working hours part time or fulltime</param>
        /// <returns></returns>
        public int dailyWage(int workHours)
        {
            wagePerDay = EMPLOYEE_WAGE_PER_HOUR * workHours; //calculating daily wage
            return wagePerDay;
        }
        /// <summary>
        /// function to Calculate Wages till a condition of get function total working hours or days is reached for a month
        /// </summary>
        /// <returns></returns>
        public int getWorkHoursOrDay()
        {
            //Calculating for a maximum hours of 100 or 20 days of workdone 
            while (totalEmpHour < MONTHLY_MAX_WORKING_HOUR && day < NUM_OF_WORKING_DAY)
            {
               
                isEmployeeRandom = random.Next(0, 3);
                employeeType = (isEmployeeRandom % 3);
                switch (employeeType)
                {
                    case EMPLOYEE_PART_TIME:
                        workHours = EMPLOYEE_PART_TIME_HOUR;
                        break;
                    case EMPLOYEE_FULL_TIME:
                        workHours = EMPLOYEE_FULL_DAY_HOUR;
                        break;
                    default:
                        break;
                }
                dailyWage(workHours);
                dailyWageDict(day, wagePerDay);
               
                totalWage = totalWage + wagePerDay;//calculate total wage 
                day++; //incrementing day +1
            }
            //print the day and daily wage using key and value
            foreach (KeyValuePair<int, int> wage in DailyWageKeyValue)
            {
                Console.WriteLine("Day:{0}  wage: {1}", wage.Key, wage.Value);
            }
            return totalWage;  //return employee wage for month 
        }
        /// <summary>
        /// method to stored day and daily wage in dictinary
        /// </summary>
        /// <param name="day">string ful month day</param>
        /// <param name="wagePerDay">storing the wahe per day its corresponding wage</param>
        public void dailyWageDict(int day, int wagePerDay)
        {
            DailyWageKeyValue.Add(day, wagePerDay);
        }

    }
}
