namespace Gestion.Forms.Sub
{
    partial class frmPermission
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblABECount = new System.Windows.Forms.Label();
            this.txtSBArticle = new System.Windows.Forms.TextBox();
            this.dgvEBonArticle = new System.Windows.Forms.DataGridView();
            this.colbe_A_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_A_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpne_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpne_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Qte_Livree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_ID_Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_A_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEBonArticle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblABECount);
            this.groupBox2.Controls.Add(this.txtSBArticle);
            this.groupBox2.Controls.Add(this.dgvEBonArticle);
            this.groupBox2.Location = new System.Drawing.Point(12, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(958, 445);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Articles";
            // 
            // lblABECount
            // 
            this.lblABECount.AutoSize = true;
            this.lblABECount.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABECount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblABECount.Location = new System.Drawing.Point(6, 62);
            this.lblABECount.Name = "lblABECount";
            this.lblABECount.Size = new System.Drawing.Size(48, 18);
            this.lblABECount.TabIndex = 26;
            this.lblABECount.Text = "label1";
            // 
            // txtSBArticle
            // 
            this.txtSBArticle.Location = new System.Drawing.Point(6, 31);
            this.txtSBArticle.Name = "txtSBArticle";
            this.txtSBArticle.Size = new System.Drawing.Size(258, 28);
            this.txtSBArticle.TabIndex = 25;
            // 
            // dgvEBonArticle
            // 
            this.dgvEBonArticle.AllowUserToAddRows = false;
            this.dgvEBonArticle.AllowUserToDeleteRows = false;
            this.dgvEBonArticle.AllowUserToOrderColumns = true;
            this.dgvEBonArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEBonArticle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEBonArticle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEBonArticle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEBonArticle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvEBonArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEBonArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colbe_A_ID,
            this.colbe_A_Date,
            this.colpne_Designation,
            this.colpne_ID,
            this.colbe_Qte_Livree,
            this.colbe_ID_Article,
            this.colbe_A_Description});
            this.dgvEBonArticle.GridColor = System.Drawing.SystemColors.Control;
            this.dgvEBonArticle.Location = new System.Drawing.Point(6, 92);
            this.dgvEBonArticle.MultiSelect = false;
            this.dgvEBonArticle.Name = "dgvEBonArticle";
            this.dgvEBonArticle.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEBonArticle.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEBonArticle.RowHeadersVisible = false;
            this.dgvEBonArticle.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEBonArticle.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEBonArticle.RowTemplate.Height = 24;
            this.dgvEBonArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEBonArticle.Size = new System.Drawing.Size(946, 347);
            this.dgvEBonArticle.TabIndex = 20;
            // 
            // colbe_A_ID
            // 
            this.colbe_A_ID.DataPropertyName = "be_A_ID";
            this.colbe_A_ID.HeaderText = "code bon article";
            this.colbe_A_ID.Name = "colbe_A_ID";
            this.colbe_A_ID.ReadOnly = true;
            this.colbe_A_ID.Visible = false;
            // 
            // colbe_A_Date
            // 
            this.colbe_A_Date.DataPropertyName = "be_A_Date";
            this.colbe_A_Date.HeaderText = "Date";
            this.colbe_A_Date.Name = "colbe_A_Date";
            this.colbe_A_Date.ReadOnly = true;
            this.colbe_A_Date.Visible = false;
            // 
            // colpne_Designation
            // 
            this.colpne_Designation.DataPropertyName = "pne_Designation";
            this.colpne_Designation.HeaderText = "Pneu";
            this.colpne_Designation.Name = "colpne_Designation";
            this.colpne_Designation.ReadOnly = true;
            // 
            // colpne_ID
            // 
            this.colpne_ID.DataPropertyName = "pne_ID";
            this.colpne_ID.HeaderText = "code pneu";
            this.colpne_ID.Name = "colpne_ID";
            this.colpne_ID.ReadOnly = true;
            this.colpne_ID.Visible = false;
            // 
            // colbe_Qte_Livree
            // 
            this.colbe_Qte_Livree.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colbe_Qte_Livree.DataPropertyName = "be_Qte_Livree";
            this.colbe_Qte_Livree.HeaderText = "Qte Livree";
            this.colbe_Qte_Livree.Name = "colbe_Qte_Livree";
            this.colbe_Qte_Livree.ReadOnly = true;
            this.colbe_Qte_Livree.Width = 114;
            // 
            // colbe_ID_Article
            // 
            this.colbe_ID_Article.DataPropertyName = "be_ID";
            this.colbe_ID_Article.HeaderText = "code bon";
            this.colbe_ID_Article.Name = "colbe_ID_Article";
            this.colbe_ID_Article.ReadOnly = true;
            this.colbe_ID_Article.Visible = false;
            // 
            // colbe_A_Description
            // 
            this.colbe_A_Description.DataPropertyName = "be_A_Description";
            this.colbe_A_Description.HeaderText = "Description";
            this.colbe_A_Description.Name = "colbe_A_Description";
            this.colbe_A_Description.ReadOnly = true;
            this.colbe_A_Description.Visible = false;
            // 
            // frmPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPermission";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permission";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEBonArticle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblABECount;
        private System.Windows.Forms.TextBox txtSBArticle;
        public System.Windows.Forms.DataGridView dgvEBonArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_A_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_A_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpne_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpne_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Qte_Livree;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_ID_Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_A_Description;
    }
}