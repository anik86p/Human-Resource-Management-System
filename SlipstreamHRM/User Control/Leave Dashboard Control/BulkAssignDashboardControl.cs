using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlipstreamHRM.User_Control.Leave_Dashboard_Control
{
    public partial class BulkAssignDashboardControl : UserControl
    {
        private static BulkAssignDashboardControl _instance;

        public static BulkAssignDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BulkAssignDashboardControl();
                return _instance;
            }
        }

        public BulkAssignDashboardControl()
        {
            InitializeComponent();
        }

        private void bulkAssignPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LeaveListLink_Click(object sender, EventArgs e)
        {

        }

        private void leaveListPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
