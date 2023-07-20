namespace Gestion.Forms.Sub
{
    partial class frmStock
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.entreesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colpne_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmvt_Qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuDGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvStock);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 551);
            this.groupBox1.TabIndex = 0;
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
            this.colpne_Designation,
            this.colmvt_Qte});
            this.dgvStock.GridColor = System.Drawing.SystemColors.Control;
            this.dgvStock.Location = new System.Drawing.Point(6, 27);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStock.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(946, 518);
            this.dgvStock.TabIndex = 21;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
            this.dgvStock.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvStock_CellContextMenuStripNeeded);
            this.dgvStock.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStock_CellMouseDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(499, 72);
            this.groupBox3.TabIndex = 3;
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
            // menuDGV
            // 
            this.menuDGV.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entreesToolStripMenuItem,
            this.sortiesToolStripMenuItem,
            this.retoursToolStripMenuItem});
            this.menuDGV.Name = "menuDGV";
            this.menuDGV.Size = new System.Drawing.Size(129, 76);
            // 
            // entreesToolStripMenuItem
            // 
            this.entreesToolStripMenuItem.Name = "entreesToolStripMenuItem";
            this.entreesToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.entreesToolStripMenuItem.Text = "Entrees";
            this.entreesToolStripMenuItem.Click += new System.EventHandler(this.entreesToolStripMenuItem_Click);
            // 
            // sortiesToolStripMenuItem
            // 
            this.sortiesToolStripMenuItem.Name = "sortiesToolStripMenuItem";
            this.sortiesToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.sortiesToolStripMenuItem.Text = "Sorties";
            this.sortiesToolStripMenuItem.Click += new System.EventHandler(this.sortiesToolStripMenuItem_Click);
            // 
            // retoursToolStripMenuItem
            // 
            this.retoursToolStripMenuItem.Name = "retoursToolStripMenuItem";
            this.retoursToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.retoursToolStripMenuItem.Text = "Retours";
            this.retoursToolStripMenuItem.Click += new System.EventHandler(this.retoursToolStripMenuItem_Click);
            // 
            // colpne_Designation
            // 
            this.colpne_Designation.DataPropertyName = "pne_Designation";
            this.colpne_Designation.FillWeight = 98.47716F;
            this.colpne_Designation.HeaderText = "Pneu";
            this.colpne_Designation.Name = "colpne_Designation";
            this.colpne_Designation.ReadOnly = true;
            // 
            // colmvt_Qte
            // 
            this.colmvt_Qte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colmvt_Qte.DataPropertyName = "mvt_Qte";
            this.colmvt_Qte.FillWeight = 101.5228F;
            this.colmvt_Qte.HeaderText = "Reste";
            this.colmvt_Qte.Name = "colmvt_Qte";
            this.colmvt_Qte.ReadOnly = true;
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStock";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuDGV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip menuDGV;
        private System.Windows.Forms.ToolStripMenuItem entreesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retoursToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpne_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmvt_Qte;
    }
}