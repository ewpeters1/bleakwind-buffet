 /*
 * Elliot Peters
 * CashViewOrginization.cs
 * Used as in middle man class for the RoundRegister.dll
 */
using RoundRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO.IsolatedStorage;
using System.Text;

namespace PointOfSale.RegisterItems
{
    /// <summary>
    /// This class implements properties and methods from the RoundRegister.dll
    /// </summary>
    public class CashViewOrginization : INotifyPropertyChanged
    {
        #region Setting up vairables for use
        //Other variables
        private double changeDue = 0;
        private bool enoughMoney = false;
        private double currentPayment = 0;
        private double amountDue = 0;
        
        //Change needed
        private int changePennies = 0;
        private int changeFiveCents = 0;
        private int changeTenCents = 0;
        private int changeTwentyFiveCents = 0;
        private int changeOneCoins = 0;
        private int changeHalfDollars = 0;
        private int changeOnes = 0;
        private int changeTwos = 0;
        private int changeFives = 0;
        private int changeTens = 0;
        private int changeTwenties = 0;
        private int changeFifties = 0;
        private int changeHundreds = 0;

        //Customer Payment 
        private int cusPennies = 0;
        private int cusNickels = 0;
        private int cusDimes = 0;
        private int cusQuarters = 0;
        private int cusOneCoins = 0;
        private int cusHalfDollars = 0;
        private int cusOnes = 0;
        private int cusTwos = 0;
        private int cusFives = 0;
        private int cusTens = 0;
        private int cusTwenties = 0;
        private int cusFifties = 0;
        private int cusHundreds = 0;

        #endregion

        public virtual event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor sets the total cost property to the recent order cost
        /// </summary>
        /// <param name="totalPrice"></param>
        public CashViewOrginization(double totalPrice)
        {
            TotalCost = totalPrice; 
        }

        /// <summary>
        /// Property for the order cost
        /// </summary>
        public double TotalCost
        {
            get;
            set;
        }

        /// <summary>
        /// Checks the amount due 
        /// </summary>
        public double AmountDue
        {
            get
            {
                if (CurrentPayment > 0)
                {
                    amountDue = TotalCost - CurrentPayment;
                }
                else amountDue = TotalCost;

                return amountDue;
            }
        }

        /// <summary>
        /// Making sure the customer payment is enough
        /// </summary>
        public bool UsingEnoughMoney
        {
            get
            {
                if (CurrentPayment >= TotalCost) enoughMoney = true;
                else enoughMoney = false;

                return enoughMoney;
            }
        }

