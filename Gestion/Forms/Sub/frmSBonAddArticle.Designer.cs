namespace Gestion.Forms.Sub
{
    partial class frmSBonAddArticle
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
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblQte = new System.Windows.Forms.Label();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.cmbxPneu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblQte);
            this.gbInfo.Controls.Add(this.txtQte);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.txtDescription);
            this.gbInfo.Controls.Add(this.cmbxPneu);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.gbInfo.Location = new System.Drawing.Point(12, 24);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(666, 253);
            this.gbInfo.TabIndex = 8;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Information";
            // 
            // lblQte
            // 
            this.lblQte.AutoSize = true;
            this.lblQte.Location = new System.Drawing.Point(303, 30);
            this.lblQte.Name = "lblQte";
            this.lblQte.Size = new System.Drawing.Size(24, 20);
            this.lblQte.TabIndex = 23;
            this.lblQte.Text = "---";
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(135, 27);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(162, 28);
            this.txtQte.TabIndex = 0;
            this.txtQte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQte_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Quantité";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(135, 114);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(509, 118);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "";
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // cmbxPneu
            // 
            this.cmbxPneu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxPneu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxPneu.DisplayMember = "art_Designation";
            this.cmbxPneu.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.cmbxPneu.FormattingEnabled = true;
            this.cmbxPneu.Location = new System.Drawing.Point(135, 70);
            this.cmbxPneu.Name = "cmbxPneu";
            this.cmbxPneu.Size = new System.Drawing.Size(509, 29);
            this.cmbxPneu.TabIndex = 1;
            this.cmbxPneu.ValueMember = "art_ID";
            this.cmbxPneu.SelectedIndexChanged += new System.EventHandler(this.cmbxPneu_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Référence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Observation";
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Image = global::Gestion.Properties.Resources.Modifier_48;
            this.btnModifier.Location = new System.Drawing.Point(379, 320);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(49, 49);
            this.btnModifier.TabIndex = 10;
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Image = global::Gestion.Properties.Resources.Ajouter_48;
            this.btnAjouter.Location = new System.Drawing.Point(262, 320);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(49, 49);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // frmSBonAddArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 393);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSBonAddArticle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSBonAddArticle_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbxPneu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblQte;
    }
}