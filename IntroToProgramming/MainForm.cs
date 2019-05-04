using System;
using System.Windows.Forms;

namespace IntroToProgramming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            vehicleQueue.RandomVehicleCreated += RandomVehicleCreated;
            TransactionDetailsCounter.Start();
        }

        private void RandomVehicleCreated(ref Vehicle vehicle)
        {
            //Align pump list title
            PumpStatus.Left = (panel1.Width - PumpStatus.Width) / 2;

            AttendToVehicle(ref vehicle);

            //Display how many pumps are free to use
            PumpStatus.Text = pumpHandler.FreePumps == 0 ? @"All Pumps In Use" : $@"Pumps Free : {pumpHandler.FreePumps}";
        }

        private void AttendToVehicle(ref Vehicle vehicle)
        {
            //Send vehicle to first free pump
            //Start searching from the last column to make vehicles get fueled in a queueing pattern

            //Fuel pump 9 followed by 8 and then 7
            //if free
            if (pumpHandler.pump7.IsFree && pumpHandler.pump8.IsFree && pumpHandler.pump9.IsFree)
            {
                pumpHandler.pump9.AssignVehicle(ref vehicle);
                vehicleQueue.RemoveVehicle(vehicle);
                return;
            }

            if (pumpHandler.pump7.IsFree && pumpHandler.pump8.IsFree)
            {
                pumpHandler.pump8.AssignVehicle(ref vehicle);
                vehicleQueue.RemoveVehicle(vehicle);
                return;
            }

            if (pumpHandler.pump7.IsFree)
            {
                pumpHandler.pump7.AssignVehicle(ref vehicle);
                vehicleQueue.RemoveVehicle(vehicle);
                return;
            }

            //Fuel pump 6 followed by 5 and then 4
            //if free
            if (pumpHandler.pump4.IsFree && pumpHandler.pump5.IsFree && pumpHandler.pump6.IsFree)
            {
                pumpHandler.pump6.AssignVehicle(ref vehicle);
                vehicleQueue.RemoveVehicle(vehicle);
                return;
            }

            if (pumpHandler.pump4.IsFree && pumpHandler.pump5.IsFree)
            {
                pumpHandler.pump5.AssignVehicle(ref vehicle);
                vehicleQueue.RemoveVehicle(vehicle);
                return;
            }

            if (pumpHandler.pump4.IsFree)
            {
                pumpHandler.pump4.AssignVehicle(ref vehicle);
                vehicleQueue.RemoveVehicle(vehicle);
                return;
            }

            //Fuel pump 3 followed by 2 and then 1
            //if free
            if (pumpHandler.pump1.IsFree && pumpHandler.pump2.IsFree && pumpHandler.pump3.IsFree)
            {
                pumpHandler.pump3.AssignVehicle(ref vehicle);
                vehicleQueue.RemoveVehicle(vehicle);
            }
            else if (pumpHandler.pump1.IsFree && pumpHandler.pump2.IsFree)
            {
                pumpHandler.pump2.AssignVehicle(ref vehicle);
                vehicleQueue.RemoveVehicle(vehicle);
            }
            else if (pumpHandler.pump1.IsFree)
            {
                pumpHandler.pump1.AssignVehicle(ref vehicle);
                vehicleQueue.RemoveVehicle(vehicle);
            }
        }

        private void DisplayTransactionsSummary()
        {
            VehiclesServiced.Text = $@"Vehicles Serviced : {Transactions.VehiclesServiced}";
            VehiclesNotFueled.Text = $@"Vehicles That Left : {Transactions.VehiclesNotServiced}";
            moneyDetails.Text = $@"Transaction Money : £{Transactions.TotalMoneyFromTransactions}     1% Commision  : £{Transactions.TotalCommison}";
            totalFuelDispensed.Text = $@"Total Fuel Dispensed ( Unleaded, Diesel, Lpg  ) : {Transactions.TotalFuelDispensed} liters";
        }

        private void TransactionDetailsCounter_Tick(object sender, EventArgs e) => DisplayTransactionsSummary();

        //Display Dispensed Fuel Data(in Detail)
        private void button2_Click(object sender, EventArgs e) => new FuelLog(false).ShowDialog();

        //Display Money from Dispensed Fuel(in Detail)
        private void button4_Click(object sender, EventArgs e) => new FuelLog(true).ShowDialog();

        private void button3_Click(object sender, EventArgs e) => new TransactionsForm().ShowDialog();
    }
}