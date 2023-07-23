namespace Gestion.Forms.Sub
{
    partial class frmBRData
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBStatus = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.pbBStatus = new System.Windows.Forms.ProgressBar();
            this.txtBPath = new System.Windows.Forms.TextBox();
            this.btnBBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRStatus = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.pbRStatus = new System.Windows.Forms.ProgressBar();
            this.txtRPath = new System.Windows.Forms.TextBox();
            this.btnRBrowse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBStatus);
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Controls.Add(this.pbBStatus);
            this.groupBox1.Controls.Add(this.txtBPath);
            this.groupBox1.Controls.Add(this.btnBBrowse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sauvegarde les données";
            // 
            // lblBStatus
            // 
            this.lblBStatus.Location = new System.Drawing.Point(485, 118);
            this.lblBStatus.Name = "lblBStatus";
            this.lblBStatus.Size = new System.Drawing.Size(111, 20);
            this.lblBStatus.TabIndex = 4;
            this.lblBStatus.Text = "100%";
            this.lblBStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBStatus.Visible = false;
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("Roboto Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(433, 197);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(214, 56);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "&Sauvegarder";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // pbBStatus
            // 
            this.pbBStatus.Location = new System.Drawing.Point(224, 141);
            this.pbBStatus.Name = "pbBStatus";
            this.pbBStatus.Size = new System.Drawing.Size(582, 26);
            this.pbBStatus.TabIndex = 2;
            this.pbBStatus.Visible = false;
            this.pbBStatus.Click += new System.EventHandler(this.pbBStatus_Click);
            // 
            // txtBPath
            // 
            this.txtBPath.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBPath.Location = new System.Drawing.Point(224, 52);
            this.txtBPath.Name = "txtBPath";
            this.txtBPath.Size = new System.Drawing.Size(582, 28);
            this.txtBPath.TabIndex = 2;
            // 
            // btnBBrowse
            // 
            this.btnBBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBBrowse.FlatAppearance.BorderSize = 0;
            this.btnBBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBBrowse.Image = global::Gestion.Properties.Resources.Folder_36px;
            this.btnBBrowse.Location = new System.Drawing.Point(817, 47);
            this.btnBBrowse.Name = "btnBBrowse";
            this.btnBBrowse.Size = new System.Drawing.Size(38, 38);
            this.btnBBrowse.TabIndex = 1;
            this.btnBBrowse.UseVisualStyleBackColor = true;
            this.btnBBrowse.Click += new System.EventHandler(this.btnBBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emplacement";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblRStatus);
            this.groupBox2.Controls.Add(this.btnRestore);
            this.groupBox2.Controls.Add(this.pbRStatus);
            this.groupBox2.Controls.Add(this.txtRPath);
            this.groupBox2.Controls.Add(this.btnRBrowse);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(958, 290);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restauration les données";
            // 
            // lblRStatus
            // 
            this.lblRStatus.Location = new System.Drawing.Point(485, 119);
            this.lblRStatus.Name = "lblRStatus";
            this.lblRStatus.Size = new System.Drawing.Size(111, 20);
            this.lblRStatus.TabIndex = 10;
            this.lblRStatus.Text = "100%";
            this.lblRStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRStatus.Visible = false;
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Roboto Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Location = new System.Drawing.Point(433, 198);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(214, 56);
            this.btnRestore.TabIndex = 9;
            this.btnRestore.Text = "&Restaurer";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // pbRStatus
            // 
            this.pbRStatus.Location = new System.Drawing.Point(224, 142);
            this.pbRStatus.Name = "pbRStatus";
            this.pbRStatus.Size = new System.Drawing.Size(582, 26);
            this.pbRStatus.TabIndex = 7;
            this.pbRStatus.Visible = false;
            // 
            // txtRPath
            // 
            this.txtRPath.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRPath.Location = new System.Drawing.Point(224, 53);
            this.txtRPath.Name = "txtRPath";
            this.txtRPath.Size = new System.Drawing.Size(582, 28);
            this.txtRPath.TabIndex = 8;
            // 
            // btnRBrowse
            // 
            this.btnRBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRBrowse.FlatAppearance.BorderSize = 0;
            this.btnRBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRBrowse.Image = global::Gestion.Properties.Resources.Folder_36px;
            this.btnRBrowse.Location = new System.Drawing.Point(817, 48);
            this.btnRBrowse.Name = "btnRBrowse";
            this.btnRBrowse.Size = new System.Drawing.Size(38, 38);
            this.btnRBrowse.TabIndex = 6;
            this.btnRBrowse.UseVisualStyleBackColor = true;
            this.btnRBrowse.Click += new System.EventHandler(this.btnRBrowse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Emplacement";
            // 
            // frmBRData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBRData";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sauvegarde et restauration des données";
            this.Load += new System.EventHandler(this.frmBRData_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.ProgressBar pbBStatus;
        private System.Windows.Forms.TextBox txtBPath;
        private System.Windows.Forms.Button btnBBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBStatus;
        private System.Windows.Forms.Label lblRStatus;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.ProgressBar pbRStatus;
        private System.Windows.Forms.TextBox txtRPath;
        private System.Windows.Forms.Button btnRBrowse;
        private System.Windows.Forms.Label label4;
    }
}