using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
namespace Lab1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine,RegistryView.Registry64);
                using (RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Galchenko"))
                {
                    byte[] numbers = { 0x2A, 0x4B, 0xCE, 0xDF };

                    registryKey.SetValue("P1", "KI2 - Student", RegistryValueKind.String);
                    registryKey.SetValue("P2", numbers, RegistryValueKind.Binary);
                    registryKey.SetValue("P3", 0x2C6BCEDF, RegistryValueKind.DWord);
                    registryKey.SetValue("P4", 709611231, RegistryValueKind.DWord);
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
