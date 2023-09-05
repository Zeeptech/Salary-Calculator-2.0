using System;
namespace Program { 
    class Program
    {
        static void Main(string[] args)
        {     

            int salary = int.Parse(args[0]);
            int hour = int.Parse(args[1]);
            int hourPerShift = int.Parse(args[2]);
            double overTimeProcent = double.Parse(args[3]);
            double taxProcent = double.Parse(args[4]);
            double ot = overTime(hour);
            double otp = overTimePay(overTimeProcent, salary);
            double totalOverTime = ot * otp;
            double payPerShift = salary * hourPerShift;
            double totalPay = salary * hour + totalOverTime;
            double tax = totalPay * (taxProcent / 100);
            double totalPayAfterTax = totalPay - tax;
            double esp = extraShiftPay(hourPerShift, salary, otp);
            Console.WriteLine($"You have worked a total of : {hour} hours.");
            
            Console.WriteLine($"Your Payment before taxes : {totalPay}kr.");
            Console.WriteLine($"Your Payment after taxes : {totalPayAfterTax}kr.");
            Console.WriteLine($"Each shift gives you : {payPerShift}kr.");
            Console.WriteLine($"After you've reached overtime. You'll get paid : {esp}kr per shift.");
        }

        // If hours pass 165, add hours to overtime, returns overtime puts it in "ot"
        static double overTime(double time)
        {

            double overTime = 0;
            if (time >= 165)
            {
                overTime = time - 165;
                Console.WriteLine($"You have a total of : {overTime} overtime hours.");
            }
            
            return time;
        }
        static double extraShiftPay(double hourPerShift, double salary, double otp)
        {
            double extraShiftPay = hourPerShift * salary + (hourPerShift * otp);
            return extraShiftPay;
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


