namespace appGestion
{
    partial class FRM_Conn
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMotdePasse = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnquitter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(68, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mot de Passe";
            this.label2.UseCompatibleTextRendering = true;
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(80, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Connexion";
            this.label1.UseWaitCursor = true;
            // 
            // txtMotdePasse
            // 
            this.txtMotdePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotdePasse.Location = new System.Drawing.Point(68, 228);
            this.txtMotdePasse.Name = "txtMotdePasse";
            this.txtMotdePasse.Size = new System.Drawing.Size(227, 26);
            this.txtMotdePasse.TabIndex = 11;
            this.txtMotdePasse.Text = "Mot de Passe";
            this.txtMotdePasse.UseWaitCursor = true;
            this.txtMotdePasse.Enter += new System.EventHandler(this.txtMotdePasse_Enter);
            this.txtMotdePasse.Leave += new System.EventHandler(this.txtMotdePasse_Leave);
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(68, 130);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(227, 26);
            this.txtNom.TabIndex = 10;
            this.txtNom.Text = "Nom d\'utilisateur";
            this.txtNom.UseWaitCursor = true;
            this.txtNom.Enter += new System.EventHandler(this.txtNom_Enter);
            this.txtNom.Leave += new System.EventHandler(this.txtNom_Leave);
            // 
            // btnquitter
            // 
            this.btnquitter.Image = global::appGestion.Properties.Resources.Button_Delete_icon;
            this.btnquitter.Location = new System.Drawing.Point(267, 12);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(51, 41);
            this.btnquitter.TabIndex = 12;
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.UseWaitCursor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::appGestion.Properties.Resources.login_32;
            this.pictureBox1.Location = new System.Drawing.Point(12, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 36);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::appGestion.Properties.Resources.Motdepasse_32;
            this.pictureBox2.Location = new System.Drawing.Point(12, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 36);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(68, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 31);
            this.button2.TabIndex = 15;
            this.button2.Text = "se Connecter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FRM_Conn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(339, 342);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.txtMotdePasse);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Conn";
            this.Text = "FRM_Conn";
            this.Load += new System.EventHandler(this.FRM_Conn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMotdePasse;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
    }
}