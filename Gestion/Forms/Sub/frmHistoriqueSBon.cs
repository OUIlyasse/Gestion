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
    public partial class frmHistoriqueSBon : Form
    {
        #region Variables

        private GestionEntities db = new GestionEntities();
        private int idBonSortie;
        private Bon_Sortie bs;
        private frmMain frmMain;

        #endregion Variables

        #region Codes

        #region Bon d'entree

        public void getData_SBon_H()
        {
            var result = db.Historique_Bon_Sortie_H().ToList();
            dgvSBonH.DataSource = result;
            lblCBon.Text = $"Ligne: {dgvSBonH.Rows.Count}";
        }

        #endregion Bon d'entree

        #region Articles

        public void getData_SBon_Articles_H(int idSBon)
        {
            var result = db.Historique_Bon_Sortie_Article_H(idSBon).ToList();
            dgvSBonArticleH.DataSource = result;
            lblCArticle.Text = $"Ligne: {dgvSBonArticleH.Rows.Count}";
        }

        #endregion Articles

        #endregion Codes

        public frmHistoriqueSBon(frmMain frmMain)
        {
            InitializeComponent();
            getData_SBon_H();
            this.frmMain = frmMain;
        }

        private void dgvEBonH_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                db = new GestionEntities();
                int index = dgvSBonH.CurrentCell.RowIndex;
                int id = (int)dgvSBonH.Rows[index].Cells[colbs_ID.Name].Value;
                idBonSortie = id;
                if (id > 0)
                {
                    bs = db.Show_Bon_Sortie_By_ID(id).FirstOrDefault();
                    getData_SBon_Articles_H(id);
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvEBonArticleH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void frmHistoriqueSBon_Activated(object sender, EventArgs e)
        {
            frmMain.Text = $"GESTION DE STOCK - [{Text}]";
        }

        private void txtSBon_TextChanged(object sender, EventArgs e)
        {
            dgvSBonH.DataSource = db.Search_Bon_Sortie_H(txtSBon.Text);
            lblCBon.Text = $"Ligne: {dgvSBonH.Rows.Count}";
        }

        private void txtSArticle_TextChanged(object sender, EventArgs e)
        {
            dgvSBonArticleH.DataSource = db.Search_Bon_Sortie_Article_H(txtSArticle.Text, idBonSortie);
            lblCArticle.Text = $"Ligne: {dgvSBonArticleH.Rows.Count}";
        }
    }
}