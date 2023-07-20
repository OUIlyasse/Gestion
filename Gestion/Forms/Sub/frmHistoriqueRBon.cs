using Gestion.DB;
using Gestion.Forms.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Forms.Sub
{
    public partial class frmHistoriqueRBon : Form
    {
        #region Variables

        private GestionEntities db = new GestionEntities();
        private int idBonRetour;
        private Bon_Retour bs;
        private frmMain frmMain;

        #endregion Variables

        #region Codes

        #region Bon d'entree

        public void getData_RBon_H()
        {
            var result = db.Historique_Bon_Retour_H().ToList();
            dgvRBonH.DataSource = result;
            lblCBon.Text = $"Ligne: {dgvRBonH.Rows.Count}";
        }

        #endregion Bon d'entree

        #region Articles

        public void getData_RBon_Articles_H(int idSBon)
        {
            var result = db.Historique_Bon_Retour_Article_H(idSBon).ToList();
            dgvRBonArticleH.DataSource = result;
            lblCArticle.Text = $"Ligne: {dgvRBonArticleH.Rows.Count}";
        }

        #endregion Articles

        #endregion Codes

        public frmHistoriqueRBon(frmMain frmMain)
        {
            InitializeComponent();
            getData_RBon_H();
            this.frmMain = frmMain;
        }

        private void dgvEBonH_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                db = new GestionEntities();
                int index = dgvRBonH.CurrentCell.RowIndex;
                int id = (int)dgvRBonH.Rows[index].Cells[colbr_ID.Name].Value;
                idBonRetour = id;
                if (id > 0)
                {
                    bs = db.Show_Bon_Retour_By_ID(id).FirstOrDefault();
                    getData_RBon_Articles_H(id);
                }
            }
            catch (Exception)
            {
            }
        }

        private void frmHistoriqueRBon_Activated(object sender, EventArgs e)
        {
            frmMain.Text = $"GESTION DE STOCK - [{Text}]";
        }

        private void txtSBon_TextChanged(object sender, EventArgs e)
        {
            dgvRBonH.DataSource = db.Search_Bon_Retour_H(txtSBon.Text);
            lblCArticle.Text = $"Ligne: {dgvRBonH.Rows.Count}";
        }

        private void txtSArticle_TextChanged(object sender, EventArgs e)
        {
            dgvRBonArticleH.DataSource = db.Search_Bon_Retour_Article_H(txtSArticle.Text, idBonRetour);
            lblCArticle.Text = $"Ligne: {dgvRBonArticleH.Rows.Count}";
        }
    }
}