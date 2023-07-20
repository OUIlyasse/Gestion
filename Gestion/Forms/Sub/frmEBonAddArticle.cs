using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion.DB;
using iTools;
using static iTools.iUtile;

namespace Gestion.Forms.Sub
{
    public partial class frmEBonAddArticle : Form
    {
        #region Vatiables

        private GestionEntities db = new GestionEntities();
        private Bon_Entree bs;
        private int idBonArticle, idBon;
        private frmEBon frmEBon;
        private Bon_Entree_Article ei;

        #endregion Vatiables

        #region Code

        private void LoadPneux()
        {
            cmbxPneu.DisplayMember = "pne_Designation";
            cmbxPneu.ValueMember = "pne_ID";
            cmbxPneu.DataSource = db.Select_Pneu().ToList();
            cmbxPneu.SelectedValue = -1;
        }

        private void newRecord()
        {
            iText.Clear(this);
            Text = "Ajouter un pneu";
            getData();
            txtQte.Focus();
            lblQte.Text = string.Empty;
        }

        private void getData()
        {
            frmEBon.getData_EBon_Articles(idBon);
        }

        private void Verify_Buttons(bool status)
        {
            if (status)
            {
                btnAjouter.Enabled = true;
                btnModifier.Enabled = false;
                //btnSupprimer.Enabled = false;
            }
            else
            {
                btnAjouter.Enabled = false;
                btnModifier.Enabled = true;
                //btnSupprimer.Enabled = true;
            }
        }

        private void Verify_Buttons(Form f, string txt)
        {
            if (f.Text == txt)
            {
                btnAjouter.Enabled = true;
                btnModifier.Enabled = false;
                //btnSupprimer.Enabled = false;
            }
            else
            {
                btnAjouter.Enabled = false;
                btnModifier.Enabled = true;
                //btnSupprimer.Enabled = true;
            }
        }

        private int maxID()
        {
            return (int)db.MaxID_Bon_Entree_Article().FirstOrDefault();
        }

        private void setValue(Bon_Entree_Article vl)
        {
            idBonArticle = vl.be_A_ID;
            txtQte.Text = $"{vl.be_Qte_Livree}";
            cmbxPneu.SelectedValue = (int)vl.pne_ID;
            txtDescription.Text = vl.be_A_Description;
        }

        private void Add_Data()
        {
            try
            {
                if (string.IsNullOrEmpty(txtQte.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQte.Focus();
                    return;
                }

                if (cmbxPneu.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxPneu.Focus();
                    return;
                }

                var rs = db.Insert_Bon_Entree_Article(maxID(), DateTime.Now, int.Parse(txtQte.Text), idBon, (int)cmbxPneu.SelectedValue, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Ce pneu {cmbxPneu.Text} est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbxPneu.Focus();
                        break;

                    case 1:
                        iMessage.sucMsg("Information", "Votre pneu a bien ajouté");
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
                if (string.IsNullOrEmpty(txtQte.Text.Trim()))
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQte.Focus();
                    return;
                }

                if (cmbxPneu.SelectedIndex == -1)
                {
                    MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxPneu.Focus();
                    return;
                }

                var rs = db.Update_Bon_Entree_Article(idBonArticle, DateTime.Now, int.Parse(txtQte.Text), idBon, (int)cmbxPneu.SelectedValue, txtDescription.Text).FirstOrDefault();
                switch (rs)
                {
                    case 0:
                        MessageBox.Show($"Ce pneu {cmbxPneu.Text} est existe déjà", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbxPneu.Focus();
                        break;

                    case 1:
                        iMessage.sucMsg("Information", "Votre pneu a bien modifié");
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

        private int restQte()
        {
            return db.ResteQteArticle((int)cmbxPneu.SelectedValue).FirstOrDefault() > 0 ? (int)db.ResteQteArticle((int)cmbxPneu.SelectedValue).FirstOrDefault() : 0;
        }

        #endregion Code

        public frmEBonAddArticle(frmEBon frmEBon, Bon_Entree bs)
        {
            InitializeComponent();
            this.frmEBon = frmEBon;
            LoadPneux();
            this.bs = bs;
            idBon = bs.be_ID;
        }

        public frmEBonAddArticle(frmEBon frmEBon, Bon_Entree_Article ei)
        {
            InitializeComponent();
            LoadPneux();
            this.frmEBon = frmEBon;
            idBon = (int)ei.be_ID;
            this.ei = ei;
        }

        private void txtQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Add_Data();
        }

        private void frmEBonAddArticle_Load(object sender, EventArgs e)
        {
            Verify_Buttons(this, "Ajouter un pneu");
            if (Text == "Ajouter un pneu")
            {
                newRecord();
                lblQte.Text = string.Empty;
            }
            else
            {
                setValue(ei);
                lblQte.Text = $"En stock: {restQte()} pneu (x)";
            }
        }

        private void cmbxPneu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxPneu.SelectedIndex != -1)
            {
                lblQte.Text = $"En stock: {restQte()} pneu (x)";
            }
            else
                lblQte.Text = string.Empty;
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            txtDescription.Text = iText.ValidateText(txtDescription.Text, TypeText.Defaut);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Update_Data();
        }
    }
}