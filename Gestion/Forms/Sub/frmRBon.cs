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
    public partial class frmRBon : Form
    {
        #region Variables

        private GestionEntities db = new GestionEntities();
        private int idBonRetour;
        private Bon_Retour bs;
        private int idBonArticle;
        private frmMain frmMain;

        #endregion Variables

        #region Codes

        #region Bon Sortie

        public void getData_RBon()
        {
            var result = db.Select_Bon_Retour().ToList();
            dgvSBon.DataSource = result;
            lblCBon.Text = $"Ligne: {dgvSBon.Rows.Count}";
        }

        private int maxID_Operation()
        {
            return (int)db.MaxID_Operation().FirstOrDefault();
        }

        private void Exploiter_Bon_Retour()
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                var allPneu = db.Select_Bon_Retour_Article(idBonRetour).ToList();
                foreach (var item in allPneu)
                {
                    var rs = db.Insert_Operation(maxID_Operation(), DateTime.Now, item.pne_ID, "R", item.br_Qte_Livree, idBonRetour, null, null, item.br_A_ID).FirstOrDefault();
                    switch (rs)
                    {
                        case 0:
                            MessageBox.Show("Test");
                            break;

                        case 1:
                            db.Historique_Bon_Retour_Article(item.br_A_ID);
                            break;
                    }
                }
                var ss = db.Historique_Bon_Retour(idBonRetour).FirstOrDefault();
                switch (ss)
                {
                    case 0:
                        MessageBox.Show("Test555");
                        break;

                    case 1:
                        iMessage.sucMsg("Information", "Votre bon a bien exploité");
                        getData_RBon();
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

        public void getData_RBon_Articles(int idRBon)
        {
            var result = db.Select_Bon_Retour_Article(idRBon).ToList();
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
                    db.Delete_Bon_Retour_Article(idBonArticle);
                    iMessage.sucMsg("Information", "Ce pneu a bien supprimé");
                    getData_RBon_Articles(idBonRetour);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion Articles

        #endregion Codes

        public frmRBon(frmMain frmMain)
        {
            InitializeComponent();
            getData_RBon();
            this.frmMain = frmMain;
        }

        private void btnBAdd_Click(object sender, EventArgs e)
        {
            frmRBonAdd frmBon = new frmRBonAdd(this);
            frmBon.Text = "Ajouter un bon de retour";
            frmBon.ShowDialog();
        }

        private void dgvSBon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                db = new GestionEntities();
                int index = dgvSBon.CurrentCell.RowIndex;
                int id = (int)dgvSBon.Rows[index].Cells[colbr_ID.Name].Value;

                if (id > 0)
                {
                    Bon_Retour bs = db.Show_Bon_Retour_By_ID(id).FirstOrDefault();
                    frmRBonAdd form = new frmRBonAdd(this, bs);
                    form.Text = "Modifier un bon de retour";
                    form.ShowDialog();
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnPAdd_Click(object sender, EventArgs e)
        {
            frmRBonAddArticle frm = new frmRBonAddArticle(this, bs);
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
                    int id = (int)dgvSBonArticle.Rows[index].Cells[colbr_A_ID.Name].Value;
                    Bon_Retour_Article ei = db.Show_Bon_Retour_Article_By_ID(id).FirstOrDefault();
                    frmRBonAddArticle frm = new frmRBonAddArticle(this, ei);
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
            if (dgvSBonArticle.Rows.Count > -1)
            {
                btnPDelete.Enabled = true;
                int index = dgvSBonArticle.CurrentCell.RowIndex;
                idBonArticle = (int)dgvSBonArticle.Rows[index].Cells[colbr_A_ID.Name].Value;
            }
            else
                btnPDelete.Enabled = false;
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
                int id = (int)dgvSBon.Rows[index].Cells[colbr_ID.Name].Value;
                idBonRetour = id;
                btnExploiter.Enabled = true;
                if (id > 0)
                {
                    btnPAdd.Enabled = true;
                    bs = db.Show_Bon_Retour_By_ID(id).FirstOrDefault();
                    getData_RBon_Articles(id);
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
            if (idBonRetour > 0)
                Exploiter_Bon_Retour();
        }

        private void frmRBon_Activated(object sender, EventArgs e)
        {
            frmMain.Text = $"GESTION DE STOCK - [{Text}]";
        }

        private void txtRBon_TextChanged(object sender, EventArgs e)
        {
            dgvSBon.DataSource = db.Search_Bon_Retour(txtRBon.Text);
            lblCBon.Text = $"Ligne: {dgvSBon.Rows.Count}";
        }

        private void txtRArticle_TextChanged(object sender, EventArgs e)
        {
            dgvSBonArticle.DataSource = db.Search_Bon_Retour_Article(txtRArticle.Text, idBonRetour);
            lblCArticle.Text = $"Ligne: {dgvSBonArticle.Rows.Count}";
        }

        private void frmRBon_Load(object sender, EventArgs e)
        {
        }
    }
}