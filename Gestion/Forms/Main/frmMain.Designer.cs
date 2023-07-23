namespace Gestion.Forms.Main
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emplacementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bonsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.receptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortiesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bonsDeSortieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.retoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bonsDeRetourCloturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.villeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uniteDeSoutienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etatDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hisoriqueDarticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDonneesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serveurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegardeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.bonsToolStripMenuItem1,
            this.sortiesToolStripMenuItem1,
            this.retoursToolStripMenuItem,
            this.utilitaireToolStripMenuItem,
            this.rapportToolStripMenuItem,
            this.baseDeDonneesToolStripMenuItem,
            this.permissionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem,
            this.articleToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.fichierToolStripMenuItem.Text = "Gestion";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // articleToolStripMenuItem
            // 
            this.articleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.emplacementToolStripMenuItem});
            this.articleToolStripMenuItem.Name = "articleToolStripMenuItem";
            this.articleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.articleToolStripMenuItem.Text = "Article";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.informationToolStripMenuItem.Tag = "frmArticleInfo";
            this.informationToolStripMenuItem.Text = "Pneux";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // emplacementToolStripMenuItem
            // 
            this.emplacementToolStripMenuItem.Enabled = false;
            this.emplacementToolStripMenuItem.Name = "emplacementToolStripMenuItem";
            this.emplacementToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.emplacementToolStripMenuItem.Text = "Emplacement";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // bonsToolStripMenuItem1
            // 
            this.bonsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receptionToolStripMenuItem,
            this.historiqueToolStripMenuItem});
            this.bonsToolStripMenuItem1.Name = "bonsToolStripMenuItem1";
            this.bonsToolStripMenuItem1.Size = new System.Drawing.Size(69, 24);
            this.bonsToolStripMenuItem1.Text = "Entrees";
            // 
            // receptionToolStripMenuItem
            // 
            this.receptionToolStripMenuItem.Name = "receptionToolStripMenuItem";
            this.receptionToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.receptionToolStripMenuItem.Text = "Reception d\'un PV";
            this.receptionToolStripMenuItem.Click += new System.EventHandler(this.receptionToolStripMenuItem_Click);
            // 
            // historiqueToolStripMenuItem
            // 
            this.historiqueToolStripMenuItem.Name = "historiqueToolStripMenuItem";
            this.historiqueToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.historiqueToolStripMenuItem.Text = "Historique des PV";
            this.historiqueToolStripMenuItem.Click += new System.EventHandler(this.historiqueToolStripMenuItem_Click);
            // 
            // sortiesToolStripMenuItem1
            // 
            this.sortiesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bonsDeSortieToolStripMenuItem,
            this.historiqueToolStripMenuItem1});
            this.sortiesToolStripMenuItem1.Name = "sortiesToolStripMenuItem1";
            this.sortiesToolStripMenuItem1.Size = new System.Drawing.Size(66, 24);
            this.sortiesToolStripMenuItem1.Text = "Sorties";
            // 
            // bonsDeSortieToolStripMenuItem
            // 
            this.bonsDeSortieToolStripMenuItem.Name = "bonsDeSortieToolStripMenuItem";
            this.bonsDeSortieToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.bonsDeSortieToolStripMenuItem.Text = "Bons de sortie courants";
            this.bonsDeSortieToolStripMenuItem.Click += new System.EventHandler(this.bonsDeSortieToolStripMenuItem_Click);
            // 
            // historiqueToolStripMenuItem1
            // 
            this.historiqueToolStripMenuItem1.Name = "historiqueToolStripMenuItem1";
            this.historiqueToolStripMenuItem1.Size = new System.Drawing.Size(238, 26);
            this.historiqueToolStripMenuItem1.Text = "Bons de sortie clotures";
            this.historiqueToolStripMenuItem1.Click += new System.EventHandler(this.historiqueToolStripMenuItem1_Click);
            // 
            // retoursToolStripMenuItem
            // 
            this.retoursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retourToolStripMenuItem,
            this.bonsDeRetourCloturesToolStripMenuItem});
            this.retoursToolStripMenuItem.Name = "retoursToolStripMenuItem";
            this.retoursToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.retoursToolStripMenuItem.Text = "Retours";
            // 
            // retourToolStripMenuItem
            // 
            this.retourToolStripMenuItem.Name = "retourToolStripMenuItem";
            this.retourToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.retourToolStripMenuItem.Text = "Bons de retour courants";
            this.retourToolStripMenuItem.Click += new System.EventHandler(this.retourToolStripMenuItem_Click);
            // 
            // bonsDeRetourCloturesToolStripMenuItem
            // 
            this.bonsDeRetourCloturesToolStripMenuItem.Name = "bonsDeRetourCloturesToolStripMenuItem";
            this.bonsDeRetourCloturesToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.bonsDeRetourCloturesToolStripMenuItem.Text = "Bons de retour clotures";
            this.bonsDeRetourCloturesToolStripMenuItem.Click += new System.EventHandler(this.bonsDeRetourCloturesToolStripMenuItem_Click);
            // 
            // utilitaireToolStripMenuItem
            // 
            this.utilitaireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fournisseurToolStripMenuItem,
            this.villeToolStripMenuItem,
            this.uniteDeSoutienToolStripMenuItem});
            this.utilitaireToolStripMenuItem.Name = "utilitaireToolStripMenuItem";
            this.utilitaireToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.utilitaireToolStripMenuItem.Text = "Utilitaires";
            // 
            // fournisseurToolStripMenuItem
            // 
            this.fournisseurToolStripMenuItem.Name = "fournisseurToolStripMenuItem";
            this.fournisseurToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.fournisseurToolStripMenuItem.Text = "Fournisseurs";
            this.fournisseurToolStripMenuItem.Click += new System.EventHandler(this.fournisseurToolStripMenuItem_Click);
            // 
            // villeToolStripMenuItem
            // 
            this.villeToolStripMenuItem.Name = "villeToolStripMenuItem";
            this.villeToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.villeToolStripMenuItem.Text = "Ville";
            this.villeToolStripMenuItem.Click += new System.EventHandler(this.villeToolStripMenuItem_Click);
            // 
            // uniteDeSoutienToolStripMenuItem
            // 
            this.uniteDeSoutienToolStripMenuItem.Name = "uniteDeSoutienToolStripMenuItem";
            this.uniteDeSoutienToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.uniteDeSoutienToolStripMenuItem.Text = "Unite de soutien";
            this.uniteDeSoutienToolStripMenuItem.Click += new System.EventHandler(this.uniteDeSoutienToolStripMenuItem_Click);
            // 
            // rapportToolStripMenuItem
            // 
            this.rapportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etatDeStockToolStripMenuItem,
            this.hisoriqueDarticleToolStripMenuItem});
            this.rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            this.rapportToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.rapportToolStripMenuItem.Text = "Rapport";
            // 
            // etatDeStockToolStripMenuItem
            // 
            this.etatDeStockToolStripMenuItem.Name = "etatDeStockToolStripMenuItem";
            this.etatDeStockToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.etatDeStockToolStripMenuItem.Text = "Etat de stock";
            this.etatDeStockToolStripMenuItem.Click += new System.EventHandler(this.etatDeStockToolStripMenuItem_Click);
            // 
            // hisoriqueDarticleToolStripMenuItem
            // 
            this.hisoriqueDarticleToolStripMenuItem.Name = "hisoriqueDarticleToolStripMenuItem";
            this.hisoriqueDarticleToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.hisoriqueDarticleToolStripMenuItem.Text = "Hisorique d\'article";
            this.hisoriqueDarticleToolStripMenuItem.Click += new System.EventHandler(this.hisoriqueDarticleToolStripMenuItem_Click);
            // 
            // baseDeDonneesToolStripMenuItem
            // 
            this.baseDeDonneesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serveurToolStripMenuItem,
            this.sauvegardeToolStripMenuItem,
            this.restaurationToolStripMenuItem});
            this.baseDeDonneesToolStripMenuItem.Name = "baseDeDonneesToolStripMenuItem";
            this.baseDeDonneesToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.baseDeDonneesToolStripMenuItem.Text = "Base de donnees";
            // 
            // serveurToolStripMenuItem
            // 
            this.serveurToolStripMenuItem.Name = "serveurToolStripMenuItem";
            this.serveurToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.serveurToolStripMenuItem.Text = "Connexion au Serveur";
            this.serveurToolStripMenuItem.Click += new System.EventHandler(this.serveurToolStripMenuItem_Click);
            // 
            // sauvegardeToolStripMenuItem
            // 
            this.sauvegardeToolStripMenuItem.Name = "sauvegardeToolStripMenuItem";
            this.sauvegardeToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.sauvegardeToolStripMenuItem.Text = "Sauvegarde";
            this.sauvegardeToolStripMenuItem.Click += new System.EventHandler(this.sauvegardeToolStripMenuItem_Click);
            // 
            // restaurationToolStripMenuItem
            // 
            this.restaurationToolStripMenuItem.Name = "restaurationToolStripMenuItem";
            this.restaurationToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.restaurationToolStripMenuItem.Text = "Restauration";
            this.restaurationToolStripMenuItem.Click += new System.EventHandler(this.restaurationToolStripMenuItem_Click);
            // 
            // permissionToolStripMenuItem
            // 
            this.permissionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateursToolStripMenuItem});
            this.permissionToolStripMenuItem.Enabled = false;
            this.permissionToolStripMenuItem.Name = "permissionToolStripMenuItem";
            this.permissionToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.permissionToolStripMenuItem.Text = "Parametres";
            // 
            // utilisateursToolStripMenuItem
            // 
            this.utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            this.utilisateursToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.utilisateursToolStripMenuItem.Text = "Utilisateurs";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Enabled = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 630);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(982, 23);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 18);
            this.lblStatus.Text = "Etat...";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTION DE STOCK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emplacementToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bonsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem receptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortiesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bonsDeSortieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiqueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem retoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bonsDeRetourCloturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDonneesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegardeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem villeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uniteDeSoutienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etatDeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hisoriqueDarticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serveurToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}