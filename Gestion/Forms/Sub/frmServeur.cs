using Gestion.DB;
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
    public partial class frmServeur : Form
    {
        #region Variables

        private GestionEntities db = new GestionEntities();
        private frmMain form = new frmMain();

        #endregion Variables

        #region Codes

        private void LoadInstinceName()
        {
            if (Environment.Is64BitOperatingSystem == true)
            {
                iSQL.GetInstanceName32(cmbxServeur);
            }
            else
            {
                iSQL.GetInstanceName64(cmbxServeur);
            }
        }

        private string GenerateConString(string Database)
        {
            string conString = $"Server = {cmbxServeur.Text}; Database = {Database}; ";
            switch (cmbxAuthentification.Text)
            {
                case "Windows Autentification":
                    conString += $"Trusted_Connection = True;";
                    break;

                case "SQL Server Autentification":
                    conString += $"User Id={txtUser.Text};Password={txtPass.Text};";
                    break;
            }

            return conString;
        }

        #endregion Codes

        public frmServeur()
        {
            InitializeComponent();
        }

        private void cmbxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShow.Checked)
                txtPass.UseSystemPasswordChar = false;
            else
                txtPass.UseSystemPasswordChar = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            //db.Database.Connection.ConnectionString = @"data source=ILYASSE-PC\test;initial catalog=Gestion;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            //MessageBox.Show($"{db.Database.Connection.ConnectionString}");
        }

        private void cmbxAuthentification_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxAuthentification.SelectedIndex != -1)
            {
                switch (cmbxAuthentification.SelectedIndex)
                {
                    case 0:
                        txtUser.Enabled = false;
                        txtPass.Enabled = false;
                        txtUser.Text = "";
                        txtPass.Text = "";
                        ckbShow.Enabled = false;
                        break;

                    case 1:
                        txtUser.Enabled = true;
                        txtPass.Enabled = true;
                        ckbShow.Enabled = true;
                        txtUser.Focus();
                        break;
                }
            }
        }

        private void btnTestConnexion_Click(object sender, EventArgs e)
        {
            if (cmbxServeur.SelectedIndex == -1)
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbxServeur.Focus();
                return;
            }
            if (cmbxAuthentification.SelectedIndex == -1)
            {
                MessageBox.Show("Votre champ est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbxAuthentification.Focus();
                return;
            }
            iSQL.TestConnection(cmbxServeur.Text, txtUser.Text, txtPass.Text, "Gestion");
        }

        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                string sqlConnectionString = $"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=master;Data Source={cmbxServeur.Text}";

                form.lblStatus.Text = "Chargement des scripts...";
                StreamReader createDatabaseScriptStreamReader = File.OpenText(Application.StartupPath + "\\SQLGestion.sql");
                using (SqlConnection sqlConnection = new SqlConnection(sqlConnectionString))
                {
                    sqlConnection.Open();

                    ExecuteScript(createDatabaseScriptStreamReader, sqlConnection);

                    sqlConnection.Close();
                }

                form.lblStatus.Text = "Terminé";
                //Server = ILYASSE-PC\ILYASSE; Database = Gestion; Integrated Security = True;
                Properties.Settings.Default.conString = GenerateConString("Gestion");
                Properties.Settings.Default.conStringMaster = GenerateConString("master");
                Properties.Settings.Default.Save();
                Cursor = Cursors.Default;
                Application.Restart();
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void ExecuteScript(StreamReader createDatabaseScriptStreamReader, SqlConnection sqlConnection)
        {
            StringBuilder stringBuilder = new StringBuilder();

            while (!createDatabaseScriptStreamReader.EndOfStream)
            {
                string line = createDatabaseScriptStreamReader.ReadLine();

                if (line == "GO")
                {
                    try
                    {
                        string command = stringBuilder.ToString();
                        string message;

                        if (command.Length > 15)
                            message = command.Substring(0, 15);
                        else
                            message = command;

                        message = message.Trim();

                        Console.WriteLine("Executing command \"" + message + "...\"");

                        SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    stringBuilder = new StringBuilder();
                }
                else
                {
                    stringBuilder.AppendLine(line);
                }
            }
        }

        private void frmServeur_Load(object sender, EventArgs e)
        {
            LoadInstinceName();
            cmbxServeur.SelectedIndex = 0;
            cmbxAuthentification.SelectedIndex = 0;
        }
    }
}