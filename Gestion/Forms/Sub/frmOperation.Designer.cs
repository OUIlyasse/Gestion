namespace Gestion.Forms.Sub
{
    partial class frmOperation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOperation = new System.Windows.Forms.DataGridView();
            this.lblPneu = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.colopera_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbon_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colopera_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpne_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colopera_Qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperation)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvOperation);
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 459);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dgvOperation
            // 
            this.dgvOperation.AllowUserToAddRows = false;
            this.dgvOperation.AllowUserToDeleteRows = false;
            this.dgvOperation.AllowUserToOrderColumns = true;
            this.dgvOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOperation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOperation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOperation.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOperation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colopera_ID,
            this.colbon_ID,
            this.colopera_Date,
            this.colpne_Designation,
            this.colbe_Designation,
            this.colbe_Reference,
            this.colopera_Qte});
            this.dgvOperation.GridColor = System.Drawing.SystemColors.Control;
            this.dgvOperation.Location = new System.Drawing.Point(6, 27);
            this.dgvOperation.MultiSelect = false;
            this.dgvOperation.Name = "dgvOperation";
            this.dgvOperation.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOperation.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOperation.RowHeadersVisible = false;
            this.dgvOperation.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOperation.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOperation.RowTemplate.Height = 24;
            this.dgvOperation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperation.Size = new System.Drawing.Size(946, 426);
            this.dgvOperation.TabIndex = 21;
            // 
            // lblPneu
            // 
            this.lblPneu.AutoSize = true;
            this.lblPneu.Location = new System.Drawing.Point(12, 15);
            this.lblPneu.Name = "lblPneu";
            this.lblPneu.Size = new System.Drawing.Size(47, 20);
            this.lblPneu.TabIndex = 2;
            this.lblPneu.Text = "Pneu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(465, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(499, 72);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recherche";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(487, 28);
            this.textBox1.TabIndex = 0;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(14, 52);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(122, 20);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type operation";
            // 
            // colopera_ID
            // 
            this.colopera_ID.DataPropertyName = "opera_ID";
            this.colopera_ID.HeaderText = "code operation";
            this.colopera_ID.Name = "colopera_ID";
            this.colopera_ID.ReadOnly = true;
            this.colopera_ID.Visible = false;
            // 
            // colbon_ID
            // 
            this.colbon_ID.DataPropertyName = "bon_ID";
            this.colbon_ID.HeaderText = "code bon";
            this.colbon_ID.Name = "colbon_ID";
            this.colbon_ID.ReadOnly = true;
            this.colbon_ID.Visible = false;
            // 
            // colopera_Date
            // 
            this.colopera_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colopera_Date.DataPropertyName = "opera_Date";
            this.colopera_Date.HeaderText = "Date";
            this.colopera_Date.Name = "colopera_Date";
            this.colopera_Date.ReadOnly = true;
            this.colopera_Date.Width = 150;
            // 
            // colpne_Designation
            // 
            this.colpne_Designation.DataPropertyName = "pne_Designation";
            this.colpne_Designation.HeaderText = "Pneu";
            this.colpne_Designation.Name = "colpne_Designation";
            this.colpne_Designation.ReadOnly = true;
            this.colpne_Designation.Visible = false;
            // 
            // colbe_Designation
            // 
            this.colbe_Designation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colbe_Designation.DataPropertyName = "be_Designation";
            this.colbe_Designation.HeaderText = "BL";
            this.colbe_Designation.Name = "colbe_Designation";
            this.colbe_Designation.ReadOnly = true;
            this.colbe_Designation.Width = 120;
            // 
            // colbe_Reference
            // 
            this.colbe_Reference.DataPropertyName = "be_Reference";
            this.colbe_Reference.HeaderText = "Référence";
            this.colbe_Reference.Name = "colbe_Reference";
            this.colbe_Reference.ReadOnly = true;
            // 
            // colopera_Qte
            // 
            this.colopera_Qte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colopera_Qte.DataPropertyName = "opera_Qte";
            this.colopera_Qte.HeaderText = "Quantité";
            this.colopera_Qte.Name = "colopera_Qte";
            this.colopera_Qte.ReadOnly = true;
            // 
            // frmOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblPneu);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOperation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operations";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperation)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvOperation;
        private System.Windows.Forms.Label lblPneu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colopera_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbon_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colopera_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpne_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colopera_Qte;
    }
}