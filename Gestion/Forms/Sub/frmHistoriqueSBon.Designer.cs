namespace Gestion.Forms.Sub
{
    partial class frmHistoriqueSBon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSBonArticleH = new System.Windows.Forms.DataGridView();
            this.colbs_A_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbs_A_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpne_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpne_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbs_Qte_Livree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbs_ID_Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbs_A_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSBonH = new System.Windows.Forms.DataGridView();
            this.colbs_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbs_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbs_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbs_Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunt_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbs_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCArticle = new System.Windows.Forms.Label();
            this.txtSArticle = new System.Windows.Forms.TextBox();
            this.lblCBon = new System.Windows.Forms.Label();
            this.txtSBon = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSBonArticleH)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSBonH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblCArticle);
            this.groupBox2.Controls.Add(this.txtSArticle);
            this.groupBox2.Controls.Add(this.dgvSBonArticleH);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 629);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Articles";
            // 
            // dgvSBonArticleH
            // 
            this.dgvSBonArticleH.AllowUserToAddRows = false;
            this.dgvSBonArticleH.AllowUserToDeleteRows = false;
            this.dgvSBonArticleH.AllowUserToOrderColumns = true;
            this.dgvSBonArticleH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSBonArticleH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSBonArticleH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSBonArticleH.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSBonArticleH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvSBonArticleH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSBonArticleH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colbs_A_ID,
            this.colbs_A_Date,
            this.colpne_ID,
            this.colpne_Designation,
            this.colbs_Qte_Livree,
            this.colbs_ID_Article,
            this.colbs_A_Description});
            this.dgvSBonArticleH.GridColor = System.Drawing.SystemColors.Control;
            this.dgvSBonArticleH.Location = new System.Drawing.Point(6, 112);
            this.dgvSBonArticleH.MultiSelect = false;
            this.dgvSBonArticleH.Name = "dgvSBonArticleH";
            this.dgvSBonArticleH.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSBonArticleH.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvSBonArticleH.RowHeadersVisible = false;
            this.dgvSBonArticleH.RowHeadersWidth = 51;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSBonArticleH.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvSBonArticleH.RowTemplate.Height = 24;
            this.dgvSBonArticleH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSBonArticleH.Size = new System.Drawing.Size(740, 511);
            this.dgvSBonArticleH.TabIndex = 21;
            // 
            // colbs_A_ID
            // 
            this.colbs_A_ID.DataPropertyName = "bs_A_ID";
            this.colbs_A_ID.HeaderText = "code article";
            this.colbs_A_ID.Name = "colbs_A_ID";
            this.colbs_A_ID.ReadOnly = true;
            this.colbs_A_ID.Visible = false;
            // 
            // colbs_A_Date
            // 
            this.colbs_A_Date.DataPropertyName = "bs_A_Date";
            this.colbs_A_Date.HeaderText = "Date";
            this.colbs_A_Date.Name = "colbs_A_Date";
            this.colbs_A_Date.ReadOnly = true;
            this.colbs_A_Date.Visible = false;
            // 
            // colpne_ID
            // 
            this.colpne_ID.DataPropertyName = "pne_ID";
            this.colpne_ID.HeaderText = "code pneu";
            this.colpne_ID.Name = "colpne_ID";
            this.colpne_ID.ReadOnly = true;
            this.colpne_ID.Visible = false;
            // 
            // colpne_Designation
            // 
            this.colpne_Designation.DataPropertyName = "pne_Designation";
            this.colpne_Designation.HeaderText = "Pneu";
            this.colpne_Designation.Name = "colpne_Designation";
            this.colpne_Designation.ReadOnly = true;
            // 
            // colbs_Qte_Livree
            // 
            this.colbs_Qte_Livree.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colbs_Qte_Livree.DataPropertyName = "bs_Qte_Livree";
            this.colbs_Qte_Livree.HeaderText = "Qte Livree";
            this.colbs_Qte_Livree.Name = "colbs_Qte_Livree";
            this.colbs_Qte_Livree.ReadOnly = true;
            this.colbs_Qte_Livree.Width = 114;
            // 
            // colbs_ID_Article
            // 
            this.colbs_ID_Article.DataPropertyName = "bs_ID";
            this.colbs_ID_Article.HeaderText = "code bon";
            this.colbs_ID_Article.Name = "colbs_ID_Article";
            this.colbs_ID_Article.ReadOnly = true;
            this.colbs_ID_Article.Visible = false;
            // 
            // colbs_A_Description
            // 
            this.colbs_A_Description.DataPropertyName = "bs_A_Description";
            this.colbs_A_Description.HeaderText = "Observation";
            this.colbs_A_Description.Name = "colbs_A_Description";
            this.colbs_A_Description.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblCBon);
            this.groupBox1.Controls.Add(this.txtSBon);
            this.groupBox1.Controls.Add(this.dgvSBonH);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 629);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historique";
            // 
            // dgvSBonH
            // 
            this.dgvSBonH.AllowUserToAddRows = false;
            this.dgvSBonH.AllowUserToDeleteRows = false;
            this.dgvSBonH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSBonH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSBonH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSBonH.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSBonH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvSBonH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSBonH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colbs_ID,
            this.colbs_Date,
            this.colbs_Designation,
            this.colbs_Reference,
            this.colunt_ID,
            this.colbs_Description});
            this.dgvSBonH.GridColor = System.Drawing.SystemColors.Control;
            this.dgvSBonH.Location = new System.Drawing.Point(6, 112);
            this.dgvSBonH.MultiSelect = false;
            this.dgvSBonH.Name = "dgvSBonH";
            this.dgvSBonH.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSBonH.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvSBonH.RowHeadersVisible = false;
            this.dgvSBonH.RowHeadersWidth = 51;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSBonH.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvSBonH.RowTemplate.Height = 24;
            this.dgvSBonH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSBonH.Size = new System.Drawing.Size(188, 511);
            this.dgvSBonH.TabIndex = 21;
            this.dgvSBonH.SelectionChanged += new System.EventHandler(this.dgvEBonH_SelectionChanged);
            // 
            // colbs_ID
            // 
            this.colbs_ID.DataPropertyName = "bs_ID";
            this.colbs_ID.HeaderText = "code bon";
            this.colbs_ID.Name = "colbs_ID";
            this.colbs_ID.ReadOnly = true;
            this.colbs_ID.Visible = false;
            // 
            // colbs_Date
            // 
            this.colbs_Date.DataPropertyName = "bs_Date";
            this.colbs_Date.HeaderText = "Date";
            this.colbs_Date.Name = "colbs_Date";
            this.colbs_Date.ReadOnly = true;
            this.colbs_Date.Visible = false;
            // 
            // colbs_Designation
            // 
            this.colbs_Designation.DataPropertyName = "bs_Designation";
            this.colbs_Designation.HeaderText = "BL";
            this.colbs_Designation.Name = "colbs_Designation";
            this.colbs_Designation.ReadOnly = true;
            // 
            // colbs_Reference
            // 
            this.colbs_Reference.DataPropertyName = "bs_Reference";
            this.colbs_Reference.HeaderText = "Référence";
            this.colbs_Reference.Name = "colbs_Reference";
            this.colbs_Reference.ReadOnly = true;
            this.colbs_Reference.Visible = false;
            // 
            // colunt_ID
            // 
            this.colunt_ID.DataPropertyName = "unt_ID";
            this.colunt_ID.HeaderText = "code unite";
            this.colunt_ID.Name = "colunt_ID";
            this.colunt_ID.ReadOnly = true;
            this.colunt_ID.Visible = false;
            // 
            // colbs_Description
            // 
            this.colbs_Description.DataPropertyName = "bs_Description";
            this.colbs_Description.HeaderText = "Observation";
            this.colbs_Description.Name = "colbs_Description";
            this.colbs_Description.ReadOnly = true;
            this.colbs_Description.Visible = false;
            // 
            // lblCArticle
            // 
            this.lblCArticle.AutoSize = true;
            this.lblCArticle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCArticle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCArticle.Location = new System.Drawing.Point(6, 75);
            this.lblCArticle.Name = "lblCArticle";
            this.lblCArticle.Size = new System.Drawing.Size(48, 18);
            this.lblCArticle.TabIndex = 28;
            this.lblCArticle.Text = "label1";
            // 
            // txtSArticle
            // 
            this.txtSArticle.Location = new System.Drawing.Point(6, 44);
            this.txtSArticle.Name = "txtSArticle";
            this.txtSArticle.Size = new System.Drawing.Size(319, 28);
            this.txtSArticle.TabIndex = 27;
            this.txtSArticle.TextChanged += new System.EventHandler(this.txtSArticle_TextChanged);
            // 
            // lblCBon
            // 
            this.lblCBon.AutoSize = true;
            this.lblCBon.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCBon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCBon.Location = new System.Drawing.Point(6, 75);
            this.lblCBon.Name = "lblCBon";
            this.lblCBon.Size = new System.Drawing.Size(48, 18);
            this.lblCBon.TabIndex = 29;
            this.lblCBon.Text = "label2";
            // 
            // txtSBon
            // 
            this.txtSBon.Location = new System.Drawing.Point(6, 44);
            this.txtSBon.Name = "txtSBon";
            this.txtSBon.Size = new System.Drawing.Size(188, 28);
            this.txtSBon.TabIndex = 28;
            this.txtSBon.TextChanged += new System.EventHandler(this.txtSBon_TextChanged);
            // 
            // frmHistoriqueSBon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmHistoriqueSBon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historique des bons de sortie";
            this.Activated += new System.EventHandler(this.frmHistoriqueSBon_Activated);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSBonArticleH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSBonH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvSBonH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbs_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbs_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbs_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbs_Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunt_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbs_Description;
        public System.Windows.Forms.DataGridView dgvSBonArticleH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbs_A_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbs_A_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpne_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpne_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbs_Qte_Livree;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbs_ID_Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbs_A_Description;
        private System.Windows.Forms.Label lblCArticle;
        private System.Windows.Forms.TextBox txtSArticle;
        private System.Windows.Forms.Label lblCBon;
        private System.Windows.Forms.TextBox txtSBon;
    }
}