namespace SlipstreamHRM.User_Control.Requirement_Dashboard_Control
{
    partial class CandidatesDashboardControl
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
            this.CandidatesLink = new MetroFramework.Controls.MetroLink();
            this.vacanciesPanel = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // CandidatesLink
            // 
            this.CandidatesLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.CandidatesLink.Location = new System.Drawing.Point(0, 0);
            this.CandidatesLink.Name = "CandidatesLink";
            this.CandidatesLink.Size = new System.Drawing.Size(945, 23);
            this.CandidatesLink.TabIndex = 0;
            this.CandidatesLink.Text = "Candidates";
            this.CandidatesLink.UseSelectable = true;
            // 
            // vacanciesPanel
            // 
            this.vacanciesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vacanciesPanel.HorizontalScrollbarBarColor = true;
            this.vacanciesPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.vacanciesPanel.HorizontalScrollbarSize = 10;
            this.vacanciesPanel.Location = new System.Drawing.Point(0, 23);
            this.vacanciesPanel.Name = "vacanciesPanel";
            this.vacanciesPanel.Size = new System.Drawing.Size(945, 604);
            this.vacanciesPanel.TabIndex = 1;
            this.vacanciesPanel.VerticalScrollbarBarColor = true;
            this.vacanciesPanel.VerticalScrollbarHighlightOnWheel = false;
            this.vacanciesPanel.VerticalScrollbarSize = 10;
            // 
            // CandidatesDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vacanciesPanel);
            this.Controls.Add(this.CandidatesLink);
            this.Name = "CandidatesDashboardControl";
            this.Size = new System.Drawing.Size(945, 627);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink CandidatesLink;
        private MetroFramework.Controls.MetroPanel vacanciesPanel;
    }
}
