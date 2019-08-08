using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlipstreamHRM.User_Control.Time_Dashboard_Control
{
    public partial class ReportDashboardControl : UserControl
    {
        private static ReportDashboardControl _instance;

        public static ReportDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ReportDashboardControl();
                return _instance;
            }
        }

        public ReportDashboardControl()
        {
            InitializeComponent();
        }
    }
}
