using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control.Qualification_Dashboard_Control
{
    public partial class EducationDashboardControl : UserControl
    {
        private static EducationDashboardControl _instance;

        public static EducationDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EducationDashboardControl();
                return _instance;
            }
        }


        public EducationDashboardControl()
        {
            InitializeComponent();
        }
    }
}
