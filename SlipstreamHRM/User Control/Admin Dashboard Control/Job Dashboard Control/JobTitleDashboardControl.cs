using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.DAL;
using System.Data.SqlClient;
using SlipstreamHRM.Forms;

namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control.Job_Dashboard_Control
{
    public partial class JobTitleDashboardControl : UserControl
    {
        private static JobTitleDashboardControl _instance;

        public static JobTitleDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new JobTitleDashboardControl();
                return _instance;
            }
        }

        private SqlConnection Connection;
        private JobTitleInformation jobTitleInformation;
        private string jobTitleID;

        public JobTitleDashboardControl()
        {
            InitializeComponent();
        }

        public void dataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT JobTitle as 'Job Title', JobTitleDescription as 'Job Description' FROM JobTitleInformation", Connection);
                DataTable JobTitleInfoTable = new DataTable();
                Adapter.Fill(JobTitleInfoTable);
                jobTitleDataGridView.DataSource = JobTitleInfoTable;
                jobTitleDataGridView.Columns[0].Width = 205;
                jobTitleDataGridView.Columns[1].Width = 680;
                jobTitleDataGridView.BackgroundColor = Color.White;
                jobTitleDataGridView.BorderStyle = BorderStyle.Fixed3D;
                jobTitleDataGridView.Cursor = Cursors.Hand;

                // Set property values appropriate for read-only display and 
                // limited interactivity. 
                jobTitleDataGridView.AllowUserToAddRows = false;
                jobTitleDataGridView.AllowUserToDeleteRows = false;
                jobTitleDataGridView.AllowUserToOrderColumns = true;
                jobTitleDataGridView.ReadOnly = true;
                jobTitleDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                jobTitleDataGridView.MultiSelect = false;
                jobTitleDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                jobTitleDataGridView.AllowUserToResizeColumns = false;
                jobTitleDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                jobTitleDataGridView.AllowUserToResizeRows = false;
                jobTitleDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                // Set the selection background color for all the cells.
                jobTitleDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                jobTitleDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
                // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
                jobTitleDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                // Set the background color for all rows and for alternating rows. 
                // The value for alternating rows overrides the value for all rows. 
                jobTitleDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                jobTitleDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                // Set the row and column header styles.
                jobTitleDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                jobTitleDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                jobTitleDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Job Title Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        private void JobTitleDashboardControl_Load(object sender, EventArgs e)
        {
            jobTitleInformation = new JobTitleInformation();
            Connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\anik\Documents\anik.mdf;Integrated Security=True;Connect Timeout=30");
            dataShow();
        }

        private void AddTile_Click(object sender, EventArgs e)
        {
            using (JobTitleAddEditForm jobTitleAddEditForm = new JobTitleAddEditForm(null, null, null))
            {
                jobTitleAddEditForm.ShowDialog();
            }
            dataShow();
        }

        private void DeleteTile_Click(object sender, EventArgs e)
        {
            string jobTileName = jobTitleDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                if (jobTileName != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter = new SqlDataAdapter("DELETE FROM JobTitleInformation WHERE JobTitleID IN(SELECT JobTitleID FROM JobTitleInformation WHERE JobTitle = '" + jobTileName + "')", Connection);
                        Adapter.SelectCommand.ExecuteNonQuery();
                        //MessageBox.Show(this, "Data Successfully Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Job Title Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
            dataShow();
        }

        private void EditTile_Click(object sender, EventArgs e)
        {
            if (jobTitleDataGridView.Rows.Count != 0 && jobTitleDataGridView.Rows != null)
            {
                jobTitleInformation.JobTitleName = jobTitleDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                jobTitleInformation.JobTitleDescription = jobTitleDataGridView.SelectedRows[0].Cells[1].Value.ToString();

                if (!string.IsNullOrEmpty(jobTitleInformation.JobTitleName))
                {
                    try
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select JobTitleID From JobTitleInformation Where JobTitle ='{0}'", jobTitleInformation.JobTitleName), Connection);
                        DataTable JobTitleInfoTable = new DataTable();
                        Adapter.Fill(JobTitleInfoTable);

                        foreach (DataRow row in JobTitleInfoTable.Rows)
                        {
                            jobTitleID = Convert.ToString(row["JobTitleID"]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Job Title Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Connection.Close();
                    }
                    finally
                    {
                        Connection.Close();
                    }

                    using (JobTitleAddEditForm jobTitleAddEditForm = new JobTitleAddEditForm(jobTitleID, jobTitleInformation.JobTitleName,jobTitleInformation.JobTitleDescription))
                    {
                        jobTitleAddEditForm.ShowDialog();
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data dosen't selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            dataShow();
        }
    }
}
