using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Configuration;
using System.Data.Common;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Media;
using System.Text.RegularExpressions;

namespace Lab2
{
    public partial class MainForm : Form
    {
        private Form _childForm; 

        private Control[] flexControls; //array of controls which could be re/activated , coresponding to chosen query


        private string connectionString;
        


        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager
                .ConnectionStrings["Lab2.Properties.Settings.ScientistsConnectionString"].ConnectionString;
            
            flexControls=new Control[]{IDtextbox,nameTextbox,midNameTextbox,surnameTextbox,directDropDown,artclTextbox,byIDCheck,byDirectCheck};


        }

        private void DirecButton_Click(object sender, EventArgs e) // go to child form,  link to which is stored in _childForm 
        {
            if (_childForm == null || _childForm.IsDisposed)
            {
                _childForm = new ChildForm(this);
            }

            _childForm.Show();
            this.Hide();

        }

        private void MainFrom_Load(object sender, EventArgs e) 
        {
            string[] predefinedData = ConfigurationManager.AppSettings["predefinedDirects"].Split(',')
                .Select(s => s.Trim()).ToArray();
            CheckData(predefinedData);
        }

        private void CheckData(string[] predefinedRows) // check if table contains predefined rows, if not then add them
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                for (int i = 0; i < predefinedRows.Length; i += 2)
                {

                    string sqlSelect =
                        $"Select * From ResearchDirections Where Name = '{predefinedRows[i]}' And Description= '{predefinedRows[i + 1]}' ";
                    MySqlCommand command = new MySqlCommand(sqlSelect, connection);
                    using (MySqlDataReader result = command.ExecuteReader())
                    {
                        if (!result.HasRows)
                        {
                            string sqlInsert =
                                $"Insert into ResearchDirections (Name,Description) values ('{predefinedRows[i]}','{predefinedRows[i + 1]}')";

                            command.CommandText = sqlInsert;
                            result.Close();
                            command.ExecuteNonQuery();
                        }
                    }





                }
            }
        }

        private void DirectDropDown_Click(object sender, EventArgs e) //retrieving directions names by their id
        {
            List<string> directionList = new List<string>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                string
                    sqlExp =
                        @"Select Name From ResearchDirections"; //@"Select rd.Name From ResearchDirections as rd Inner Join Scientists as sc on sc.DirectionID=rd.ID";
                MySqlCommand command = new MySqlCommand(sqlExp, connection);
                MySqlDataReader data = command.ExecuteReader();

                while (data.Read())
                {
                    directionList.Add(data.GetString(0));
                }
            }

            directDropDown.DataSource = directionList;
        }

        private void ExecButton_Click(object sender, EventArgs e) 
        {
            if (InputAnalisys())
            {
                string query = CookQuery();
                if(getRadioButton.Checked)
                    ExecuteSelectQuery(query,dataGridView);
                else
                    ExecuteNonSelectQuery(query);

            }
           

        }

        public void ExecuteSelectQuery(string query, DataGridView grid) 
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                grid.DataSource = ds.Tables[0];

            }
        }

        public void ExecuteNonSelectQuery(string query) //for non-select query types, shows number of affected rows
        {
            using (MySqlConnection connection= new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command= new MySqlCommand(query,connection);
                int affectedRows = command.ExecuteNonQuery();
                MessageBox.Show(affectedRows.ToString());
            }
        }

        private bool InputAnalisys() //checks textboxes for appropriate input
        {
            bool check=true;
            string errorMsg = String.Empty;

            if (!int.TryParse(IDtextbox.Text, out int m) && IDtextbox.Enabled)
            {
                check = false;
                errorMsg += "Invalid ID Format! ";
            }

            if (directDropDown.Enabled && directDropDown.Text == String.Empty)
            {
                errorMsg = "Direction field  is empty!";
                check = false;
                
            }

            if (artclTextbox.Enabled && artclTextbox.Text == String.Empty)
            {
                errorMsg = "Number of articles is undefined!";
                check = false;

            }

            if (!int.TryParse(artclTextbox.Text, out int n) && artclTextbox.Enabled)
            {
                check = false;
                errorMsg += "Number of articles has an  invalid format! ";
            }


            foreach (TextBox input in nameGroupBox.Controls)
            {
                if (input.Enabled&&input.Text == String.Empty)
                {
                    errorMsg = "One or more name fields are empty!";
                    check = false;
                    break;
                }


                if (!FormatCheck(input.Text)&&input.Enabled)
                {
                    check = false;
                    errorMsg += input.Text + " is invalid! ";
                }



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

        public bool FormatCheck(string input) //regex for text only
        {
            Regex pattern = new Regex("^[a-zA-Zа-яА-ЯіІїЇєЄ'][a-zA-Zа-яА-Я-'іІїЇєЄ ]+[a-zA-Zа-яА-ЯіІїЇєЄ']?$");
            Match check = pattern.Match(input);
            return check.Success;
        }

        public  string CookQuery() //pick apropriate query
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

        private string FormDeleteQuery()
        {
            
            return $"Delete From Scientists Where ID={IDtextbox.Text}";
        }

        public void ReactivateControlls(bool[] values, Control[] controls) // re/activating controls, listed in array, acording to bool values
        {
            if (values.Length == controls.Length)
            {
                for (int i = 0; i < values.Length && i<controls.Length; i++)
                {
                    controls[i].Enabled = values[i];
                }
            }
        }

        private string FormUpdateQuery()
        {
            
            return  $"Update Scientists Set FirstName='{nameTextbox.Text}', MiddleName='{midNameTextbox.Text}', Surname='{surnameTextbox.Text}', DirectionId={GetDirection()}, ArticlesNumber={int.Parse(artclTextbox.Text)} Where ID={int.Parse(IDtextbox.Text)} ";
        }

        private string FormInsertQuery()
        {

            

            return $"Insert Into Scientists(FirstName,MiddleName,Surname,DirectionId,ArticlesNumber) Values('{nameTextbox.Text}','{midNameTextbox.Text}','{surnameTextbox.Text}',{GetDirection()},{int.Parse(artclTextbox.Text)})";
        }

        private int? GetDirection() //get dierction id by name
        {
            int? result=null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();
                string sqlExp = $"Select ID From ResearchDirections Where Name='{directDropDown.Text}'";
                MySqlCommand command = new MySqlCommand(sqlExp, connection);
                MySqlDataReader data = command.ExecuteReader();
                while (data.Read())
                {
                    result =(int) data[0];
                }


            }

            return result;
        }

        private string FormSelectQuery()
        {
             

            string condition = String.Empty;

                if (byDirectCheck.Checked && !byIDCheck.Checked)
                {
                    
                condition = "Where " + $"sc.DirectionID={GetDirection()}";
                }
                else
                {
                    if (!byDirectCheck.Checked && byIDCheck.Checked)
                    {
                        
                    condition = "Where " + $"sc.ID={int.Parse(IDtextbox.Text)}";
                    }
                }

                return
                    $"Select sc.ID,sc.FirstName,sc.MiddleName,sc.Surname,sc.ArticlesNumber,rd.Name,rd.Description From Scientists as sc Inner Join ResearchDirections as rd on sc.DirectionID = rd.ID {condition}";
            }

        private void DeleteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            byIDCheck.Checked = false;
            byDirectCheck.Checked = false;
            bool[] controlsParams = new bool[] { true, false, false, false, false, false, false, false };
            ReactivateControlls(controlsParams,flexControls);
        }

        private void UpdateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            byIDCheck.Checked = false;
            byDirectCheck.Checked = false;
            bool[] controlsParams = new bool[] { true, true, true, true, true, true, false, false };
            ReactivateControlls(controlsParams, flexControls);
        }

        private void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            byIDCheck.Checked = false;
            byDirectCheck.Checked = false;
            bool[] controlsParams = new bool[] { false, true, true, true, true, true, false, false };
            ReactivateControlls(controlsParams,flexControls);
        }

        private void GetRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
                bool[] controlsParams = new bool[] { false, false, false, false, false, false, true, true};
                ReactivateControlls(controlsParams,flexControls);
            
        }

        private void ByDirectCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!byDirectCheck.Checked)
            {
                GetRadioButton_CheckedChanged(getRadioButton, new EventArgs());
                
            }
            else
            {
                byIDCheck.Checked = false;
                if (getRadioButton.Checked)
                {
                    bool[] controlsParams = new bool[] {false, false, false, false, true, false, true, true};
                    ReactivateControlls(controlsParams,flexControls);
                }
            }
        }

        private void ByIDCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!byIDCheck.Checked)
            {
                GetRadioButton_CheckedChanged(getRadioButton, new EventArgs());
            }
            else
            {
                byDirectCheck.Checked = false;
                if (getRadioButton.Checked)
                {
                    bool[] controlsParams = new bool[] {true, false, false, false, false, false, true, true};
                    ReactivateControlls(controlsParams,flexControls);
                }
            }
        }
    }
}
