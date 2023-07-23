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

namespace Gestion.Forms.Sub
{
    public partial class frmJournal : Form
    {
        #region Variable

        private GestionEntities db = new GestionEntities();
        private string pneu;
        private int idPneu;

        #endregion Variable

        #region Code

        private void getJournal()
        {
            lblPneu.Text = $"Pneu: {pneu}";
            dgvStock.DataSource = db.Journal_All_Operation(pneu);
        }

        private int restQte()
        {
            return db.ResteQteArticle(idPneu).FirstOrDefault() > 0 ? (int)db.ResteQteArticle(idPneu).FirstOrDefault() : 0;
        }

        #endregion Code

        public frmJournal(string pneu, int idPneu)
        {
            InitializeComponent();
            this.pneu = pneu;
            this.idPneu = idPneu;
        }

        private void frmJournal_Load(object sender, EventArgs e)
        {
            getJournal();
            lblRest.Text = $"Reste: {restQte()}";
        }
    }
}