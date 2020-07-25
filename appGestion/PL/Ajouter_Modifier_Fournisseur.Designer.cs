namespace appGestion
{
    partial class Ajouter_Modifier_Fournisseur
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
            this.components = new System.ComponentModel.Container();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.btnquitter = new System.Windows.Forms.Button();
            this.lbltitre = new System.Windows.Forms.Label();
            this.btnactualiser = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(48, 133);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(141, 20);
            this.txtNom.TabIndex = 1;
            this.txtNom.Text = "Nom Fournisseur";
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            this.txtNom.Enter += new System.EventHandler(this.txtNom_Enter);
            this.txtNom.Leave += new System.EventHandler(this.txtNom_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(211, 133);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(141, 20);
            this.txtAdd.TabIndex = 3;
            this.txtAdd.Text = "Addresse";
            this.txtAdd.Enter += new System.EventHandler(this.txtAdd_Enter);
            this.txtAdd.Leave += new System.EventHandler(this.txtAdd_Leave);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(48, 183);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(141, 20);
            this.txtTel.TabIndex = 4;
            this.txtTel.Text = "Téléphone";
            this.txtTel.Enter += new System.EventHandler(this.txtTel_Enter);
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            this.txtTel.Leave += new System.EventHandler(this.txtTel_Leave);
            // 
            // btnquitter
            // 
            this.btnquitter.Image = global::appGestion.Properties.Resources.Button_Delete_icon;
            this.btnquitter.Location = new System.Drawing.Point(315, 12);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(61, 43);
            this.btnquitter.TabIndex = 9;
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // lbltitre
            // 
            this.lbltitre.AutoSize = true;
            this.lbltitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitre.Location = new System.Drawing.Point(80, 75);
            this.lbltitre.Name = "lbltitre";
            this.lbltitre.Size = new System.Drawing.Size(219, 25);
            this.lbltitre.TabIndex = 10;
            this.lbltitre.Text = "Ajouter Fournisseur";
            // 
            // btnactualiser
            // 
            this.btnactualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualiser.Location = new System.Drawing.Point(34, 246);
            this.btnactualiser.Name = "btnactualiser";
            this.btnactualiser.Size = new System.Drawing.Size(155, 33);
            this.btnactualiser.TabIndex = 11;
            this.btnactualiser.Text = "Actualiser";
            this.btnactualiser.UseVisualStyleBackColor = true;
            this.btnactualiser.Click += new System.EventHandler(this.btnactualiser_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(211, 246);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(141, 33);
            this.btnEnregistrer.TabIndex = 12;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // Ajouter_Modifier_Fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(386, 349);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnactualiser);
            this.Controls.Add(this.lbltitre);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ajouter_Modifier_Fournisseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter_Modifier_Fournisseur";
            this.Load += new System.EventHandler(this.Ajouter_Modifier_Fournisseur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnquitter;
        public System.Windows.Forms.Label lbltitre;
        public System.Windows.Forms.Button btnactualiser;
        private System.Windows.Forms.Button btnEnregistrer;
        public System.Windows.Forms.TextBox txtNom;
        public System.Windows.Forms.TextBox txtAdd;
        public System.Windows.Forms.TextBox txtTel;
    }
}