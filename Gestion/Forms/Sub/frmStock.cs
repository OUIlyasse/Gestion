using Gestion.DB;
using Gestion.Forms.Main;
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
    public partial class frmStock : Form
    {
        #region Variables

        private GestionEntities db = new GestionEntities();
        private frmMain frmMain;
        private int rowSelected;

        #endregion Variables

        #region Codes

        private void getData()
        {
            var rs = db.SommeQte();
            dgvStock.DataSource = rs;
        }

        private void showOperation(char operation)
        {
            string pneu = $"{dgvStock.Rows[rowSelected].Cells[colpne_Designation.Name].Value}";
            frmOperation frm;
            switch (operation)
            {
                case 'E':
                    frm = new frmOperation('E', pneu, this);
                    frm.ShowDialog();
                    break;

                case 'S':
                    frm = new frmOperation('S', pneu, this);
                    frm.ShowDialog();
                    break;

                case 'R':
                    frm = new frmOperation('R', pneu, this);
                    frm.ShowDialog();
                    break;
            }
        }

        #endregion Codes

        #region New

        public frmStock(frmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
            getData();
        }

        #endregion New

        private void dgvStock_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;
            e.ContextMenuStrip = menuDGV;
            rowSelected = e.RowIndex;
        }

        private void dgvStock_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    dgvStock.CurrentCell = dgvStock[e.ColumnIndex, e.RowIndex];
                }
            }
        }

        private void entreesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showOperation('E');
        }

        private void sortiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showOperation('S');
        }

        private void retoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showOperation('R');
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = e.RowIndex;
        }
    }
}