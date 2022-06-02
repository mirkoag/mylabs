using System;

namespace zadanije
{
    class Program
    {
        static void Main(string[] args)
        {
            HrDepartament com0 = HrDepartament.GetInstanceCom();
            com0.NameAuto = "Integral";
            com0.CompanyWorkersUp(100);
            com0.CompanyHoursUp(20);
            com0.NewWage(10);
            com0.NewTax(25);
            com0.ResWage();
            PrintInfo(com0);
            com0.CompanyHoursUp(30);
            com0.CompanyWorkersUp(50);
            PrintInfo(com0);
        }
        
        private static void PrintInfo(HrDepartament com0)
        {
            Console.WriteLine($"1.Company name: {com0.NameAuto}");
            Console.WriteLine($"2.Number of workers: {com0.CompanyCurrentWorkers}");
            Console.WriteLine($"3.Norm of hours: {com0.CompanyCurrentHours}");
            Console.WriteLine($"4.Wage: {com0.CompanyCurrentWage}");
            Console.WriteLine($"5.Tax: {com0.CompanyCurrentTax}");
            Console.WriteLine($"6.Res: {com0.CompanyCurrentResWage}");
        }
    }
}
