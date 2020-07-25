namespace appGestion.RAP
{
    partial class FRM_Rapport
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
            this.RPAfichier = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RPAfichier
            // 
            this.RPAfichier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RPAfichier.DocumentMapWidth = 42;
            this.RPAfichier.Location = new System.Drawing.Point(0, 0);
            this.RPAfichier.Name = "RPAfichier";
            this.RPAfichier.ServerReport.BearerToken = null;
            this.RPAfichier.Size = new System.Drawing.Size(828, 296);
            this.RPAfichier.TabIndex = 0;
            // 
            // FRM_Rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 296);
            this.Controls.Add(this.RPAfichier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Rapport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapport";
            this.Load += new System.EventHandler(this.FRM_Rapport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer RPAfichier;
    }
}