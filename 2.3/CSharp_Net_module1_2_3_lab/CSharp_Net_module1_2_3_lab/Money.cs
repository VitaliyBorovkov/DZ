using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    // 1) declare enumeration CurrencyTypes, values UAH, USD, EU

    enum CurrencyTypes
    {
        UAH,
        USD,
        EU
    }
    class Money
    {
        // 2) declare 2 properties Amount, CurrencyType
        public int Amount { get; set; }
        public CurrencyTypes CurrencyType { get; set; }

        // 3) declare parameter constructor for properties initialization
        public Money(int Amount, CurrencyTypes currencyTypes)
        {
            this.Amount = Amount;
            this.CurrencyType = currencyTypes;
        }

        // 4) declare overloading of operator + to add 2 objects of Money
        public static Money operator + (Money money1, Money money2)
        {
            return new Money(money1.Amount + money2.Amount, money1.CurrencyType);
        }

        // 5) declare overloading of operator -- to decrease object of Money by 1
        public static Money operator -- (Money money1)
        {
            return new Money (money1.Amount, money1.CurrencyType);
        }

        // 6) declare overloading of operator * to increase object of Money 3 times
        public static Money operator * (Money money1, Money money2)
        {
            return new Money(money1.Amount * money2.Amount, money1.CurrencyType);
        }

        // 7) declare overloading of operator > and < to compare 2 objects of Money


        // 8) declare overloading of operator true and false to check CurrencyType of object

        // 9) declare overloading of implicit/ explicit conversion  to convert Money to double, string and vice versa

        //explicit
    }
}