        #region Variables for editing bill values
        /// <summary>
        /// property for number of 100 dollar bills the customer gave
        /// </summary>
        public int CusHundreds
        {
            get
            {
                return cusHundreds;
            }
            set
            {
                cusHundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CusHundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UsingEnoughMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }

        /// <summary>
        /// Property for number of 100s to give back
        /// </summary>
        public int ChangeHundreds 
        {
            get
            {
                return changeHundreds;
            }
            set
            {
                changeHundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        /// <summary>
        /// property for number of 50 dollar bills the customer gave
        /// </summary>
        public int CusFifties
        {
            get
            {
                return cusFifties;
            }
            set
            {
                cusFifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CusFifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UsingEnoughMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }

        /// <summary>
        /// Property for number of 50s to give back
        /// </summary>
        public int ChangeFifties
        {
            get
            {
                return changeFifties;
            }
            set
            {
                changeFifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        /// <summary>
        /// property for number of 20 dollar bills the customer gave
        /// </summary>
        public int CusTwenties
        {
            get
            {
                return cusTwenties;
            }
            set
            {
                cusTwenties  = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CusTwenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UsingEnoughMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }

        /// <summary>
        /// Property for number of 20s to give back
        /// </summary>
        public int ChangeTwenties
        {
            get
            {
                return changeTwenties;
            }
            set
            {
                changeTwenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        /// <summary>
        /// property for number of 10 dollar bills the customer gave
        /// </summary>
        public int CusTens
        {
            get
            {
                return cusTens;
            }
            set
            {
                cusTens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CusTens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UsingEnoughMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }

        /// <summary>
        /// Property for number of 10s to give back
        /// </summary>
        public int ChangeTens
        {
            get
            {
                return changeTens;
            }
            set
            {
                changeTens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        /// <summary>
        /// property for number of 5 dollar bills the customer gave
        /// </summary>
        public int CusFives
        {
            get
            {
                return cusFives;
            }
            set
            {
                cusFives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CusFives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UsingEnoughMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }

        /// <summary>
        /// Property for number of 5s to give back
        /// </summary>
        public int ChangeFives
        {
            get
            {
                return changeFives;
            }
            set
            {
                changeFives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        

        /// <summary>
        /// property for number of 2 dollar bills the customer gave
        /// </summary>
        public int CusTwos
        {
            get
            {
                return cusTwos;
            }
            set
            {
                cusTwos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CusTwos"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UsingEnoughMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }

        /// <summary>
        /// Property for number of 2s to give back
        /// </summary>
        public int ChangeTwos
        {
            get
            {
                return changeTwos;
            }
            set
            {
                changeTwos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwos"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }
        /// <summary>
        /// property for number of 1 dollar bills the customer gave
        /// </summary>
        public int CusOnes
        {
            get
            {
                return cusOnes;
            }
            set
            {
                cusOnes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CusOnes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UsingEnoughMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }

        /// <summary>
        /// Property for number of 100s to give back
        /// </summary>
        public int ChangeOnes
        {
            get
            {
                return changeOnes;
            }
            set
            {
                changeOnes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOnes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        public int ChangeOneCoins
        {
            get
            {
                return changeOneCoins;
            }
            set
            {
                changeOneCoins = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOneCoins"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        public int CusOneCoins
        {
            get
            {
                return cusOneCoins;
            }
            set
            {
                cusOneCoins = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CusOneCoins"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UsingEnoughMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }

        public int ChangeFiftyCents
        {
            get
            {
                return changeHalfDollars;
            }
            set
            {
                changeHalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFiftyCents"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        public int CusFiftyCents
        {
            get
            {
                return cusHalfDollars;
            }
            set
            {
                cusHalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CusFiftyCents"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UsingEnoughMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }


        public int ChangeTwentyFiveCents
        {
            get
            {
                return changeTwentyFiveCents;
            }
            set
            {
                changeTwentyFiveCents = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwentyFivesCents"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        public int CusTwentyFiveCents
        {
            get
            {
                return cusQuarters;
            }
            set
            {
                cusQuarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CusTwetnyFiveCents"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UsingEnoughMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }

        public int ChangeTenCents
        {
            get
            {
                return changeTenCents;
            }
            set
            {
                changeTens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTenCents"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        public int CusTenCents
        {
            get
            {
                return cusDimes;
            }
            set
            {
                cusDimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CusTenCents"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UsingEnoughMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }

        public int ChangeFiveCents
        {
            get
            {
                return changeFiveCents;
            }
            set
            {
                changeFiveCents = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeNickels"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        public int CusFiveCents
        {
            get
            {
                return cusNickels;
            }
            set
            {
                cusNickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CusFiveCents"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UsingEnoughMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }

        public int ChangePennies
        {
            get
            {
                return changePennies;
            }
            set
            {
                changePennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangePennies"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
            }
        }

        public int CusPennies
        {
            get
            {
                return cusPennies;
            }
            set
            {
                cusPennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CusPennies"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UsingEnoughMoney"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }
        #endregion

        #region Values for coins and bills in RoundRegister
        public int Pennies
        {
            get
            {
                return CashDrawer.Pennies;
            }
            set
            {
                CashDrawer.Pennies = value;
            }
        }

        public int Nickels
        {
            get
            {
                return CashDrawer.Nickels;
            }
            set
            {
                CashDrawer.Nickels = value;
            }
        }

        public int Dimes
        {
            get
            {
                return CashDrawer.Dimes;
            }
            set
            {
                CashDrawer.Dimes = value;
            }
        }

        public int Quarters
        {
            get
            {
                return CashDrawer.Quarters;
            }
            set
            {
                CashDrawer.Quarters = value;
            }
        }

        public int Dollars
        {
            get
            {
                return CashDrawer.Dollars;
            }
            set
            {
                CashDrawer.Dollars = value;
            }
        }

        public int HalfDollars
        {
            get
            {
                return CashDrawer.HalfDollars;
            }
            set
            {
                CashDrawer.HalfDollars = value;
            }
        }

        public int Ones
        {
            get
            {
                return CashDrawer.Ones;
            }
            set
            {
                CashDrawer.Ones = value;
            }
        }

        public int Twos
        {
            get
            {
                return CashDrawer.Twos;
            }
            set
            {
                CashDrawer.Twos = value;
            }
        }

        public int Fives
        {
            get
            {
                return CashDrawer.Fives;
            }
            set
            {
                CashDrawer.Fives = value;
            }
        }

        public int Tens
        {
            get
            {
                return CashDrawer.Tens;
            }
            set
            {
                CashDrawer.Tens = value;
            }
        }

        public int Twenties
        {
            get
            {
                return CashDrawer.Twenties;
            }
            set
            {
                CashDrawer.Twenties = value;
            }
        }

        public int Fifties
        {
            get
            {
                return CashDrawer.Fifties;
            }
            set
            {
                CashDrawer.Fifties = value;
            }
        }

        public int Hundreds
        {
            get
            {
                return CashDrawer.Hundreds;
            }
            set
            {
                CashDrawer.Hundreds = value;
            }
        }
        #endregion

        /// <summary>
        /// Total number of bills and coins in the drawer
        /// </summary>
        public double Total
        {
            get
            {
                return CashDrawer.Total;
            }
        }

        /// <summary>
        /// This is the change due property assigned to the change due textbox in the xaml
        /// </summary>
        public double ChangeDue
        {
            get { return changeDue; }
            set { changeDue = value; }
        }

        /// <summary>
        /// This adds up totals to give a resulting payment
        /// </summary>
        public double CurrentPayment
        {
            get
            {
                currentPayment = CusPennies * 0.01 + CusFiveCents * 0.05 + CusTenCents * 0.10 + CusTwentyFiveCents * 0.25 +
                                 CusFiftyCents * 0.50 + CusOneCoins * 1.0 +
                                 CusOnes * 1.00 + CusTwos * 2.00 + CusFives * 5.00 + CusTens * 10.00 +
                                 CusTwenties * 20.0 + CusFifties * 50.0 + CusHundreds * 100.0;
                return currentPayment;
            }
        }

        /// <summary>
        /// Opens the Drawer of the register
        /// </summary>
        public void OpenDrawer()
        {
            CashDrawer.OpenDrawer();
        }

        /// <summary>
        /// Resets the drawer in the register
        /// </summary>
        public void ResetDrawer()
        {
            CashDrawer.ResetDrawer();
        }

        /// <summary>
        /// Method for making change using the modular operator
        /// </summary>
        public void MakeChange()
        {
            if (UsingEnoughMoney && (CurrentPayment > TotalCost))
            {
                changeDue = Math.Round(CurrentPayment - TotalCost, 2);

                int payment = (int)changeDue;
                double paymentChange = Math.Round(changeDue - payment, 2);

                ChangeHundreds = payment / 100;
                payment %= 100;

                ChangeFifties = payment / 50;
                payment %= 50;

                ChangeTwenties = payment / 20;
                payment %= 20;

                ChangeTens = payment / 10;
                payment %= 10;

                ChangeFives = payment / 5;
                payment %= 5;

                ChangeTwos = payment / 2;
                payment %= 2;

                ChangeOnes = payment;

                ChangeOneCoins = 0;

                ChangeFiftyCents = (int)(paymentChange / 0.50);
                paymentChange %= 0.50;

                ChangeTwentyFiveCents = (int)(paymentChange / 0.25);
                paymentChange %= 0.25;

                ChangeTenCents = (int)(paymentChange / 0.10);
                paymentChange %= 0.10;

                ChangeFiftyCents = (int)(paymentChange / 0.05);
                paymentChange %= 0.05;

                ChangePennies = (int)(paymentChange / 0.01);
            }
            else
            {
                ChangeDue = 0;
                ChangeHundreds = 0;
                ChangeFifties = 0;
                ChangeTwenties = 0;
                ChangeTens = 0;
                ChangeFives = 0;
                ChangeTwos = 0;
                ChangeOnes = 0;
                ChangeOneCoins = 0;
                ChangeFiftyCents = 0;
                ChangeTwentyFiveCents = 0;
                ChangeTenCents = 0;
                ChangeFiveCents = 0;
                ChangePennies = 0;
            }
        }

        /// <summary>
        /// Method to calculate the remaining bills in the register
        /// </summary>
        public void FinializeSale()
        {
            Pennies = Pennies - ChangePennies + CusPennies;
            Nickels = Nickels - ChangeFiveCents + CusFiveCents;
            Dimes = Dimes - ChangeTenCents + CusTenCents;
            Quarters = Quarters - ChangeTwentyFiveCents + CusTwentyFiveCents;
            HalfDollars = HalfDollars - ChangeFiftyCents + CusFiftyCents;
            Dollars = Dollars - ChangeOneCoins + CusOneCoins;
            Ones = Ones - ChangeOnes + CusOnes;
            Twos = Twos - ChangeTwos + CusTwos;
            Fives = Fives - ChangeFives + CusFives;
            Tens = Tens - ChangeTens + CusTens;
            Twenties = Twenties - ChangeTwenties + CusTwenties;
            Fifties = Fifties - ChangeFifties + CusFifties;
            Hundreds = Hundreds - ChangeHundreds + CusHundreds;
        }

    }
}
