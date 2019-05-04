using IntroToProgramming.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IntroToProgramming
{
    public class Vehicle : Button
    {
        public enum VehicleType { Car, Van, Hgv }

        private readonly VehicleType _selectedVehicleType;

        //Properties that have to do with fuel type

        private enum FuelType { Unleaded, Diesel, Lpg }

        private FuelType _selectedFuelType = FuelType.Diesel;

        private string _fuelType;

        //Properties that have to do with service frame time
        public readonly Timer WaitCount = new Timer();

        //Properties that have to do with vehicle tank
        private int _tankLimit = 40;

        private double _currentTank;

        //Take count of total number of liters of fuel dispensed
        private double _litersDispensed;

        public readonly Timer Fueling = new Timer();

        public bool TankIsFull => _currentTank > _tankLimit;

        //Vehicle Count
        private static int _vehiclenumber = 1;

        private static int VehicleNumber => _vehiclenumber++;

        private string FuelingInfo
        {
            get
            {
                if (_selectedFuelType == FuelType.Lpg) _fuelType = "LPG";
                else if (_selectedFuelType == FuelType.Unleaded) _fuelType = "Unleaded";
                else _fuelType = "Diesel";

                return $"Fuel: {_fuelType}\n\n\n\n\nTank: {_currentTank} / {_tankLimit}";
            }
        }

        public Vehicle(VehicleType vehicleType)
        {
            InitializeComponent();

            //Vehicle type
            ImplementVehicleProperties(vehicleType);
            _selectedVehicleType = vehicleType;

            //Set time frame to service a vehicle
            var waitTime = new Random().Next(1000, 2000);

            //if timer ever gets the chance to run
            //dispose vehicle object
            WaitCount.Interval = waitTime;
            WaitCount.Tick += (sender, args) => { Dispose(); };
            WaitCount.Start();
        }

        public void GenerateVechicleLog()
        {
            //Get string from vehicle type enum
            string vehicleType;
            switch (_selectedVehicleType)
            {
                case VehicleType.Car:
                    vehicleType = "Car";
                    break;

                case VehicleType.Van:
                    vehicleType = "Van";
                    break;

                case VehicleType.Hgv:
                    vehicleType = "HGV";
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            //£1.35 per litre for diseal
            //£1.31 per litre for unleaded
            //£1.33 per litre for LPG
            double moneyFromTransaction;
            if (_selectedFuelType == FuelType.Diesel) moneyFromTransaction = _litersDispensed * 1.35;
            else if (_selectedFuelType == FuelType.Diesel) moneyFromTransaction = _litersDispensed * 1.33;
            else moneyFromTransaction = _litersDispensed * 1.31;

            //Log Fueling info
            var lineSpace = Environment.NewLine;
            var logText = $"{lineSpace}#{VehicleNumber}  Vehicle Type: {vehicleType}  Fuel Type: {_fuelType}{lineSpace}";
            logText += $"Liters Dispensed : {_litersDispensed} liters  (£{moneyFromTransaction}){lineSpace}";

            Transactions.TransactionLog += logText;
        }

        private void FuelingOnTick(object sender, EventArgs e)
        {
            //Increase current tank if tank is not full
            if (TankIsFull) return;

            Text = FuelingInfo;
            _currentTank += 1.5;
            _litersDispensed += 1.5;

            //Take log of fuel dispensed based on fuel type
            //Log data to transaction class
            switch (_selectedFuelType)
            {
                case FuelType.Diesel:
                    Transactions.DieselFuelDispenced += 1.5;
                    break;

                case FuelType.Lpg:
                    Transactions.LpgFuelDispenced += 1.5;
                    break;

                case FuelType.Unleaded:
                    Transactions.UnleadedFuelDispenced += 1.5;
                    break;
            }
        }

        private void ImplementVehicleProperties(VehicleType vehicleType)
        {
            /*
             * Cars - maximum 40 litres (All Fuel Types)
             * Vans - maximum 80 litres (Diesel and Lgp)
             * HGV  - maximum 150 litres. (Just Diesel)
             */
            switch (vehicleType)
            {
                case VehicleType.Car:
                    Image = Resources.car;
                    _selectedFuelType = (FuelType)new Random().Next(0, 3);
                    break;

                case VehicleType.Van:
                    Image = Resources.van;
                    _selectedFuelType = (FuelType)new Random().Next(1, 3);
                    _tankLimit = 80;
                    break;

                case VehicleType.Hgv:
                    Image = Resources.hgv;
                    _tankLimit = 150;
                    break;

                default:
                    MessageBox.Show(@"There Was An Error Somewhere");
                    break;
            }

            //give vehicle random amount of fuel less than a quarter of maximum amount of fuel it can hold
            _currentTank = new Random().Next(0, _tankLimit / 4);
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            //
            // Fueling
            //
            Fueling.Interval = 1000;
            Fueling.Tick += FuelingOnTick;
            //
            // Vehicle
            //
            BackColor = Color.Transparent;
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Size = new Size(140, 110);
            UseVisualStyleBackColor = false;
            ResumeLayout(false);
        }
    }
}