using System;
using System.Windows.Forms;

namespace IntroToProgramming
{
    public partial class FuelLog : Form
    {
        //Display money gotten from fuel type if is moneyMode
        //else display liters dispensed

        private FuelLog() => InitializeComponent();

        public FuelLog(bool moneyMode) : this()
        {
            //if is moneyMode MoneyFromLitersCounter Start
            //else LiterDetailsDisplayCounter
            if (moneyMode) MoneyFromLitersCounter.Start();
            else LiterDetailsDisplayCounter.Start();
        }

        private void LiterDetailsDisplayCounter_Tick(object sender, EventArgs e)
        {
            Text = $"{Transactions.TotalFuelDispensed} liters dispensed";
            lpg.Text = $@"Total Fuel Dispensed ( Lpg ) : {Transactions.LpgFuelDispenced} liters";
            unleaded.Text = $@"Total Fuel Dispensed ( Unleaded ) : {Transactions.UnleadedFuelDispenced} liters";
            diesel.Text = $@"Total Fuel Dispensed ( Diesel ) : {Transactions.DieselFuelDispenced} liters";
        }

        private void MoneyFromLitersCounter_Tick(object sender, EventArgs e)
        {
            Text = $"£{Transactions.TotalMoneyFromTransactions} Sold";
            lpg.Text = $@"Lpg Fuel Sold : £{Transactions.MoneyFromLpg}";
            unleaded.Text = $@"Unleaded Fuel Sold : £{Transactions.MoneyFromUnleaded}";
            diesel.Text = $@"Diesel Fuel Sold : £{Transactions.MoneyFromDiesel}";
        }
    }
}