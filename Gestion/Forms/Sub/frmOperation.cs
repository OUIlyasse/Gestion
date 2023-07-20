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
    public partial class frmOperation : Form
    {
        #region Variables

        private GestionEntities db = new GestionEntities();
        private char TypeOperation;
        private frmStock frmStock;

        #endregion Variables

        #region Code

        private void getData(char v, string pneu)
        {
            lblPneu.Text = $"Référence: {pneu}";
            switch (v)
            {
                case 'E':
                    lblType.Text = $"Type d'operation: Entrées";
                    dgvOperation.DataSource = db.Select_Operation_By_Operation("E", pneu);
                    break;

                case 'R':
                    lblType.Text = $"Type d'operation: Retours";
                    dgvOperation.DataSource = db.Select_Operation_By_Operation("R", pneu);
                    break;

                case 'S':
                    lblType.Text = $"Type d'operation: Sorties";
                    dgvOperation.DataSource = db.Select_Operation_By_Operation("S", pneu);
                    break;
            }
        }

        #endregion Code

        #region New

        public frmOperation(char TypeOperation, string pneu, frmStock frmStock)
        {
            InitializeComponent();
            this.TypeOperation = TypeOperation;
            this.frmStock = frmStock;
            getData(TypeOperation, pneu);
        }

        #endregion New
    }
}