﻿using Gestion.DB;
using iTools;
using Gestion.Forms.iForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static iTools.iUtile;

namespace Gestion.Forms.Sub
{
    public partial class frmFournisseur : frmCRUD
    {
        #region Variables

        private GestionEntities db = new GestionEntities();
        private int idFournisseur;
        private frmLFournisseur frm;
        private Fournisseur frns;

        #endregion Variables

        #region Codes

        private void LoadVille()
        {
            cmbxVille.DisplayMember = "vil_Nom";
            cmbxVille.ValueMember = "vil_ID";
            cmbxVille.DataSource = db.Select_Ville();
            cmbxVille.SelectedValue = -1;
        }

        private int maxID()
        {
            return (int)db.MaxID_Fournisseur().FirstOrDefault();
        }

        private void setValue(Fournisseur vl)
        {
            idFournisseur = vl.frns_ID;
            txtFournisseur.Text = vl.frns_Nom;
            txtAdresse.Text = vl.frns_Adresse;
            txtAdresse2.Text = vl.frns_Adresse2;
            txtCodePostal.Text = vl.frns_Code_Postal;
            cmbxVille.SelectedValue = vl.vil_ID;
            txtGSM.Text = vl.frns_GSM;
            txtGSM2.Text = vl.frns_GSM2;
            txtFixe.Text = vl.frns_Fixe1;
            txtFixe2.Text = vl.frns_Fixe2;
            txtDescription.Text = vl.frns_Description;
        }

        private bool isMail(string mail)
        {
            Regex validateEmailRegex = new Regex("^[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
            if (validateEmailRegex.IsMatch(mail))
                return true;
            else
                return false;
        }

        private bool isGSM(string phone)
        {
            Regex validateEmailRegex = new Regex(@"^[0-9]{10}$");
            if (validateEmailRegex.IsMatch(phone))
                return true;
            else
                return false;
        }

        private bool isZipCode(string code)
        {
            Regex validateEmailRegex = new Regex(@"^[0 - 9]{ 5 }(?:-[0 - 9]{ 4})?$");
            if (validateEmailRegex.IsMatch(code))
                return true;
            else
                return false;
        }

        #endregion Codes

        #region Overrides

        public override void newRecord()
        {
            iText.Clear(this);
            Text = "Ajouter un fournisseur";
            tabControl1.SelectedTab = tabPage1;
            txtFournisseur.Focus();
            base.newRecord();
        }

        public override void getData()
        {
            frm.getData();
            base.getData();
        }

        public override void Add_Data()
        {
            try
            {
                if (string.IsNullOrEmpty(txtFournisseur.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFournisseur.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtGSM.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGSM.Focus();
                    return;
                }
                if (cmbxVille.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxVille.Focus();
                    return;
                }
                var rs = db.Insert_Fournisseur(maxID(), txtFournisseur.Text, txtAdresse.Text, txtAdresse2.Text, txtCodePostal.Text,
                    (int)cmbxVille.SelectedValue, txtEmail.Text, txtGSM.Text, txtGSM2.Text, txtFixe.Text, txtFixe2.Text, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Ce fournisseur {txtFournisseur.Text}  est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtFournisseur.Focus();
                        break;

                    case 1:
                        iMessage.sucMsg("Information", "Votre fournisseur a bien ajouté");
                        base.Add_Data();
                        Verify_Buttons(true);
                        break;
                }
            }
            catch (Exception ex)
            {
                iMessage.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
        }

        public override void Update_Data()
        {
            try
            {
                if (string.IsNullOrEmpty(txtFournisseur.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFournisseur.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtGSM.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGSM.Focus();
                    return;
                }
                if (cmbxVille.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxVille.Focus();
                    return;
                }
                var rs = db.Update_Fournisseur(idFournisseur, txtFournisseur.Text, txtAdresse.Text, txtAdresse2.Text, txtCodePostal.Text,
                    (int)cmbxVille.SelectedValue, txtEmail.Text, txtGSM.Text, txtGSM2.Text, txtFixe.Text, txtFixe2.Text, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Ce fournisseur {txtFournisseur.Text}  est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtFournisseur.Focus();
                        break;

                    case 1:
                        iMessage.sucMsg("Information", "Votre fournisseur a bien modifié");
                        base.Update_Data();
                        Verify_Buttons(true);
                        break;
                }
            }
            catch (Exception ex)
            {
                iMessage.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
        }

        public override void Delete_Data()
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer ce fournisseur {txtFournisseur.Text}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Fournisseur(idFournisseur);
                    iMessage.sucMsg("Information", "Votre fournisseur  a bien supprimé");
                    base.Delete_Data();
                    Verify_Buttons(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public override void setData()
        {
            setValue(frns);
            base.setData();
        }

        public override void Verify_Buttons(Form f, string txt)
        {
            base.Verify_Buttons(this, "Ajouter un fournisseur");
        }

        #endregion Overrides

        #region Constracteur

        public frmFournisseur(frmLFournisseur frm)
        {
            InitializeComponent();
            LoadVille();
            this.frm = frm;
        }

        public frmFournisseur(frmLFournisseur frm, Fournisseur frns)
        {
            InitializeComponent();
            LoadVille();
            this.frm = frm;
            this.frns = frns;
        }

        #endregion Constracteur

        #region Validating

        private void txtFournisseur_Validating(object sender, CancelEventArgs e)
        {
            txtFournisseur.Text = iText.ValidateText(txtFournisseur.Text, TypeText.Majuscule);
        }

        private void txtGSM_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGSM.Text))
            {
                if (isGSM(txtGSM.Text))
                {
                    e.Cancel = false;
                    errorValidate.SetError(txtGSM, "");
                }
                else
                {
                    e.Cancel = true;
                    errorValidate.SetError(txtGSM, "Veuillez entrer un numéro de téléphone valide");
                }
            }
        }

        private void txtFixe_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFixe.Text))
            {
                if (isGSM(txtFixe.Text))
                {
                    e.Cancel = false;
                    errorValidate.SetError(txtFixe, "");
                }
                else
                {
                    e.Cancel = true;
                    errorValidate.SetError(txtFixe, "Veuillez entrer un numéro de téléphone valide");
                }
            }
        }

