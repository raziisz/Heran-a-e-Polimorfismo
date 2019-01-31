using System;
using System.Collections.Generic;
using Herança_e_Polimorfismo.Entities;

namespace Herança_e_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAcount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.001));
            list.Add(new BusinessAcount(1004, "Anna", 500.0, 500.0));

        }
    }
}
