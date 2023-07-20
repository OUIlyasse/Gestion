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
    public partial class frmSBonAdd : Form
    {
        #region Variables

        private GestionEntities db = new GestionEntities();
        private int idBonSortie;
        private frmSBon form;
        private Bon_Sortie bs;

        #endregion Variables

        #region Codes

        private void LoadUSoutien()
        {
            cmbxUSoutien.DisplayMember = "unt_Unite";
            cmbxUSoutien.ValueMember = "unt_ID";
            cmbxUSoutien.DataSource = db.Select_Unite_Soutien();
            cmbxUSoutien.SelectedValue = -1;
        }

        private int maxID()
        {
            return (int)db.MaxID_Bon_Sortie().FirstOrDefault();
        }

        private void setValue(Bon_Sortie vl)
        {
            idBonSortie = vl.bs_ID;
            txtDesignation.Text = vl.bs_Designation;
            dtDate.Value = (DateTime)vl.bs_Date;
            cmbxUSoutien.SelectedValue = (int)vl.unt_ID;
            txtReference.Text = vl.bs_Reference;
            txtDescription.Text = vl.bs_Description;
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
            Text = "Ajouter un bon de sortie";
            txtDesignation.Text = maxBL();
            getData();
            txtDesignation.Focus();
        }

        private void getData()
        {
            form.getData_SBon();
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
                if (cmbxUSoutien.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxUSoutien.Focus();
                    return;
                }

                var rs = db.Insert_Bon_Sortie(maxID(), dtDate.Value, txtDesignation.Text, txtReference.Text, (int)cmbxUSoutien.SelectedValue, txtDescription.Text).FirstOrDefault();
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
                if (cmbxUSoutien.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxUSoutien.Focus();
                    return;
                }

                var rs = db.Update_Bon_Sortie(idBonSortie, (DateTime)dtDate.Value, txtDesignation.Text, txtReference.Text, (int)cmbxUSoutien.SelectedValue, txtDescription.Text).FirstOrDefault();
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
                    db.Delete_Bon_Sortie(idBonSortie);
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

        public frmSBonAdd(frmSBon frmSBon)
        {
            InitializeComponent();
            form = frmSBon;
            LoadUSoutien();
        }

        public frmSBonAdd(frmSBon frmSBon, Bon_Sortie bs) : this(frmSBon)
        {
            this.bs = bs;
            LoadUSoutien();
            setValue(bs);
        }

        private void frmSBonAdd_Load(object sender, EventArgs e)
        {
            Verify_Buttons(this, "Ajouter un bon de sortie");
            if (Text == "Ajouter un bon de sortie")
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

        private void txtDesignation_Validating(object sender, CancelEventArgs e)
        {
            txtDesignation.Text = iText.ValidateText(txtDesignation.Text, TypeText.Majuscule);
        }

        private void txtReference_Validating(object sender, CancelEventArgs e)
        {
            txtReference.Text = iText.ValidateText(txtReference.Text, TypeText.Majuscule);
        }
    }
}