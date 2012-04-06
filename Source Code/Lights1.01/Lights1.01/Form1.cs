using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using Microsoft;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SerialPort COM3 = new SerialPort();
        // Allow the user to set the appropriate properties.

        public Form1()
        {

            bool open = COM3.IsOpen;
            string portName = Interaction.InputBox("Port Name", "Port Name", "COM3", 10, 10);
            string baudRateStr = Interaction.InputBox("Baud Rate", "Baud Rate", "9600", 10, 10);
            int baudRateInt = Convert.ToInt32(baudRateStr);
            /*bool check = true; 
            while (check == true)
                {
                    string parityStr = Interaction.InputBox("Parity", "Enter T or F", "T", 10, 10);
                    if (parityStr.Equals("T"))
                    {
                        COM3.Parity = (true);
                        bool parityBool = true;
                    } if else (parityStr.Equals("F")) {

                    }
                }*/
            /*COM3.DataBits = SetPortDataBits(COM3.DataBits);
            /COM3.StopBits = SetPortStopBits(COM3.StopBits);
            COM3.Handshake = SetPortHandshake(COM3.Handshake);

            COM3.Parity = (COM3.Parity);
             */
            COM3.PortName = (portName);
            COM3.BaudRate = (baudRateInt);

            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (COM3.IsOpen == false)
            {
                COM3.Open();
            }
            string s = button1.Text;
            int numberOfBytesToRead;
            numberOfBytesToRead = COM3.BytesToRead;
            Byte[] newReceivedData = new Byte[numberOfBytesToRead];
            int reading = COM3.Read(newReceivedData, 0, numberOfBytesToRead);
            COM3.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            //MessageBox.Show("Number of bytes: " + COM3.BaudRate);
            if (s.Equals("Lights on"))
                    {button1.Text = "Lights off";
                    COM3.WriteLine("1");
            pictureBox1.Image = Lights.Properties.Resources.Light_on;
            COM3.Close();
                    }else{
            button1.Text = "Lights on";
            COM3.WriteLine("2");
            pictureBox1.Image = Lights.Properties.Resources.Light_off;
            COM3.Close();
                    }
    }
            
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private static void DataReceivedHandler(
                    object sender,
                    SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
        }
    }
}