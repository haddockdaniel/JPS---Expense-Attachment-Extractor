using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Globalization;
using Gizmox.Controls;
using JDataEngine;
using JurisAuthenticator;
using JurisUtilityBase.Properties;
using System.Data.OleDb;
using System.Reflection;

namespace JurisUtilityBase
{
    public partial class UtilityBaseMain : Form
    {
        #region Private  members

        private JurisUtility _jurisUtility;

        #endregion

        #region Public properties

        public string CompanyCode { get; set; }

        public string JurisDbName { get; set; }

        public string JBillsDbName { get; set; }

        private int clisysnbr = 0;

        private int matsysnbr = 0;

        private System.Drawing.Point pt;

        private string clicode = "";

        private string matcode = "";

        public string path = "";

        private int option = 5; 
        //which radio button did they select?
        //1 by inv num, 2 by inv date, 3 by mat, 4 by cli, 5 all (default)
        //we use it later is simplify all the validation and execution if/else statements into a simple case

        #endregion

        #region Constructor

        public UtilityBaseMain()
        {
            InitializeComponent();
            _jurisUtility = new JurisUtility();
        }

        #endregion

        #region Public methods

        public void LoadCompanies()
        {
            var companies = _jurisUtility.Companies.Cast<object>().Cast<Instance>().ToList();
//            listBoxCompanies.SelectedIndexChanged -= listBoxCompanies_SelectedIndexChanged;
            listBoxCompanies.ValueMember = "Code";
            listBoxCompanies.DisplayMember = "Key";
            listBoxCompanies.DataSource = companies;
//            listBoxCompanies.SelectedIndexChanged += listBoxCompanies_SelectedIndexChanged;
            var defaultCompany = companies.FirstOrDefault(c => c.Default == Instance.JurisDefaultCompany.jdcJuris);
            if (companies.Count > 0)
            {
                listBoxCompanies.SelectedItem = defaultCompany ?? companies[0];
            }
        }

        #endregion

