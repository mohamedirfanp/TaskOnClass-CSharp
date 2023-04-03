using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOnCSharp._31_03_2023
{
    internal class CalculateOvertime
    {

        public void CalculatePay(float[] EmployeeActivityChart)
        {
            float start_time = EmployeeActivityChart[0];
            float end_time = EmployeeActivityChart[1];
            float hour_rate = EmployeeActivityChart[2];
            float overtime_bouns = EmployeeActivityChart[3];
            var overtime_pay = 0.0;
            var base_pay = 0.0;

            if(start_time > 9 && end_time  < 17)
            {
                base_pay = (end_time - start_time) * hour_rate;
                Console.WriteLine($"${base_pay}");
                return;
            }

            base_pay = (17 - start_time) * hour_rate;
            if(end_time > 17.0f)
            {
                overtime_pay = (end_time - 17) * hour_rate * overtime_bouns;
            }

            var SalaryPerDay = base_pay + overtime_pay;
            Console.WriteLine($"${SalaryPerDay}");
            return;

        }

        public void MainBlock()
        {
            float[] arr = { 9, 17, 30, 1.5f };
            CalculatePay(arr);

            float[] arr2 = { 16, 18, 30, 1.8f };
            CalculatePay(arr2);

            float[] arr3 = { 13.25f, 15, 30, 1.5f };
            CalculatePay(arr3);
        }
    }
}
