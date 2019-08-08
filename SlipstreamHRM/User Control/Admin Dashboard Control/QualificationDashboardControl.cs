using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control.Admin_Dashboard_Control.Qualification_Dashboard_Control;

namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control
{
    public partial class QualificationDashboardControl : UserControl
    {
        private static QualificationDashboardControl _instance;

        public static QualificationDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QualificationDashboardControl();
                return _instance;
            }
        }

        public QualificationDashboardControl()
        {
            InitializeComponent();
            skillInformationDashboardShow();
            languageInformationDashboardShow();
            educationInformationDashboardShow();
        }

        public void skillInformationDashboardShow()
        {
            if (!QualificationTabPage1.Controls.Contains(SkillDashboardControl.Instance))
            {
                QualificationTabPage1.Controls.Add(SkillDashboardControl.Instance);
                SkillDashboardControl.Instance.Dock = DockStyle.Fill;
                SkillDashboardControl.Instance.BringToFront();
            }
            else
                SkillDashboardControl.Instance.BringToFront();
        }

        public void languageInformationDashboardShow()
        {
            if (!QualificationTabPage2.Controls.Contains(LanguageDashboardControl.Instance))
            {
                QualificationTabPage2.Controls.Add(LanguageDashboardControl.Instance);
                LanguageDashboardControl.Instance.Dock = DockStyle.Fill;
                LanguageDashboardControl.Instance.BringToFront();
            }
            else
                LanguageDashboardControl.Instance.BringToFront();
        }

        public void educationInformationDashboardShow()
        {
            if (!QualificationTabPage3.Controls.Contains(EducationDashboardControl.Instance))
            {
                QualificationTabPage3.Controls.Add(EducationDashboardControl.Instance);
                EducationDashboardControl.Instance.Dock = DockStyle.Fill;
                EducationDashboardControl.Instance.BringToFront();
            }
            else
                EducationDashboardControl.Instance.BringToFront();
        }
    }
}
