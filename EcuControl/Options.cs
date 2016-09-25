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
using EcuControl.Properties;
using System.Threading;

namespace EcuControl
{
    public partial class Options : Form
    {
        double tpsMax = Settings.Default.tpsMax;
        double tpsMin = Settings.Default.tpsMin;
        double tpsV = 0;

        public Thread th;

        bool stop = false;
        bool stopB = true;

        public Options()
        {
            InitializeComponent();
            fullText.Text = tpsMax.ToString();
            zeroText.Text = tpsMin.ToString();

            updateStatus();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = port;
                item.Value = port;

                portBox.Items.Add(item);
            }
            portBox.SelectedText = Settings.Default.com;
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            Settings.Default.com = portBox.Text;
            Settings.Default.Save();
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SerialLoop()
        {
            string line;

            while (!stop && Main.port.IsOpen)
            {
                line = Main.port.ReadLine();
                if (line.Contains("b"))
                {
                    if (double.TryParse(Main.port.ReadLine(), out tpsV))
                    {
                        tpsV = Math.Round((tpsV / 100), 2);
                        SetText(currentText, (Math.Round(((tpsV - tpsMin) / (tpsMax - tpsMin)), 2) * 100).ToString() + "%");
                        if (tpsV >= tpsMin && tpsV <= tpsMax)
                            SetBar(currentBar, Convert.ToInt32(Math.Round((tpsV * 100), 0)));
                    }
                }
            }
            CloseSerial();
        }

        private bool OptionsLoop()
        {
            if (!Main.port.IsOpen)
            {
                Main.port.Open();
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

        private void SetBar(ProgressBar bar, int value)
        {
            if (bar.InvokeRequired)
            {
                bar.Invoke(new Action<ProgressBar, int>(SetBar), bar, value);
            }
            else
            {
                bar.Value = value;
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

        private void CloseSerial()
        {
            if (Main.port.IsOpen)
                Main.port.Close();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            stopB = OptionsLoop();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            stop = true;
            stopB = true;
        }

        private void updateStatus()
        {
            double i;
            double j;

            i = double.Parse(zeroText.Text);
            j = double.Parse(fullText.Text);

            i *= 100;
            j *= 100;

            currentBar.Minimum = Convert.ToInt32(Math.Round(i, 0));
            currentBar.Maximum = Convert.ToInt32(Math.Round(j, 0));
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            tpsMin = tpsV;
            zeroText.Text = tpsMin.ToString();
            updateStatus();
        }

        private void fullBtn_Click(object sender, EventArgs e)
        {
            tpsMax = tpsV;
            fullText.Text = tpsMax.ToString();
            updateStatus();
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!stopB)
            {
                MessageBox.Show("Stop the serial communication first!");
                e.Cancel = true;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Settings.Default.tpsMin = tpsMin;
            Settings.Default.tpsMax = tpsMax;
            Settings.Default.Save();
        }
    }
}
