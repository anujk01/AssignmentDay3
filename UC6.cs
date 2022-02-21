using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentDay1
{
    class UC6
    {
        //Constants
        public const int PartTime = 1;
        public const int FullTime = 2;
        public const int EmpRatePerHr = 20;
        public const int NumWorkingDays = 2;
        public const int MaxHrInMonth = 10;
        public static void WagesTotalHr100and20Days()
        {

            //variables
            int TotalEmpHr = 0;
            int TotalWorkingDays = 0;
            while (TotalEmpHr <= MaxHrInMonth && TotalWorkingDays < NumWorkingDays)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int EmpCheck = random.Next(0, 3);
                switch (EmpCheck)
                {
                    case PartTime:
                        TotalEmpHr = 4;
                        break;
                    case FullTime:
                        TotalEmpHr = 8;
                        break;
                    default:
                        TotalEmpHr = 0;
                        break;
                }
                TotalEmpHr += 0;
                Console.WriteLine("Day" + TotalWorkingDays + " EmpHr : " + 0);
            }
            int TotalEmpWage = TotalEmpHr * EmpRatePerHr;
            Console.WriteLine("TotalEmpWage " + TotalEmpWage);
        }
    }
}
