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
    public partial class AssignLeaveDashboardControl : UserControl
    {
        private static AssignLeaveDashboardControl _instance;

        public static AssignLeaveDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AssignLeaveDashboardControl();
                return _instance;
            }
        }

        public AssignLeaveDashboardControl()
        {
            InitializeComponent();
        }
    }
}
