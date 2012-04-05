using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string command = "1";
        SerialPort COM1 = new SerialPort("COM1");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = button1.Text;
            COM1.WriteLine(command);
                    if (s.Equals("Lights on"))
                    {button1.Text = "Lights off";
            pictureBox1.Image = Lights.Properties.Resources.Light_on;
                    }else{
            button1.Text = "Lights on";
            pictureBox1.Image = Lights.Properties.Resources.Light_off;
                    }
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}