namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control.Qualification_Dashboard_Control
{
    partial class EducationDashboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EdicationPanel = new MetroFramework.Controls.MetroPanel();
            this.edu = new System.Windows.Forms.Button();
            this.EduGridView = new System.Windows.Forms.DataGridView();
            this.DeleteTile = new MetroFramework.Controls.MetroTile();
            this.EditTile = new MetroFramework.Controls.MetroTile();
            this.AddTile = new MetroFramework.Controls.MetroTile();
            this.EdicationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EduGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EdicationPanel
            // 
            this.EdicationPanel.Controls.Add(this.edu);
            this.EdicationPanel.Controls.Add(this.EduGridView);
            this.EdicationPanel.Controls.Add(this.DeleteTile);
            this.EdicationPanel.Controls.Add(this.EditTile);
            this.EdicationPanel.Controls.Add(this.AddTile);
            this.EdicationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EdicationPanel.HorizontalScrollbarBarColor = true;
            this.EdicationPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.EdicationPanel.HorizontalScrollbarSize = 10;
            this.EdicationPanel.Location = new System.Drawing.Point(0, 0);
            this.EdicationPanel.Name = "EdicationPanel";
            this.EdicationPanel.Size = new System.Drawing.Size(934, 559);
            this.EdicationPanel.TabIndex = 0;
            this.EdicationPanel.VerticalScrollbarBarColor = true;
            this.EdicationPanel.VerticalScrollbarHighlightOnWheel = false;
            this.EdicationPanel.VerticalScrollbarSize = 10;
            // 
            // edu
            // 
            this.edu.Location = new System.Drawing.Point(179, 29);
            this.edu.Name = "edu";
            this.edu.Size = new System.Drawing.Size(198, 30);
            this.edu.TabIndex = 24;
            this.edu.Text = "eduu";
            this.edu.UseVisualStyleBackColor = true;
            // 
            // EduGridView
            // 
            this.EduGridView.AllowUserToAddRows = false;
            this.EduGridView.AllowUserToDeleteRows = false;
            this.EduGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EduGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EduGridView.Location = new System.Drawing.Point(3, 93);
            this.EduGridView.Name = "EduGridView";
            this.EduGridView.ReadOnly = true;
            this.EduGridView.Size = new System.Drawing.Size(928, 463);
            this.EduGridView.TabIndex = 22;
            // 
            // DeleteTile
            // 
            this.DeleteTile.ActiveControl = null;
            this.DeleteTile.Location = new System.Drawing.Point(838, 3);
            this.DeleteTile.Name = "DeleteTile";
            this.DeleteTile.Size = new System.Drawing.Size(93, 84);
            this.DeleteTile.TabIndex = 21;
            this.DeleteTile.Text = "Delete";
            this.DeleteTile.TileImage = global::SlipstreamHRM.Properties.Resources.Felete_Icon;
            this.DeleteTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteTile.UseSelectable = true;
            this.DeleteTile.UseStyleColors = true;
            this.DeleteTile.UseTileImage = true;
            // 
            // EditTile
            // 
            this.EditTile.ActiveControl = null;
            this.EditTile.Location = new System.Drawing.Point(739, 3);
            this.EditTile.Name = "EditTile";
            this.EditTile.Size = new System.Drawing.Size(93, 84);
            this.EditTile.TabIndex = 20;
            this.EditTile.Text = "Edit";
            this.EditTile.TileImage = global::SlipstreamHRM.Properties.Resources.Edit_Icon;
            this.EditTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditTile.UseSelectable = true;
            this.EditTile.UseTileImage = true;
            // 
            // AddTile
            // 
            this.AddTile.ActiveControl = null;
            this.AddTile.Location = new System.Drawing.Point(640, 3);
            this.AddTile.Name = "AddTile";
            this.AddTile.Size = new System.Drawing.Size(93, 84);
            this.AddTile.TabIndex = 19;
            this.AddTile.Text = "Add";
            this.AddTile.TileImage = global::SlipstreamHRM.Properties.Resources.Add_Icon;
            this.AddTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddTile.UseSelectable = true;
            this.AddTile.UseTileImage = true;
            // 
            // EducationDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EdicationPanel);
            this.Name = "EducationDashboardControl";
            this.Size = new System.Drawing.Size(934, 559);
            this.EdicationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EduGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel EdicationPanel;
        private System.Windows.Forms.DataGridView EduGridView;
        private MetroFramework.Controls.MetroTile DeleteTile;
        private MetroFramework.Controls.MetroTile EditTile;
        private MetroFramework.Controls.MetroTile AddTile;
        private System.Windows.Forms.Button edu;
    }
}
