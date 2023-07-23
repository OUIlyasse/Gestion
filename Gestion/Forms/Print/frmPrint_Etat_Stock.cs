using Gestion.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Forms.Print
{
    public partial class frmPrint_Etat_Stock : Form
    {
        #region Variables

        private GestionEntities db = new GestionEntities();

        #endregion Variables

        #region Codes

        private void getData()
        {
            var rs = db.SommeQte();
            dgvStock.DataSource = rs;
        }

        #endregion Codes

        public frmPrint_Etat_Stock()
        {
            InitializeComponent();
        }

        private void frmPrint_Etat_Stock_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath.ToString() + @"\Report\Etat de stock.frxt";
            report1.Load(path);
            //report1.Load(@"E:\VS17\Gestion\Gestion\Report\Etat de stock.frx");
            report1.Dictionary.Connections[0].ConnectionString = Properties.Settings.Default.conString;
            report1.Show();
        }
    }
}