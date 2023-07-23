using Gestion.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Forms.Print
{
    public partial class frmPrint_Historique_Article : Form
    {
        #region Vatiables

        private GestionEntities db = new GestionEntities();

        #endregion Vatiables

        #region Codes

        private void LoadPneux()
        {
            cmbxPneu.DisplayMember = "pne_Designation";
            cmbxPneu.ValueMember = "pne_ID";
            cmbxPneu.DataSource = db.Select_Pneu().ToList();
            cmbxPneu.SelectedValue = -1;
        }

        private void getJournal(string pneu)
        {
            dgvStock.DataSource = db.Journal_All_Operation(pneu);
        }

        #endregion Codes

        public frmPrint_Historique_Article()
        {
            InitializeComponent();
        }

        private void frmPrint_Historique_Article_Load(object sender, EventArgs e)
        {
            LoadPneux();
        }

        private void cmbxPneu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxPneu.SelectedIndex != -1)
            {
                string pneu = cmbxPneu.Text;
                getJournal(pneu);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbxPneu.SelectedIndex != -1)
                {
                    string path = Application.StartupPath.ToString() + @"\Report\Hisorique d'article.frxt";
                    report1.Load(path);
                    //report1.Load(@"E:\VS17\Gestion\Gestion\Report\Hisorique d'article.frx");
                    report1.Dictionary.Connections[0].ConnectionString = Properties.Settings.Default.conString;
                    report1.SetParameterValue("pne_Designation", cmbxPneu.Text);
                    report1.Show();
                }
                else
                {
                    MessageBox.Show("Votre champs est vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbxPneu.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}