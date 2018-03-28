using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (var item in this.Controls) 
            {
                if (item is Button) 
                {
                    ((Button)item).Click += CommonBtn_Click;
 
                }
                
            }
        }
        private void CommonBtn_Click(object sender, EventArgs e)
        {
            string msg = ((Button)sender).Text;
            switch (msg) {
                case "NO":
                    this.Hide();
                    MessageBox.Show("Дуже прикро: Наступного разу не забудьте про морковку!");
                    Application.Exit();
                    break;
                case "Yes":
                    this.Hide();
                    MessageBox.Show("Добре,правильно! Морковка дуже корисна!");
                    Application.Exit();
                    break;
                case "Cancel":
                    this.Hide();
                    MessageBox.Show("Ви ухилились від запитання!\nЯкщо ви не будете їсти морковку,то вас буде відраховано");
                    Application.Exit();
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
