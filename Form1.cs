using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gothic_Pixels_Virtuals
{
    public partial class Gothic_DimCalc : Form
    {
        public Gothic_DimCalc()
        {
            InitializeComponent();
            ResolutionCBox.SelectedIndex = 0;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            String resolution = ResolutionCBox.Text;
            String[] dimensions = resolution.Split('x');

            int X = Int32.Parse(dimensions[0]);
            int Y = Int32.Parse(dimensions[1]);

            int value = Convert.ToInt32(ValueNumeric.Value);

            int[] convertedX = { value * X / 8192, value * 8192 / X };
            int[] convertedY = { value * Y / 8192, value * 8192 / Y };

            PixelsX.Text = convertedX[0].ToString();
            PixelsY.Text = convertedY[0].ToString();

            VirtualsX.Text = convertedX[1].ToString();
            VirtualsY.Text = convertedY[1].ToString();
        }
    }
}
