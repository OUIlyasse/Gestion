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
    public partial class frmEBon : Form
    {
        #region Variables

        private GestionEntities db = new GestionEntities();
        private int idBonEntree;
        private Bon_Entree bs;
        private int idBonArticle;
        private frmMain frmMain;

        #endregion Variables

        #region Codes

        #region Bon d'entree

        public void getData_EBon()
        {
            dgvEBon.DataSource = db.Select_Bon_Entree().ToList();
            CountRow(db.Count_Bon_Entree(true).FirstOrDefault());
        }

        private int maxID_Operation()
        {
            return (int)db.MaxID_Operation().FirstOrDefault();
        }

        private void Exploiter_Bon_Entree()
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                var allPneu = db.Select_Bon_Entree_Article(idBonEntree).ToList();
                foreach (var item in allPneu)
                {
                    var rs = db.Insert_Operation(maxID_Operation(), DateTime.Now, item.pne_ID, "E", item.be_Qte_Livree, idBonEntree, null, item.be_A_ID, null).FirstOrDefault();
                    switch (rs)
                    {
                        case 0:
                            MessageBox.Show("Test");
                            break;

                        case 1:
                            db.Historique_Bon_Entree_Article(item.be_A_ID);
                            break;
                    }
                }
                var ss = db.Historique_Bon_Entree(idBonEntree).FirstOrDefault();
                switch (ss)
                {
                    case 0:
                        MessageBox.Show("Test555");
                        break;

                    case 1:
                        iMessage.sucMsg("Information", "Votre bon a bien exploité");
                        getData_EBon();
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

        private void CountRow(int? count)
        {
            lblBECount.Text = $"Ligne: {count}";
        }

        #endregion Bon d'entree

        #region Articles

        public void getData_EBon_Articles(int idEBon)
        {
            dgvEBonArticle.DataSource = db.Select_Bon_Entree_Article(idEBon).ToList();
            lblABECount.Text = $"Ligne: {dgvEBonArticle.Rows.Count}";
        }

        private void Delete_Data(string pneu)
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer ce pneu {pneu}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Bon_Entree_Article(idBonArticle);
                    iMessage.sucMsg("Information", "Ce pneu a bien supprimé");
                    getData_EBon_Articles(idBonEntree);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion Articles

        #endregion Codes

        public frmEBon(frmMain frmMain)
        {
            InitializeComponent();
            getData_EBon();
            this.frmMain = frmMain;
        }

        private void btnBAdd_Click(object sender, EventArgs e)
        {
            frmEBonAdd frmBon = new frmEBonAdd(this);
            frmBon.Text = "Ajouter un bon d'entrée";
            frmBon.ShowDialog();
        }

        private void dgvEBon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                db = new GestionEntities();
                int index = dgvEBon.CurrentCell.RowIndex;
                int id = (int)dgvEBon.Rows[index].Cells[colbe_ID.Name].Value;

                if (id > 0)
                {
                    Bon_Entree bs = db.Show_Bon_Entree_By_ID(id).FirstOrDefault();
                    frmEBonAdd form = new frmEBonAdd(this, bs);
                    form.Text = "Modifier un bon d'entrée";
                    form.ShowDialog();
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvEBon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnPAdd_Click(object sender, EventArgs e)
        {
            frmEBonAddArticle frm = new frmEBonAddArticle(this, bs);
            frm.Text = "Ajouter un pneu";
            frm.ShowDialog();
        }

        private void btnPDelete_Click(object sender, EventArgs e)
        {
            Delete_Data("");
        }

        private void dgvEBonArticle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                db = new GestionEntities();
                if (dgvEBonArticle.RowCount > 0)
                {
                    int index = dgvEBonArticle.CurrentCell.RowIndex;
                    int id = (int)dgvEBonArticle.Rows[index].Cells[colbe_A_ID.Name].Value;
                    Bon_Entree_Article ei = db.Show_Bon_Entree_Article_By_ID(id).FirstOrDefault();
                    frmEBonAddArticle frm = new frmEBonAddArticle(this, ei);
                    frm.Text = "Modifier un pneu";
                    frm.ShowDialog();
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvEBonArticle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvEBonArticle_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEBonArticle.Rows.Count > -1)
            {
                btnPDelete.Enabled = true;
                int index = dgvEBonArticle.CurrentCell.RowIndex;
                idBonArticle = (int)dgvEBonArticle.Rows[index].Cells[colbe_A_ID.Name].Value;
            }
            else
                btnPDelete.Enabled = false;
        }

        private void dgvEBon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvEBon.Rows.Count == 0)
                {
                    btnExploiter.Enabled = false;
                    return;
                }
                btnExploiter.Enabled = true;
                db = new GestionEntities();
                int index = dgvEBon.CurrentCell.RowIndex;
                int id = (int)dgvEBon.Rows[index].Cells[colbe_ID.Name].Value;
                idBonEntree = id;
                btnExploiter.Enabled = true;
                if (id > 0)
                {
                    btnPAdd.Enabled = true;
                    bs = db.Show_Bon_Entree_By_ID(id).FirstOrDefault();
                    getData_EBon_Articles(id);
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
            Exploiter_Bon_Entree();
        }

        private void frmEBon_Load(object sender, EventArgs e)
        {
        }

        private void frmEBon_Activated(object sender, EventArgs e)
        {
            frmMain.Text = $"GESTION DE STOCK - [{Text}]";
        }

        private void txtSBEntree_TextChanged(object sender, EventArgs e)
        {
            dgvEBon.DataSource = db.Search_Bon_Entree(txtSBEntree.Text);
            CountRow(dgvEBon.Rows.Count);
        }

        private void txtSBArticle_TextChanged(object sender, EventArgs e)
        {
            dgvEBonArticle.DataSource = db.Search_Bon_Entree_Article(txtSBArticle.Text, idBonEntree);
            lblABECount.Text = $"Ligne: {dgvEBonArticle.Rows.Count}";
        }
    }
}