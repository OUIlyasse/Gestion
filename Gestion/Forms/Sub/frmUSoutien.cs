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
    public partial class frmUSoutien : frmLCRUD
    {
        #region Variables

        private GestionEntities db = new GestionEntities();
        private int idUniteSoutien;
        private frmMain frmMain;

        #endregion Variables

        #region Codes

        private void LoadVille()
        {
            cmbxVille.DisplayMember = "vil_Nom";
            cmbxVille.ValueMember = "vil_ID";
            cmbxVille.DataSource = db.Select_Ville().ToList();
            cmbxVille.SelectedValue = -1;
        }

        private int maxID()
        {
            return (int)db.MaxID_Unite_Soutien().FirstOrDefault();
        }

        private void setValue(Unite_Soutien f)
        {
            txtUnite.Text = f.unt_Unite;
            cmbxVille.SelectedValue = f.vil_ID;
            txtDescription.Text = f.unt_Description;
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
                if (string.IsNullOrEmpty(txtUnite.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUnite.Focus();
                    return;
                }
                if (cmbxVille.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxVille.Focus();
                    return;
                }
                var rs = db.Insert_Unite_Soutien(maxID(), txtUnite.Text, (int)cmbxVille.SelectedValue, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"L'unité de soutien {txtUnite.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUnite.Focus();
                        break;

                    case 1:
                        iMessage.sucMsg("Information", "L'unité de soutien a bien ajouté");
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
                if (string.IsNullOrEmpty(txtUnite.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUnite.Focus();
                    return;
                }
                if (cmbxVille.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxVille.Focus();
                    return;
                }
                var rs = db.Update_Unite_Soutien(idUniteSoutien, txtUnite.Text, (int)cmbxVille.SelectedValue, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"L'unité de soutien {txtUnite.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUnite.Focus();
                        break;

                    case 1:
                        iMessage.sucMsg("Information", "L'unité de soutien a bien modifié");
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
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer cette unité de soutien {txtUnite.Text}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Unite_Soutien(idUniteSoutien);
                    iMessage.sucMsg("Information", "Votre unité de soutien  a bien supprimé");
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
            dgvUniteSoutien.DataSource = db.Select_Unite_Soutien().ToList();
            CountRow(db.Count_Unite_Soutien().FirstOrDefault());
        }

        public override void newRecord()
        {
            base.newRecord();
            iText.Clear(this);
            txtUnite.Focus();
        }

        public override void setToolTip(string enteties)
        {
            base.setToolTip("une unité de soutien");
        }

        #endregion Overrides

        #region Constracteurs

        public frmUSoutien(frmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }

        #endregion Constracteurs

        #region Validating

        private void txtUnite_Validating(object sender, CancelEventArgs e)
        {
            txtUnite.Text = iText.ValidateText(txtUnite.Text, TypeText.Majuscule);
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            txtDescription.Text = iText.ValidateText(txtDescription.Text, TypeText.Defaut);
        }

        #endregion Validating

        #region Search

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvUniteSoutien.DataSource = db.Search_Unite_Soutien(txtSearch.Text);
            CountRow(dgvUniteSoutien.Rows.Count);
        }

        #endregion Search

        private void dgvUniteSoutien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new GestionEntities();
            DataGridViewRow row = dgvUniteSoutien.Rows[e.RowIndex];
            idUniteSoutien = int.Parse(row.Cells[colunt_ID.Name].Value.ToString());
            Unite_Soutien us = db.Show_Unite_Soutien_By_ID(idUniteSoutien).FirstOrDefault();
            setValue(us);
            Verify_Buttons(false);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newRecord();
        }

        private void frmUniteSoutien_Load(object sender, EventArgs e)
        {
            LoadVille();
        }

        private void dgvUniteSoutien_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                e.ContextMenuStrip = menuDGV;
        }
    }
}