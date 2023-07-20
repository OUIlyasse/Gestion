using Gestion.DB;
using Gestion.Forms.Main;
using iTools;
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
    public partial class frmSBon : Form
    {
        #region Variables

        private GestionEntities db = new GestionEntities();
        private int idBonSortie;
        private Bon_Sortie bs;
        private int idBonArticle;

        private frmMain frmMain;

        #endregion Variables

        #region Codes

        #region Bon Sortie

        public void getData_SBon()
        {
            var result = db.Select_Bon_Sortie().ToList();
            dgvSBon.DataSource = result;
            lblCBon.Text = $"Ligne: {dgvSBon.Rows.Count}";
        }

        private int maxID_Operation()
        {
            return (int)db.MaxID_Operation().FirstOrDefault();
        }

        private void Exploiter_Bon_Sortie()
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                var allPneu = db.Select_Bon_Sortie_Article(idBonSortie).ToList();
                foreach (var item in allPneu)
                {
                    var rs = db.Insert_Operation(maxID_Operation(), DateTime.Now, item.pne_ID, "S", item.bs_Qte_Livree, idBonSortie, item.bs_A_ID, null, null).FirstOrDefault();
                    switch (rs)
                    {
                        case 0:
                            MessageBox.Show("Test");
                            break;

                        case 1:
                            db.Historique_Bon_Sortie_Article(item.bs_A_ID);
                            break;
                    }
                }
                var ss = db.Historique_Bon_Sortie(idBonSortie).FirstOrDefault();
                switch (ss)
                {
                    case 0:
                        MessageBox.Show("Test555");
                        break;

                    case 1:
                        iMessage.sucMsg("Information", "Votre bon a bien exploité");
                        getData_SBon();
                        break;
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                iMessage.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
        }

        #endregion Bon Sortie

        #region Articles

        public void getData_SBon_Articles(int idSBon)
        {
            var result = db.Select_Bon_Sortie_Article(idSBon).ToList();
            dgvSBonArticle.DataSource = result;
            lblCArticle.Text = $"Ligne: {dgvSBonArticle.Rows.Count}";
        }

        private void Delete_Data(string pneu)
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer ce pneu {pneu}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Bon_Sortie_Article(idBonArticle);
                    iMessage.sucMsg("Information", "Ce pneu a bien supprimé");
                    getData_SBon_Articles(idBonSortie);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion Articles

        #endregion Codes

        public frmSBon(frmMain frmMain)
        {
            InitializeComponent();
            getData_SBon();
            this.frmMain = frmMain;
        }

        private void btnBAdd_Click(object sender, EventArgs e)
        {
            frmSBonAdd frmBon = new frmSBonAdd(this);
            frmBon.Text = "Ajouter un bon de sortie";
            frmBon.ShowDialog();
        }

        private void dgvSBon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                db = new GestionEntities();
                int index = dgvSBon.CurrentCell.RowIndex;
                int id = (int)dgvSBon.Rows[index].Cells[colbs_ID.Name].Value;

                if (id > 0)
                {
                    Bon_Sortie bs = db.Show_Bon_Sortie_By_ID(id).FirstOrDefault();
                    frmSBonAdd form = new frmSBonAdd(this, bs);
                    form.Text = "Modifier un bon de sortie";
                    form.ShowDialog();
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnPAdd_Click(object sender, EventArgs e)
        {
            frmSBonAddArticle frm = new frmSBonAddArticle(this, bs);
            frm.Text = "Ajouter un pneu";
            frm.ShowDialog();
        }

        private void btnPDelete_Click(object sender, EventArgs e)
        {
            Delete_Data("");
        }

        private void dgvSBonArticle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                db = new GestionEntities();
                if (dgvSBonArticle.RowCount > 0)
                {
                    int index = dgvSBonArticle.CurrentCell.RowIndex;
                    int id = (int)dgvSBonArticle.Rows[index].Cells[colbs_A_ID.Name].Value;
                    Bon_Sortie_Article ei = db.Show_Bon_Sortie_Article_By_ID(id).FirstOrDefault();
                    frmSBonAddArticle frm = new frmSBonAddArticle(this, ei);
                    frm.Text = "Modifier un pneu";
                    frm.ShowDialog();
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvSBonArticle_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSBonArticle.Rows.Count > 0)
            {
                btnPDelete.Enabled = true;
                int index = dgvSBonArticle.CurrentCell.RowIndex;
                idBonArticle = (int)dgvSBonArticle.Rows[index].Cells[colbs_A_ID.Name].Value;
            }
            else
            {
                btnPDelete.Enabled = false;
            }
        }

        private void dgvSBon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvSBon.Rows.Count == 0)
                {
                    btnExploiter.Enabled = false;
                    return;
                }
                btnExploiter.Enabled = true;
                db = new GestionEntities();
                int index = dgvSBon.CurrentCell.RowIndex;
                int id = (int)dgvSBon.Rows[index].Cells[colbs_ID.Name].Value;
                idBonSortie = id;
                btnExploiter.Enabled = true;
                if (id > 0)
                {
                    btnPAdd.Enabled = true;
                    bs = db.Show_Bon_Sortie_By_ID(id).FirstOrDefault();
                    getData_SBon_Articles(id);
                }
                else
                {
                    btnPAdd.Enabled = false;
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnExploiter_Click(object sender, EventArgs e)
        {
            Exploiter_Bon_Sortie();
        }

        private void frmSBon_Activated(object sender, EventArgs e)
        {
            frmMain.Text = $"GESTION DE STOCK - [{Text}]";
        }

        private void txtRBon_TextChanged(object sender, EventArgs e)
        {
            dgvSBon.DataSource = db.Search_Bon_Sortie(txtRBon.Text);
            lblCBon.Text = $"Ligne: {dgvSBon.Rows.Count}";
        }

        private void txtRArticle_TextChanged(object sender, EventArgs e)
        {
            dgvSBonArticle.DataSource = db.Search_Bon_Sortie_Article(txtRArticle.Text, idBonSortie);
            lblCArticle.Text = $"Ligne: {dgvSBonArticle.Rows.Count}";
        }
    }
}