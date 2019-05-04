namespace IntroToProgramming
{
    partial class FuelLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.diesel = new System.Windows.Forms.Label();
            this.unleaded = new System.Windows.Forms.Label();
            this.lpg = new System.Windows.Forms.Label();
            this.LiterDetailsDisplayCounter = new System.Windows.Forms.Timer(this.components);
            this.MoneyFromLitersCounter = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // diesel
            // 
            this.diesel.AutoSize = true;
            this.diesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diesel.Location = new System.Drawing.Point(39, 29);
            this.diesel.Name = "diesel";
            this.diesel.Size = new System.Drawing.Size(281, 20);
            this.diesel.TabIndex = 11;
            this.diesel.Text = "Total Fuel Dispensed ( Diesel ) : 0";
            // 
            // unleaded
            // 
            this.unleaded.AutoSize = true;
            this.unleaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unleaded.Location = new System.Drawing.Point(12, 9);
            this.unleaded.Name = "unleaded";
            this.unleaded.Size = new System.Drawing.Size(308, 20);
            this.unleaded.TabIndex = 10;
            this.unleaded.Text = "Total Fuel Dispensed ( Unleaded ) : 0";
            // 
            // lpg
            // 
            this.lpg.AutoSize = true;
            this.lpg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpg.Location = new System.Drawing.Point(59, 49);
            this.lpg.Name = "lpg";
            this.lpg.Size = new System.Drawing.Size(261, 20);
            this.lpg.TabIndex = 9;
            this.lpg.Text = "Total Fuel Dispensed ( Lpg ) : 0";
            // 
            // LiterDetailsDisplayCounter
            // 
            this.LiterDetailsDisplayCounter.Tick += new System.EventHandler(this.LiterDetailsDisplayCounter_Tick);
            // 
            // MoneyFromLitersCounter
            // 
            this.MoneyFromLitersCounter.Tick += new System.EventHandler(this.MoneyFromLitersCounter_Tick);
            // 
            // FuelLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 76);
            this.Controls.Add(this.diesel);
            this.Controls.Add(this.unleaded);
            this.Controls.Add(this.lpg);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(498, 115);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(498, 115);
            this.Name = "FuelLog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FuelLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label diesel;
        private System.Windows.Forms.Label unleaded;
        private System.Windows.Forms.Label lpg;
        private System.Windows.Forms.Timer LiterDetailsDisplayCounter;
        private System.Windows.Forms.Timer MoneyFromLitersCounter;
    }
}