using IntroToProgramming.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace IntroToProgramming
{
    public class Pump : Button
    {
        public bool IsFree = true;
        private Vehicle _currentVehicle;

        public Pump()
        {
            InitializeComponent();
            Image = Resources.Free;
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            //
            // Pump
            //
            BackColor = Color.Transparent;
            FlatAppearance.BorderSize = 1;
            FlatStyle = FlatStyle.Flat;
            Size = new Size(140, 110);
            UseVisualStyleBackColor = false;
            ResumeLayout(false);
        }

        public void AssignVehicle(ref Vehicle vehicle)
        {
            //Clone original variable
            //Dispose original vehicle
            //use clone instead of original to insure only one vehicle can use the pump

            //if there is a vehicle being attended to by pump
            //end method
            if (_currentVehicle != null) return;

            //Disable car wait count
            //Increase Count of vehicles serviced
            vehicle.Dispose();
            _currentVehicle = vehicle;

            vehicle.WaitCount.Stop();

            Image = vehicle.Image;

            Transactions.VehiclesServiced++;

            //Implemnt vehicle data being displayed on pump
            vehicle.Fueling.Tick += delegate
            {
                //Display vehicle detials on pump
                Text = _currentVehicle.Text;

                //Remove vehicle data from pump (Free pump)
                if (_currentVehicle.TankIsFull)
                {
                    _currentVehicle.GenerateVechicleLog();
                    _currentVehicle.Fueling.Stop();
                    _currentVehicle.Dispose();
                    DropVehicle();
                }
            };

            //Start vehicle fueling timer
            _currentVehicle.Fueling.Start();

            IsFree = false;
        }

        private void DropVehicle()
        {
            Image = Resources.Free;
            _currentVehicle = null;
            IsFree = true;
            Text = "";
        }
    }
}