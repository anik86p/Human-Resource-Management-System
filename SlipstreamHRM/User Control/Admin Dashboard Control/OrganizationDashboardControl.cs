using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control.Admin_Dashboard_Control.Organization_Dashboard_Control;

namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control
{
    public partial class OrganizationDashboardControl : UserControl
    {
        private static OrganizationDashboardControl _instance;

        public static OrganizationDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new OrganizationDashboardControl();
                return _instance;
            }
        }

        public OrganizationDashboardControl()
        {
            InitializeComponent();
        }

        private void OrganizationDashboardControl_Load(object sender, EventArgs e)
        {
            generalInformationDashboardShow();
        }

        public void generalInformationDashboardShow()
        {
            if (!organizationTabPage1.Controls.Contains(GeneralInformationDashboardControl.Instance))
            {
                organizationTabPage1.Controls.Add(GeneralInformationDashboardControl.Instance);
                GeneralInformationDashboardControl.Instance.Dock = DockStyle.Fill;
                GeneralInformationDashboardControl.Instance.BringToFront();
            }
            else
                GeneralInformationDashboardControl.Instance.BringToFront();
        }
    }
}
