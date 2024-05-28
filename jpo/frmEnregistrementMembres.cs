using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jpo
{


    public partial class frmEnregistrementMembres : Form
    {
        
        OleDbDataReader dataReader;
        OleDbDataReader drLigue;

        Boolean ajout, modification = false;

        public frmEnregistrementMembres()
        {
            InitializeComponent();
        }

        private void frmEnregistrementMembres_Load(object sender, EventArgs e)
        {


            dvgMembres.ColumnCount = 7;

            dvgMembres.RowHeadersVisible = false;
            dvgMembres.ColumnHeadersVisible = false;
            dvgMembres.MultiSelect = false;
            dvgMembres.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dvgMembres.AllowUserToResizeColumns = false;
            dvgMembres.AllowUserToResizeRows = false;
            dvgMembres.ReadOnly = true;
            dvgMembres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgMembres.AllowUserToAddRows = false;

            dvgMembres.Columns[0].Visible = false;
            dvgMembres.Columns[1].Width = 87;
            dvgMembres.Columns[2].Width = 87;

            for(int k = 3; k < 7; k++)
            {
                dvgMembres.Columns[k].Visible = false;
            }

            fillTable();
           


            if(dvgMembres.RowCount > 0)
            {
                dvgMembres.CurrentRow.Selected = false;
                dvgMembres.Rows[0].Selected = true;
            }

            //tbxNom.Text = dvgMembres[1, int.Parse(dvgMembres.CurrentRow.Index.ToString())].Value.ToString();
            //tbxPrenom.Text = dvgMembres[2, int.Parse(dvgMembres.CurrentRow.Index.ToString())].Value.ToString();
            //tbxTel.Text = dvgMembres[3, int.Parse(dvgMembres.CurrentRow.Index.ToString())].Value.ToString();
            //tbxMail.Text = dvgMembres[4, int.Parse(dvgMembres.CurrentRow.Index.ToString())].Value.ToString();

            //int ligueID = int.Parse(dvgMembres[5, int.Parse(dvgMembres.CurrentRow.Index.ToString())].Value.ToString());


            //drLigue = DbConnex.GetDataReader("Select nomLigue from Ligues Where codeLigue = " + ligueID);

            //while (drLigue.Read())
            //{
            //    cbxLigue.Text = drLigue.GetString(0);
            //}


            tbxNom.Enabled = false;
            tbxPrenom.Enabled = false;
            tbxTel.Enabled = false;
            tbxMail.Enabled = false;
            cbxLigue.Enabled = false;

            if (DbConnex.etatConnection() != ConnectionState.Open) DbConnex.connexionBase();
            drLigue = DbConnex.GetDataReader("Select codeLigue, nomLigue from Ligues");

            DataTable dataTable = new DataTable();
            dataTable.Load(drLigue);

            cbxLigue.DataSource = dataTable;
            cbxLigue.DisplayMember = "nomLigue";
            cbxLigue.ValueMember = "codeLigue";

            
            DbConnex.connexionClose();

        }

        private void fillTable()
        {
            if (DbConnex.etatConnection() != ConnectionState.Open) DbConnex.connexionBase();

            dataReader = DbConnex.GetDataReader("Select Membre.*, nomLigue from Membre Inner Join Ligues on Ligues.codeLigue = Membre.codeLigue");

            dvgMembres.SelectionChanged -= dvgMembres_SelectionChanged;

            dvgMembres.RowCount = 0;

            int i = 0;
            while (dataReader.Read())
            {
                dvgMembres.Rows.Add();

                dvgMembres[0, i].Value = dataReader.GetInt32(0).ToString();
                dvgMembres[1, i].Value = dataReader.GetString(1);
                dvgMembres[2, i].Value = dataReader.GetString(2);
                dvgMembres[3, i].Value = dataReader.GetString(3);
                dvgMembres[4, i].Value = dataReader.GetValue(4).GetType().Name == "DBNull" ? "" : dataReader.GetString(4);
                dvgMembres[5, i].Value = dataReader.GetInt32(5).ToString();
                dvgMembres[6, i].Value = dataReader.GetString(6).ToString();
                
                i++;
            }

           

            

            dvgMembres.SelectionChanged += dvgMembres_SelectionChanged;
            DbConnex.connexionClose();
        }

        private void dvgMembres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgMembres_SelectionChanged(object sender, EventArgs e)
        {
            tbxNom.Text = dvgMembres[1, dvgMembres.CurrentRow.Index].Value.ToString();
            tbxPrenom.Text = dvgMembres[2, dvgMembres.CurrentRow.Index].Value.ToString();
            tbxTel.Text = dvgMembres[3,dvgMembres.CurrentRow.Index].Value.ToString();
            tbxMail.Text = dvgMembres[4, dvgMembres.CurrentRow.Index].Value.ToString();
            cbxLigue.Text = dvgMembres[6, dvgMembres.CurrentRow.Index].Value.ToString();
        }


        // ANNULER LA MODIFICATION OU AJOUT D'UN MEMBRE
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // Désactivation des champs du formulaire des membres.
            tbxNom.Enabled = false;
            tbxPrenom.Enabled = false;
            tbxTel.Enabled = false;
            tbxMail.Enabled = false;
            cbxLigue.Enabled = false;
            
            dvgMembres.Enabled = true;

            btnDelete.Visible = true;
            btnModify.Visible = true;

            dvgMembres.CurrentRow.Selected = false;
            dvgMembres.CurrentRow.Selected = true;

            // Désactivation des types de modification ou ajout
            ajout = false;
            modification = false;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Connexion à la base si elle n'est pas connecté.
            if (DbConnex.etatConnection() != ConnectionState.Open) DbConnex.connexionBase();


            int currentRow = -1;
            // Si la validation correspond à un ajout ou une modification d'un enregistrements.
            if (ajout)
            {
                // AJOUT //

                
                

                // Recuperer l'id de la ligue choisi dans le formulaire.
                int idLigue = int.Parse(dvgMembres[5, dvgMembres.CurrentRow.Index].Value.ToString());

                // Requête d'ajout d'un membre à la liste des membres.
                DbConnex.ajouterMembre(tbxNom.Text, tbxPrenom.Text, tbxTel.Text, tbxMail.Text, idLigue);

                

            }else if(modification)
            {
                // Recuperer l'id de la ligue choisi dans le formulaire.
                int idLigue = int.Parse(cbxLigue.SelectedValue.ToString());

                // Recuperer le codeMembre du membre séléctionné.
                int codeMembre = int.Parse(dvgMembres[0, dvgMembres.CurrentRow.Index].Value.ToString());

                currentRow = dvgMembres.CurrentRow.Index;
                // Requête de modification d'un membre à la liste des membres
                DbConnex.modifierMembre(tbxNom.Text, tbxPrenom.Text, tbxTel.Text, tbxMail.Text, idLigue, codeMembre);


            }

            fillTable();

            tbxNom.Enabled = false;
            tbxPrenom.Enabled = false;
            tbxTel.Enabled = false;
            tbxMail.Enabled = false;
            cbxLigue.Enabled = false;

            dvgMembres.Enabled = true;

            btnDelete.Visible = true;
            btnModify.Visible = true;
            ajout = false;
            modification = false;


            dvgMembres.ClearSelection();
            dvgMembres.Rows[0].Selected = true;
            // Fermeture de la connexion à la base de donnée
            DbConnex.connexionClose();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            modification = true;
            ajout = false;
            cbxLigue.Enabled = true;
            tbxMail.Enabled = true;
            tbxNom.Enabled = true;
            tbxPrenom.Enabled = true;
            tbxTel.Enabled = true;
            dvgMembres.Enabled = false;

            btnDelete.Visible = false;
            btnModify.Visible = false;
        }

        private void dvgMembres_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sur de supprimer ce réservant ?", "Confirmation de suppression", MessageBoxButtons.YesNoCancel);

            if(result == DialogResult.Yes)
            {
                int codeMembre = int.Parse(dvgMembres[0, dvgMembres.CurrentRow.Index].Value.ToString());

                if (DbConnex.etatConnection() != ConnectionState.Open) DbConnex.connexionBase();

                DbConnex.supprimerMembre(codeMembre);


            }

            fillTable();
            dvgMembres.ClearSelection();
            dvgMembres.Rows[0].Selected = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ajout = true;
            modification = false;
            cbxLigue.Text = "";
            tbxMail.Text = "";
            tbxNom.Text = "";
            tbxPrenom.Text = "";
            tbxTel.Text = "";

            cbxLigue.Enabled = true;
            tbxMail.Enabled = true;
            tbxNom.Enabled = true;
            tbxPrenom.Enabled = true;
            tbxTel.Enabled = true;
            dvgMembres.Enabled = false;

            btnDelete.Visible = false;
            btnModify.Visible = false;

        }

    }
}
