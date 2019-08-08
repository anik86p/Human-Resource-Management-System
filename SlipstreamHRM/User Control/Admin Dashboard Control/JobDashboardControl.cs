using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control.Admin_Dashboard_Control.Job_Dashboard_Control;

namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control
{
    public partial class JobDashboardControl : UserControl
    {
        private static JobDashboardControl _instance;

        public static JobDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new JobDashboardControl();
                return _instance;
            }
        }

        public JobDashboardControl()
        {
            InitializeComponent();
        }

        private void JobDashboardControl_Load(object sender, EventArgs e)
        {
            jobTitelDashboardLoad();
            employmentStatusDashboardLoad();
            jobCategoriesDashboardLoad();
            workShiftDashboardLoad();
        }

        public void jobTitelDashboardLoad()
        {
            if (!jobTabPage1.Controls.Contains(JobTitleDashboardControl.Instance))
            {
                jobTabPage1.Controls.Add(JobTitleDashboardControl.Instance);
                JobTitleDashboardControl.Instance.Dock = DockStyle.Fill;
                JobTitleDashboardControl.Instance.BringToFront();
            }
            else
                JobTitleDashboardControl.Instance.BringToFront();
        }

        public void employmentStatusDashboardLoad()
        {
            if (!jobTabPage2.Controls.Contains(EmploymentStatusDashboardControl.Instance))
            {
                jobTabPage2.Controls.Add(EmploymentStatusDashboardControl.Instance);
                EmploymentStatusDashboardControl.Instance.Dock = DockStyle.Fill;
                EmploymentStatusDashboardControl.Instance.BringToFront();
            }
            else
                EmploymentStatusDashboardControl.Instance.BringToFront();
        }

        public void jobCategoriesDashboardLoad()
        {
            if (!jobTabPage3.Controls.Contains(JobCategoriesDashboardControl.Instance))
            {
                jobTabPage3.Controls.Add(JobCategoriesDashboardControl.Instance);
                JobCategoriesDashboardControl.Instance.Dock = DockStyle.Fill;
                JobCategoriesDashboardControl.Instance.BringToFront();
            }
            else
                JobCategoriesDashboardControl.Instance.BringToFront();
        }

        public void workShiftDashboardLoad()
        {
            if (!jobTabPage4.Controls.Contains(WorkShiftDashboardControl.Instance))
            {
                jobTabPage4.Controls.Add(WorkShiftDashboardControl.Instance);
                WorkShiftDashboardControl.Instance.Dock = DockStyle.Fill;
                WorkShiftDashboardControl.Instance.BringToFront();
            }
            else
                WorkShiftDashboardControl.Instance.BringToFront();
        }
    }
}
