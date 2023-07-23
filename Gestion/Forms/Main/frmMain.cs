using Gestion.Forms.Print;
using Gestion.Forms.Sub;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Forms.Main
{
    public partial class frmMain : Form
    {
        #region Codes

        private void OpenForm(Form frm)
        {
            Cursor = Cursors.WaitCursor;
            bool isOpen = false;
            //Text = $"GESTION DE STOCK - [{frm.Text}]";
            foreach (Form item in Application.OpenForms)
            {
                if (item.Text == frm.Text)
                {
                    isOpen = true;
                    item.WindowState = FormWindowState.Maximized;
                    item.Activate();
                    break;
                }
            }
            if (isOpen == false)
            {
                frm.MdiParent = this;
                //frm.MaximizeBox = false;
                //frm.MinimizeBox = false;
                //frm.Dock = DockStyle.Fill;
                frm.WindowState = FormWindowState.Maximized;
                //frm.FormBorderStyle = FormBorderStyle.None;
                //frm.Dock = DockStyle.Fill;
                //frm.ControlBox = false;
                //Text = "GESTION DE STOCK";
                frm.Show();
            }
            Cursor = Cursors.Default;
        }

        #endregion Codes

        public frmMain()
        {
            InitializeComponent();
        }

        private void receptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEBon frm = new frmEBon(this);
            OpenForm(frm);
        }

        private void historiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistoriqueEBon frm = new frmHistoriqueEBon(this);
            OpenForm(frm);
        }

        private void bonsDeSortieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSBon frm = new frmSBon(this);
            OpenForm(frm);
        }

        private void historiqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHistoriqueSBon frm = new frmHistoriqueSBon(this);
            OpenForm(frm);
        }

        private void retourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRBon frm = new frmRBon(this);
            OpenForm(frm);
        }

        private void bonsDeRetourCloturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistoriqueRBon frm = new frmHistoriqueRBon(this);
            OpenForm(frm);
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStock frm = new frmStock(this);
            OpenForm(frm);
        }

        private void fournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLFournisseur frm = new frmLFournisseur(this);
            OpenForm(frm);
        }

        private void villeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVille frm = new frmVille(this);
            OpenForm(frm);
        }

        private void uniteDeSoutienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUSoutien frm = new frmUSoutien(this);
            OpenForm(frm);
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPneu frm = new frmPneu(this);
            OpenForm(frm);
        }

        private void sauvegardeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBRData frm = new frmBRData(this);
            frm.ShowDialog();
        }

        private void restaurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBRData frm = new frmBRData(this);
            frm.ShowDialog();
        }

        private void etatDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrint_Etat_Stock frm = new frmPrint_Etat_Stock();
            OpenForm(frm);
        }

        private void hisoriqueDarticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrint_Historique_Article frm = new frmPrint_Historique_Article();
            OpenForm(frm);
        }

        private void serveurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServeur frm = new frmServeur();
            frm.ShowDialog();
        }
    }
}