namespace appGestion.PL
{
    partial class FRM_Ajouter_Modifier_Client
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
            this.btnquitter = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnactualiser = new System.Windows.Forms.Button();
            this.lbltitre = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnquitter
            // 
            this.btnquitter.Image = global::appGestion.Properties.Resources.Button_Delete_icon;
            this.btnquitter.Location = new System.Drawing.Point(326, 12);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(61, 43);
            this.btnquitter.TabIndex = 10;
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.UseWaitCursor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(232, 269);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(141, 33);
            this.btnEnregistrer.TabIndex = 18;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.UseWaitCursor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnactualiser
            // 
            this.btnactualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualiser.Location = new System.Drawing.Point(51, 269);
            this.btnactualiser.Name = "btnactualiser";
            this.btnactualiser.Size = new System.Drawing.Size(155, 33);
            this.btnactualiser.TabIndex = 17;
            this.btnactualiser.Text = "Actualiser";
            this.btnactualiser.UseVisualStyleBackColor = true;
            this.btnactualiser.UseWaitCursor = true;
            this.btnactualiser.Click += new System.EventHandler(this.btnactualiser_Click);
            // 
            // lbltitre
            // 
            this.lbltitre.AutoSize = true;
            this.lbltitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltitre.Location = new System.Drawing.Point(87, 63);
            this.lbltitre.Name = "lbltitre";
            this.lbltitre.Size = new System.Drawing.Size(191, 31);
            this.lbltitre.TabIndex = 16;
            this.lbltitre.Text = "Ajouter Client";
            this.lbltitre.UseWaitCursor = true;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(51, 188);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(141, 20);
            this.txtTel.TabIndex = 15;
            this.txtTel.Text = "Telephone";
            this.txtTel.UseWaitCursor = true;
            this.txtTel.Enter += new System.EventHandler(this.txtTel_Enter);
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            this.txtTel.Leave += new System.EventHandler(this.txtTel_Leave);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(246, 124);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(141, 20);
            this.txtAdd.TabIndex = 14;
            this.txtAdd.Text = "Adresse";
            this.txtAdd.UseWaitCursor = true;
            this.txtAdd.Enter += new System.EventHandler(this.txtAdd_Enter);
            this.txtAdd.Leave += new System.EventHandler(this.txtAdd_Leave);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(51, 124);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(141, 20);
            this.txtNom.TabIndex = 13;
            this.txtNom.Text = "Nom Client";
            this.txtNom.UseWaitCursor = true;
            this.txtNom.Enter += new System.EventHandler(this.txtNom_Enter);
            this.txtNom.Leave += new System.EventHandler(this.txtNom_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::appGestion.Properties.Resources.Phone_32;
            this.pictureBox1.Location = new System.Drawing.Point(4, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 32);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::appGestion.Properties.Resources.adresse;
            this.pictureBox2.Location = new System.Drawing.Point(199, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 32);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::appGestion.Properties.Resources.deconnect;
            this.pictureBox3.Location = new System.Drawing.Point(4, 112);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.UseWaitCursor = true;
            // 
            // FRM_Ajouter_Modifier_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(399, 356);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnactualiser);
            this.Controls.Add(this.lbltitre);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnquitter);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Ajouter_Modifier_Client";
            this.Text = "FRM_Ajouter_Modifier_Client";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.Button btnEnregistrer;
        public System.Windows.Forms.Button btnactualiser;
        public System.Windows.Forms.Label lbltitre;
        public System.Windows.Forms.TextBox txtTel;
        public System.Windows.Forms.TextBox txtAdd;
        public System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}