        private void txtAdresse_Validating(object sender, CancelEventArgs e)
        {
            txtAdresse.Text = iText.ValidateText(txtAdresse.Text, TypeText.Defaut);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                if (isMail(txtEmail.Text))
                {
                    e.Cancel = false;
                    errorValidate.SetError(txtEmail, "");
                }
                else
                {
                    e.Cancel = true;
                    errorValidate.SetError(txtEmail, "Veuillez entrer un email valide");
                }
            }
        }

        private void txtCodePostal_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodePostal.Text))
            {
                if (isMail(txtCodePostal.Text))
                {
                    e.Cancel = false;
                    errorValidate.SetError(txtCodePostal, "");
                }
                else
                {
                    e.Cancel = true;
                    errorValidate.SetError(txtCodePostal, "Veuillez entrer un code postal valide");
                }
            }
        }

        private void txtGSM2_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGSM2.Text))
            {
                if (isGSM(txtGSM2.Text))
                {
                    e.Cancel = false;
                    errorValidate.SetError(txtGSM2, "");
                }
                else
                {
                    e.Cancel = true;
                    errorValidate.SetError(txtGSM2, "Veuillez entrer un numéro de téléphone valide");
                }
            }
        }

        private void txtFixe2_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFixe2.Text))
            {
                if (isGSM(txtFixe2.Text))
                {
                    e.Cancel = false;
                    errorValidate.SetError(txtFixe2, "");
                }
                else
                {
                    e.Cancel = true;
                    errorValidate.SetError(txtFixe2, "Veuillez entrer un numéro de téléphone valide");
                }
            }
        }

        private void txtAdresse2_Validating(object sender, CancelEventArgs e)
        {
            txtAdresse2.Text = iText.ValidateText(txtAdresse2.Text, TypeText.Defaut);
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            txtDescription.Text = iText.ValidateText(txtDescription.Text, TypeText.Defaut);
        }

        #endregion Validating

        #region KeyPress

        private void txtGSM_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtFixe_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtCodePostal_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtGSM2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtFixe2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        #endregion KeyPress
    }
}