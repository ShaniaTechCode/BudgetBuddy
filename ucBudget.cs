using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BudgetBuddy;

namespace BudgetBuddy
{
    public partial class ucBudget : UserControl
    {
        private Conecction conecction;
        public ucBudget()
        {
            
            InitializeComponent();
            conecction = new Conecction();
        }

        private void btnSaveBudget_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Occurs when the control is loaded.
        /// </summary>
        /// <param name="sender">The source o
        private void ucBudget_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = conecction.GetSqlConnection();
            string query = "SELECT BudgetName, Period, DateCreated FROM BudgetTable";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvBudgetList.DataSource = dataTable;
        }
    }
}