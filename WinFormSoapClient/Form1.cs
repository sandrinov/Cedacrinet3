using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSoapClient
{
    public partial class Form1 : Form
    {
        private Services.MeteoService meteo;
        public Form1()
        {
            InitializeComponent();
            meteo = new Services.MeteoService();
            meteo.GetPrevisioneCompleted += Meteo_GetPrevisioneCompleted;
        }

        private void Meteo_GetPrevisioneCompleted(object sender, Services.GetPrevisioneCompletedEventArgs e)
        {
            this.label1.Text = e.Result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.label1.Text = meteo.GetPrevisione(this.textBox1.Text);
            meteo.GetPrevisioneAsync(this.textBox1.Text);
        }
    }
}
