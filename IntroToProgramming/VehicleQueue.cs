using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace IntroToProgramming
{
    internal class VehicleQueue : UserControl
    {
        //Flow layout panel used to hold vehicle objects
        private FlowLayoutPanel _flowLayoutPanel1;

        //Title
        private Label _label1;

        //Objects used to aid random car creation
        private IContainer components;

        private readonly Random _random = new Random(169);
        private Timer _carCreation;

        //Random vehicle creation event
        public delegate void RandomVehicleCreate(ref Vehicle vehicle);

        public RandomVehicleCreate RandomVehicleCreated;

        public VehicleQueue()
        {
            InitializeComponent();
            _label1.Left = (Width - _label1.Width) / 2;
            _carCreation.Start();

            RandomVehicleCreated += (ref Vehicle vehicle) =>
            {
                // Change Time it takes for vehicles to be created
                // Create car creation between 1500 to 2200
                _carCreation.Interval = _random.Next(1500, 2200);

                //Keep Count of total vehicles created
                //(To be able to get number of vehicles that left before getting serivced
                Transactions.TotalNumberOfVehiclesCreated++;
            };
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._carCreation = new System.Windows.Forms.Timer(this.components);
            this._flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // _carCreation
            //
            this._carCreation.Interval = 1500;
            this._carCreation.Tick += new System.EventHandler(this._carCreation_Tick);
            //
            // _flowLayoutPanel1
            //
            this._flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._flowLayoutPanel1.AutoScroll = true;
            this._flowLayoutPanel1.Location = new System.Drawing.Point(0, 53);
            this._flowLayoutPanel1.Name = "_flowLayoutPanel1";
            this._flowLayoutPanel1.Size = new System.Drawing.Size(488, 336);
            this._flowLayoutPanel1.TabIndex = 0;
            //
            // _label1
            //
            this._label1.AutoSize = true;
            this._label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label1.Location = new System.Drawing.Point(119, 13);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(225, 37);
            this._label1.TabIndex = 1;
            this._label1.Text = "Vehicle Queue";
            //
            // VehicleQueue
            //
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._label1);
            this.Controls.Add(this._flowLayoutPanel1);
            this.Name = "VehicleQueue";
            this.Size = new System.Drawing.Size(488, 389);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        //Timer tick to create create random vehicles
        private void _carCreation_Tick(object sender, EventArgs e) => CreateVehicle();

        private void CreateVehicle()
        {
            //Create random vehicle with random type (Van,HGV,Car)
            var newVehicle = new Vehicle((Vehicle.VehicleType)_random.Next(0, 3));
            _flowLayoutPanel1.Controls.Add(newVehicle);
            RandomVehicleCreated(ref newVehicle);
        }

        //Remove Vehicle from vechicle queue
        public void RemoveVehicle(Vehicle vehicle) => _flowLayoutPanel1.Controls.Remove(vehicle);
    }
}