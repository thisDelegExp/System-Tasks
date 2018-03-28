using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Lab1_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                using (RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Galchenko"))
                {
                    string[] words = {
                        "Я -",
                        "- не студент",
                        "кафедри",
                        "Комп'ютерної інженерії!"
                     };

                    registryKey.SetValue("P5", words, RegistryValueKind.MultiString);
                    MessageBox.Show("Successfully");
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE", true).CreateSubKey("Galchenko", true))
                {

                    var s = registryKey.GetValue("P6") as string[];
                    if (s!=null) {
                        string i1 = null;
                        foreach (var i in s)
                        {
                            i1 += i;
                        }
                        MessageBox.Show(i1);
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
