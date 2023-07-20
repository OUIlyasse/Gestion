namespace Gestion.Forms.Sub
{
    partial class frmPneu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnColonne = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.dgvPneu = new System.Windows.Forms.DataGridView();
            this.colvil_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvil_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvil_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObservation = new System.Windows.Forms.RichTextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtProduction = new System.Windows.Forms.DateTimePicker();
            this.menuDGV.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPneu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuDGV
            // 
            this.menuDGV.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnColonne});
            this.menuDGV.Name = "menuDGV";
            this.menuDGV.Size = new System.Drawing.Size(134, 28);
            // 
            // btnColonne
            // 
            this.btnColonne.Name = "btnColonne";
            this.btnColonne.Size = new System.Drawing.Size(133, 24);
            this.btnColonne.Text = "Colonne";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.lblCount);
            this.groupBox3.Controls.Add(this.dgvPneu);
            this.groupBox3.Location = new System.Drawing.Point(498, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 479);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Affichage";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Recherche";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(223, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(279, 28);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Roboto Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCount.Location = new System.Drawing.Point(6, 31);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(21, 20);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "---";
            // 
            // dgvPneu
            // 
            this.dgvPneu.AllowUserToAddRows = false;
            this.dgvPneu.AllowUserToDeleteRows = false;
            this.dgvPneu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPneu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPneu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPneu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPneu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvPneu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPneu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colvil_ID,
            this.colvil_Nom,
            this.colvil_Description});
            this.dgvPneu.ContextMenuStrip = this.menuDGV;
            this.dgvPneu.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPneu.Location = new System.Drawing.Point(6, 61);
            this.dgvPneu.MultiSelect = false;
            this.dgvPneu.Name = "dgvPneu";
            this.dgvPneu.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPneu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPneu.RowHeadersVisible = false;
            this.dgvPneu.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPneu.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPneu.RowTemplate.Height = 24;
            this.dgvPneu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPneu.Size = new System.Drawing.Size(496, 412);
            this.dgvPneu.TabIndex = 1;
            this.dgvPneu.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvVille_CellContextMenuStripNeeded);
            this.dgvPneu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVille_CellDoubleClick);
            // 
            // colvil_ID
            // 
            this.colvil_ID.DataPropertyName = "vil_ID";
            this.colvil_ID.HeaderText = "Code ville";
            this.colvil_ID.Name = "colvil_ID";
            this.colvil_ID.ReadOnly = true;
            this.colvil_ID.Visible = false;
            // 
            // colvil_Nom
            // 
            this.colvil_Nom.DataPropertyName = "vil_Nom";
            this.colvil_Nom.HeaderText = "Ville";
            this.colvil_Nom.Name = "colvil_Nom";
            this.colvil_Nom.ReadOnly = true;
            // 
            // colvil_Description
            // 
            this.colvil_Description.DataPropertyName = "vil_Description";
            this.colvil_Description.HeaderText = "Description";
            this.colvil_Description.Name = "colvil_Description";
            this.colvil_Description.ReadOnly = true;
            this.colvil_Description.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.dtProduction);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMarque);
            this.groupBox2.Controls.Add(this.txtObservation);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtReference);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 373);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // txtObservation
            // 
            this.txtObservation.Location = new System.Drawing.Point(17, 204);
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(420, 130);
            this.txtObservation.TabIndex = 19;
            this.txtObservation.Text = "";
            this.txtObservation.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Image = global::Gestion.Properties.Resources.New_file_28px;
            this.btnNew.Location = new System.Drawing.Point(416, 18);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(28, 28);
            this.btnNew.TabIndex = 12;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Observation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Tag = "";
            this.label1.Text = "Référence";
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(17, 76);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(420, 28);
            this.txtReference.TabIndex = 0;
            this.txtReference.Validating += new System.ComponentModel.CancelEventHandler(this.txtVille_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 21;
            this.label2.Tag = "";
            this.label2.Text = "Marque";
            // 
            // txtMarque
            // 
            this.txtMarque.Location = new System.Drawing.Point(17, 140);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.Size = new System.Drawing.Size(235, 28);
            this.txtMarque.TabIndex = 20;
            this.txtMarque.Validating += new System.ComponentModel.CancelEventHandler(this.txtMarque_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 22;
            this.label5.Tag = "";
            this.label5.Text = "Date production";
            // 
            // dtProduction
            // 
            this.dtProduction.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtProduction.Location = new System.Drawing.Point(270, 140);
            this.dtProduction.Name = "dtProduction";
            this.dtProduction.Size = new System.Drawing.Size(167, 28);
            this.dtProduction.TabIndex = 7;
            // 
            // frmPneu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1018, 503);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmPneu";
            this.Text = "Villes";
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.menuDGV.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPneu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip menuDGV;
        private System.Windows.Forms.ToolStripMenuItem btnColonne;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCount;
        public System.Windows.Forms.DataGridView dgvPneu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvil_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvil_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvil_Description;
        private System.Windows.Forms.RichTextBox txtObservation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarque;
        private System.Windows.Forms.DateTimePicker dtProduction;
    }
}