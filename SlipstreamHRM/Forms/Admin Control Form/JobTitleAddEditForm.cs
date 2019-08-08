using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SlipstreamHRM.DAL;

namespace SlipstreamHRM.Forms
{
    public partial class JobTitleAddEditForm : MaterialSkin.Controls.MaterialForm
    {
        private SqlConnection Connection;
        private JobTitleInformation jobTileInformation;
        private string JobTitleID;

        public JobTitleAddEditForm(string jobTileID, string jobTitel, string jobTitelDescription)
        {
            InitializeComponent();
            this.Text = "Add Job Title";
            this.JobTitleID = jobTileID;
            if (!string.IsNullOrEmpty(JobTitleID))
            {
                this.Text = "Edit Job Title";
                txtJobTile.Text = jobTitel;
                txtJobDescription.Text = jobTitelDescription;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int _jobTtleID = Convert.ToInt32(JobTitleID);
            jobTileInformation.JobTitleName = txtJobTile.Text;
            jobTileInformation.JobTitleDescription = txtJobDescription.Text;

            if (string.IsNullOrEmpty(JobTitleID))
            {
                try
                {
                    if (!string.IsNullOrEmpty(jobTileInformation.JobTitleName))
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter = new SqlDataAdapter("INSERT INTO JobTitleInformation (JobTitle, JobTitleDescription) VALUES ('" + jobTileInformation.JobTitleName + "', '"+jobTileInformation.JobTitleDescription+"')", Connection);
                        Adapter.SelectCommand.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "Data Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Input Job Tile", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Job Title Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.Close();
                }
                finally
                {
                    Connection.Close();
                    this.Close();
                }
            }

            else
            {
                try
                {
                    if (!string.IsNullOrEmpty(jobTileInformation.JobTitleName))
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("UPDATE JobTitleInformation SET JobTitle = '{0}', JobTitleDescription = '{1}' WHERE JobTitleID = '{2}'", jobTileInformation.JobTitleName, jobTileInformation.JobTitleDescription, _jobTtleID), Connection);
                        Adapter.SelectCommand.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "Data Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Input Job Tile", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Job Title Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.Close();
                }
                finally
                {
                    Connection.Close();
                    this.Close();
                }
            }
        }

        private void JobTitleAddEditForm_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\anik\Documents\anik.mdf;Integrated Security=True;Connect Timeout=30");
            jobTileInformation = new JobTitleInformation();
        }
    }
}
