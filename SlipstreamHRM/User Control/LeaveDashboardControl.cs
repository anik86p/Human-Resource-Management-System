using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control.Leave_Dashboard_Control;

namespace SlipstreamHRM.User_Control
{
    public partial class LeaveDashboardControl : UserControl
    {
        private static LeaveDashboardControl _instance;

        public static LeaveDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LeaveDashboardControl();
                return _instance;
            }
        }

        public LeaveDashboardControl()
        {
            InitializeComponent();
        }

        private void EntitelmentsTile_Click(object sender, EventArgs e)
        {
            if (!leavePanel.Controls.Contains(EntitelmentsDashboardControl.Instance))
            {
                leavePanel.Controls.Add(EntitelmentsDashboardControl.Instance);
                EntitelmentsDashboardControl.Instance.Dock = DockStyle.Fill;
                EntitelmentsDashboardControl.Instance.BringToFront();
            }
            else
                EntitelmentsDashboardControl.Instance.BringToFront();
        }

        private void LeaveAssignTile_Click(object sender, EventArgs e)
        {
            if (!leavePanel.Controls.Contains(AssignLeaveDashboardControl.Instance))
            {
                leavePanel.Controls.Add(AssignLeaveDashboardControl.Instance);
                AssignLeaveDashboardControl.Instance.Dock = DockStyle.Fill;
                AssignLeaveDashboardControl.Instance.BringToFront();
            }
            else
                AssignLeaveDashboardControl.Instance.BringToFront();
        }

        private void LeaveListTile_Click(object sender, EventArgs e)
        {
            if (!leavePanel.Controls.Contains(LeaveListDashboardControl.Instance))
            {
                leavePanel.Controls.Add(LeaveListDashboardControl.Instance);
                LeaveListDashboardControl.Instance.Dock = DockStyle.Fill;
                LeaveListDashboardControl.Instance.BringToFront();
            }
            else
                LeaveListDashboardControl.Instance.BringToFront();
        }

        private void BulkAssignTile_Click(object sender, EventArgs e)
        {
            if (!leavePanel.Controls.Contains(BulkAssignDashboardControl.Instance))
            {
                leavePanel.Controls.Add(BulkAssignDashboardControl.Instance);
                BulkAssignDashboardControl.Instance.Dock = DockStyle.Fill;
                BulkAssignDashboardControl.Instance.BringToFront();
            }
            else
                BulkAssignDashboardControl.Instance.BringToFront();
        }
    }
}
