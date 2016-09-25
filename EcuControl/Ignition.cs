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
using Extensions;

namespace EcuControl
{
    public partial class Ignition : Form
    {
        public List<List<int>> ignitionList = new List<List<int>>();

        public int n;
        public int tps;

        bool stop = false;

        public Thread th;

        public Ignition()
        {
            InitializeComponent();
        }

        private void Ignition_Load(object sender, EventArgs e)
        {
            closeBtn.Focus();

            ignitionList = Main.ignitionList;
            if (ignitionList.Count != 0)
            {
                for (int i = 0; i <= 100; i += 10)
                {
                    for (int j = 500; j <= 8000; j += 500)
                    {
                        ((TextBox)Controls.Find("txt" + i + "_" + j, true)[0]).Text = ignitionList[(i / 10)][((j - 500) / 500)].ToString();
                    }
                }
            }
            else
            {
                for (int i = 0; i <= 100; i += 10)
                {
                    for (int j = 500; j <= 8000; j += 500)
                    {
                        ((TextBox)Controls.Find("txt" + i + "_" + j, true)[0]).Text = "0";
                    }
                }
            }
            ignitionList.Clear();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i += 10)
            {
                for (int j = 500; j <= 8000; j += 500)
                {
                    ((TextBox)Controls.Find("txt" + i + "_" + j, true)[0]).Text = "0";
                    
                }
            }
            ClearColor();
            stop = true;
        }
        private void CloseSerial()
        {
            if (Main.port.IsOpen)
                Main.port.Close();
        }

        private void SetColor(TextBox box, Color color)
        {
            if (box.InvokeRequired)
            {
                box.Invoke(new Action<TextBox, Color>(SetColor), box, color);
            }
            else
            {
                box.BackColor = color;
            }
        }

        private void ClearColor()
        {
            for (int i = 0; i <= 100; i += 10)
            {
                for (int j = 500; j <= 8000; j += 500)
                {
                    ((TextBox)Controls.Find("txt" + i + "_" + j, true)[0]).BackColor = SystemColors.Window;
                }
            }
        }

        public void  SerialLoop()
        {
            String line;
            TextBox vorige = txt0_500;

            bool tpsBool;
            bool nBool;

            while (!stop && Main.port.IsOpen)
            {
                
                line = Main.port.ReadLine();
                if (line.Contains("b"))
                {
                    tpsBool = int.TryParse(Main.port.ReadLine(), out tps);
                    Main.port.ReadLine();
                    nBool = int.TryParse(Main.port.ReadLine(), out n);
                    
                    if (!rmbBtn.Checked)
                        SetColor(vorige, SystemColors.Window);
                    else
                        SetColor(vorige, SystemColors.GradientActiveCaption);

                    if (tps >= 0 && tps <= 100 && n >= 500 && n <= 8000 && tpsBool && nBool)
                    {
                        tps = tps.Round(10);
                        n = n.Round(500);
                        vorige = (TextBox)Controls.Find("txt" + tps + "_" + n, true)[0];
                        SetColor(vorige, Color.Yellow);
                    }
                }
            }
            CloseSerial();
        }

        private void rmbBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!rmbBtn.Checked)
                ClearColor();
        }

        private void mapTraceBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (Main.port.IsOpen == false && mapTraceBtn.Checked)
            {
                Main.port.Open();
                stop = false;
                th = new Thread(new ThreadStart(SerialLoop));
                th.Start();
            }
            else if (!mapTraceBtn.Checked)
            {
                stop = true;
                if(!rmbBtn.Checked)
                    ClearColor();
            }
            else
            {
                MessageBox.Show("Serial port is closed!");
            }
        }

        private void Ignition_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!mapTraceBtn.Checked)
            {
                for (int i = 0; i <= 100; i += 10)
                {
                    List<int> subList = new List<int>();

                    for (int j = 500; j <= 8000; j += 500)
                    {
                        subList.Add(Int32.Parse(((TextBox)Controls.Find("txt" + i + "_" + j, true)[0]).Text));
                    }

                    ignitionList.Add(subList);
                }
                Main.ignitionList = ignitionList;
                stop = true;
            }
            else
            {
                MessageBox.Show("Stop the map trace first!");
                e.Cancel = true;
            }
        }
    }
}