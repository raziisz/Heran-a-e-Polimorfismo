using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPraFixacao.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return base.PriceTag()+"Customs fee: $ "+TotalPrice();
        }

        public double TotalPrice()
        {
            Price += CustomsFee;
            return Price;

        }
    }
}
