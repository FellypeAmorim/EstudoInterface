using System;
using System.Collections.Generic;
using System.Text;

namespace PropostoArquivos.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public double TotalPayment { get { return BasicPayment + Tax; } }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }
        public override string ToString()
        {
            return "Basic payment: " + BasicPayment + "\nTax: " + Tax + "\nTotal payment: " + TotalPayment;
        }
    }
}
