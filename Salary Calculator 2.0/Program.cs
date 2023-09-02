using System;
namespace Program { 
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(args[0]);
            int salary = int.Parse(args[1]);
            double overTimeProcent = double.Parse(args[2]);
            double taxProcent = double.Parse(args[3]);
            double ot = overTime(hour);
            double otp = overTimePay(overTimeProcent, salary);
            double totalOverTime = ot * otp;
            double totalPay = salary * hour + totalOverTime;
            double tax = totalPay * (taxProcent / 100);
            double totalPayAfterTax = totalPay - tax;
            Console.WriteLine($"Ur Payment before taxes:{totalPay}kr. Ur Payment after taxes:{totalPayAfterTax}kr");
        }

        // If hours pass 165, add hours to overtime, returns overtime puts it in "ot"
        static double overTime(double time)
        {

            double overTime = 0;
            if (time >= 165)
            {
                overTime = time - 165;
            }

            return time;
        }
        // 
        static double overTimePay(double otp, double salary)
        {
            double overTimePay = salary * (otp / 100);

            return overTimePay;
        }
    }
}

// Ta emot argument och skicka ut svaren "Ingen dialog med consol" All info på en WriteLine, 
// Lägg till Total Efter skatt, skatt i procent, Typ


