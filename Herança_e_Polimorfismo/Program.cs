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

        }
    }
}
