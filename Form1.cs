using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
using Microsoft.Win32;

namespace ModelChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RegistryKey myKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\OEMInformation", true);
            String manu = myKey.OpenSubKey("Manufacturer", true).ToString();
            textBox1.Text = manu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                RegistryKey myKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\OEMInformation", true);
                myKey.SetValue("Manufacturer", textBox1.Text, RegistryValueKind.String);
            }
            if (textBox2.Text.Length > 0)
            {
                RegistryKey myKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\OEMInformation", true);
                myKey.SetValue("Model", textBox2.Text, RegistryValueKind.String);
            }
        }
    }
}
