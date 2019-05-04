using System.ComponentModel;
using System.Windows.Forms;

namespace IntroToProgramming
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PumpStatus = new System.Windows.Forms.Label();
            this.fuelingHandler1 = new IntroToProgramming.FuelingHandler();
            this.PumpAssignCheck = new System.Windows.Forms.Timer(this.components);
            this.totalFuelDispensed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.moneyDetails = new System.Windows.Forms.Label();
            this.VehiclesNotFueled = new System.Windows.Forms.Label();
            this.VehiclesServiced = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.TransactionDetailsCounter = new System.Windows.Forms.Timer(this.components);
            this.vehicleQueue1 = new IntroToProgramming.VehicleQueue();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::IntroToProgramming.Properties.Resources.hgv;
            this.button1.Location = new System.Drawing.Point(146, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PumpStatus);
            this.panel1.Controls.Add(this.fuelingHandler1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(467, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 399);
            this.panel1.TabIndex = 4;
            // 
            // PumpStatus
            // 
            this.PumpStatus.AutoSize = true;
            this.PumpStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PumpStatus.Location = new System.Drawing.Point(133, 11);
            this.PumpStatus.Name = "PumpStatus";
            this.PumpStatus.Size = new System.Drawing.Size(236, 37);
            this.PumpStatus.TabIndex = 4;
            this.PumpStatus.Text = "Pumps Free : 9";
            // 
            // fuelingHandler1
            // 
            this.fuelingHandler1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fuelingHandler1.BackColor = System.Drawing.Color.White;
            this.fuelingHandler1.Location = new System.Drawing.Point(2, 51);
            this.fuelingHandler1.Name = "fuelingHandler1";
            this.fuelingHandler1.Size = new System.Drawing.Size(453, 346);
            this.fuelingHandler1.TabIndex = 3;
            // 
            // totalFuelDispensed
            // 
            this.totalFuelDispensed.AutoSize = true;
            this.totalFuelDispensed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFuelDispensed.Location = new System.Drawing.Point(60, 5);
            this.totalFuelDispensed.Name = "totalFuelDispensed";
            this.totalFuelDispensed.Size = new System.Drawing.Size(457, 20);
            this.totalFuelDispensed.TabIndex = 5;
            this.totalFuelDispensed.Text = "Total Fuel Dispensed ( Unleaded, Diesel, Lpg  ) : 0 liters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Money From Transactions : £0";
            // 
            // moneyDetails
            // 
            this.moneyDetails.AutoSize = true;
            this.moneyDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyDetails.Location = new System.Drawing.Point(83, 88);
            this.moneyDetails.Name = "moneyDetails";
            this.moneyDetails.Size = new System.Drawing.Size(377, 20);
            this.moneyDetails.TabIndex = 10;
            this.moneyDetails.Text = "Transaction Money : £0     1% Commision  : £0\r\n";
            // 
            // VehiclesNotFueled
            // 
            this.VehiclesNotFueled.AutoSize = true;
            this.VehiclesNotFueled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehiclesNotFueled.Location = new System.Drawing.Point(273, 56);
            this.VehiclesNotFueled.Name = "VehiclesNotFueled";
            this.VehiclesNotFueled.Size = new System.Drawing.Size(180, 20);
            this.VehiclesNotFueled.TabIndex = 12;
            this.VehiclesNotFueled.Text = "Vehicles That Left : 0";
            // 
            // VehiclesServiced
            // 
            this.VehiclesServiced.AutoSize = true;
            this.VehiclesServiced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehiclesServiced.Location = new System.Drawing.Point(277, 36);
            this.VehiclesServiced.Name = "VehiclesServiced";
            this.VehiclesServiced.Size = new System.Drawing.Size(176, 20);
            this.VehiclesServiced.TabIndex = 11;
            this.VehiclesServiced.Text = "Vehicles Serviced : 0";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(5, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(87, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 37);
            this.button3.TabIndex = 14;
            this.button3.Text = "View Transaction Log";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.VehiclesNotFueled);
            this.panel2.Controls.Add(this.VehiclesServiced);
            this.panel2.Controls.Add(this.moneyDetails);
            this.panel2.Controls.Add(this.totalFuelDispensed);
            this.panel2.Location = new System.Drawing.Point(3, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 112);
            this.panel2.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(23, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TransactionDetailsCounter
            // 
            this.TransactionDetailsCounter.Tick += new System.EventHandler(this.TransactionDetailsCounter_Tick);
            // 
            // vehicleQueue1
            // 
            this.vehicleQueue1.BackColor = System.Drawing.Color.White;
            this.vehicleQueue1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehicleQueue1.Location = new System.Drawing.Point(3, 4);
            this.vehicleQueue1.Name = "vehicleQueue1";
            this.vehicleQueue1.Size = new System.Drawing.Size(461, 399);
            this.vehicleQueue1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(932, 523);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vehicleQueue1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private VehicleQueue vehicleQueue1;
        private FuelingHandler fuelingHandler1;
        private Panel panel1;
        private Label PumpStatus;
        private Timer PumpAssignCheck;
        private Label totalFuelDispensed;
        private Label label5;
        private Label moneyDetails;
        private Label VehiclesNotFueled;
        private Label VehiclesServiced;
        private Button button2;
        private Button button3;
        private Panel panel2;
        private Timer TransactionDetailsCounter;
        private Button button4;
    }
}

