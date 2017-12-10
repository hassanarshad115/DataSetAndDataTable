using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSetAndDataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DataTable dtEmployee;
        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet dsoffice = new DataSet("DataBaseKaName");

            dtEmployee = new DataTable("TableKaName");
            dtEmployee.Columns.Add("ID");
            dtEmployee.Columns.Add("Name");

            dtEmployee.Rows.Add(1, "hassan");
            dtEmployee.Rows.Add(2, "ali");
            dtEmployee.Rows.Add(3, "rizwan");

            dsoffice.Tables.Add(dtEmployee);

            dataGridView1.DataSource = dsoffice.Tables["TableKaName"];
            //dataGridView1.DataSource = dtEmployee;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtEmployee.DefaultView;

            dv.RowFilter ="Name Like '%" + textBox1.Text.Trim() + "%' ";
        }
    }
}
