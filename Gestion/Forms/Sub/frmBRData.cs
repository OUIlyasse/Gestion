using Gestion.Forms.Main;
using iTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Forms.Sub
{
    public partial class frmBRData : Form
    {
        #region Variable

        private string BPath = Properties.Settings.Default.BPath;
        private frmMain frmMain;

        #endregion Variable

        #region Code

        private void Backup()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.conStringMaster))
                {
                    con.Open();
                    //string sql = $"BACKUP DATABASE {con.Database.ToString()} to disk = {@"" + txtLocation.Text + ""}\backup{DateTime.Now.ToString("yyyyMMddHHmm")}.bak';";
                    string file = txtBPath.Text + @"\" + "backup" + "" + DateTime.Now.ToString("yyyyMMddHHmm") + ".bak";
                    string sql = string.Format("BACKUP DATABASE Gestion TO DISK = '{0}'", file);
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                        //iMessage.sucMsg("Success", "Votre backup");
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Restore()
        {
            try
            {
                string sql = "Alter Database Gestion SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += "Restore Database Gestion FROM DISK ='" + txtRPath.Text + "' WITH REPLACE;";
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.conStringMaster))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Code

        public frmBRData(frmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }

        private void btnBBrowse_Click(object sender, EventArgs e)
        {
            using (var folder = new FolderBrowserDialog())
            {
                folder.SelectedPath = BPath;
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    txtBPath.Text = folder.SelectedPath;
                    //BPath = folder.SelectedPath;
                    //Properties.Settings.Default.Save();
                }
            }
        }

        private void btnRBrowse_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                open.FileName = string.Empty;
                open.Filter = "Backup File |*.bak";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtRPath.Text = open.FileName;
                }
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBPath.Text.Trim()))
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBPath.Focus();
                return;
            }
            btnBackup.Enabled = false;
            backgroundWorkerBackup.RunWorkerAsync();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRPath.Text.Trim()))
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRPath.Focus();
                return;
            }
            btnRestore.Enabled = false;
            backgroundWorkerRestore.RunWorkerAsync();
        }

        private void backgroundWorkerBackup_DoWork(object sender, DoWorkEventArgs e)
        {
            Backup();
        }

        private void backgroundWorkerBackup_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbBStatus.Value = e.ProgressPercentage;
            lblBStatus.Text = $"{e.ProgressPercentage}%";
        }

        private void backgroundWorkerBackup_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnBackup.Enabled = true;
            iMessage.sucMsg("Success", "Votre sauvegarde est créée correctement");
        }

        private void backgroundWorkerRestore_DoWork(object sender, DoWorkEventArgs e)
        {
            Restore();
        }

        private void backgroundWorkerRestore_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbRStatus.Value = e.ProgressPercentage;
            lblRStatus.Text = $"{e.ProgressPercentage}%";
        }

        private void backgroundWorkerRestore_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnRestore.Enabled = true;
            iMessage.sucMsg("Success", "Votre restauration s'effectue correctement");
        }

        private void frmBRData_Load(object sender, EventArgs e)
        {
            txtBPath.Text = BPath;
            lblBStatus.Text = string.Empty;
            lblRStatus.Text = string.Empty;
        }

        private void pbBStatus_Click(object sender, EventArgs e)
        {
        }
    }
}