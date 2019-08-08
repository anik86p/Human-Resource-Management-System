using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SlipstreamHRM.User_Control.PIM_Dashboard_Control
{
    public partial class BulkUpdateDashboardControl : UserControl
    {
        private static BulkUpdateDashboardControl _instance;

        public static BulkUpdateDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BulkUpdateDashboardControl();
                return _instance;
            }
        }

        public BulkUpdateDashboardControl()
        {
            InitializeComponent();
        }
    }
}
