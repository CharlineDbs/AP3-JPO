using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Common;

namespace jpo
{
    public partial class frmEnregistrementLigues : Form
    {

        bool enregModifierLigue;
        bool ajoutLigue;


        public frmEnregistrementLigues()
        {
            InitializeComponent();
        }

        private void frmEnregistrementLigues_Load(object sender, EventArgs e)
        {

            btnModifier.Visible = true;
            btnSupprimer.Visible = true;
            btnEnregistrer.Visible = false;
            btnAnnuler.Visible = false;

            // on initialise le dgv
            dgvLigues.ColumnCount = 6;
            dgvLigues.Columns[0].Visible = false;
            dgvLigues.Columns[1].Width = 200;
            dgvLigues.Columns[2].Visible = false;
            dgvLigues.Columns[3].Visible = false;
            dgvLigues.Columns[4].Visible = false;
            dgvLigues.Columns[5].Visible = false;


            dgvLigues.RowHeadersVisible = false;
            dgvLigues.ColumnHeadersVisible = false;
            dgvLigues.MultiSelect = false;
            dgvLigues.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvLigues.AllowUserToResizeColumns = false;
            dgvLigues.AllowUserToResizeRows = false;
            dgvLigues.ReadOnly = true;
            dgvLigues.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLigues.AllowUserToAddRows = false;


            // on affiche les informations du dgv
            fillTable();


            if (dgvLigues.RowCount > 0)
            {
                dgvLigues.CurrentRow.Selected = false;
                dgvLigues.Rows[0].Selected = true;
            }

        }

        // on ajoute dans les champs de saisis
        private void dgvLigues_SelectionChanged(object sender, EventArgs e)
        {


            tbxNom.Text = dgvLigues[1, int.Parse(dgvLigues.CurrentRow.Index.ToString())].Value.ToString();
            tbxAdresse.Text = dgvLigues[2, int.Parse(dgvLigues.CurrentRow.Index.ToString())].Value.ToString();
            tbxCp.Text = dgvLigues[3, int.Parse(dgvLigues.CurrentRow.Index.ToString())].Value.ToString();
            tbxVille.Text = dgvLigues[4, int.Parse(dgvLigues.CurrentRow.Index.ToString())].Value.ToString();
            tbxDiscipline.Text = dgvLigues[5, int.Parse(dgvLigues.CurrentRow.Index.ToString())].Value.ToString();



            tbxNom.Enabled = false;
            tbxAdresse.Enabled = false;
            tbxCp.Enabled = false;
            tbxVille.Enabled = false;
            tbxDiscipline.Enabled = false;

        }

        // on met les champs vide 
        private void btnAjouter_Click(object sender, EventArgs e)
        {

            btnModifier.Visible = false;
            btnSupprimer.Visible = false;
            btnEnregistrer.Visible = true;
            btnAnnuler.Visible = true;

            tbxNom.Text = "";
            tbxAdresse.Text = "";
            tbxCp.Text = "";
            tbxVille.Text = "";
            tbxDiscipline.Text = "";



            tbxNom.Enabled = true;
            tbxAdresse.Enabled = true;
            tbxCp.Enabled = true;
            tbxVille.Enabled = true;
            tbxDiscipline.Enabled = true;


            ajoutLigue = true;
            enregModifierLigue = false;

        }

        // soit on ajoute soit on modifie avec le bouton enregistrer
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            int idLigue;
            // connexion

            if (DbConnex.etatConnection() != ConnectionState.Open)
            {
                DbConnex.connexionBase();
            }

            if (ajoutLigue)
            {
                DbConnex.ajouterLigue(tbxNom.Text, tbxAdresse.Text, tbxCp.Text, tbxVille.Text, tbxDiscipline.Text);


            }
            else if (enregModifierLigue)
            {
                idLigue = int.Parse(dgvLigues[0, dgvLigues.CurrentRow.Index].Value.ToString());
                DbConnex.modifierLigue(idLigue, tbxNom.Text, tbxAdresse.Text, tbxCp.Text, tbxVille.Text, tbxDiscipline.Text);


            }

            // on affiche les champs dans le dgv
            fillTable();

