namespace appGestion.PL
{
    partial class User_list_Client
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnajout = new System.Windows.Forms.Button();
            this.btnsuppClient = new System.Windows.Forms.Button();
            this.btnmodifierclient = new System.Windows.Forms.Button();
            this.dvgclient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Téléphonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgclient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnajout
            // 
            this.btnajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajout.Image = global::appGestion.Properties.Resources.Actions_list_add_icon;
            this.btnajout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajout.Location = new System.Drawing.Point(62, 51);
            this.btnajout.Name = "btnajout";
            this.btnajout.Size = new System.Drawing.Size(190, 51);
            this.btnajout.TabIndex = 7;
            this.btnajout.Text = "Ajouter";
            this.btnajout.UseVisualStyleBackColor = true;
            this.btnajout.Click += new System.EventHandler(this.btnajout_Click);
            // 
            // btnsuppClient
            // 
            this.btnsuppClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuppClient.Image = global::appGestion.Properties.Resources.Close_2_icon;
            this.btnsuppClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsuppClient.Location = new System.Drawing.Point(511, 51);
            this.btnsuppClient.Name = "btnsuppClient";
            this.btnsuppClient.Size = new System.Drawing.Size(190, 51);
            this.btnsuppClient.TabIndex = 10;
            this.btnsuppClient.Text = "Supprimer";
            this.btnsuppClient.UseVisualStyleBackColor = true;
            this.btnsuppClient.Click += new System.EventHandler(this.btnsuppClient_Click);
            // 
            // btnmodifierclient
            // 
            this.btnmodifierclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifierclient.Image = global::appGestion.Properties.Resources.Recycle_iconaaa;
            this.btnmodifierclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifierclient.Location = new System.Drawing.Point(288, 51);
            this.btnmodifierclient.Name = "btnmodifierclient";
            this.btnmodifierclient.Size = new System.Drawing.Size(190, 51);
            this.btnmodifierclient.TabIndex = 9;
            this.btnmodifierclient.Text = "Modifier";
            this.btnmodifierclient.UseVisualStyleBackColor = true;
            this.btnmodifierclient.Click += new System.EventHandler(this.btnmodifierclient_Click);
            // 
            // dvgclient
            // 
            this.dvgclient.AllowUserToAddRows = false;
            this.dvgclient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgclient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgclient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgclient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dvgclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Adresse,
            this.Téléphonne});
            this.dvgclient.EnableHeadersVisualStyles = false;
            this.dvgclient.Location = new System.Drawing.Point(39, 151);
            this.dvgclient.Name = "dvgclient";
            this.dvgclient.RowHeadersVisible = false;
            this.dvgclient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgclient.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dvgclient.Size = new System.Drawing.Size(746, 217);
            this.dvgclient.TabIndex = 12;
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
            // User_list_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dvgclient);
            this.Controls.Add(this.btnsuppClient);
            this.Controls.Add(this.btnmodifierclient);
            this.Controls.Add(this.btnajout);
            this.Name = "User_list_Client";
            this.Size = new System.Drawing.Size(810, 403);
            this.Load += new System.EventHandler(this.User_list_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgclient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnajout;
        private System.Windows.Forms.Button btnsuppClient;
        private System.Windows.Forms.Button btnmodifierclient;
        private System.Windows.Forms.DataGridView dvgclient;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Téléphonne;
    }
}
