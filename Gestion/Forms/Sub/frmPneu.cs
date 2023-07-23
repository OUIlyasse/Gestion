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
using System.Threading.Tasks;
using System.Windows.Forms;
using static iTools.iUtile;

namespace Gestion.Forms.Sub
{
    public partial class frmPneu : frmLCRUD
    {
        #region Variables

        private GestionEntities db = new GestionEntities();
        private int idPneu;
        private frmMain frmMain;

        #endregion Variables

        #region Codes

        private int maxID()
        {
            return (int)db.MaxID_Pneu().FirstOrDefault();
        }

        private void setValue(Pneu f)
        {
            txtReference.Text = f.pne_Designation;
            txtMarque.Text = f.pne_Marque;
            dtProduction.Value = (DateTime)f.pne_Date_Production;
            txtObservation.Text = f.pne_Observation;
        }

        private void CountRow(int? count)
        {
            lblCount.Text = $"Ligne: {count}";
        }

        #endregion Codes

        #region Overrides

        public override void Add_Data()
        {
            try
            {
                if (string.IsNullOrEmpty(txtReference.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtReference.Focus();
                    return;
                }

                var rs = db.Insert_Pneu(maxID(), txtReference.Text, txtMarque.Text, dtProduction.Value, txtObservation.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Ce pneu {txtReference.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtReference.Focus();
                        break;

                    case 1:
                        iMessage.sucMsg("Information", "Ce pneu a bien ajouté");
                        newRecord();
                        break;
                }
            }
            catch (Exception ex)
            {
                iMessage.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
            base.Add_Data();
        }

        public override void Update_Data()
        {
            try
            {
                if (string.IsNullOrEmpty(txtReference.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtReference.Focus();
                    return;
                }
                var rs = db.Update_Pneu(idPneu, txtReference.Text, txtMarque.Text, dtProduction.Value, txtObservation.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Ce pneu {txtReference.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtReference.Focus();
                        break;

                    case 1:
                        iMessage.sucMsg("Information", "Ce pneu a bien modifié");
                        newRecord();
                        break;
                }
            }
            catch (Exception ex)
            {
                iMessage.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
            base.Update_Data();
        }

        public override void Delete_Data()
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer ce pneu {txtReference.Text}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Pneu(idPneu);
                    iMessage.sucMsg("Information", "Votre pneu  a bien supprimé");
                    newRecord();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                base.Delete_Data();
            }
        }

        public override void getData()
        {
            dgvPneu.DataSource = db.Select_Pneu().ToList();
            CountRow(db.Count_Pneu().FirstOrDefault());
        }

        public override void newRecord()
        {
            base.newRecord();
            iText.Clear(this);
            txtReference.Focus();
        }

        public override void setToolTip(string enteties)
        {
            base.setToolTip("un pneu");
        }

        #endregion Overrides

        #region Constracteur

        public frmPneu(frmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }

        #endregion Constracteur

        #region Validating

        private void txtVille_Validating(object sender, CancelEventArgs e)
        {
            txtReference.Text = iText.ValidateText(txtReference.Text, TypeText.Defaut);
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            txtObservation.Text = iText.ValidateText(txtObservation.Text, TypeText.Defaut);
        }

        private void txtMarque_Validating(object sender, CancelEventArgs e)
        {
            txtMarque.Text = iText.ValidateText(txtMarque.Text, TypeText.Defaut);
        }

        #endregion Validating

        #region Search

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvPneu.DataSource = db.Search_Ville(txtSearch.Text);
            CountRow(dgvPneu.Rows.Count);
        }

        #endregion Search

        private void btnNew_Click(object sender, EventArgs e)
        {
            newRecord();
        }

        private void dgvVille_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new GestionEntities();
            DataGridViewRow row = dgvPneu.Rows[e.RowIndex];
            idPneu = int.Parse(row.Cells[colpne_ID.Name].Value.ToString());
            Pneu ville = db.Show_Pneu_By_ID(idPneu).FirstOrDefault();
            setValue(ville);
            Verify_Buttons(false);
        }

        private void dgvVille_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                e.ContextMenuStrip = menuDGV;
        }
    }
}