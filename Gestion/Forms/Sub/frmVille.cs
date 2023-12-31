﻿using Gestion.DB;
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
    public partial class frmVille : frmLCRUD
    {
        #region Variables

        private GestionEntities db = new GestionEntities();
        private int idVille;
        private frmMain frmMain;

        #endregion Variables

        #region Codes

        private int maxID()
        {
            return (int)db.MaxID_Ville().FirstOrDefault();
        }

        private void setValue(Ville f)
        {
            txtVille.Text = f.vil_Nom;
            txtDescription.Text = f.vil_Description;
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
                if (string.IsNullOrEmpty(txtVille.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtVille.Focus();
                    return;
                }
                var rs = db.Insert_Ville(maxID(), txtVille.Text, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"La ville {txtVille.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtVille.Focus();
                        break;

                    case 1:
                        iMessage.sucMsg("Information", "La ville a bien ajouté");
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
                if (string.IsNullOrEmpty(txtVille.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtVille.Focus();
                    return;
                }
                var rs = db.Update_Ville(idVille, txtVille.Text, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"La ville {txtVille.Text} existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtVille.Focus();
                        break;

                    case 1:
                        iMessage.sucMsg("Information", "La ville a bien modifié");
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
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer cette ville {txtVille.Text}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Ville(idVille);
                    iMessage.sucMsg("Information", "Votre ville  a bien supprimé");
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
            dgvVille.DataSource = db.Select_Ville().ToList();
            CountRow(db.Count_Ville().FirstOrDefault());
        }

        public override void newRecord()
        {
            base.newRecord();
            iText.Clear(this);
            txtVille.Focus();
        }

        public override void setToolTip(string enteties)
        {
            base.setToolTip("une ville");
        }

        #endregion Overrides

        #region Constracteur

        public frmVille(frmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }

        #endregion Constracteur

        #region Validating

        private void txtVille_Validating(object sender, CancelEventArgs e)
        {
            txtVille.Text = iText.ValidateText(txtVille.Text, TypeText.Majuscule);
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            txtDescription.Text = iText.ValidateText(txtDescription.Text, TypeText.Defaut);
        }

        #endregion Validating

        #region Search

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvVille.DataSource = db.Search_Ville(txtSearch.Text);
            CountRow(dgvVille.Rows.Count);
        }

        #endregion Search

        private void btnNew_Click(object sender, EventArgs e)
        {
            newRecord();
        }

        private void dgvVille_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new GestionEntities();
            DataGridViewRow row = dgvVille.Rows[e.RowIndex];
            idVille = int.Parse(row.Cells[colvil_ID.Name].Value.ToString());
            Ville ville = db.Show_Ville_By_ID(idVille).FirstOrDefault();
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