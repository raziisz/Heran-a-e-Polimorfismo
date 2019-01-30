using System;
using Herança_e_Polimorfismo.Entities;

namespace Herança_e_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAcount bacc = new BusinessAcount(1002, "Maria", 0.0, 500.00);

            //UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAcount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //DOWNCASTING
            BusinessAcount acc4 = (BusinessAcount)acc2;
            acc4.Loan(100.0);

            //BusinessAcount acc5 = (BusinessAcount)acc3;
            if(acc3 is BusinessAcount)
            {
                //BusinessAcount acc5 = (BusinessAcount)acc3;
                BusinessAcount acc5 = acc3 as BusinessAcount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!!!");
            }

        }
    }
}
