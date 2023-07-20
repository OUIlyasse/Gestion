namespace Gestion.Forms.Sub
{
    partial class frmHistoriqueEBon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEBonArticleH = new System.Windows.Forms.DataGridView();
            this.colbe_A_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_A_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpne_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpne_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Qte_Livree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_ID_Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_A_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEBonH = new System.Windows.Forms.DataGridView();
            this.txtSArticle = new System.Windows.Forms.TextBox();
            this.txtSBon = new System.Windows.Forms.TextBox();
            this.lblCArticle = new System.Windows.Forms.Label();
            this.lblCBon = new System.Windows.Forms.Label();
            this.colbe_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_PV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfrns_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrep_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEBonArticleH)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEBonH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblCArticle);
            this.groupBox2.Controls.Add(this.txtSArticle);
            this.groupBox2.Controls.Add(this.dgvEBonArticleH);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 629);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Articles";
            // 
            // dgvEBonArticleH
            // 
            this.dgvEBonArticleH.AllowUserToAddRows = false;
            this.dgvEBonArticleH.AllowUserToDeleteRows = false;
            this.dgvEBonArticleH.AllowUserToOrderColumns = true;
            this.dgvEBonArticleH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEBonArticleH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEBonArticleH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEBonArticleH.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEBonArticleH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvEBonArticleH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEBonArticleH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colbe_A_ID,
            this.colbe_A_Date,
            this.colpne_Designation,
            this.colpne_ID,
            this.colbe_Qte_Livree,
            this.colbe_ID_Article,
            this.colbe_A_Description});
            this.dgvEBonArticleH.GridColor = System.Drawing.SystemColors.Control;
            this.dgvEBonArticleH.Location = new System.Drawing.Point(6, 99);
            this.dgvEBonArticleH.MultiSelect = false;
            this.dgvEBonArticleH.Name = "dgvEBonArticleH";
            this.dgvEBonArticleH.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEBonArticleH.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEBonArticleH.RowHeadersVisible = false;
            this.dgvEBonArticleH.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEBonArticleH.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEBonArticleH.RowTemplate.Height = 24;
            this.dgvEBonArticleH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEBonArticleH.Size = new System.Drawing.Size(740, 524);
            this.dgvEBonArticleH.TabIndex = 20;
            this.dgvEBonArticleH.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEBonArticleH_CellDoubleClick);
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
            this.colbe_A_Description.HeaderText = "Observation";
            this.colbe_A_Description.Name = "colbe_A_Description";
            this.colbe_A_Description.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblCBon);
            this.groupBox1.Controls.Add(this.txtSBon);
            this.groupBox1.Controls.Add(this.dgvEBonH);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 629);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historique";
            // 
            // dgvEBonH
            // 
            this.dgvEBonH.AllowUserToAddRows = false;
            this.dgvEBonH.AllowUserToDeleteRows = false;
            this.dgvEBonH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEBonH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEBonH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEBonH.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEBonH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvEBonH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEBonH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colbe_ID,
            this.colbe_Date,
            this.colbe_Designation,
            this.colbe_PV,
            this.colbe_Reference,
            this.colfrns_ID,
            this.colrep_ID,
            this.colbe_Description,
            this.colbe_Status});
            this.dgvEBonH.GridColor = System.Drawing.SystemColors.Control;
            this.dgvEBonH.Location = new System.Drawing.Point(6, 99);
            this.dgvEBonH.MultiSelect = false;
            this.dgvEBonH.Name = "dgvEBonH";
            this.dgvEBonH.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEBonH.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEBonH.RowHeadersVisible = false;
            this.dgvEBonH.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEBonH.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEBonH.RowTemplate.Height = 24;
            this.dgvEBonH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEBonH.Size = new System.Drawing.Size(188, 524);
            this.dgvEBonH.TabIndex = 20;
            this.dgvEBonH.SelectionChanged += new System.EventHandler(this.dgvEBonH_SelectionChanged);
            // 
            // txtSArticle
            // 
            this.txtSArticle.Location = new System.Drawing.Point(6, 28);
            this.txtSArticle.Name = "txtSArticle";
            this.txtSArticle.Size = new System.Drawing.Size(319, 28);
            this.txtSArticle.TabIndex = 21;
            this.txtSArticle.TextChanged += new System.EventHandler(this.txtSArticle_TextChanged);
            // 
            // txtSBon
            // 
            this.txtSBon.Location = new System.Drawing.Point(6, 28);
            this.txtSBon.Name = "txtSBon";
            this.txtSBon.Size = new System.Drawing.Size(188, 28);
            this.txtSBon.TabIndex = 22;
            this.txtSBon.TextChanged += new System.EventHandler(this.txtSBon_TextChanged);
            // 
            // lblCArticle
            // 
            this.lblCArticle.AutoSize = true;
            this.lblCArticle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCArticle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCArticle.Location = new System.Drawing.Point(6, 59);
            this.lblCArticle.Name = "lblCArticle";
            this.lblCArticle.Size = new System.Drawing.Size(48, 18);
            this.lblCArticle.TabIndex = 22;
            this.lblCArticle.Text = "label1";
            // 
            // lblCBon
            // 
            this.lblCBon.AutoSize = true;
            this.lblCBon.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCBon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCBon.Location = new System.Drawing.Point(6, 59);
            this.lblCBon.Name = "lblCBon";
            this.lblCBon.Size = new System.Drawing.Size(48, 18);
            this.lblCBon.TabIndex = 23;
            this.lblCBon.Text = "label2";
            // 
            // colbe_ID
            // 
            this.colbe_ID.DataPropertyName = "be_ID";
            this.colbe_ID.HeaderText = "code Bon";
            this.colbe_ID.Name = "colbe_ID";
            this.colbe_ID.ReadOnly = true;
            this.colbe_ID.Visible = false;
            // 
            // colbe_Date
            // 
            this.colbe_Date.DataPropertyName = "be_Date";
            this.colbe_Date.HeaderText = "Date";
            this.colbe_Date.Name = "colbe_Date";
            this.colbe_Date.ReadOnly = true;
            this.colbe_Date.Visible = false;
            // 
            // colbe_Designation
            // 
            this.colbe_Designation.DataPropertyName = "be_Designation";
            this.colbe_Designation.HeaderText = "BL";
            this.colbe_Designation.Name = "colbe_Designation";
            this.colbe_Designation.ReadOnly = true;
            // 
            // colbe_PV
            // 
            this.colbe_PV.DataPropertyName = "be_PV";
            this.colbe_PV.HeaderText = "PV";
            this.colbe_PV.Name = "colbe_PV";
            this.colbe_PV.ReadOnly = true;
            this.colbe_PV.Visible = false;
            // 
            // colbe_Reference
            // 
            this.colbe_Reference.DataPropertyName = "be_Reference";
            this.colbe_Reference.HeaderText = "Reference";
            this.colbe_Reference.Name = "colbe_Reference";
            this.colbe_Reference.ReadOnly = true;
            this.colbe_Reference.Visible = false;
            // 
            // colfrns_ID
            // 
            this.colfrns_ID.DataPropertyName = "frns_ID";
            this.colfrns_ID.HeaderText = "code fournisseur";
            this.colfrns_ID.Name = "colfrns_ID";
            this.colfrns_ID.ReadOnly = true;
            this.colfrns_ID.Visible = false;
            // 
            // colrep_ID
            // 
            this.colrep_ID.DataPropertyName = "rep_ID";
            this.colrep_ID.HeaderText = "code repres.";
            this.colrep_ID.Name = "colrep_ID";
            this.colrep_ID.ReadOnly = true;
            this.colrep_ID.Visible = false;
            // 
            // colbe_Description
            // 
            this.colbe_Description.DataPropertyName = "be_Description";
            this.colbe_Description.HeaderText = "Description";
            this.colbe_Description.Name = "colbe_Description";
            this.colbe_Description.ReadOnly = true;
            this.colbe_Description.Visible = false;
            // 
            // colbe_Status
            // 
            this.colbe_Status.DataPropertyName = "be_Historique";
            this.colbe_Status.HeaderText = "Status";
            this.colbe_Status.Name = "colbe_Status";
            this.colbe_Status.ReadOnly = true;
            this.colbe_Status.Visible = false;
            // 
            // frmHistoriqueEBon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHistoriqueEBon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historique des bons d\'entrées";
            this.Activated += new System.EventHandler(this.frmHistoriqueEBon_Activated);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEBonArticleH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEBonH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvEBonArticleH;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvEBonH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_A_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_A_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpne_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpne_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Qte_Livree;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_ID_Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_A_Description;
        private System.Windows.Forms.TextBox txtSArticle;
        private System.Windows.Forms.TextBox txtSBon;
        private System.Windows.Forms.Label lblCArticle;
        private System.Windows.Forms.Label lblCBon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_PV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfrns_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colrep_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Status;
    }
}