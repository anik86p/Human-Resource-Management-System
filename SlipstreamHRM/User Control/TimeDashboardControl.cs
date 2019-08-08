using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control.Time_Dashboard_Control;


namespace SlipstreamHRM.User_Control
{
    public partial class TimeDashboardControl : UserControl
    {
        private static TimeDashboardControl _instance;

        public static TimeDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TimeDashboardControl();
                return _instance;
            }
        }

        public TimeDashboardControl()
        {
            InitializeComponent();
        }

        private void ReportTile_Click(object sender, EventArgs e)
        {
            if (!timePanel.Controls.Contains(ReportDashboardControl.Instance))
            {
                timePanel.Controls.Add(ReportDashboardControl.Instance);
                ReportDashboardControl.Instance.Dock = DockStyle.Fill;
                ReportDashboardControl.Instance.BringToFront();
            }
            else
                ReportDashboardControl.Instance.BringToFront();
        }

        private void ProjectInfoTile_Click(object sender, EventArgs e)
        {
            if (!timePanel.Controls.Contains(ProjectInfoDashboardControl.Instance))
            {
                timePanel.Controls.Add(ProjectInfoDashboardControl.Instance);
                ProjectInfoDashboardControl.Instance.Dock = DockStyle.Fill;
                ProjectInfoDashboardControl.Instance.BringToFront();
            }
            else
                ProjectInfoDashboardControl.Instance.BringToFront();
        }
    }
}
