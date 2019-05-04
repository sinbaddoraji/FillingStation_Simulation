using System;
using System.Windows.Forms;

namespace IntroToProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            vehicleQueue1.RandomVehicleCreated += RandomVehicleCreated;
            TransactionDetailsCounter.Start();
        }

        private void RandomVehicleCreated(ref Vehicle vehicle)
        {
            //Align pump list title
            PumpStatus.Left = (panel1.Width - PumpStatus.Width) / 2;

            AttendToVehicle(ref vehicle);

            //Display how many pumps are free to use
            PumpStatus.Text = fuelingHandler1.FreePumps == 0 ? @"All Pumps In Use" : $@"Pumps Free : {fuelingHandler1.FreePumps}";
        }

        private void AttendToVehicle(ref Vehicle vehicle)
        {
            //Send vehicle to first free pump
            //Start searching from the last column to make vehicles get fueled in a queueing pattern

            //Fuel pump 9 followed by 8 and then 7
            //if free
            if (fuelingHandler1.pump7.IsFree && fuelingHandler1.pump8.IsFree && fuelingHandler1.pump9.IsFree)
            {
                fuelingHandler1.pump9.AssignVehicle(ref vehicle);
                vehicleQueue1.RemoveVehicle(vehicle);
                return;
            }

            if (fuelingHandler1.pump7.IsFree && fuelingHandler1.pump8.IsFree)
            {
                fuelingHandler1.pump8.AssignVehicle(ref vehicle);
                vehicleQueue1.RemoveVehicle(vehicle);
                return;
            }

            if (fuelingHandler1.pump7.IsFree)
            {
                fuelingHandler1.pump7.AssignVehicle(ref vehicle);
                vehicleQueue1.RemoveVehicle(vehicle);
                return;
            }

            //Fuel pump 6 followed by 5 and then 4
            //if free
            if (fuelingHandler1.pump4.IsFree && fuelingHandler1.pump5.IsFree && fuelingHandler1.pump6.IsFree)
            {
                fuelingHandler1.pump6.AssignVehicle(ref vehicle);
                vehicleQueue1.RemoveVehicle(vehicle);
                return;
            }

            if (fuelingHandler1.pump4.IsFree && fuelingHandler1.pump5.IsFree)
            {
                fuelingHandler1.pump5.AssignVehicle(ref vehicle);
                vehicleQueue1.RemoveVehicle(vehicle);
                return;
            }

            if (fuelingHandler1.pump4.IsFree)
            {
                fuelingHandler1.pump4.AssignVehicle(ref vehicle);
                vehicleQueue1.RemoveVehicle(vehicle);
                return;
            }

            //Fuel pump 3 followed by 2 and then 1
            //if free
            if (fuelingHandler1.pump1.IsFree && fuelingHandler1.pump2.IsFree && fuelingHandler1.pump3.IsFree)
            {
                fuelingHandler1.pump3.AssignVehicle(ref vehicle);
                vehicleQueue1.RemoveVehicle(vehicle);
            }
            else if (fuelingHandler1.pump1.IsFree && fuelingHandler1.pump2.IsFree)
            {
                fuelingHandler1.pump2.AssignVehicle(ref vehicle);
                vehicleQueue1.RemoveVehicle(vehicle);
            }
            else if (fuelingHandler1.pump1.IsFree)
            {
                fuelingHandler1.pump1.AssignVehicle(ref vehicle);
                vehicleQueue1.RemoveVehicle(vehicle);
            }
        }

        private void TransactionDetailsCounter_Tick(object sender, EventArgs e)
        {
            VehiclesServiced.Text = $@"Vehicles Serviced : {Transactions.VehiclesServiced}";
            VehiclesNotFueled.Text = $@"Vehicles That Left : {Transactions.VehiclesNotServiced}";
            moneyDetails.Text = $@"Transaction Money : £{Transactions.TotalMoneyFromTransactions}     1% Commision  : £{Transactions.TotalCommison}";
            totalFuelDispensed.Text = $@"Total Fuel Dispensed ( Unleaded, Diesel, Lpg  ) : {Transactions.TotalFuelDispensed} liters";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FuelLog(false).ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FuelLog(true).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new TransactionsForm().ShowDialog();
        }
    }
}