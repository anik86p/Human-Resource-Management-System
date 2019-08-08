using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlipstreamHRM.User_Control.Requirement_Dashboard_Control
{
    public partial class CandidatesDashboardControl : UserControl
    {
        private static CandidatesDashboardControl _instance;

        public static CandidatesDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CandidatesDashboardControl();
                return _instance;
            }
        }

        public CandidatesDashboardControl()
        {
            InitializeComponent();
        }
    }
}
