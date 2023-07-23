namespace Gestion.Forms.Sub
{
    partial class frmJournal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.lblPneu = new System.Windows.Forms.Label();
            this.colopera_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbon_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colopera_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colopera_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbe_Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpne_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpne_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colopera_Qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRest = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvStock);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 550);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AllowUserToOrderColumns = true;
            this.dgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colopera_ID,
            this.colbon_ID,
            this.colopera_Date,
            this.colopera_Type,
            this.colbe_Designation,
            this.colbe_Reference,
            this.colpne_ID,
            this.colpne_Designation,
            this.colopera_Qte});
            this.dgvStock.GridColor = System.Drawing.SystemColors.Control;
            this.dgvStock.Location = new System.Drawing.Point(6, 27);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStock.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(946, 517);
            this.dgvStock.TabIndex = 21;
            // 
            // lblPneu
            // 
            this.lblPneu.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPneu.Location = new System.Drawing.Point(82, 16);
            this.lblPneu.Name = "lblPneu";
            this.lblPneu.Size = new System.Drawing.Size(818, 46);
            this.lblPneu.TabIndex = 2;
            this.lblPneu.Text = "Pneu";
            this.lblPneu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // colopera_Type
            // 
            this.colopera_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colopera_Type.DataPropertyName = "opera_Type";
            this.colopera_Type.HeaderText = "Opération";
            this.colopera_Type.Name = "colopera_Type";
            this.colopera_Type.ReadOnly = true;
            this.colopera_Type.Width = 130;
            // 
            // colbe_Designation
            // 
            this.colbe_Designation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colbe_Designation.DataPropertyName = "be_Designation";
            this.colbe_Designation.HeaderText = "BL";
            this.colbe_Designation.Name = "colbe_Designation";
            this.colbe_Designation.ReadOnly = true;
            // 
            // colbe_Reference
            // 
            this.colbe_Reference.DataPropertyName = "be_Reference";
            this.colbe_Reference.HeaderText = "Référence";
            this.colbe_Reference.Name = "colbe_Reference";
            this.colbe_Reference.ReadOnly = true;
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
            this.colpne_Designation.HeaderText = "pneu";
            this.colpne_Designation.Name = "colpne_Designation";
            this.colpne_Designation.ReadOnly = true;
            this.colpne_Designation.Visible = false;
            // 
            // colopera_Qte
            // 
            this.colopera_Qte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colopera_Qte.DataPropertyName = "opera_Qte";
            this.colopera_Qte.HeaderText = "Quantité";
            this.colopera_Qte.Name = "colopera_Qte";
            this.colopera_Qte.ReadOnly = true;
            this.colopera_Qte.Width = 120;
            // 
            // lblRest
            // 
            this.lblRest.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRest.ForeColor = System.Drawing.Color.Green;
            this.lblRest.Location = new System.Drawing.Point(316, 63);
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(350, 29);
            this.lblRest.TabIndex = 3;
            this.lblRest.Text = "Pneu";
            this.lblRest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.lblRest);
            this.Controls.Add(this.lblPneu);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJournal";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Journal";
            this.Load += new System.EventHandler(this.frmJournal_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Label lblPneu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colopera_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbon_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colopera_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colopera_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbe_Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpne_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpne_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colopera_Qte;
        private System.Windows.Forms.Label lblRest;
    }
}