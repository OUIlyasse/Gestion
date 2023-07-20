namespace Gestion.Forms.Sub
{
    partial class frmEBon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEBon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEBon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExploiter = new System.Windows.Forms.Button();
            this.btnBAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPDelete = new System.Windows.Forms.Button();
            this.btnPAdd = new System.Windows.Forms.Button();
            this.dgvEBonArticle = new System.Windows.Forms.DataGridView();
            this.colbe_A_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_A_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpne_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpne_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Qte_Livree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_ID_Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_A_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSBArticle = new System.Windows.Forms.TextBox();
            this.txtSBEntree = new System.Windows.Forms.TextBox();
            this.lblABECount = new System.Windows.Forms.Label();
            this.lblBECount = new System.Windows.Forms.Label();
            this.colbe_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_PV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfrns_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrep_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEBon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEBonArticle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEBon
            // 
            this.dgvEBon.AllowUserToAddRows = false;
            this.dgvEBon.AllowUserToDeleteRows = false;
            this.dgvEBon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEBon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEBon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEBon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEBon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvEBon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEBon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colbe_ID,
            this.colbe_Date,
            this.colbe_Designation,
            this.colbe_PV,
            this.colbe_Reference,
            this.colfrns_ID,
            this.colrep_ID,
            this.colbe_Description,
            this.colbe_Status});
            this.dgvEBon.GridColor = System.Drawing.SystemColors.Control;
            this.dgvEBon.Location = new System.Drawing.Point(6, 141);
            this.dgvEBon.MultiSelect = false;
            this.dgvEBon.Name = "dgvEBon";
            this.dgvEBon.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEBon.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEBon.RowHeadersVisible = false;
            this.dgvEBon.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEBon.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEBon.RowTemplate.Height = 24;
            this.dgvEBon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEBon.Size = new System.Drawing.Size(188, 482);
            this.dgvEBon.TabIndex = 20;
            this.dgvEBon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEBon_CellClick);
            this.dgvEBon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEBon_CellDoubleClick);
            this.dgvEBon.SelectionChanged += new System.EventHandler(this.dgvEBon_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblBECount);
            this.groupBox1.Controls.Add(this.txtSBEntree);
            this.groupBox1.Controls.Add(this.btnExploiter);
            this.groupBox1.Controls.Add(this.btnBAdd);
            this.groupBox1.Controls.Add(this.dgvEBon);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 629);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bons d\'entree";
            // 
            // btnExploiter
            // 
            this.btnExploiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExploiter.Enabled = false;
            this.btnExploiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExploiter.Location = new System.Drawing.Point(6, 90);
            this.btnExploiter.Name = "btnExploiter";
            this.btnExploiter.Size = new System.Drawing.Size(99, 34);
            this.btnExploiter.TabIndex = 24;
            this.btnExploiter.Text = "Exploiter";
            this.btnExploiter.UseVisualStyleBackColor = true;
            this.btnExploiter.Click += new System.EventHandler(this.btnExploiter_Click);
            // 
            // btnBAdd
            // 
            this.btnBAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBAdd.FlatAppearance.BorderSize = 0;
            this.btnBAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnBAdd.Image")));
            this.btnBAdd.Location = new System.Drawing.Point(160, 90);
            this.btnBAdd.Name = "btnBAdd";
            this.btnBAdd.Size = new System.Drawing.Size(34, 34);
            this.btnBAdd.TabIndex = 23;
            this.btnBAdd.UseVisualStyleBackColor = true;
            this.btnBAdd.Click += new System.EventHandler(this.btnBAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblABECount);
            this.groupBox2.Controls.Add(this.txtSBArticle);
            this.groupBox2.Controls.Add(this.btnPDelete);
            this.groupBox2.Controls.Add(this.btnPAdd);
            this.groupBox2.Controls.Add(this.dgvEBonArticle);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 629);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Articles";
            // 
            // btnPDelete
            // 
            this.btnPDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDelete.Enabled = false;
            this.btnPDelete.FlatAppearance.BorderSize = 0;
            this.btnPDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDelete.Image = global::Gestion.Properties.Resources.Supprimer_48;
            this.btnPDelete.Location = new System.Drawing.Point(687, 27);
            this.btnPDelete.Name = "btnPDelete";
            this.btnPDelete.Size = new System.Drawing.Size(48, 48);
            this.btnPDelete.TabIndex = 24;
            this.btnPDelete.UseVisualStyleBackColor = true;
            this.btnPDelete.Click += new System.EventHandler(this.btnPDelete_Click);
            // 
            // btnPAdd
            // 
            this.btnPAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPAdd.Enabled = false;
            this.btnPAdd.FlatAppearance.BorderSize = 0;
            this.btnPAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPAdd.Image = global::Gestion.Properties.Resources.Ajouter_48;
            this.btnPAdd.Location = new System.Drawing.Point(614, 27);
            this.btnPAdd.Name = "btnPAdd";
            this.btnPAdd.Size = new System.Drawing.Size(48, 48);
            this.btnPAdd.TabIndex = 23;
            this.btnPAdd.UseVisualStyleBackColor = true;
            this.btnPAdd.Click += new System.EventHandler(this.btnPAdd_Click);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEBonArticle.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEBonArticle.RowHeadersVisible = false;
            this.dgvEBonArticle.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEBonArticle.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEBonArticle.RowTemplate.Height = 24;
            this.dgvEBonArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEBonArticle.Size = new System.Drawing.Size(740, 531);
            this.dgvEBonArticle.TabIndex = 20;
            this.dgvEBonArticle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEBonArticle_CellClick);
            this.dgvEBonArticle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEBonArticle_CellDoubleClick);
            this.dgvEBonArticle.SelectionChanged += new System.EventHandler(this.dgvEBonArticle_SelectionChanged);
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
            // txtSBArticle
            // 
            this.txtSBArticle.Location = new System.Drawing.Point(6, 31);
            this.txtSBArticle.Name = "txtSBArticle";
            this.txtSBArticle.Size = new System.Drawing.Size(258, 28);
            this.txtSBArticle.TabIndex = 25;
            this.txtSBArticle.TextChanged += new System.EventHandler(this.txtSBArticle_TextChanged);
            // 
            // txtSBEntree
            // 
            this.txtSBEntree.Location = new System.Drawing.Point(6, 31);
            this.txtSBEntree.Name = "txtSBEntree";
            this.txtSBEntree.Size = new System.Drawing.Size(188, 28);
            this.txtSBEntree.TabIndex = 26;
            this.txtSBEntree.TextChanged += new System.EventHandler(this.txtSBEntree_TextChanged);
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
            // lblBECount
            // 
            this.lblBECount.AutoSize = true;
            this.lblBECount.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBECount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblBECount.Location = new System.Drawing.Point(6, 62);
            this.lblBECount.Name = "lblBECount";
            this.lblBECount.Size = new System.Drawing.Size(48, 18);
            this.lblBECount.TabIndex = 27;
            this.lblBECount.Text = "label2";
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
            // frmEBon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEBon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bons d\'entrée courants";
            this.Activated += new System.EventHandler(this.frmEBon_Activated);
            this.Load += new System.EventHandler(this.frmEBon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEBon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEBonArticle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvEBon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPDelete;
        private System.Windows.Forms.Button btnPAdd;
        public System.Windows.Forms.DataGridView dgvEBonArticle;
        private System.Windows.Forms.Button btnExploiter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_A_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_A_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpne_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpne_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Qte_Livree;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_ID_Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_A_Description;
        private System.Windows.Forms.TextBox txtSBEntree;
        private System.Windows.Forms.TextBox txtSBArticle;
        private System.Windows.Forms.Label lblBECount;
        private System.Windows.Forms.Label lblABECount;
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