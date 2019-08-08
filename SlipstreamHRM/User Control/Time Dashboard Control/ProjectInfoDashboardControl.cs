using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.Forms.Time;

namespace SlipstreamHRM.User_Control.Time_Dashboard_Control
{
    public partial class ProjectInfoDashboardControl : UserControl
    {
        private static ProjectInfoDashboardControl _instance;

        public static ProjectInfoDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProjectInfoDashboardControl();
                return _instance;
            }
        }

        public ProjectInfoDashboardControl()
        {
            InitializeComponent();
        }

        private void Clich_ADD_Customer(object sender, EventArgs e)
        {
            ADD_Project xx = new ADD_Project();
            xx.Show();
        }

        private void Click_Add_project(object sender, EventArgs e)
        {
            Customer_ADD cc = new Customer_ADD();
            cc.Show();
        }
    }
}
