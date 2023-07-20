using Gestion.DB;
using Gestion.Forms.Main;
using iTools;
using Gestion.Forms.iForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion.Forms.Sub
{
    public partial class frmLFournisseur : frmList
    {
        #region Variables

        private GestionEntities db = new GestionEntities();
        private int idFournisseur;
        private frmMain frmMain;

        #endregion Variables

        #region Overrides

        public override void CountRow(int? count)
        {
            lblCount.Text = $"Ligne: {count}";
        }

        public override void getData()
        {
            dgvFournisseur.DataSource = db.Select_Fournisseur().ToList();
            CountRow(db.Count_Fournisseur().FirstOrDefault());
        }

        public override void openForm()
        {
            frmFournisseur form = new frmFournisseur(this);
            form.Text = "Ajouter un fournisseur";
            form.ShowDialog();
        }

        public override void Delete_Data_By_Row()
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer ce fournisseur", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    var rs = db.Delete_Fournisseur(idFournisseur);
                    iMessage.sucMsg("Votre fournisseur a bien supprimé", "Information");
                    getData();
                    Verify_Buttons(true);
                }
                catch (Exception ex)
                {
                    iMessage.errorMsg("Erreur", ex.Message);
                    //form.txtStatus.Caption = ex.Message;
                }
            }
            base.Delete_Data_By_Row();
        }

        public override void setToolTip(string enteties)
        {
            base.setToolTip("un fournisseur");
        }

        #endregion Overrides

        #region Constracteur

        public frmLFournisseur(frmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }

        #endregion Constracteur

        private void dgvFournisseur_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvFournisseur.Rows[e.RowIndex];
            idFournisseur = int.Parse(row.Cells[colfrns_ID.Name].Value.ToString());
            db = new GestionEntities();
            Fournisseur vl = db.Show_Fournisseur_By_ID(idFournisseur).FirstOrDefault();
            frmFournisseur form = new frmFournisseur(this);
            form.Text = "Modifier un fournisseur";
            form.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvFournisseur.DataSource = db.Search_Fournisseur(txtSearch.Text);
            CountRow(dgvFournisseur.Rows.Count);
        }

        private void dgvFournisseur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvFournisseur.Rows[e.RowIndex];
                idFournisseur = int.Parse(row.Cells[colfrns_ID.Name].Value.ToString());
                if (idFournisseur > 0)
                    Verify_Buttons(false);
            }
        }

        private void dgvFournisseur_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                e.ContextMenuStrip = menuDGV;
            else
                e.ContextMenuStrip = menuRows;
            idFournisseur = (int)dgvFournisseur[colfrns_ID.Index, e.RowIndex].Value;
        }

        private void dgvFournisseur_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                dgvFournisseur.CurrentCell = dgvFournisseur[e.ColumnIndex, e.RowIndex];
                idFournisseur = (int)dgvFournisseur[colfrns_ID.Index, e.RowIndex].Value;
            }
        }

        private void btnRepresentant_Click(object sender, EventArgs e)
        {
            frmLRepresentant form = new frmLRepresentant(idFournisseur);
            form.MdiParent = this.MdiParent;
            form.Show();
        }
    }
}