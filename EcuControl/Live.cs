using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace EcuControl
{
    public partial class Live : Form
    {
        public Thread th;
        bool stop = false;
        bool stopB = true;

        public Live()
        {
            InitializeComponent();
            statusLbl.Text = "Serial communication closed";
        }

        private bool LiveLoop()
        {
            if (!Main.port.IsOpen)
            {
                Main.port.Open();
                statusLbl.Text = "Serial communication active";
                stop = false;

                th = new Thread(new ThreadStart(SerialLoop));
                th.Start();
                return false;
            }
            else
            {
                MessageBox.Show("Serial port is closed!");
                return true;
            }
        }

        private void SerialLoop()
        {
            int tps = 0;
            double tpsV = 0;
            int n = 0;
            double mapI = 0;
            double igtI = 0;
            double mapO = 0;
            double igtO = 0;

            string line;
            
            while (!stop && Main.port.IsOpen)
            {
                line = Main.port.ReadLine();
                if (line.Contains("b"))
                {
                    if (int.TryParse(Main.port.ReadLine(), out tps))
                        SetText(tpsTxt, tps.ToString());
                    if (double.TryParse(Main.port.ReadLine(), out tpsV))
                        SetText(tpsVTxt, Math.Round((tpsV / 100), 2).ToString());
                    if (int.TryParse(Main.port.ReadLine(), out n))
                        SetText(nTxt, n.ToString());
                    if (double.TryParse(Main.port.ReadLine(), out mapI))
                        SetText(mapITxt, Math.Round((mapI / 100), 2).ToString());
                    if (double.TryParse(Main.port.ReadLine(), out igtI))
                        SetText(igtITxt, Math.Round((igtI / 100), 2).ToString());
                    if (double.TryParse(Main.port.ReadLine(), out mapO))
                        SetText(mapOTxt, Math.Round((mapO / 100), 2).ToString());
                    if (double.TryParse(Main.port.ReadLine(), out igtO))
                        SetText(igtOTxt, Math.Round((igtO / 100), 2).ToString());
                }
            }
            CloseSerial();
        }

        private void CloseSerial()
        {
            if (Main.port.IsOpen)
            { 
                Main.port.Close();
            }  
        }

        private void SetText(TextBox box, String text)
        {
            if (box.InvokeRequired)
            {
                box.Invoke(new Action<TextBox, String>(SetText), box, text);
            }
            else
            {
                box.Text = text;
            }
        }

        private void Live_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!stopB)
            {
                MessageBox.Show("Stop the serial communication first!");
                e.Cancel = true;
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            stopB = LiveLoop();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            stop = true;
            stopB = true;
            statusLbl.Text = "Serial communication closed";
        }
    }
}
