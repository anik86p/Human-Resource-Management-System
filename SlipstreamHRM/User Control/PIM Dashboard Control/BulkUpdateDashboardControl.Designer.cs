namespace SlipstreamHRM.User_Control.PIM_Dashboard_Control
{
    partial class BulkUpdateDashboardControl
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
            this.BulkUpdatePanel = new MetroFramework.Controls.MetroPanel();
            this.BulkUpdateLink = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // BulkUpdatePanel
            // 
            this.BulkUpdatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BulkUpdatePanel.HorizontalScrollbarBarColor = true;
            this.BulkUpdatePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.BulkUpdatePanel.HorizontalScrollbarSize = 10;
            this.BulkUpdatePanel.Location = new System.Drawing.Point(0, 23);
            this.BulkUpdatePanel.Name = "BulkUpdatePanel";
            this.BulkUpdatePanel.Size = new System.Drawing.Size(945, 604);
            this.BulkUpdatePanel.TabIndex = 3;
            this.BulkUpdatePanel.VerticalScrollbarBarColor = true;
            this.BulkUpdatePanel.VerticalScrollbarHighlightOnWheel = false;
            this.BulkUpdatePanel.VerticalScrollbarSize = 10;
            // 
            // BulkUpdateLink
            // 
            this.BulkUpdateLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.BulkUpdateLink.Location = new System.Drawing.Point(0, 0);
            this.BulkUpdateLink.Name = "BulkUpdateLink";
            this.BulkUpdateLink.Size = new System.Drawing.Size(945, 23);
            this.BulkUpdateLink.TabIndex = 2;
            this.BulkUpdateLink.Text = "Bulk Update";
            this.BulkUpdateLink.UseSelectable = true;
            // 
            // BulkUpdateDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BulkUpdatePanel);
            this.Controls.Add(this.BulkUpdateLink);
            this.Name = "BulkUpdateDashboardControl";
            this.Size = new System.Drawing.Size(945, 627);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel BulkUpdatePanel;
        private MetroFramework.Controls.MetroLink BulkUpdateLink;
    }
}
