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
using System.Diagnostics;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Remember to change COM#
        SerialPort serialPort1 = new SerialPort("COM13", 9600, Parity.None, 8, StopBits.One); 
        string pressInput;
        kayChart serialDataChart, serialDataChart2;

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
            serialPort1.RtsEnable = true;
            Debug.WriteLine("Send to debug output.");
            /*serialPort1.Open();
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine();
            Console.Read();
            serialPort1.Close();
            */
            this.Load += Form1_Load;
        }

        private void DataReceivedHandler(
                        object sender,
                        SerialDataReceivedEventArgs e)
        {
            
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            /*Console.Write("Data Received: ");
            Console.WriteLine(indata);*/
            serialData.Invoke((MethodInvoker)delegate { serialData.AppendText("Data Received: " + indata + "\n"); });
            /*if (String.Equals(indata, "A"))
            {
                serialPort1.DiscardInBuffer();          // clear the serial port buffer
                serialPort1.Write("A");               // ask for more
            }*/
        }

        private void serialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        { 
            SerialPort sData = sender as SerialPort;
            string recvData = sData.ReadLine();

            /*byte[] recvData = new byte[2];

            recvData[0] = (byte)sData.ReadByte();
            recvData[1] = (byte)sData.ReadByte();
            */
            /*if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }*/
            //serialData.Invoke((MethodInvoker)delegate { serialData.AppendText("Received: " + recvData + "\n"); });
            if (String.Equals(recvData, "A"))
            {
                serialPort1.DiscardInBuffer();          // clear the serial port buffer
                serialPort1.Write("0.0\n");               // ask for more / handshake
            }
            serialData.Invoke((MethodInvoker)delegate { serialData.AppendText("Received: " + recvData + "\n"); });
            //serialPort1.Close();

            // Initialization of Chart Update
            double data, data2;
            bool result = Double.TryParse(recvData, out data);
            bool result2 = Double.TryParse(pressInput, out data2);
            if (result)
            {
                serialDataChart.TriggeredUpdate(data);

            }
            if (result2)
            {
                serialDataChart2.TriggeredUpdate(data2);
            }
            

        }

        private void pressureBtn_Click(object sender, EventArgs e)
        {
            pressInput = pressureText.Text + "\n";
            //Debug.WriteLine(pressInput);
            //double pressDouble = double.Parse(pressInput);
            //Debug.WriteLine(pressDouble);
            //byte[] pressByteArr = BitConverter.GetBytes(pressDouble);
            //Debug.WriteLine(pressByteArr);
            if (true)//(!serialPort1.IsOpen)
            {
                try
                {
                    //serialPort1.Open();
                    serialPort1.Write(pressInput);
                    //Debug.WriteLine(BitConverter.ToDouble(pressByteArr, 0));
                    //serialPort1.Close();
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
            serialDataChart2 = new kayChart(chart1, 60);
            serialDataChart2.serieName = "Input Pressure";
            //TODO: figure out how to get kayChart to print 2 lines through 2 series
        }

        private void serialData_TextChanged(object sender, EventArgs e)
        {
            serialData.SelectionStart = serialData.Text.Length;
            serialData.ScrollToCaret();
        }

        private void readSerialButton_Click(object sender, EventArgs e)
        {
            byte[] readSerialByteArr = new byte[8];
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();
                    //serialPort1.Read(readSerialByteArr, 0, 8);
                    //serialPort1.Close();
                    readSerialButton.Text = "Close";
                }
                catch
                {
                    MessageBox.Show("Serial Port is busy.");
                }
            } else
            {
                serialPort1.Close();
                readSerialButton.Text = "Read Serial";
            }
            //serialData.Invoke((MethodInvoker)delegate { serialData.AppendText("Received: " + BitConverter.ToString(readSerialByteArr) + "\n"); });
        }

    }
}