            // réactive les champs

            tbxNom.Enabled = false;
            tbxAdresse.Enabled = false;
            tbxCp.Enabled = false;
            tbxVille.Enabled = false;
            tbxDiscipline.Enabled = false;
            dgvLigues.Enabled = true;

            btnModifier.Visible = true;
            btnSupprimer.Visible = true;
            btnEnregistrer.Visible = false;
            btnAnnuler.Visible = false;


            // fermer connexion
            DbConnex.connexionClose();

            ajoutLigue = false;
            enregModifierLigue = false;
        }

        // on supprime les enregistrements 
        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            if (DbConnex.etatConnection() != ConnectionState.Open)
            {
                DbConnex.connexionBase();
            }

            const string message = "Es-tu sur de vouloir supprimer ?";
            const string caption = "Supprimer";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int idLigues = int.Parse(dgvLigues[0, dgvLigues.CurrentRow.Index].Value.ToString());
                DbConnex.supprimerLigue(idLigues);


                fillTable();
            }

            tbxNom.Text = "";
            tbxAdresse.Text = "";
            tbxCp.Text = "";
            tbxVille.Text = "";
            tbxDiscipline.Text = "";

            enregModifierLigue = false;
            ajoutLigue = false;

            tbxNom.Enabled = false;
            tbxAdresse.Enabled = false;
            tbxCp.Enabled = false;
            tbxVille.Enabled = false;
            tbxDiscipline.Enabled = false;
            dgvLigues.Enabled = true;

            btnModifier.Visible = true;
            btnSupprimer.Visible = true;
            btnEnregistrer.Visible = false;
            btnAnnuler.Visible = false;
            btnAjouter.Visible = true;

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            if (DbConnex.etatConnection() != ConnectionState.Open)
            {
                DbConnex.connexionBase();
            }

            enregModifierLigue = true;
            ajoutLigue = false;

            tbxNom.Enabled = true;
            tbxAdresse.Enabled = true;
            tbxCp.Enabled = true;
            tbxVille.Enabled = true;
            tbxDiscipline.Enabled = true;
            dgvLigues.Enabled = false;

            btnModifier.Visible = false;
            btnSupprimer.Visible = false;
            btnEnregistrer.Visible = true;
            btnAnnuler.Visible = true;
            btnAjouter.Visible = true;

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            tbxNom.Text = "";
            tbxAdresse.Text = "";
            tbxCp.Text = "";
            tbxVille.Text = "";
            tbxDiscipline.Text = "";

            tbxNom.Enabled = false;
            tbxAdresse.Enabled = false;
            tbxCp.Enabled = false;
            tbxVille.Enabled = false;
            tbxDiscipline.Enabled = false;
            dgvLigues.Enabled = true;


            btnModifier.Visible = true;
            btnSupprimer.Visible = true;
            btnEnregistrer.Visible = false;
            btnAnnuler.Visible = false;
            btnAjouter.Visible = true;

            enregModifierLigue = false;
            ajoutLigue = false;
        }

        // on rempli le dgv avec les champs
        private void fillTable()
        {
            if (DbConnex.etatConnection() != ConnectionState.Open)
            {
                DbConnex.connexionBase();
            }
            // requête pour afficher les ligues
            OleDbDataReader drLigues = DbConnex.GetDataReader("select * from ligues");

            dgvLigues.SelectionChanged -= dgvLigues_SelectionChanged;

            dgvLigues.RowCount = 0;

            int i = 0;

            while (drLigues.Read())
            {
                dgvLigues.Rows.Add();

                dgvLigues[0, i].Value = drLigues.GetInt32(0).ToString();
                dgvLigues[1, i].Value = drLigues.GetString(1).ToString();
                dgvLigues[2, i].Value = drLigues.GetString(2).ToString();
                dgvLigues[3, i].Value = drLigues.GetString(3).ToString();
                dgvLigues[4, i].Value = drLigues.GetString(4).ToString();
                dgvLigues[5, i].Value = drLigues.GetString(5).ToString();
                i++;

            }

            dgvLigues.SelectionChanged += dgvLigues_SelectionChanged;
            DbConnex.connexionClose();
        }

    }
}
