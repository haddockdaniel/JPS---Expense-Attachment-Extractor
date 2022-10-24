using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JurisUtilityBase
{
    public partial class MatLookUp : Form
    {
        public MatLookUp(JurisUtility jutil, System.Drawing.Point ppt)
        {
            InitializeComponent();
            _jurisUtility = jutil;
            pt = ppt;
        }

        JurisUtility _jurisUtility;
        private System.Drawing.Point pt;
        public bool clientSelected = false;
        public int clisysnbr = 0;
        public string clicode = "";
        public int matsysnbr = 0;
        public bool matterSelected = false;
        public string matcode = "";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = "select clisysnbr, dbo.jfn_FormatClientCode(clicode) as clicode, clireportingname from client where clireportingname like '%" + textBoxClient.Text + "%'";
            DataSet ds = _jurisUtility.RecordsetFromSQL(sql);

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Width = 1;
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[2].Width = 250;
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            if (dataGridView1.SelectedRows.Count == 0 || dataGridView1.SelectedRows.Count > 1)
                MessageBox.Show("Please select one client to proceed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int index = e.RowIndex;
                dataGridView1.Rows[index].Selected = true;
                //clisysnbr = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                //clicode = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                clisysnbr = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                clicode = dataGridView1.Rows[index].Cells[1].Value.ToString();
                clientSelected = true;
            }
        }

        private void buttonCreateClient_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            if (!clientSelected)
                MessageBox.Show("Please select one client to proceed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //client chosen, now show matters
                string sql = "select matsysnbr, dbo.jfn_FormatMatterCode(matcode) as matcode, matreportingname from matter inner join client on clisysnbr = matclinbr where clisysnbr = " + clisysnbr.ToString();
                DataSet ds = _jurisUtility.RecordsetFromSQL(sql);

                dataGridView2.DataSource = ds.Tables[0];
                dataGridView2.Columns[0].Width = 1;
                dataGridView2.Columns[1].Width = 50;
                dataGridView2.Columns[2].Width = 250;
                this.dataGridView2.Columns[0].Visible = false;

                //this.Hide();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            if (dataGridView1.SelectedRows.Count == 0 || dataGridView1.SelectedRows.Count > 1)
                MessageBox.Show("Please select one client to proceed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int index = e.RowIndex;
                dataGridView1.Rows[index].Selected = true;
                clisysnbr = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                clicode = dataGridView1.Rows[index].Cells[1].Value.ToString();
                clientSelected = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            if (dataGridView1.SelectedRows.Count == 0 || dataGridView1.SelectedRows.Count > 1)
                MessageBox.Show("Please select one client to proceed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int index = e.RowIndex;
                dataGridView1.Rows[index].Selected = true;
                clisysnbr = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                clicode = dataGridView1.Rows[index].Cells[1].Value.ToString();
                clientSelected = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!matterSelected)
                MessageBox.Show("Please select one matter to proceed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.Hide();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            if (dataGridView2.SelectedRows.Count == 0 || dataGridView2.SelectedRows.Count > 1)
                MessageBox.Show("Please select one matter to proceed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int index = e.RowIndex;
                dataGridView2.Rows[index].Selected = true;
                matcode = dataGridView1.Rows[index].Cells[1].Value.ToString();
                matsysnbr = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value);
                matterSelected = true;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            if (dataGridView2.SelectedRows.Count == 0 || dataGridView2.SelectedRows.Count > 1)
                MessageBox.Show("Please select one matter to proceed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int index = e.RowIndex;
                dataGridView2.Rows[index].Selected = true;
                matcode = dataGridView1.Rows[index].Cells[1].Value.ToString();
                matsysnbr = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value);
                //matcode = dataGridView1.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value.ToString();
                // matsysnbr = Convert.ToInt32(dataGridView2.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                matterSelected = true;
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            if (dataGridView2.SelectedRows.Count == 0 || dataGridView2.SelectedRows.Count > 1)
                MessageBox.Show("Please select one matter to proceed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int index = e.RowIndex;
                dataGridView2.Rows[index].Selected = true;
                matcode = dataGridView1.Rows[index].Cells[1].Value.ToString();
                matsysnbr = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value);
                //matcode = dataGridView1.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value.ToString();
                //matsysnbr = Convert.ToInt32(dataGridView2.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                matterSelected = true;
            }
        }
    }
}
