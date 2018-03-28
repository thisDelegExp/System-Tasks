using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Lab1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                string date = key.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion").GetValue("InstallDate").ToString();
                DateTime dateDef = new DateTime(1970, 1, 1);

                Console.WriteLine(dateDef.AddSeconds(Convert.ToInt64(date)).ToString());
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
