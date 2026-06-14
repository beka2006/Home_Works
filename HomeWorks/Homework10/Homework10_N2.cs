using System;
using HomeWorks;

// N2 ამოცანა 
namespace HomeWorks
{
    interface IFinanceOperations
    {
        double CalculateLoanPercent(int month, double amountPerMonth);
        bool CheckUserHistory();
    }

    class Bank : IFinanceOperations
    {
        private static Random random = new Random();
        private string bankName;

        public Bank(string bankName)
        {
            this.bankName = bankName;
        }

        public bool CheckUserHistory()
        {
            bool result = random.Next(2) == 1;
            Console.WriteLine($"{bankName} CheckUserHistory: {result}");
            return result;
        }

        public double CalculateLoanPercent(int month, double amountPerMonth)
        {
            if (!CheckUserHistory())
            {
                Console.WriteLine($"[{bankName}] Loan denied due to bad credit history.");
                return -1;
            }

            double principal = amountPerMonth * month;
            double maxRate = 0.05;
            double interest = principal * maxRate;
            double total = principal + interest;

            Console.WriteLine($"[{bankName}] Loan Approved!");
            Console.WriteLine($"  Principal:     {principal:F2} GEL");
            Console.WriteLine($"  Interest (5%): {interest:F2} GEL");
            Console.WriteLine($"  Total Payable: {total:F2} GEL");

            return total;
        }
    }

    class MicroFinance : IFinanceOperations
    {
        private int _userCount;
        private const double MonthlyRate = 0.10;
        private const double ServiceFeePerUser = 4;

        public MicroFinance(int userCount)
        {
            _userCount = userCount;
        }

        public bool CheckUserHistory()
        {
            Console.WriteLine("[MicroFinance] CheckUserHistory: True (always approved)");
            return true;
        }

        public double CalculateLoanPercent(int month, double amountPerMonth)
        {
            double principal = amountPerMonth * month;
            double interest = principal * MonthlyRate;
            double gross = principal + interest;
            double totalFees = ServiceFeePerUser * _userCount;
            double netAmount = gross - totalFees;

            Console.WriteLine($"[MicroFinance] Loan Calculation:");
            Console.WriteLine($"  Principal:         {principal:F2} GEL");
            Console.WriteLine($"  Interest (10%/mo): {interest:F2} GEL");
            Console.WriteLine($"  Gross Amount:      {gross:F2} GEL");
            Console.WriteLine($"  Service Fee:       {totalFees:F2} GEL ({_userCount} users x 4 GEL)");
            Console.WriteLine($"  Net to Customer:   {netAmount:F2} GEL");

            return netAmount;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("===== FileWorker Demo =====");
            TextFileWorker worker = new TextFileWorker("demo.txt", 128);
            worker.Write("Hello, this is a test file.");
            worker.Read();
            worker.Edit("Updated content.");
            worker.Delete();

            Console.WriteLine("===== Bank =====");
            Bank bank = new Bank("TBC Bank");
            bank.CalculateLoanPercent(12, 200);

            Console.WriteLine("===== MicroFinance Demo =====");
            MicroFinance mf = new MicroFinance(userCount: 3);
            mf.CheckUserHistory();
            mf.CalculateLoanPercent(6, 150);
        }
    }
}