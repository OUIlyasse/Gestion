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
    public partial class frmHistoriqueEBon : Form
    {
        #region Variables

        private GestionEntities db = new GestionEntities();
        private int idBonEntree;
        private Bon_Entree bs;
        private frmMain frmMain;

        #endregion Variables

        #region Codes

        #region Bon d'entree

        public void getData_EBon_H()
        {
            dgvEBonH.DataSource = db.Historique_Bon_Entree_H().ToList();
            CountRow(db.Count_Bon_Entree(false).FirstOrDefault());
        }

        private void CountRow(int? count)
        {
            lblCBon.Text = $"Ligne: {count}";
        }

        #endregion Bon d'entree

        #region Articles

        public void getData_EBon_Articles_H(int idEBon)
        {
            var result = db.Historique_Bon_Entree_Article_H(idEBon).ToList();
            dgvEBonArticleH.DataSource = result;
            lblCArticle.Text = $"Ligne: {db.Count_Bon_Entree_Article(false).FirstOrDefault()}";
        }

        #endregion Articles

        #endregion Codes

        public frmHistoriqueEBon(frmMain frmMain)
        {
            InitializeComponent();
            getData_EBon_H();
            this.frmMain = frmMain;
        }

        private void dgvEBonH_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                db = new GestionEntities();
                int index = dgvEBonH.CurrentCell.RowIndex;
                int id = (int)dgvEBonH.Rows[index].Cells[colbe_ID.Name].Value;
                idBonEntree = id;
                if (id > 0)
                {
                    bs = db.Show_Bon_Entree_By_ID(id).FirstOrDefault();
                    getData_EBon_Articles_H(id);
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvEBonArticleH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void frmHistoriqueEBon_Activated(object sender, EventArgs e)
        {
            frmMain.Text = $"GESTION DE STOCK - [{Text}]";
        }

        private void txtSBon_TextChanged(object sender, EventArgs e)
        {
            dgvEBonH.DataSource = db.Search_Bon_Entree_H(txtSBon.Text);
            CountRow(dgvEBonH.Rows.Count);
        }

        private void txtSArticle_TextChanged(object sender, EventArgs e)
        {
            dgvEBonArticleH.DataSource = db.Search_Bon_Entree_Article_H(txtSArticle.Text, idBonEntree);
            lblCArticle.Text = $"Ligne: {dgvEBonArticleH.Rows.Count}";
        }
    }
}