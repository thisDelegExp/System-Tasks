using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class ChildFrom : Form
    {
        private Form parentForm;
        public ChildFrom()
        {
            InitializeComponent();
        }

        public ChildFrom(Form parent): this()
        {
            parentForm = parent;
        }


        private void execButton_Click(object sender, EventArgs e)
        {
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Hide();

        }

        private void ChildFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            backButton_Click(sender,e);
        }
    }
}
