using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class ChildForm : Form
    {
        private MainForm parentForm;
        private Control[] flexControls;
        private string connectionString;
        public ChildForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager
                .ConnectionStrings["Lab2.Properties.Settings.ScientistsConnectionString"].ConnectionString;
            flexControls = new Control[] { IDtextBox,nameTextBox,descTextBox};
        }

        public ChildForm(MainForm parent): this()
        {
            parentForm = parent;
        }


        private void ExecButton_Click(object sender, EventArgs e)
        {
            if (InputAnalisys())
            {
                string query = CookQuery();
                if (getRadioButton.Checked)
                    parentForm.ExecuteSelectQuery(query,dataGridView);
                else
                    parentForm.ExecuteNonSelectQuery(query);

            }

        }

        private string CookQuery()
        {
            string sqlExp = String.Empty;

            foreach (RadioButton radioButton in queryGroupBox.Controls)
            {
                if (radioButton.Checked)
                {
                    switch (radioButton.Name)
                    {
                        case "getRadioButton":
                            sqlExp = FormSelectQuery();
                            break;
                        case "addRadioButton":
                            sqlExp = FormInsertQuery();
                            break;
                        case "updateRadioButton":
                            sqlExp = FormUpdateQuery();
                            break;
                        case "deleteRadioButton":
                            sqlExp = FormDeleteQuery();
                            break;
                    }
                }

            }

            return sqlExp;
        }

        private bool InputAnalisys()
        {
            bool check = true;
            string errorMsg = String.Empty;

            if (!int.TryParse(IDtextBox.Text, out int n) && IDtextBox.Enabled)
            {
                check = false;
                errorMsg += "Invalid ID Format! ";
            }

             if (nameTextBox.Enabled && nameTextBox.Text == String.Empty)
                {
                    errorMsg = "One or more name fields are empty!";
                    check = false;
                    
                }

             if (!parentForm.FormatCheck(nameTextBox.Text) && nameTextBox.Enabled)
                {
                    check = false;
                    errorMsg += nameTextBox.Text + " is invalid! ";
                }


            if (errorMsg != String.Empty)
            {
                //errorMsg = errorMsg.TrimEnd(" is invalid ".ToCharArray());
                MessageBox.Show($"AHTUNG! {errorMsg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                check = false;

            }

            return check;
        }

        private string FormDeleteQuery()
        {

            return $"Delete From ResearchDirections Where ID={IDtextBox.Text}";
        }

        private string FormUpdateQuery()
        {

            return $"Update ResearchDirections Set Name='{nameTextBox.Text}', Description='{descTextBox.Text}' Where ID='{IDtextBox.Text}'";
        }

        private string FormInsertQuery()
        {



            return $"Insert Into ResearchDirections(Name,Description) Values('{nameTextBox.Text}','{descTextBox.Text}')";
        }

        private string FormSelectQuery()
        {


          

            return
                $"Select ID,Name,Description From ResearchDirections";
        }




        private void BackButton_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Hide();

        }

        private void ChildFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            BackButton_Click(sender,e);
        }

        private void DeleteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            bool[] controlsParams = new bool[] { true, false,false};
            parentForm.ReactivateControlls(controlsParams,flexControls);
        }

        private void GetRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            bool[] controlsParams = new bool[] { false, false, false};
            parentForm.ReactivateControlls(controlsParams,flexControls);

        }

        private void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            bool[] controlsParams = new bool[] { false, true, true};
            parentForm.ReactivateControlls(controlsParams,flexControls);
        }

        private void UpdateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            bool[] controlsParams = new bool[] { true, true, true};
            parentForm.ReactivateControlls(controlsParams,flexControls);
        }
    }
}
