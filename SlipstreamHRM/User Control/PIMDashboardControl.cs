using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control.PIM_Dashboard_Control;

namespace SlipstreamHRM.User_Control
{
    public partial class PIMDashboardControl : UserControl
    {
        private static PIMDashboardControl _instance;

        public static PIMDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PIMDashboardControl();
                return _instance;
            }
        }

        public PIMDashboardControl()
        {
            InitializeComponent();
        }

        private void EmployeeListTile_Click(object sender, EventArgs e)
        {
            if (!PIMPanel.Controls.Contains(EmployeeListDashboardControl.Instance))
            {
                PIMPanel.Controls.Add(EmployeeListDashboardControl.Instance);
                EmployeeListDashboardControl.Instance.Dock = DockStyle.Fill;
                EmployeeListDashboardControl.Instance.BringToFront();
            }
            else
                EmployeeListDashboardControl.Instance.BringToFront();
        }

        private void AddEmployeeTile_Click(object sender, EventArgs e)
        {
            if (!PIMPanel.Controls.Contains(AddEmployeeDashboardControl.Instance))
            {
                PIMPanel.Controls.Add(AddEmployeeDashboardControl.Instance);
                AddEmployeeDashboardControl.Instance.Dock = DockStyle.Fill;
                AddEmployeeDashboardControl.Instance.BringToFront();
            }
            else
                AddEmployeeDashboardControl.Instance.BringToFront();
        }

        private void BulkUpdateTile_Click(object sender, EventArgs e)
        {
            if (!PIMPanel.Controls.Contains(BulkUpdateDashboardControl.Instance))
            {
                PIMPanel.Controls.Add(BulkUpdateDashboardControl.Instance);
                BulkUpdateDashboardControl.Instance.Dock = DockStyle.Fill;
                BulkUpdateDashboardControl.Instance.BringToFront();
            }
            else
                BulkUpdateDashboardControl.Instance.BringToFront();
        }
    }
}
