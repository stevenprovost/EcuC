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
    public partial class Main : Form
    {
        public static List<List<int>> ignitionList = new List<List<int>>();
        public static List<List<int>> fuelList = new List<List<int>>();

        public static SerialPort port = new SerialPort(Properties.Settings.Default.com, 9600);

        public int rpm = 0;
        public int tps = 0;
        public int map = 0;
        public int igt = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            System.Threading.Thread newThread = new System.Threading.Thread(serialCom);
        }
        public void serialCom()
        {

            string s;
            while (true)
            {
                s = port.ReadLine();
                switch (s.Substring(0, 3))
                {
                    case "rpm":
                        int.TryParse(s, out rpm);
                        break;
                    case "tps":
                        int.TryParse(s, out tps);
                        break;
                    case "map":
                        int.TryParse(s, out map);
                        break;
                    case "igt":
                        int.TryParse(s, out igt);
                        break;
                }
            }
        }

        private void realtimeDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Live Main = new Live();
            Main.Show();
        }

        private void fuelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fuel Main = new Fuel();
            Main.Show();
        }

        private void ignitionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Ignition Main = new Ignition();
            Main.Show();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options Main = new Options();
            Main.Show();
        }
    }
}

namespace Extensions
{
    public static class Extension
    {
        public static int Round(this int i, int nearest)
        {
            return (i + 5 * nearest / 10) / nearest * nearest;
        }
    }
}
