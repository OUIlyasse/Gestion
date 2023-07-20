namespace Gestion.Forms.Sub
{
    partial class frmHistoriqueRBon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRBonArticleH = new System.Windows.Forms.DataGridView();
            this.colbr_A_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbr_A_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpne_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbr_Qte_Livree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbr_ID_Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpne_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbr_A_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRBonH = new System.Windows.Forms.DataGridView();
            this.colbr_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbr_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbr_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbr_Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbr_PV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunt_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbr_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCBon = new System.Windows.Forms.Label();
            this.txtSBon = new System.Windows.Forms.TextBox();
            this.lblCArticle = new System.Windows.Forms.Label();
            this.txtSArticle = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRBonArticleH)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRBonH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblCArticle);
            this.groupBox2.Controls.Add(this.txtSArticle);
            this.groupBox2.Controls.Add(this.dgvRBonArticleH);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 629);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Articles";
            // 
            // dgvRBonArticleH
            // 
            this.dgvRBonArticleH.AllowUserToAddRows = false;
            this.dgvRBonArticleH.AllowUserToDeleteRows = false;
            this.dgvRBonArticleH.AllowUserToOrderColumns = true;
            this.dgvRBonArticleH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRBonArticleH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRBonArticleH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRBonArticleH.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRBonArticleH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvRBonArticleH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRBonArticleH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colbr_A_ID,
            this.colbr_A_Date,
            this.colpne_Designation,
            this.colbr_Qte_Livree,
            this.colbr_ID_Article,
            this.colpne_ID,
            this.colbr_A_Description});
            this.dgvRBonArticleH.GridColor = System.Drawing.SystemColors.Control;
            this.dgvRBonArticleH.Location = new System.Drawing.Point(6, 99);
            this.dgvRBonArticleH.MultiSelect = false;
            this.dgvRBonArticleH.Name = "dgvRBonArticleH";
            this.dgvRBonArticleH.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRBonArticleH.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRBonArticleH.RowHeadersVisible = false;
            this.dgvRBonArticleH.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRBonArticleH.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvRBonArticleH.RowTemplate.Height = 24;
            this.dgvRBonArticleH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRBonArticleH.Size = new System.Drawing.Size(740, 524);
            this.dgvRBonArticleH.TabIndex = 21;
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
            this.groupBox1.Controls.Add(this.dgvRBonH);
            this.groupBox1.Controls.Add(this.txtSBon);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 629);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historique";
            // 
            // dgvRBonH
            // 
            this.dgvRBonH.AllowUserToAddRows = false;
            this.dgvRBonH.AllowUserToDeleteRows = false;
            this.dgvRBonH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRBonH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRBonH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRBonH.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRBonH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvRBonH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRBonH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colbr_ID,
            this.colbr_Date,
            this.colbr_Designation,
            this.colbr_Reference,
            this.colbr_PV,
            this.colunt_ID,
            this.colbr_Description});
            this.dgvRBonH.GridColor = System.Drawing.SystemColors.Control;
            this.dgvRBonH.Location = new System.Drawing.Point(9, 99);
            this.dgvRBonH.MultiSelect = false;
            this.dgvRBonH.Name = "dgvRBonH";
            this.dgvRBonH.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRBonH.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvRBonH.RowHeadersVisible = false;
            this.dgvRBonH.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRBonH.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvRBonH.RowTemplate.Height = 24;
            this.dgvRBonH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRBonH.Size = new System.Drawing.Size(188, 524);
            this.dgvRBonH.TabIndex = 22;
            this.dgvRBonH.SelectionChanged += new System.EventHandler(this.dgvEBonH_SelectionChanged);
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
            this.lblCBon.Location = new System.Drawing.Point(9, 60);
            this.lblCBon.Name = "lblCBon";
            this.lblCBon.Size = new System.Drawing.Size(48, 18);
            this.lblCBon.TabIndex = 27;
            this.lblCBon.Text = "label2";
            // 
            // txtSBon
            // 
            this.txtSBon.Location = new System.Drawing.Point(9, 29);
            this.txtSBon.Name = "txtSBon";
            this.txtSBon.Size = new System.Drawing.Size(188, 28);
            this.txtSBon.TabIndex = 25;
            this.txtSBon.TextChanged += new System.EventHandler(this.txtSBon_TextChanged);
            // 
            // lblCArticle
            // 
            this.lblCArticle.AutoSize = true;
            this.lblCArticle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCArticle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCArticle.Location = new System.Drawing.Point(6, 58);
            this.lblCArticle.Name = "lblCArticle";
            this.lblCArticle.Size = new System.Drawing.Size(48, 18);
            this.lblCArticle.TabIndex = 26;
            this.lblCArticle.Text = "label1";
            // 
            // txtSArticle
            // 
            this.txtSArticle.Location = new System.Drawing.Point(6, 27);
            this.txtSArticle.Name = "txtSArticle";
            this.txtSArticle.Size = new System.Drawing.Size(319, 28);
            this.txtSArticle.TabIndex = 24;
            this.txtSArticle.TextChanged += new System.EventHandler(this.txtSArticle_TextChanged);
            // 
            // frmHistoriqueRBon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmHistoriqueRBon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historique des bons de retour";
            this.Activated += new System.EventHandler(this.frmHistoriqueRBon_Activated);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRBonArticleH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRBonH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvRBonArticleH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_A_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_A_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpne_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_Qte_Livree;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_ID_Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpne_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_A_Description;
        public System.Windows.Forms.DataGridView dgvRBonH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_PV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunt_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbr_Description;
        private System.Windows.Forms.Label lblCArticle;
        private System.Windows.Forms.TextBox txtSArticle;
        private System.Windows.Forms.Label lblCBon;
        private System.Windows.Forms.TextBox txtSBon;
    }
}