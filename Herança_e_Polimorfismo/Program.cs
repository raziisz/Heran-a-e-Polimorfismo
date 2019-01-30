using System;
using Herança_e_Polimorfismo.Entities;

namespace Herança_e_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAcount account = new BusinessAcount(8010, "Bob BRown", 100.0, 500.00);

            Console.WriteLine(account.Balance);

            account.Deposit(500.00);

            Console.WriteLine(account.Balance);

        }
    }
}