        #region MainForm events

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void listBoxCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_jurisUtility.DbOpen)
            {
                _jurisUtility.CloseDatabase();
            }
            CompanyCode = "Company" + listBoxCompanies.SelectedValue;
            _jurisUtility.SetInstance(CompanyCode);
            JurisDbName = _jurisUtility.Company.DatabaseName;
            JBillsDbName = "JBills" + _jurisUtility.Company.Code;
            _jurisUtility.OpenDatabase();
            if (_jurisUtility.DbOpen)
            {
                ///GetFieldLengths();
            }

        }



        #endregion

        #region Private methods

        private void DoDaFix()
        {
            string message = "This will print all attachment expenses into the folder " + path + ". Any files with duplicate names will be incremented by 1 so printing can complete. Continue?";
            DialogResult dr = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                List<string> errors = printAttachments().ToList();
                if (errors.Count == 0)
                    MessageBox.Show("The process completed without error", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                else
                {
                    DialogResult dr1 = MessageBox.Show("The process completed but encountered some issues. Would you like to view the error log?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr1 == DialogResult.Yes)
                    {
                        DataSet ds = errors.ConvertToDataSet("TestTable");
                        ReportDisplay rd = new ReportDisplay(ds);
                        


                    }



                }


            }
            System.Environment.Exit(0);
        }
        private bool VerifyFirmName()
        {
            //    Dim SQL     As String
            //    Dim rsDB    As ADODB.Recordset
            //
            //    SQL = "SELECT CASE WHEN SpTxtValue LIKE '%firm name%' THEN 'Y' ELSE 'N' END AS Firm FROM SysParam WHERE SpName = 'FirmName'"
            //    Cmd.CommandText = SQL
            //    Set rsDB = Cmd.Execute
            //
            //    If rsDB!Firm = "Y" Then
            return true;
            //    Else
            //        VerifyFirmName = False
            //    End If

        }

        private bool FieldExistsInRS(DataSet ds, string fieldName)
        {

            foreach (DataColumn column in ds.Tables[0].Columns)
            {
                if (column.ColumnName.Equals(fieldName, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }


        private static bool IsDate(String date)
        {
            try
            {
                DateTime dt = DateTime.Parse(date);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static bool IsNumeric(object Expression)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum; 
        }

        private void WriteLog(string comment)
        {
            var sql =
                string.Format("Insert Into UtilityLog(ULTimeStamp,ULWkStaUser,ULComment) Values('{0}','{1}', '{2}')",
                    DateTime.Now, GetComputerAndUser(), comment);
            _jurisUtility.ExecuteNonQueryCommand(0, sql);
        }

        private string GetComputerAndUser()
        {
            var computerName = Environment.MachineName;
            var windowsIdentity = System.Security.Principal.WindowsIdentity.GetCurrent();
            var userName = (windowsIdentity != null) ? windowsIdentity.Name : "Unknown";
            return computerName + "/" + userName;
        }

        /// <summary>
        /// Update status bar (text to display and step number of total completed)
        /// </summary>
        /// <param name="status">status text to display</param>
        /// <param name="step">steps completed</param>
        /// <param name="steps">total steps to be done</param>


        private void DeleteLog()
        {
            string AppDir = Path.GetDirectoryName(Application.ExecutablePath);
            string filePathName = Path.Combine(AppDir, "VoucherImportLog.txt");
            if (File.Exists(filePathName + ".ark5"))
            {
                File.Delete(filePathName + ".ark5");
            }
            if (File.Exists(filePathName + ".ark4"))
            {
                File.Copy(filePathName + ".ark4", filePathName + ".ark5");
                File.Delete(filePathName + ".ark4");
            }
            if (File.Exists(filePathName + ".ark3"))
            {
                File.Copy(filePathName + ".ark3", filePathName + ".ark4");
                File.Delete(filePathName + ".ark3");
            }
            if (File.Exists(filePathName + ".ark2"))
            {
                File.Copy(filePathName + ".ark2", filePathName + ".ark3");
                File.Delete(filePathName + ".ark2");
            }
            if (File.Exists(filePathName + ".ark1"))
            {
                File.Copy(filePathName + ".ark1", filePathName + ".ark2");
                File.Delete(filePathName + ".ark1");
            }
            if (File.Exists(filePathName ))
            {
                File.Copy(filePathName, filePathName + ".ark1");
                File.Delete(filePathName);
            }

        }

            

        private void LogFile(string LogLine)
        {
            string AppDir = Path.GetDirectoryName(Application.ExecutablePath);
            string filePathName = Path.Combine(AppDir, "VoucherImportLog.txt");
            using (StreamWriter sw = File.AppendText(filePathName))
            {
                sw.WriteLine(LogLine);
            }	
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            DoDaFix();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {

            System.Environment.Exit(0);
          
        }


        private List<string> printAttachments()
        {
            List<string> errors = new List<string>();
            List<ExpAttachment> exps = new List<ExpAttachment>();
            string file = "";
            try
            {
                string sql2 = "  select name, attachmentobject, bebillnbr, dbo.jfn_FormatCientCode(clicode) as clicode, dbo.jfn_FormatMatterCode(matcode) as matcode from Attachment aa " +
                  "  inner join ExpenseEntryAttachment ea on ea.AttachmentID = aa.id " +
                  "  inner join expenseEntry ee on ee.entryid = ea.EntryID " +
                  "  INNER JOIN  ExpenseEntryLink el ON ee.EntryID = el.EntryID " +
                  "  INNER JOIN BilledExpenses be ON el.EBDID = be.beid " +
                  " inner join matter on bematter = matsysnbr " +
                  " inner join client on clisysnbr = matclinbr " +
                  "  where AttachmentType = 0";
                DataSet fs = _jurisUtility.RecordsetFromSQL(sql2);


                foreach (DataRow dr in fs.Tables[0].Rows)
                {

                    ExpAttachment expattach = new ExpAttachment();
                    expattach.fileName = dr["name"].ToString();
                    expattach.fileData = (byte[])dr["attachmentobject"];
                    expattach.billNo = Convert.ToInt32(dr["bebillnbr"].ToString());
                    expattach.clicode = dr["clicode"].ToString();
                    expattach.matcode = dr["matcode"].ToString();
                    exps.Add(expattach);
                }
            }
            catch (Exception juris)
            {
                errors.Add("There was an error connecting to the Juris database. Details: " + juris.Message);
            }
            //need to find an easy way for dynamic pathing
            if (!checkBoxAdv.Checked) //use defaults
            {
                foreach(ExpAttachment ee in exps)
                {
                    try
                    {
                        file = labelPath.Text;
                        file = file + @"/" + ee.fileName;
                        int count = 1;

                        string fileNameOnly = Path.GetFileNameWithoutExtension(file);
                        string extension = Path.GetExtension(file);
                        string path = Path.GetDirectoryName(file);
                        string newFullPath = file;

                        while (File.Exists(newFullPath))
                        {
                            string tempFileName = string.Format("{0}({1})", fileNameOnly, count++);
                            newFullPath = Path.Combine(path, tempFileName + extension);
                        }
                        File.WriteAllBytes(newFullPath, ee.fileData);
                    }
                    catch (Exception attach)
                    {
                        errors.Add("Client: " + ee.clicode + ", Matter: " + ee.matcode + ", Invoice: " + ee.billNo.ToString() + ", File: " + ee.fileName + " cannot be printed because: " + attach.Message);
                    }
                }

            }

            return errors;
        }

        private void radioButtonNum_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNum.Checked)
            {
                textBoxBillDateFrom.Visible = false;
                textBoxBillDateTo.Visible = false;
                textBoxBillNoFrom.Visible = true;
                textBoxBillNoTo.Visible = true;
                labelBillDate.Visible = false;
                labelBillNo.Visible = true;
                option = 1;
            }
        }

        private void radioButtonDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDate.Checked)
            {
                textBoxBillDateFrom.Visible = true;
                textBoxBillDateTo.Visible = true;
                textBoxBillNoFrom.Visible = false;
                textBoxBillNoTo.Visible = false;
                labelBillDate.Visible = true;
                labelBillNo.Visible = false;
                option = 2;
            }
        }

        private void radioButtonMat_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonDate.Checked && !radioButtonNum.Checked)
            {
                textBoxBillDateFrom.Visible = false;
                textBoxBillDateTo.Visible = false;
                textBoxBillNoFrom.Visible = false;
                textBoxBillNoTo.Visible = false;
                labelBillDate.Visible = false;
                labelBillNo.Visible = false;
            }
            if (radioButtonMat.Checked)
            {
                option = 3;
                this.Location = pt;
                this.Hide();
                MatLookUp cl = new MatLookUp(_jurisUtility, pt);
                cl.ShowDialog();
                if (cl.clientSelected && cl.matterSelected)
                {
                    clisysnbr = cl.clisysnbr;
                    matsysnbr = cl.matsysnbr;
                    clicode = cl.clicode;
                    matcode = cl.matcode;
                }
                cl.Close();
                this.Show();
            }
        }

        private void radioButtonCli_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonDate.Checked && !radioButtonNum.Checked)
            {
                textBoxBillDateFrom.Visible = false;
                textBoxBillDateTo.Visible = false;
                textBoxBillNoFrom.Visible = false;
                textBoxBillNoTo.Visible = false;
                labelBillDate.Visible = false;
                labelBillNo.Visible = false;

            }
            if (radioButtonCli.Checked)
            {
                option = 4;
                this.Location = pt;
                this.Hide();
                ClientLookUp cl = new ClientLookUp(_jurisUtility, pt);
                cl.ShowDialog();
                if (cl.clientSelected)
                {
                    clisysnbr = cl.clisysnbr;
                }
                cl.Close();
                this.Show();
            }
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonDate.Checked && !radioButtonNum.Checked)
            {
                textBoxBillDateFrom.Visible = false;
                textBoxBillDateTo.Visible = false;
                textBoxBillNoFrom.Visible = false;
                textBoxBillNoTo.Visible = false;
                labelBillDate.Visible = false;
                labelBillNo.Visible = false;

            }
            if (radioButtonAll.Checked)
                option = 5;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
                labelPath.Text = path;
            }
        }

        private void checkBoxAdv_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = checkBoxAdv.Checked;
            groupBox3.Visible = checkBoxAdv.Checked;
        }


    }
}
