namespace SlipstreamHRM.User_Control.Requirement_Dashboard_Control
{
    partial class DisciplineCasesDashboardControl
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
            this.DisciplineCasesLink = new MetroFramework.Controls.MetroLink();
            this.disciplinePanel = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // DisciplineCasesLink
            // 
            this.DisciplineCasesLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.DisciplineCasesLink.Location = new System.Drawing.Point(0, 0);
            this.DisciplineCasesLink.Name = "DisciplineCasesLink";
            this.DisciplineCasesLink.Size = new System.Drawing.Size(945, 23);
            this.DisciplineCasesLink.TabIndex = 0;
            this.DisciplineCasesLink.Text = "Discipline Cases";
            this.DisciplineCasesLink.UseSelectable = true;
            // 
            // disciplinePanel
            // 
            this.disciplinePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disciplinePanel.HorizontalScrollbarBarColor = true;
            this.disciplinePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.disciplinePanel.HorizontalScrollbarSize = 10;
            this.disciplinePanel.Location = new System.Drawing.Point(0, 23);
            this.disciplinePanel.Name = "disciplinePanel";
            this.disciplinePanel.Size = new System.Drawing.Size(945, 604);
            this.disciplinePanel.TabIndex = 1;
            this.disciplinePanel.VerticalScrollbarBarColor = true;
            this.disciplinePanel.VerticalScrollbarHighlightOnWheel = false;
            this.disciplinePanel.VerticalScrollbarSize = 10;
            // 
            // DisciplineCasesDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.disciplinePanel);
            this.Controls.Add(this.DisciplineCasesLink);
            this.Name = "DisciplineCasesDashboardControl";
            this.Size = new System.Drawing.Size(945, 627);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink DisciplineCasesLink;
        private MetroFramework.Controls.MetroPanel disciplinePanel;
    }
}
