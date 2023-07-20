namespace Gestion.Forms.Sub
{
    partial class frmRBon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRBon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPDelete = new System.Windows.Forms.Button();
            this.btnPAdd = new System.Windows.Forms.Button();
            this.dgvSBonArticle = new System.Windows.Forms.DataGridView();
            this.colbr_A_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbr_A_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpne_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbr_Qte_Livree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbr_ID_Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpne_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbr_A_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExploiter = new System.Windows.Forms.Button();
            this.btnBAdd = new System.Windows.Forms.Button();
            this.dgvSBon = new System.Windows.Forms.DataGridView();
            this.colbr_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbr_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbr_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbr_Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbr_PV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunt_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbr_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCBon = new System.Windows.Forms.Label();
            this.txtRBon = new System.Windows.Forms.TextBox();
            this.lblCArticle = new System.Windows.Forms.Label();
            this.txtRArticle = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSBonArticle)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSBon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblCArticle);
            this.groupBox2.Controls.Add(this.txtRArticle);
            this.groupBox2.Controls.Add(this.btnPDelete);
            this.groupBox2.Controls.Add(this.btnPAdd);
            this.groupBox2.Controls.Add(this.dgvSBonArticle);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 629);
            this.groupBox2.TabIndex = 26;
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
            // dgvSBonArticle
            // 
            this.dgvSBonArticle.AllowUserToAddRows = false;
            this.dgvSBonArticle.AllowUserToDeleteRows = false;
            this.dgvSBonArticle.AllowUserToOrderColumns = true;
            this.dgvSBonArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSBonArticle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSBonArticle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSBonArticle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSBonArticle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvSBonArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSBonArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colbr_A_ID,
            this.colbr_A_Date,
            this.colpne_Designation,
            this.colbr_Qte_Livree,
            this.colbr_ID_Article,
            this.colpne_ID,
            this.colbr_A_Description});
            this.dgvSBonArticle.GridColor = System.Drawing.SystemColors.Control;
            this.dgvSBonArticle.Location = new System.Drawing.Point(6, 92);
            this.dgvSBonArticle.MultiSelect = false;
            this.dgvSBonArticle.Name = "dgvSBonArticle";
            this.dgvSBonArticle.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSBonArticle.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvSBonArticle.RowHeadersVisible = false;
            this.dgvSBonArticle.RowHeadersWidth = 51;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSBonArticle.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvSBonArticle.RowTemplate.Height = 24;
            this.dgvSBonArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSBonArticle.Size = new System.Drawing.Size(740, 531);
            this.dgvSBonArticle.TabIndex = 20;
            this.dgvSBonArticle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSBonArticle_CellDoubleClick);
            this.dgvSBonArticle.SelectionChanged += new System.EventHandler(this.dgvSBonArticle_SelectionChanged);
            // 
            // colbr_A_ID
            // 
            this.colbr_A_ID.DataPropertyName = "br_A_ID";
            this.colbr_A_ID.HeaderText = "code bon article";
            this.colbr_A_ID.Name = "colbr_A_ID";
            this.colbr_A_ID.ReadOnly = true;
            this.colbr_A_ID.Visible = false;
            // 
            // colbr_A_Date
            // 
            this.colbr_A_Date.DataPropertyName = "br_A_Date";
            this.colbr_A_Date.HeaderText = "Date";
            this.colbr_A_Date.Name = "colbr_A_Date";
            this.colbr_A_Date.ReadOnly = true;
            this.colbr_A_Date.Visible = false;
            // 
            // colpne_Designation
            // 
            this.colpne_Designation.DataPropertyName = "pne_Designation";
            this.colpne_Designation.HeaderText = "Pneu";
            this.colpne_Designation.Name = "colpne_Designation";
            this.colpne_Designation.ReadOnly = true;
            // 
            // colbr_Qte_Livree
            // 
            this.colbr_Qte_Livree.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colbr_Qte_Livree.DataPropertyName = "br_Qte_Livree";
            this.colbr_Qte_Livree.HeaderText = "Qte reçue";
            this.colbr_Qte_Livree.Name = "colbr_Qte_Livree";
            this.colbr_Qte_Livree.ReadOnly = true;
            this.colbr_Qte_Livree.Width = 111;
            // 
            // colbr_ID_Article
            // 
            this.colbr_ID_Article.DataPropertyName = "br_ID";
            this.colbr_ID_Article.HeaderText = "code bon";
            this.colbr_ID_Article.Name = "colbr_ID_Article";
            this.colbr_ID_Article.ReadOnly = true;
            this.colbr_ID_Article.Visible = false;
            // 
            // colpne_ID
            // 
            this.colpne_ID.DataPropertyName = "pne_ID";
            this.colpne_ID.HeaderText = "code pneu";
            this.colpne_ID.Name = "colpne_ID";
            this.colpne_ID.ReadOnly = true;
            this.colpne_ID.Visible = false;
            // 
            // colbr_A_Description
            // 
            this.colbr_A_Description.DataPropertyName = "br_A_Description";
            this.colbr_A_Description.HeaderText = "Observation";
            this.colbr_A_Description.Name = "colbr_A_Description";
            this.colbr_A_Description.ReadOnly = true;
            this.colbr_A_Description.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblCBon);
            this.groupBox1.Controls.Add(this.txtRBon);
            this.groupBox1.Controls.Add(this.btnExploiter);
            this.groupBox1.Controls.Add(this.btnBAdd);
            this.groupBox1.Controls.Add(this.dgvSBon);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 629);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bons de retour";
            // 
            // btnExploiter
            // 
            this.btnExploiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExploiter.Enabled = false;
            this.btnExploiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExploiter.Location = new System.Drawing.Point(6, 92);
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
            this.btnBAdd.Location = new System.Drawing.Point(160, 92);
            this.btnBAdd.Name = "btnBAdd";
            this.btnBAdd.Size = new System.Drawing.Size(34, 34);
            this.btnBAdd.TabIndex = 23;
            this.btnBAdd.UseVisualStyleBackColor = true;
            this.btnBAdd.Click += new System.EventHandler(this.btnBAdd_Click);
            // 
            // dgvSBon
            // 
            this.dgvSBon.AllowUserToAddRows = false;
            this.dgvSBon.AllowUserToDeleteRows = false;
            this.dgvSBon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSBon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSBon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSBon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSBon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvSBon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSBon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colbr_ID,
            this.colbr_Date,
            this.colbr_Designation,
            this.colbr_Reference,
            this.colbr_PV,
            this.colunt_ID,
            this.colbr_Description});
            this.dgvSBon.GridColor = System.Drawing.SystemColors.Control;
            this.dgvSBon.Location = new System.Drawing.Point(6, 132);
            this.dgvSBon.MultiSelect = false;
            this.dgvSBon.Name = "dgvSBon";
            this.dgvSBon.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSBon.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvSBon.RowHeadersVisible = false;
            this.dgvSBon.RowHeadersWidth = 51;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSBon.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvSBon.RowTemplate.Height = 24;
            this.dgvSBon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSBon.Size = new System.Drawing.Size(188, 491);
            this.dgvSBon.TabIndex = 20;
            this.dgvSBon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSBon_CellDoubleClick);
            this.dgvSBon.SelectionChanged += new System.EventHandler(this.dgvSBon_SelectionChanged);
            // 
            // colbr_ID
            // 
            this.colbr_ID.DataPropertyName = "br_ID";
            this.colbr_ID.HeaderText = "code bon";
            this.colbr_ID.Name = "colbr_ID";
            this.colbr_ID.ReadOnly = true;
            this.colbr_ID.Visible = false;
            // 
            // colbr_Date
            // 
            this.colbr_Date.DataPropertyName = "br_Date";
            this.colbr_Date.HeaderText = "Date";
            this.colbr_Date.Name = "colbr_Date";
            this.colbr_Date.ReadOnly = true;
            this.colbr_Date.Visible = false;
            // 
            // colbr_Designation
            // 
            this.colbr_Designation.DataPropertyName = "br_Designation";
            this.colbr_Designation.HeaderText = "BL";
            this.colbr_Designation.Name = "colbr_Designation";
            this.colbr_Designation.ReadOnly = true;
            // 
            // colbr_Reference
            // 
            this.colbr_Reference.DataPropertyName = "br_Reference";
            this.colbr_Reference.HeaderText = "Référence";
            this.colbr_Reference.Name = "colbr_Reference";
            this.colbr_Reference.ReadOnly = true;
            this.colbr_Reference.Visible = false;
            // 
            // colbr_PV
            // 
            this.colbr_PV.DataPropertyName = "br_PV";
            this.colbr_PV.HeaderText = "PV";
            this.colbr_PV.Name = "colbr_PV";
            this.colbr_PV.ReadOnly = true;
            this.colbr_PV.Visible = false;
            // 
            // colunt_ID
            // 
            this.colunt_ID.DataPropertyName = "unt_ID";
            this.colunt_ID.HeaderText = "code unite";
            this.colunt_ID.Name = "colunt_ID";
            this.colunt_ID.ReadOnly = true;
            this.colunt_ID.Visible = false;
            // 
            // colbr_Description
            // 
            this.colbr_Description.DataPropertyName = "br_Description";
            this.colbr_Description.HeaderText = "Description";
            this.colbr_Description.Name = "colbr_Description";
            this.colbr_Description.ReadOnly = true;
            this.colbr_Description.Visible = false;
            // 
            // lblCBon
            // 
            this.lblCBon.AutoSize = true;
            this.lblCBon.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCBon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCBon.Location = new System.Drawing.Point(6, 65);
            this.lblCBon.Name = "lblCBon";
            this.lblCBon.Size = new System.Drawing.Size(48, 18);
            this.lblCBon.TabIndex = 29;
            this.lblCBon.Text = "label2";
            // 
            // txtRBon
            // 
            this.txtRBon.Location = new System.Drawing.Point(6, 34);
            this.txtRBon.Name = "txtRBon";
            this.txtRBon.Size = new System.Drawing.Size(188, 28);
            this.txtRBon.TabIndex = 28;
            this.txtRBon.TextChanged += new System.EventHandler(this.txtRBon_TextChanged);
            // 
            // lblCArticle
            // 
            this.lblCArticle.AutoSize = true;
            this.lblCArticle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCArticle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCArticle.Location = new System.Drawing.Point(6, 65);
            this.lblCArticle.Name = "lblCArticle";
            this.lblCArticle.Size = new System.Drawing.Size(48, 18);
            this.lblCArticle.TabIndex = 28;
            this.lblCArticle.Text = "label1";
            // 
            // txtRArticle
            // 
            this.txtRArticle.Location = new System.Drawing.Point(6, 34);
            this.txtRArticle.Name = "txtRArticle";
            this.txtRArticle.Size = new System.Drawing.Size(319, 28);
            this.txtRArticle.TabIndex = 27;
            this.txtRArticle.TextChanged += new System.EventHandler(this.txtRArticle_TextChanged);
            // 
            // frmRBon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmRBon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bons de retour courants";
            this.Activated += new System.EventHandler(this.frmRBon_Activated);
            this.Load += new System.EventHandler(this.frmRBon_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSBonArticle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSBon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPDelete;
        private System.Windows.Forms.Button btnPAdd;
        public System.Windows.Forms.DataGridView dgvSBonArticle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExploiter;
        private System.Windows.Forms.Button btnBAdd;
        public System.Windows.Forms.DataGridView dgvSBon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_A_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_A_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpne_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_Qte_Livree;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_ID_Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpne_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_A_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_PV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunt_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_Description;
        private System.Windows.Forms.Label lblCBon;
        private System.Windows.Forms.TextBox txtRBon;
        private System.Windows.Forms.Label lblCArticle;
        private System.Windows.Forms.TextBox txtRArticle;
    }
}