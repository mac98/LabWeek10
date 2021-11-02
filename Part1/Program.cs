using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment test1 = new Payment(100);
            test1.SetPayment(-12.20);
            Console.WriteLine(test1.PaymentDetails());

            CashPayment test2 = new CashPayment();
            test2.SetPayment(45);
            Console.WriteLine(test2.GetPayment());
            test2.SetPayment(1001.33);
            Console.WriteLine(test2.PaymentDetails());

            CreditCardPayment test3 = new CreditCardPayment("John Doe", 10002003, 75.55);
            test3.SetCardHolder("Jared Smith");
            test3.SetCardID(10003256);
            test3.SetPayment(48.99);
            Console.WriteLine(test3.PaymentDetails());

            CreditCardPayment test4 = new CreditCardPayment();
            test3.SetCardHolder("Vivian Meir");
            test3.SetCardID(10003278);
            test3.SetPayment(12);
            Console.WriteLine(test3.PaymentDetails());

            Console.Read();
        }
    }

    class Payment
    {
        double amount;

        public Payment()
        {
            amount = 0;
        }

        public Payment(double _amount)
        {
            amount = _amount;
        }

        public double GetPayment()
        {
            return amount;
        }

        public void SetPayment(double _amount)
        {
            amount = _amount;
        }

        public string PaymentDetails()
        {
            return "The amount paid is $" + amount;
        }
    }

    class CashPayment : Payment
    {
        public CashPayment()
        {
            this.SetPayment(0);
        }

        public CashPayment(int _amount)
        {
            this.SetPayment(_amount);
        }

        public new string PaymentDetails()
        {
            return "The amount paid in cash is $" + this.GetPayment();
        }
    }

    class CreditCardPayment : Payment
    {
        string card_name;
        int card_ID;

        public CreditCardPayment()
        {
            card_name = "";
            card_ID = 0;
            this.SetPayment(0);
        }

        public CreditCardPayment(string card_holder, int ID_number, double _amount)
        {
            card_name = card_holder;
            card_ID = ID_number;
            this.SetPayment(_amount);
        }

        public void SetCardHolder(string card_holder)
        {
            card_name = card_holder;
        }

        public void SetCardID(int ID_number)
        {
            card_ID = ID_number;
        }

        public string GetCardHolder()
        {
            return card_name;
        }

        public int GetCardID()
        {
            return card_ID;
        }

        public new string PaymentDetails()
        {
            return "The amount paid by " + this.card_name + "'s credit card, numbered " + this.card_ID + ", is $" + this.GetPayment();
        }
    }
}
