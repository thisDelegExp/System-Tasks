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
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Lab2
{
    public partial class MainFrom : Form
    {
        private Form _childForm;
        private string connectionString;
        //private Dictionary<string, string> expPatterns;
        

        public MainFrom()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Lab2.Properties.Settings.ScientistsConnectionString"].ConnectionString;
            //expPatterns= new Dictionary<string, string>();
            
        }

        private void DirecButton_Click(object sender, EventArgs e)
        {
            if (_childForm == null||_childForm.IsDisposed)
            {
                _childForm = new ChildFrom(this);
            }
            _childForm.Show();
            this.Hide();

        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
            string[] predefinedData = ConfigurationManager.AppSettings["predefinedDirects"].Split(',').Select(s => s.Trim()).ToArray();
            CheckData(predefinedData);
        }

        private void CheckData(string[] predefinedRows)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                connection.Open();        
                
                for (int i = 0; i < predefinedRows.Length; i += 2)
                {
                    
                    string sqlSelect =$"Select * From ResearchDirections Where Name = '{predefinedRows[i]}' And Description= '{predefinedRows[i+1]}' ";
                    SqlCommand command = new SqlCommand(sqlSelect, connection);
                    using (SqlDataReader result = command.ExecuteReader())
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

        private void DirectDropDown_Click(object sender, EventArgs e)
        {
            List<string> directionList=new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                string sqlExp = @"Select Name From ResearchDirections";//@"Select rd.Name From ResearchDirections as rd Inner Join Scientists as sc on sc.DirectionID=rd.ID";
                SqlCommand command= new SqlCommand(sqlExp,connection);
                SqlDataReader data = command.ExecuteReader();

                while (data.Read())
                {
                    directionList.Add(data.GetString(0));
                }
            }

            directDropDown.DataSource = directionList;
        }

        private void ExecButton_Click(object sender, EventArgs e)
        {
            foreach (TextBox input in nameGroupBox.Controls)
            {
                if(!InputFormatCheck(input.Text))
                    errorProvider.SetError(nameGroupBox,"AHTUNG!");
                else
                    errorProvider.SetError(nameGroupBox,"");

            }

        }

        public bool InputFormatCheck(string input)
        {
            Regex pattern = new Regex("^[a-zA-Zа-яА-ЯіІїЇєЄ][a-zA-Zа-яА-ЯіІїЇєЄ]+[a-zA-Zа-яА-ЯіІїЇєЄ]?$");
            Match check = pattern.Match(input);
            return check.Success;
        }

        private void midNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
