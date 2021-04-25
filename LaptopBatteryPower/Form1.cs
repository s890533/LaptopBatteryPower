using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace LaptopBatteryPower
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PowerStatus pw = SystemInformation.PowerStatus;
            MessageBox.Show(pw.BatteryLifePercent.ToString() + " " + Environment.MachineName);
        }
    }
}
