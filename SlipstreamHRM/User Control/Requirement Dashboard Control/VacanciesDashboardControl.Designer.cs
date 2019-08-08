namespace SlipstreamHRM.User_Control.Requirement_Dashboard_Control
{
    partial class VacanciesDashboardControl
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
            this.VacanciesLink = new MetroFramework.Controls.MetroLink();
            this.candidatesPanel = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // VacanciesLink
            // 
            this.VacanciesLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.VacanciesLink.Location = new System.Drawing.Point(0, 0);
            this.VacanciesLink.Name = "VacanciesLink";
            this.VacanciesLink.Size = new System.Drawing.Size(945, 23);
            this.VacanciesLink.TabIndex = 0;
            this.VacanciesLink.Text = "Vacancies";
            this.VacanciesLink.UseSelectable = true;
            // 
            // candidatesPanel
            // 
            this.candidatesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.candidatesPanel.HorizontalScrollbarBarColor = true;
            this.candidatesPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.candidatesPanel.HorizontalScrollbarSize = 10;
            this.candidatesPanel.Location = new System.Drawing.Point(0, 23);
            this.candidatesPanel.Name = "candidatesPanel";
            this.candidatesPanel.Size = new System.Drawing.Size(945, 604);
            this.candidatesPanel.TabIndex = 1;
            this.candidatesPanel.VerticalScrollbarBarColor = true;
            this.candidatesPanel.VerticalScrollbarHighlightOnWheel = false;
            this.candidatesPanel.VerticalScrollbarSize = 10;
            // 
            // VacanciesDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.candidatesPanel);
            this.Controls.Add(this.VacanciesLink);
            this.Name = "VacanciesDashboardControl";
            this.Size = new System.Drawing.Size(945, 627);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink VacanciesLink;
        private MetroFramework.Controls.MetroPanel candidatesPanel;
    }
}
