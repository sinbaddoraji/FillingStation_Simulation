using System;
using System.Windows.Forms;

namespace IntroToProgramming
{
    public partial class PumpHandler : UserControl
    {
        public int FreePumps
        {
            get
            {
                //Get count of free pumps
                var output = 0;
                for (var i = 0; i < Controls.Count; i++)
                {
                    if (Controls[i] is Pump pump && pump.IsFree) output++;
                }
                //return count of free pumps
                return output;
            }
        }

        public PumpHandler() => InitializeComponent();

        private void FuelingHandler_SizeChanged(object sender, EventArgs e)
        {
            //Make Sure pump 5 always stays in the middle of the control
            pump5.Left = (Width - pump5.Width) / 2;
            pump5.Top = (Height - pump5.Height) / 2;

            //make sure pump 2 always stays in the top middle
            pump2.Left = (Width - pump2.Width) / 2;

            //make sure pump 8 always stays in the bottom middle
            pump8.Left = (Width - pump8.Width) / 2;
        }
    }
}