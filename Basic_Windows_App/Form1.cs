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
    public partial class Form1 : Form
    {
        double celcius, farenheit;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFarenheit_Click(object sender, EventArgs e)
        {
            celcius = double.Parse(txtTemp.Text);
            farenheit = (celcius * 9) / 5 + 32;
            lblResult.Text = farenheit.ToString();
        }

        private void btnNewConvertor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Temp temp = new Temp();
            temp.Show();
        }

        private void btnCelcius_Click(object sender, EventArgs e)
        {
            farenheit = double.Parse(txtTemp.Text);

            celcius = (farenheit -32)* 5/9;

           lblResult.Text= celcius.ToString();
            
        }
    }
}
