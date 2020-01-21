using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Windows_App
{
    public partial class Temp : Form
    {
        double farenheit, celcius;
        public Temp()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            if (chboxCelcius.Checked==true)
            {
                farenheit = double.Parse(txtTemp.Text);

                celcius = (farenheit - 32) * 5 / 9;

                lblResult.Text = celcius.ToString();
            }
            else if (chkboxFarenheit.Checked==true)
            {
                celcius = double.Parse(txtTemp.Text);
                farenheit = (celcius * 9) / 5 + 32;
                lblResult.Text = farenheit.ToString();
            }
            else
            {
                lblResult.Text = "Please select the conversion type !";
            }
        }
    }
}
