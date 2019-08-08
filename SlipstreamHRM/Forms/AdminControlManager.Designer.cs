﻿namespace SlipstreamHRM.Forms
{
    partial class AdminControlManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.adminFormPanel = new MetroFramework.Controls.MetroPanel();
            this.adminDashboardPanel = new MetroFramework.Controls.MetroPanel();
            this.adminNavigationPanel = new MetroFramework.Controls.MetroPanel();
            this.RequirementTile = new MetroFramework.Controls.MetroTile();
            this.TimeTile = new MetroFramework.Controls.MetroTile();
            this.adminHomeLink = new MetroFramework.Controls.MetroLink();
            this.LeaveTile = new MetroFramework.Controls.MetroTile();
            this.PimTile = new MetroFramework.Controls.MetroTile();
            this.AdminTile = new MetroFramework.Controls.MetroTile();
            this.adminHeaderPanel = new MetroFramework.Controls.MetroPanel();
            this.ModuleNameShowLink = new MetroFramework.Controls.MetroLink();
            this.adminSettignLink = new MetroFramework.Controls.MetroLink();
            this.SettingContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slipstreamLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.adminFormPanel.SuspendLayout();
            this.adminNavigationPanel.SuspendLayout();
            this.adminHeaderPanel.SuspendLayout();
            this.SettingContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slipstreamLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // adminFormPanel
            // 
            this.adminFormPanel.Controls.Add(this.adminDashboardPanel);
            this.adminFormPanel.Controls.Add(this.adminNavigationPanel);
            this.adminFormPanel.Controls.Add(this.adminHeaderPanel);
            this.adminFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminFormPanel.HorizontalScrollbarBarColor = true;
            this.adminFormPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.adminFormPanel.HorizontalScrollbarSize = 10;
            this.adminFormPanel.Location = new System.Drawing.Point(20, 60);
            this.adminFormPanel.Name = "adminFormPanel";
            this.adminFormPanel.Size = new System.Drawing.Size(1326, 688);
            this.adminFormPanel.TabIndex = 0;
            this.adminFormPanel.VerticalScrollbarBarColor = true;
            this.adminFormPanel.VerticalScrollbarHighlightOnWheel = false;
            this.adminFormPanel.VerticalScrollbarSize = 10;
            // 
            // adminDashboardPanel
            // 
            this.adminDashboardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminDashboardPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.adminDashboardPanel.HorizontalScrollbarBarColor = true;
            this.adminDashboardPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.adminDashboardPanel.HorizontalScrollbarSize = 10;
            this.adminDashboardPanel.Location = new System.Drawing.Point(162, 38);
            this.adminDashboardPanel.Name = "adminDashboardPanel";
            this.adminDashboardPanel.Size = new System.Drawing.Size(1164, 650);
            this.adminDashboardPanel.TabIndex = 4;
            this.adminDashboardPanel.VerticalScrollbarBarColor = true;
            this.adminDashboardPanel.VerticalScrollbarHighlightOnWheel = false;
            this.adminDashboardPanel.VerticalScrollbarSize = 10;
            // 
            // adminNavigationPanel
            // 
            this.adminNavigationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminNavigationPanel.Controls.Add(this.RequirementTile);
            this.adminNavigationPanel.Controls.Add(this.TimeTile);
            this.adminNavigationPanel.Controls.Add(this.adminHomeLink);
            this.adminNavigationPanel.Controls.Add(this.LeaveTile);
            this.adminNavigationPanel.Controls.Add(this.PimTile);
            this.adminNavigationPanel.Controls.Add(this.AdminTile);
            this.adminNavigationPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.adminNavigationPanel.HorizontalScrollbarBarColor = true;
            this.adminNavigationPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.adminNavigationPanel.HorizontalScrollbarSize = 10;
            this.adminNavigationPanel.Location = new System.Drawing.Point(0, 38);
            this.adminNavigationPanel.Name = "adminNavigationPanel";
            this.adminNavigationPanel.Size = new System.Drawing.Size(156, 650);
            this.adminNavigationPanel.TabIndex = 3;
            this.adminNavigationPanel.TabStop = true;
            this.adminNavigationPanel.VerticalScrollbarBarColor = true;
            this.adminNavigationPanel.VerticalScrollbarHighlightOnWheel = false;
            this.adminNavigationPanel.VerticalScrollbarSize = 10;
            // 
            // RequirementTile
            // 
            this.RequirementTile.ActiveControl = null;
            this.RequirementTile.Location = new System.Drawing.Point(3, 530);
            this.RequirementTile.Name = "RequirementTile";
            this.RequirementTile.Size = new System.Drawing.Size(150, 117);
            this.RequirementTile.TabIndex = 11;
            this.RequirementTile.Text = "Requirement";
            this.RequirementTile.TileImage = global::SlipstreamHRM.Properties.Resources.Requirement_Icon_White1;
            this.RequirementTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RequirementTile.UseSelectable = true;
            this.RequirementTile.UseTileImage = true;
            this.RequirementTile.Click += new System.EventHandler(this.RequirementTile_Click);
            // 
            // TimeTile
            // 
            this.TimeTile.ActiveControl = null;
            this.TimeTile.Location = new System.Drawing.Point(3, 407);
            this.TimeTile.Name = "TimeTile";
            this.TimeTile.Size = new System.Drawing.Size(150, 117);
            this.TimeTile.TabIndex = 10;
            this.TimeTile.Text = "Time";
            this.TimeTile.TileImage = global::SlipstreamHRM.Properties.Resources.Time_Icon_White;
            this.TimeTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimeTile.UseSelectable = true;
            this.TimeTile.UseTileImage = true;
            this.TimeTile.Click += new System.EventHandler(this.TimeTile_Click);
            // 
            // adminHomeLink
            // 
            this.adminHomeLink.BackColor = System.Drawing.Color.Transparent;
            this.adminHomeLink.BackgroundImage = global::SlipstreamHRM.Properties.Resources.Home_Icon_Black;
            this.adminHomeLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.adminHomeLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminHomeLink.Location = new System.Drawing.Point(41, 3);
            this.adminHomeLink.Name = "adminHomeLink";
            this.adminHomeLink.Size = new System.Drawing.Size(78, 33);
            this.adminHomeLink.TabIndex = 3;
            this.adminHomeLink.UseSelectable = true;
            this.adminHomeLink.Click += new System.EventHandler(this.adminHomeLink_Click);
            // 
            // LeaveTile
            // 
            this.LeaveTile.ActiveControl = null;
            this.LeaveTile.Location = new System.Drawing.Point(3, 284);
            this.LeaveTile.Name = "LeaveTile";
            this.LeaveTile.Size = new System.Drawing.Size(150, 117);
            this.LeaveTile.TabIndex = 9;
            this.LeaveTile.Text = "Leave";
            this.LeaveTile.TileImage = global::SlipstreamHRM.Properties.Resources.Leave_White_Icon;
            this.LeaveTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LeaveTile.UseSelectable = true;
            this.LeaveTile.UseTileImage = true;
            this.LeaveTile.Click += new System.EventHandler(this.LeaveTile_Click);
            // 
            // PimTile
            // 
            this.PimTile.ActiveControl = null;
            this.PimTile.Location = new System.Drawing.Point(3, 161);
            this.PimTile.Name = "PimTile";
            this.PimTile.Size = new System.Drawing.Size(150, 117);
            this.PimTile.TabIndex = 8;
            this.PimTile.Text = "PIM";
            this.PimTile.TileImage = global::SlipstreamHRM.Properties.Resources.PIM_White_Icon;
            this.PimTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PimTile.UseSelectable = true;
            this.PimTile.UseTileImage = true;
            this.PimTile.Click += new System.EventHandler(this.PimTile_Click);
            // 
            // AdminTile
            // 
            this.AdminTile.ActiveControl = null;
            this.AdminTile.Location = new System.Drawing.Point(3, 38);
            this.AdminTile.Name = "AdminTile";
            this.AdminTile.Size = new System.Drawing.Size(150, 117);
            this.AdminTile.TabIndex = 7;
            this.AdminTile.Text = "Admin";
            this.AdminTile.TileImage = global::SlipstreamHRM.Properties.Resources.Admin_Icon_White;
            this.AdminTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminTile.UseSelectable = true;
            this.AdminTile.UseStyleColors = true;
            this.AdminTile.UseTileImage = true;
            this.AdminTile.Click += new System.EventHandler(this.AdminTile_Click);
            // 
            // adminHeaderPanel
            // 
            this.adminHeaderPanel.BackgroundImage = global::SlipstreamHRM.Properties.Resources.Header_Logo;
            this.adminHeaderPanel.Controls.Add(this.ModuleNameShowLink);
            this.adminHeaderPanel.Controls.Add(this.adminSettignLink);
            this.adminHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminHeaderPanel.HorizontalScrollbarBarColor = true;
            this.adminHeaderPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.adminHeaderPanel.HorizontalScrollbarSize = 10;
            this.adminHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.adminHeaderPanel.Name = "adminHeaderPanel";
            this.adminHeaderPanel.Size = new System.Drawing.Size(1326, 38);
            this.adminHeaderPanel.TabIndex = 2;
            this.adminHeaderPanel.VerticalScrollbarBarColor = true;
            this.adminHeaderPanel.VerticalScrollbarHighlightOnWheel = false;
            this.adminHeaderPanel.VerticalScrollbarSize = 10;
            // 
            // ModuleNameShowLink
            // 
            this.ModuleNameShowLink.Location = new System.Drawing.Point(1061, 3);
            this.ModuleNameShowLink.Name = "ModuleNameShowLink";
            this.ModuleNameShowLink.Size = new System.Drawing.Size(151, 32);
            this.ModuleNameShowLink.TabIndex = 3;
            this.ModuleNameShowLink.UseSelectable = true;
            // 
            // adminSettignLink
            // 
            this.adminSettignLink.BackColor = System.Drawing.Color.Transparent;
            this.adminSettignLink.BackgroundImage = global::SlipstreamHRM.Properties.Resources.Seetign_Icon_White;
            this.adminSettignLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.adminSettignLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminSettignLink.Location = new System.Drawing.Point(1268, 2);
            this.adminSettignLink.Name = "adminSettignLink";
            this.adminSettignLink.Size = new System.Drawing.Size(53, 33);
            this.adminSettignLink.TabIndex = 4;
            this.adminSettignLink.UseSelectable = true;
            this.adminSettignLink.Click += new System.EventHandler(this.adminSettignLink_Click);
            // 
            // SettingContextMenu
            // 
            this.SettingContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.toolStripSeparator1,
            this.logOutToolStripMenuItem});
            this.SettingContextMenu.Name = "SettingContextMenu";
            this.SettingContextMenu.Size = new System.Drawing.Size(169, 76);
            this.SettingContextMenu.Style = MetroFramework.MetroColorStyle.Orange;
            this.SettingContextMenu.UseStyleColors = true;
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // slipstreamLogoPictureBox
            // 
            this.slipstreamLogoPictureBox.Image = global::SlipstreamHRM.Properties.Resources.SlipstreamHRM_Logo;
            this.slipstreamLogoPictureBox.Location = new System.Drawing.Point(23, 10);
            this.slipstreamLogoPictureBox.Name = "slipstreamLogoPictureBox";
            this.slipstreamLogoPictureBox.Size = new System.Drawing.Size(116, 44);
            this.slipstreamLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slipstreamLogoPictureBox.TabIndex = 5;
            this.slipstreamLogoPictureBox.TabStop = false;
            // 
            // AdminControlManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.slipstreamLogoPictureBox);
            this.Controls.Add(this.adminFormPanel);
            this.MaximizeBox = false;
            this.Name = "AdminControlManager";
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminControlManager_FormClosing);
            this.adminFormPanel.ResumeLayout(false);
            this.adminNavigationPanel.ResumeLayout(false);
            this.adminHeaderPanel.ResumeLayout(false);
            this.SettingContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slipstreamLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel adminFormPanel;
        private System.Windows.Forms.PictureBox slipstreamLogoPictureBox;
        private MetroFramework.Controls.MetroPanel adminHeaderPanel;
        private MetroFramework.Controls.MetroLink adminHomeLink;
        private MetroFramework.Controls.MetroLink adminSettignLink;
        private MetroFramework.Controls.MetroLink ModuleNameShowLink;
        private MetroFramework.Controls.MetroPanel adminNavigationPanel;
        private MetroFramework.Controls.MetroTile RequirementTile;
        private MetroFramework.Controls.MetroTile TimeTile;
        private MetroFramework.Controls.MetroTile LeaveTile;
        private MetroFramework.Controls.MetroTile PimTile;
        private MetroFramework.Controls.MetroTile AdminTile;
        private MetroFramework.Controls.MetroPanel adminDashboardPanel;
        private MetroFramework.Controls.MetroContextMenu SettingContextMenu;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}