﻿using System;

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
        //variable
        private static int wagePerDay = 0;
        private static int workHours=0;
        static void Main(string[] args)
        {
            Program emp =new Program();
            Console.WriteLine("Welcome to Employee Wage Computation");
            Random random = new Random();
            int isEmpRandom = random.Next(0, 3);
            int empType = (isEmpRandom % 3);
            //calculating full-time,part-time using case statement 
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

            int wage=emp.employeeType(empType,EMP_WAGE_PER_HOUR,workHours);
            Console.WriteLine("wage per day : " + wage);
        }
        //Method to check employee present full time or part time then calulate the wagePerDay
        public int employeeType(int empType,int EMP_WAGE_PER_HOUR, int workHours)
        {
            
            if ( empType == EMP_FULL_TIME)
            {
                Console.WriteLine("Employee is present for full time");
                wagePerDay = EMP_WAGE_PER_HOUR * workHours;
                return wagePerDay;
            }
            else if( empType == EMP_PART_TIME )
            {
                Console.WriteLine("Employee is present for part time");
                wagePerDay = EMP_WAGE_PER_HOUR * workHours;
                return wagePerDay;
            }
            else
            {
                wagePerDay = NO_WAGE;
                return wagePerDay;
            }
            return 0;
        }
    }
}
