namespace SlipstreamHRM.User_Control.Leave_Dashboard_Control
{
    partial class LeaveListDashboardControl
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
            this.LeaveListLink = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // LeaveListLink
            // 
            this.LeaveListLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeaveListLink.Location = new System.Drawing.Point(0, 0);
            this.LeaveListLink.Name = "LeaveListLink";
            this.LeaveListLink.Size = new System.Drawing.Size(942, 27);
            this.LeaveListLink.TabIndex = 0;
            this.LeaveListLink.Text = "Leave List";
            this.LeaveListLink.UseSelectable = true;
            // 
            // LeaveListDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LeaveListLink);
            this.Name = "LeaveListDashboardControl";
            this.Size = new System.Drawing.Size(942, 627);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink LeaveListLink;
    }
}
