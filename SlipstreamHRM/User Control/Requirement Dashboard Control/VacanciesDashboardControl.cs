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
    public partial class VacanciesDashboardControl : UserControl
    {
        private static VacanciesDashboardControl _instance;

        public static VacanciesDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new VacanciesDashboardControl();
                return _instance;
            }
        }

        public VacanciesDashboardControl()
        {
            InitializeComponent();
        }
    }
}
