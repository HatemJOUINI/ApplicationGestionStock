namespace appGestion
{
    partial class FRM_Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClient = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnProduit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelParametre = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlaficher = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelParametre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnClient);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnProduit);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(-6, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 522);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnClient
            // 
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClient.Image = global::appGestion.Properties.Resources.customer_service_icon;
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(7, 234);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(222, 54);
            this.btnClient.TabIndex = 6;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::appGestion.Properties.Resources.Menu_32;
            this.button4.Location = new System.Drawing.Point(18, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 40);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnProduit
            // 
            this.btnProduit.FlatAppearance.BorderSize = 0;
            this.btnProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProduit.Image = global::appGestion.Properties.Resources.shop_cart_add_icon;
            this.btnProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduit.Location = new System.Drawing.Point(4, 80);
            this.btnProduit.Name = "btnProduit";
            this.btnProduit.Size = new System.Drawing.Size(222, 54);
            this.btnProduit.TabIndex = 1;
            this.btnProduit.Text = "Produit ";
            this.btnProduit.UseVisualStyleBackColor = true;
            this.btnProduit.Click += new System.EventHandler(this.btnProduit_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = global::appGestion.Properties.Resources.Office_Client_Male_Light_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "     Fournisseur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelParametre);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(264, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 128);
            this.panel2.TabIndex = 7;
            // 
            // panelParametre
            // 
            this.panelParametre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelParametre.Controls.Add(this.button7);
            this.panelParametre.Controls.Add(this.button6);
            this.panelParametre.Location = new System.Drawing.Point(350, 7);
            this.panelParametre.Name = "panelParametre";
            this.panelParametre.Size = new System.Drawing.Size(237, 124);
            this.panelParametre.TabIndex = 16;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Image = global::appGestion.Properties.Resources.Deconnecte;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 66);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(237, 37);
            this.button7.TabIndex = 1;
            this.button7.Text = "Déconnecter";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Image = global::appGestion.Properties.Resources.Connected_16;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(237, 37);
            this.button6.TabIndex = 0;
            this.button6.Text = "Connecter";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::appGestion.Properties.Resources.Settings_32;
            this.button5.Location = new System.Drawing.Point(593, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 40);
            this.button5.TabIndex = 15;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::appGestion.Properties.Resources.Subtract_32;
            this.button3.Location = new System.Drawing.Point(651, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 40);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::appGestion.Properties.Resources.Shutdown_32;
            this.button1.Location = new System.Drawing.Point(707, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 40);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pnlaficher
            // 
            this.pnlaficher.Location = new System.Drawing.Point(237, 139);
            this.pnlaficher.Name = "pnlaficher";
            this.pnlaficher.Size = new System.Drawing.Size(775, 373);
            this.pnlaficher.TabIndex = 13;
            // 
            // FRM_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 533);
            this.Controls.Add(this.pnlaficher);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Menu";
            this.Text = "FRM_Menu";
            this.Load += new System.EventHandler(this.FRM_Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelParametre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnProduit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelParametre;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlaficher;
        private System.Windows.Forms.Button btnClient;
    }
}