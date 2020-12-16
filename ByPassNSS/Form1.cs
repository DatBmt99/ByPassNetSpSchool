using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Threading.Tasks;
using Microsoft.Win32;
namespace ByPassNSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Trinh Xuan Dat
            InitializeComponent();
            
        }
        string subKey = @"SOFTWARE\NetSupport Ltd\PCICTL\ConfigList\NetSupport School";
        string value = "";
        string keyName = @"General\AdminPassword";
        string keyName1 = @"General\Password";
       
        private void txtConect_Click(object sender, EventArgs e)
        {
            string data = ReadRegistry(keyName, subKey);
            if (data != "dgAAAJ5RqmOJNaYoN)VdEUoablcA")
            {
                MessageBox.Show("Password already exists");
            }
            else
            {
                EditIntoRegistry(keyName, value, subKey);
                EditIntoRegistry(keyName1, value, subKey);
                MessageBox.Show("Success");
            }
         
        }
        static void WriteIntoRegistry(string keyName, string value, string subKey)
        {

            RegistryKey sk = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(subKey);
            sk.SetValue(keyName, value);
        }
        static void EditIntoRegistry(string keyName, string value, string subKey)
        {
            RegistryKey sk = Registry.CurrentUser.OpenSubKey(subKey, true);
            sk.SetValue(keyName, value);
            sk.Close(); 
        }
        static string ReadRegistry(string keyName, string subKey)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(subKey, true);

            string data = key.GetValue(keyName).ToString();
            return data;
            //key.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string value = "dgAAAJ5RqmOJNaYoN)VdEUoablcA";
            EditIntoRegistry(keyName,value,subKey);
            EditIntoRegistry(keyName1, value, subKey);
            Application.Exit();
        }
    }
}

