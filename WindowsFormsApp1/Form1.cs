using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;
using System.IO.Ports;
using System.Threading;
using System.Runtime.InteropServices.WindowsRuntime;
using rtChart;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SerialPort serialPort1 = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
        string pressInput;
        kayChart serialDataChart;

        public Form1()
        {
            this.InitializeComponent();
            /*Button pressureBtn = new Button();
            pressureBtn.Name = "pressureBtn";
            pressureBtn.Click += pressureBtn_Click;
            TextBox pressureText = new TextBox();
            pressureText.Name = "pressureText";*/
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialDataReceivedEventHandler);
            serialPort1.Handshake = Handshake.None;

            
        }

        private void serialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sData = sender as SerialPort;
            string recvData = sData.ReadLine();
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
            serialData.Invoke((MethodInvoker)delegate { serialData.AppendText("Received: " + recvData); });
            serialPort1.Close();

            // Initialization of Chart Update
            double data;
            bool result = Double.TryParse(recvData, out data);
            if (result)
            {
                serialDataChart.TriggeredUpdate(data);
            }
            

        }

        private void pressureBtn_Click(object sender, EventArgs e)
        {
            pressInput = pressureText.Text;
            float pressFloat = float.Parse(pressInput);
            byte[] pressByteArr = BitConverter.GetBytes(pressFloat);
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();
                    serialPort1.Write(pressByteArr, 0, 4);
                    serialPort1.Close();
                }
                catch
                {
                    MessageBox.Show("Serial Port is busy.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialDataChart = new kayChart(chart1, 60);
            serialDataChart.serieName = "Pressure Sensed";
            //TODO: figure out how to get kayChart to print 2 lines through 2 series
        }

        private void serialData_TextChanged(object sender, EventArgs e)
        {
            serialData.SelectionStart = serialData.Text.Length;
            serialData.ScrollToCaret();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
