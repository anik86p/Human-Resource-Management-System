using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control;
using Tulpep.NotificationWindow;

namespace SlipstreamHRM.Forms
{
    public partial class AdminControlManager : MetroFramework.Forms.MetroForm
    {
        private string userName;
        public AdminControlManager(string txt)
        {
            InitializeComponent();
            this.Text = "                Welcome Admin!";
            this.userName = txt;
            HomeDashboardShow();
        }

        public void HomeDashboardShow()
        {
            if (!adminDashboardPanel.Controls.Contains(HomeDashboardControl.Instance))
            {
                adminDashboardPanel.Controls.Clear();
                adminDashboardPanel.Controls.Add(HomeDashboardControl.Instance);
                HomeDashboardControl.Instance.Dock = DockStyle.Fill;
                HomeDashboardControl.Instance.BringToFront();
            }
            else
                HomeDashboardControl.Instance.BringToFront();
            this.ModuleNameShowLink.Text = "Home";
        }

        private void AdminTile_Click(object sender, EventArgs e)
        {
            if (!adminDashboardPanel.Controls.Contains(AdminDashboardControl.Instance))
            {
                adminDashboardPanel.Controls.Add(AdminDashboardControl.Instance);
                AdminDashboardControl.Instance.Dock = DockStyle.Fill;
                AdminDashboardControl.Instance.BringToFront();
            }
            else
                AdminDashboardControl.Instance.BringToFront();
            this.ModuleNameShowLink.Text = "Admin";
        }

        private void LeaveTile_Click(object sender, EventArgs e)
        {
            if (!adminDashboardPanel.Controls.Contains(LeaveDashboardControl.Instance))
            {
                adminDashboardPanel.Controls.Add(LeaveDashboardControl.Instance);
                LeaveDashboardControl.Instance.Dock = DockStyle.Fill;
                LeaveDashboardControl.Instance.BringToFront();
            }
            else
                LeaveDashboardControl.Instance.BringToFront();
            this.ModuleNameShowLink.Text = "Leave";
        }

        private void PimTile_Click(object sender, EventArgs e)
        {
            if (!adminDashboardPanel.Controls.Contains(PIMDashboardControl.Instance))
            {
                adminDashboardPanel.Controls.Add(PIMDashboardControl.Instance);
                PIMDashboardControl.Instance.Dock = DockStyle.Fill;
                PIMDashboardControl.Instance.BringToFront();
            }
            else
                PIMDashboardControl.Instance.BringToFront();
            this.ModuleNameShowLink.Text = "PIM";
        }

        private void TimeTile_Click(object sender, EventArgs e)
        {
            if (!adminDashboardPanel.Controls.Contains(TimeDashboardControl.Instance))
            {
                adminDashboardPanel.Controls.Add(TimeDashboardControl.Instance);
                TimeDashboardControl.Instance.Dock = DockStyle.Fill;
                TimeDashboardControl.Instance.BringToFront();
            }
            else
                TimeDashboardControl.Instance.BringToFront();
            this.ModuleNameShowLink.Text = "Time";
        }

        private void RequirementTile_Click(object sender, EventArgs e)
        {
            if (!adminDashboardPanel.Controls.Contains(RequirementDashboardControl.Instance))
            {
                adminDashboardPanel.Controls.Add(RequirementDashboardControl.Instance);
                RequirementDashboardControl.Instance.Dock = DockStyle.Fill;
                RequirementDashboardControl.Instance.BringToFront();
            }
            else
                RequirementDashboardControl.Instance.BringToFront();
            this.ModuleNameShowLink.Text = "Requirement";
        }

        private void adminHomeLink_Click(object sender, EventArgs e)
        {
            HomeDashboardShow();
        }      

        private void adminSettignLink_Click(object sender, EventArgs e)
        {
            SettingContextMenu.Show(adminSettignLink, 0, adminSettignLink.Height);
        }

        private void AdminControlManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.Successfull;
            popup.TitleText = "Log Out";
            popup.ContentText = "Successfully Loged Out";
            popup.ShowCloseButton = false;
            popup.Popup();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ChangePasswordForm changePasswordForm = new ChangePasswordForm(userName))
            {
                changePasswordForm.ShowDialog();
            }
        }
    }
}
