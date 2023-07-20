using Gestion.DB;
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
using static iTools.iUtile;

namespace Gestion.Forms.Sub
{
    public partial class frmEBonAdd : Form
    {
        #region Variables

        private GestionEntities db = new GestionEntities();
        private int idBonEntree;
        private frmEBon form;
        private Bon_Entree bs;

        #endregion Variables

        #region Codes

        private void LoadFournisseur()
        {
            cmbxFournisseur.DisplayMember = "frns_Nom";
            cmbxFournisseur.ValueMember = "frns_ID";
            cmbxFournisseur.DataSource = db.Select_Fournisseur();
            cmbxFournisseur.SelectedValue = -1;
        }

        private void LoadRepresentant(int idFournisseur)
        {
            cmbxRepresentant.DisplayMember = "rep_Nom";
            cmbxRepresentant.ValueMember = "rep_ID";
            cmbxRepresentant.DataSource = db.Select_Representant(idFournisseur);
            cmbxRepresentant.SelectedValue = -1;
        }

        private int maxID()
        {
            return (int)db.MaxID_Bon_Entree().FirstOrDefault();
        }

        private void setValue(Bon_Entree vl)
        {
            idBonEntree = vl.be_ID;
            txtDesignation.Text = vl.be_Designation;
            dtDate.Value = (DateTime)vl.be_Date;
            cmbxFournisseur.SelectedValue = (int)vl.frns_ID;
            cmbxRepresentant.SelectedValue = (int)vl.rep_ID;
            txtReference.Text = vl.be_Reference;
            txtDescription.Text = vl.be_Description;
        }

        private string maxBL()
        {
            string rs = $"BL {maxID().ToString()}/{dtDate.Value.Date.ToString("yy")}";
            return rs;
        }

        #endregion Codes

        #region Overrides

        private void newRecord()
        {
            iText.Clear(this);
            Text = "Ajouter un bon d'entrée";
            txtDesignation.Text = maxBL();
            getData();
            txtDesignation.Focus();
        }

        private void getData()
        {
            form.getData_EBon();
        }

        private void Add_Data()
        {
            try
            {
                if (string.IsNullOrEmpty(txtDesignation.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDesignation.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtReference.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtReference.Focus();
                    return;
                }
                if (cmbxFournisseur.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxFournisseur.Focus();
                    return;
                }
                if (cmbxRepresentant.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxRepresentant.Focus();
                    return;
                }
                var rs = db.Insert_Bon_Entree(maxID(), dtDate.Value, txtDesignation.Text, txtReference.Text, null, (int)cmbxFournisseur.SelectedValue, (int)cmbxRepresentant.SelectedValue, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Ce bon {txtDesignation.Text} est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDesignation.Focus();
                        break;

                    case 1:
                        iMessage.sucMsg("Information", "Votre bon a bien ajouté");
                        Verify_Buttons(true);
                        newRecord();
                        break;
                }
            }
            catch (Exception ex)
            {
                iMessage.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
        }

        private void Update_Data()
        {
            try
            {
                if (string.IsNullOrEmpty(txtDesignation.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDesignation.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtReference.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtReference.Focus();
                    return;
                }
                if (cmbxFournisseur.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxFournisseur.Focus();
                    return;
                }
                if (cmbxRepresentant.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxRepresentant.Focus();
                    return;
                }
                var rs = db.Update_Bon_Entree(idBonEntree, (DateTime)dtDate.Value, txtDesignation.Text, txtReference.Text, null, (int)cmbxFournisseur.SelectedValue, (int)cmbxRepresentant.SelectedValue, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Ce bon {txtDesignation.Text} est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDesignation.Focus();
                        break;

                    case 1:
                        iMessage.sucMsg("Information", "Votre bon a bien modifié");
                        Verify_Buttons(true);
                        newRecord();
                        break;
                }
            }
            catch (Exception ex)
            {
                iMessage.errorMsg("Erreur", ex.Message);
                //form.txtStatus.Caption = ex.Message;
            }
        }

        private void Delete_Data()
        {
            DialogResult re = MessageBox.Show($"Voulez-vous supprimer ce bon {txtDesignation.Text}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    db.Delete_Bon_Entree(idBonEntree);
                    iMessage.sucMsg("Information", "Ce bon a bien supprimé");
                    Verify_Buttons(true);
                    newRecord();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Verify_Buttons(bool status)
        {
            if (status)
            {
                btnAjouter.Enabled = true;
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
            }
            else
            {
                btnAjouter.Enabled = false;
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
            }
        }

        private void Verify_Buttons(Form f, string txt)
        {
            if (f.Text == txt)
            {
                btnAjouter.Enabled = true;
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
            }
            else
            {
                btnAjouter.Enabled = false;
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
            }
        }

        #endregion Overrides

        public frmEBonAdd(frmEBon form)
        {
            InitializeComponent();
            this.form = form;
            LoadFournisseur();
        }

        public frmEBonAdd(frmEBon form, Bon_Entree bs) : this(form)
        {
            this.bs = bs;
            LoadFournisseur();
            setValue(bs);
        }

        private void frmEBonAdd_Load(object sender, EventArgs e)
        {
            Verify_Buttons(this, "Ajouter un bon d'entrée");
            if (Text == "Ajouter un bon d'entrée")
                newRecord();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Add_Data();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Update_Data();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Delete_Data();
        }

        private void cmbxFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxFournisseur.SelectedIndex != -1)
            {
                LoadRepresentant((int)cmbxFournisseur.SelectedValue);
            }
            else
                cmbxRepresentant.SelectedIndex = -1;
        }

        private void txtDesignation_Validating(object sender, CancelEventArgs e)
        {
            txtDesignation.Text = iText.ValidateText(txtDesignation.Text, TypeText.Majuscule);
        }

        private void txtReference_Validating(object sender, CancelEventArgs e)
        {
            txtReference.Text = iText.ValidateText(txtReference.Text, TypeText.Majuscule);
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            txtDesignation.Text = iText.ValidateText(txtDesignation.Text, TypeText.Defaut);
        }
    }
}