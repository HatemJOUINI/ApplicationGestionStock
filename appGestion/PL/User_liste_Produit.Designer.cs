namespace appGestion
{
    partial class User_liste_Produit
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnajout = new System.Windows.Forms.Button();
            this.btnmodifierproduit = new System.Windows.Forms.Button();
            this.btnsuppProduit = new System.Windows.Forms.Button();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.comborecherche = new System.Windows.Forms.ComboBox();
            this.dvgProduit = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gESTIONDataSet3 = new appGestion.GESTIONDataSet3();
            this.gESTIONDataSet2 = new appGestion.GESTIONDataSet2();
            this.gESTIONDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitTableAdapter = new appGestion.GESTIONDataSet3TableAdapters.ProduitTableAdapter();
            this.btnRAP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTIONDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTIONDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTIONDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnajout
            // 
            this.btnajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajout.Location = new System.Drawing.Point(30, 31);
            this.btnajout.Name = "btnajout";
            this.btnajout.Size = new System.Drawing.Size(190, 51);
            this.btnajout.TabIndex = 0;
            this.btnajout.Text = "Ajouter";
            this.btnajout.UseVisualStyleBackColor = true;
            this.btnajout.Click += new System.EventHandler(this.btnajout_Click);
            // 
            // btnmodifierproduit
            // 
            this.btnmodifierproduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifierproduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifierproduit.Location = new System.Drawing.Point(266, 31);
            this.btnmodifierproduit.Name = "btnmodifierproduit";
            this.btnmodifierproduit.Size = new System.Drawing.Size(190, 51);
            this.btnmodifierproduit.TabIndex = 1;
            this.btnmodifierproduit.Text = "Modifier";
            this.btnmodifierproduit.UseVisualStyleBackColor = true;
            this.btnmodifierproduit.Click += new System.EventHandler(this.btnmodifierproduit_Click);
            // 
            // btnsuppProduit
            // 
            this.btnsuppProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuppProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsuppProduit.Location = new System.Drawing.Point(488, 31);
            this.btnsuppProduit.Name = "btnsuppProduit";
            this.btnsuppProduit.Size = new System.Drawing.Size(190, 51);
            this.btnsuppProduit.TabIndex = 2;
            this.btnsuppProduit.Text = "Supprimer";
            this.btnsuppProduit.UseVisualStyleBackColor = true;
            this.btnsuppProduit.Click += new System.EventHandler(this.btnsuppProduit_Click);
            // 
            // txtrecherche
            // 
            this.txtrecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecherche.Location = new System.Drawing.Point(266, 116);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(190, 30);
            this.txtrecherche.TabIndex = 3;
            this.txtrecherche.Text = "Recherche";
            this.txtrecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrecherche.UseSystemPasswordChar = true;
            this.txtrecherche.TextChanged += new System.EventHandler(this.txtrecherche_TextChanged);
            this.txtrecherche.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // comborecherche
            // 
            this.comborecherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comborecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comborecherche.FormattingEnabled = true;
            this.comborecherche.Items.AddRange(new object[] {
            "ID",
            "Nom"});
            this.comborecherche.Location = new System.Drawing.Point(30, 109);
            this.comborecherche.Name = "comborecherche";
            this.comborecherche.Size = new System.Drawing.Size(190, 33);
            this.comborecherche.TabIndex = 4;
            this.comborecherche.SelectedIndexChanged += new System.EventHandler(this.comborecherche_SelectedIndexChanged);
            // 
            // dvgProduit
            // 
            this.dvgProduit.AllowUserToAddRows = false;
            this.dvgProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgProduit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgProduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dvgProduit.EnableHeadersVisualStyles = false;
            this.dvgProduit.Location = new System.Drawing.Point(30, 176);
            this.dvgProduit.Name = "dvgProduit";
            this.dvgProduit.RowHeadersVisible = false;
            this.dvgProduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgProduit.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgProduit.Size = new System.Drawing.Size(800, 227);
            this.dvgProduit.TabIndex = 5;
            this.dvgProduit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Column4
            // 
            this.Column4.HeaderText = "Référence";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quantité";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Rayonnage";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Désignation";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "Produit";
            this.produitBindingSource.DataSource = this.gESTIONDataSet3;
            // 
            // gESTIONDataSet3
            // 
            this.gESTIONDataSet3.DataSetName = "GESTIONDataSet3";
            this.gESTIONDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gESTIONDataSet2
            // 
            this.gESTIONDataSet2.DataSetName = "GESTIONDataSet2";
            this.gESTIONDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gESTIONDataSet2BindingSource
            // 
            this.gESTIONDataSet2BindingSource.DataSource = this.gESTIONDataSet2;
            this.gESTIONDataSet2BindingSource.Position = 0;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // btnRAP
            // 
            this.btnRAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRAP.Location = new System.Drawing.Point(705, 31);
            this.btnRAP.Name = "btnRAP";
            this.btnRAP.Size = new System.Drawing.Size(190, 51);
            this.btnRAP.TabIndex = 6;
            this.btnRAP.Text = "Imprimer rapport ";
            this.btnRAP.UseVisualStyleBackColor = true;
            this.btnRAP.Click += new System.EventHandler(this.btnRAP_Click);
            // 
            // User_liste_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRAP);
            this.Controls.Add(this.dvgProduit);
            this.Controls.Add(this.comborecherche);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.btnsuppProduit);
            this.Controls.Add(this.btnmodifierproduit);
            this.Controls.Add(this.btnajout);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "User_liste_Produit";
            this.Size = new System.Drawing.Size(1061, 445);
            this.Load += new System.EventHandler(this.User_liste_Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTIONDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTIONDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTIONDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnajout;
        private System.Windows.Forms.Button btnmodifierproduit;
        private System.Windows.Forms.Button btnsuppProduit;
        private System.Windows.Forms.ComboBox comborecherche;
        private System.Windows.Forms.DataGridView dvgProduit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        public System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.BindingSource gESTIONDataSet2BindingSource;
        private GESTIONDataSet2 gESTIONDataSet2;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private GESTIONDataSet3 gESTIONDataSet3;
        private GESTIONDataSet3TableAdapters.ProduitTableAdapter produitTableAdapter;
        private System.Windows.Forms.Button btnRAP;
    }
}
