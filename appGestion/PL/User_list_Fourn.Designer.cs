namespace appGestion
{
    partial class User_list_Fourn
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgFourn = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Téléphonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comborecherche = new System.Windows.Forms.ComboBox();
            this.btnsuppProduit = new System.Windows.Forms.Button();
            this.btnmodifierproduit = new System.Windows.Forms.Button();
            this.btnajout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFourn)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgFourn
            // 
            this.dvgFourn.AllowUserToAddRows = false;
            this.dvgFourn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgFourn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgFourn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgFourn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgFourn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgFourn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Adresse,
            this.Téléphonne});
            this.dvgFourn.EnableHeadersVisualStyles = false;
            this.dvgFourn.Location = new System.Drawing.Point(37, 191);
            this.dvgFourn.Name = "dvgFourn";
            this.dvgFourn.RowHeadersVisible = false;
            this.dvgFourn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgFourn.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgFourn.Size = new System.Drawing.Size(746, 217);
            this.dvgFourn.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nom";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            // 
            // Téléphonne
            // 
            this.Téléphonne.HeaderText = "Téléphonne";
            this.Téléphonne.Name = "Téléphonne";
            // 
            // comborecherche
            // 
            this.comborecherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comborecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comborecherche.FormattingEnabled = true;
            this.comborecherche.Items.AddRange(new object[] {
            "ID",
            "Nom"});
            this.comborecherche.Location = new System.Drawing.Point(37, 114);
            this.comborecherche.Name = "comborecherche";
            this.comborecherche.Size = new System.Drawing.Size(190, 33);
            this.comborecherche.TabIndex = 10;
            // 
            // btnsuppProduit
            // 
            this.btnsuppProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuppProduit.Image = global::appGestion.Properties.Resources.Close_2_icon;
            this.btnsuppProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsuppProduit.Location = new System.Drawing.Point(495, 36);
            this.btnsuppProduit.Name = "btnsuppProduit";
            this.btnsuppProduit.Size = new System.Drawing.Size(190, 51);
            this.btnsuppProduit.TabIndex = 8;
            this.btnsuppProduit.Text = "Supprimer";
            this.btnsuppProduit.UseVisualStyleBackColor = true;
            this.btnsuppProduit.Click += new System.EventHandler(this.btnsuppProduit_Click);
            // 
            // btnmodifierproduit
            // 
            this.btnmodifierproduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifierproduit.Image = global::appGestion.Properties.Resources.Recycle_iconaaa;
            this.btnmodifierproduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifierproduit.Location = new System.Drawing.Point(273, 36);
            this.btnmodifierproduit.Name = "btnmodifierproduit";
            this.btnmodifierproduit.Size = new System.Drawing.Size(190, 51);
            this.btnmodifierproduit.TabIndex = 7;
            this.btnmodifierproduit.Text = "Modifier";
            this.btnmodifierproduit.UseVisualStyleBackColor = true;
            this.btnmodifierproduit.Click += new System.EventHandler(this.btnmodifierproduit_Click);
            // 
            // btnajout
            // 
            this.btnajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajout.Image = global::appGestion.Properties.Resources.Actions_list_add_icon;
            this.btnajout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajout.Location = new System.Drawing.Point(37, 36);
            this.btnajout.Name = "btnajout";
            this.btnajout.Size = new System.Drawing.Size(190, 51);
            this.btnajout.TabIndex = 6;
            this.btnajout.Text = "Ajouter";
            this.btnajout.UseVisualStyleBackColor = true;
            this.btnajout.Click += new System.EventHandler(this.btnajout_Click);
            // 
            // User_list_Fourn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dvgFourn);
            this.Controls.Add(this.comborecherche);
            this.Controls.Add(this.btnsuppProduit);
            this.Controls.Add(this.btnmodifierproduit);
            this.Controls.Add(this.btnajout);
            this.Name = "User_list_Fourn";
            this.Size = new System.Drawing.Size(821, 445);
            this.Load += new System.EventHandler(this.User_list_Fourn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgFourn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgFourn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Téléphonne;
        private System.Windows.Forms.ComboBox comborecherche;
        private System.Windows.Forms.Button btnsuppProduit;
        private System.Windows.Forms.Button btnmodifierproduit;
        private System.Windows.Forms.Button btnajout;
        private System.Windows.Forms.Label lbltitre;
    }
}
