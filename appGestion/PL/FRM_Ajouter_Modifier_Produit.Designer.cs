namespace appGestion
{
    partial class FRM_Ajouter_Modifier_Produit
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
            this.lbltitre = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtQantite = new System.Windows.Forms.TextBox();
            this.txtRay = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnactualiser = new System.Windows.Forms.Button();
            this.btnquitter = new System.Windows.Forms.Button();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbltitre
            // 
            this.lbltitre.AutoSize = true;
            this.lbltitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltitre.Location = new System.Drawing.Point(130, 42);
            this.lbltitre.Name = "lbltitre";
            this.lbltitre.Size = new System.Drawing.Size(208, 31);
            this.lbltitre.TabIndex = 0;
            this.lbltitre.Text = "Ajouter Produit";
            // 
            // txtRef
            // 
            this.txtRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef.Location = new System.Drawing.Point(274, 111);
            this.txtRef.Multiline = true;
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(191, 31);
            this.txtRef.TabIndex = 1;
            this.txtRef.Text = "Référence ";
            this.txtRef.Enter += new System.EventHandler(this.txtRef_Enter);
            this.txtRef.Leave += new System.EventHandler(this.txtRef_Leave);
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(35, 111);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(191, 31);
            this.txtNom.TabIndex = 2;
            this.txtNom.Text = "Nom Produit";
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            this.txtNom.Enter += new System.EventHandler(this.txtNom_Enter);
            this.txtNom.Leave += new System.EventHandler(this.txtNom_Leave);
            // 
            // txtQantite
            // 
            this.txtQantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQantite.Location = new System.Drawing.Point(35, 184);
            this.txtQantite.Multiline = true;
            this.txtQantite.Name = "txtQantite";
            this.txtQantite.Size = new System.Drawing.Size(191, 30);
            this.txtQantite.TabIndex = 3;
            this.txtQantite.Text = "Quantité";
            this.txtQantite.TextChanged += new System.EventHandler(this.txtQantite_TextChanged);
            this.txtQantite.Enter += new System.EventHandler(this.txtQantite_Enter);
            this.txtQantite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQantite_KeyPress);
            this.txtQantite.Leave += new System.EventHandler(this.txtQantite_Leave);
            // 
            // txtRay
            // 
            this.txtRay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRay.Location = new System.Drawing.Point(274, 184);
            this.txtRay.Multiline = true;
            this.txtRay.Name = "txtRay";
            this.txtRay.Size = new System.Drawing.Size(191, 30);
            this.txtRay.TabIndex = 4;
            this.txtRay.Text = "Rayonnage / Type ";
            this.txtRay.TextChanged += new System.EventHandler(this.txtRay_TextChanged);
            this.txtRay.Enter += new System.EventHandler(this.txtRay_Enter);
            this.txtRay.Leave += new System.EventHandler(this.txtRay_Leave);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(274, 273);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(191, 33);
            this.btnEnregistrer.TabIndex = 6;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnactualiser
            // 
            this.btnactualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualiser.Location = new System.Drawing.Point(35, 273);
            this.btnactualiser.Name = "btnactualiser";
            this.btnactualiser.Size = new System.Drawing.Size(191, 33);
            this.btnactualiser.TabIndex = 7;
            this.btnactualiser.Text = "Actualiser";
            this.btnactualiser.UseVisualStyleBackColor = true;
            this.btnactualiser.Click += new System.EventHandler(this.btnactualiser_Click);
            // 
            // btnquitter
            // 
            this.btnquitter.Image = global::appGestion.Properties.Resources.Button_Delete_icon;
            this.btnquitter.Location = new System.Drawing.Point(404, 12);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(61, 43);
            this.btnquitter.TabIndex = 8;
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // txtDes
            // 
            this.txtDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(168, 347);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(191, 30);
            this.txtDes.TabIndex = 9;
            this.txtDes.Text = "Désignation";
            // 
            // FRM_Ajouter_Modifier_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(500, 338);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.btnactualiser);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtRay);
            this.Controls.Add(this.txtQantite);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.lbltitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Ajouter_Modifier_Produit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Ajouter_Modifier_Produit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnquitter;
        public System.Windows.Forms.Label lbltitre;
        public System.Windows.Forms.Button btnactualiser;
        public System.Windows.Forms.TextBox txtRef;
        public System.Windows.Forms.TextBox txtNom;
        public System.Windows.Forms.TextBox txtQantite;
        public System.Windows.Forms.TextBox txtRay;
        public System.Windows.Forms.TextBox txtDes;
    }
}