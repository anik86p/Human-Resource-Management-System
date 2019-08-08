using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control.Admin_Dashboard_Control;

namespace SlipstreamHRM.User_Control
{
    public partial class AdminDashboardControl : UserControl
    {
        private static AdminDashboardControl _instance;

        public static AdminDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminDashboardControl();
                return _instance;
            }
        }

        public AdminDashboardControl()
        {
            InitializeComponent();
        }

        private void UserManagementTile_Click(object sender, EventArgs e)
        {
            if (!adminPanel.Controls.Contains(UserDashboardControl.Instance))
            {
                adminPanel.Controls.Add(UserDashboardControl.Instance);
                UserDashboardControl.Instance.Dock = DockStyle.Fill;
                UserDashboardControl.Instance.BringToFront();
            }
            else
                UserDashboardControl.Instance.BringToFront();
        }

        private void JobTile_Click(object sender, EventArgs e)
        {
            if (!adminPanel.Controls.Contains(JobDashboardControl.Instance))
            {
                adminPanel.Controls.Add(JobDashboardControl.Instance);
                JobDashboardControl.Instance.Dock = DockStyle.Fill;
                JobDashboardControl.Instance.BringToFront();
            }
            else
                JobDashboardControl.Instance.BringToFront();
        }

        private void OrganizationTile_Click(object sender, EventArgs e)
        {
            if (!adminPanel.Controls.Contains(OrganizationDashboardControl.Instance))
            {
                adminPanel.Controls.Add(OrganizationDashboardControl.Instance);
                OrganizationDashboardControl.Instance.Dock = DockStyle.Fill;
                OrganizationDashboardControl.Instance.BringToFront();
            }
            else
                OrganizationDashboardControl.Instance.BringToFront();
        }

        private void QualificationTile_Click(object sender, EventArgs e)
        {
            if (!adminPanel.Controls.Contains(QualificationDashboardControl.Instance))
            {
                adminPanel.Controls.Add(QualificationDashboardControl.Instance);
                QualificationDashboardControl.Instance.Dock = DockStyle.Fill;
                QualificationDashboardControl.Instance.BringToFront();
            }
            else
                QualificationDashboardControl.Instance.BringToFront();
        }

        private void NationalitiesTile_Click(object sender, EventArgs e)
        {
            if (!adminPanel.Controls.Contains(NationalitiesDashboardControl.Instance))
            {
                adminPanel.Controls.Add(NationalitiesDashboardControl.Instance);
                NationalitiesDashboardControl.Instance.Dock = DockStyle.Fill;
                NationalitiesDashboardControl.Instance.BringToFront();
            }
            else
                NationalitiesDashboardControl.Instance.BringToFront();
        }
    }
}
