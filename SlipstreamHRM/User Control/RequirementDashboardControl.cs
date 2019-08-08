using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control.Requirement_Dashboard_Control;

namespace SlipstreamHRM.User_Control
{
    public partial class RequirementDashboardControl : UserControl
    {
        private static RequirementDashboardControl _instance;

        public static RequirementDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RequirementDashboardControl();
                return _instance;
            }
        }

        public RequirementDashboardControl()
        {
            InitializeComponent();
        }

        private void CandidatesTile_Click(object sender, EventArgs e)
        {
            if (!requirementPanel.Controls.Contains(CandidatesDashboardControl.Instance))
            {
                requirementPanel.Controls.Add(CandidatesDashboardControl.Instance);
                CandidatesDashboardControl.Instance.Dock = DockStyle.Fill;
                CandidatesDashboardControl.Instance.BringToFront();
            }
            else
                CandidatesDashboardControl.Instance.BringToFront();
        }

        private void VacanciesTile_Click(object sender, EventArgs e)
        {
            if (!requirementPanel.Controls.Contains(VacanciesDashboardControl.Instance))
            {
                requirementPanel.Controls.Add(VacanciesDashboardControl.Instance);
                VacanciesDashboardControl.Instance.Dock = DockStyle.Fill;
                VacanciesDashboardControl.Instance.BringToFront();
            }
            else
                VacanciesDashboardControl.Instance.BringToFront();
        }

        private void DisiplineCasesTile_Click(object sender, EventArgs e)
        {
            if (!requirementPanel.Controls.Contains(DisciplineCasesDashboardControl.Instance))
            {
                requirementPanel.Controls.Add(DisciplineCasesDashboardControl.Instance);
                DisciplineCasesDashboardControl.Instance.Dock = DockStyle.Fill;
                DisciplineCasesDashboardControl.Instance.BringToFront();
            }
            else
                DisciplineCasesDashboardControl.Instance.BringToFront();
        }
    }
}
