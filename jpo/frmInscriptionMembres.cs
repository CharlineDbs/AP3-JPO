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
    public partial class frmInscriptionMembres : Form
    {

        private OleDbDataReader dataReader;
        private OleDbDataReader drCreneau;
        private OleDbDataReader drActivite;
        private OleDbDataReader drMembreNonInscrit;
        private bool ajout, modification = false;

        public frmInscriptionMembres()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmInscriptionMembres_Load(object sender, EventArgs e)
        {

            dvgInscriptions.ColumnCount = 7;

            dvgInscriptions.RowHeadersVisible = false;
            dvgInscriptions.ColumnHeadersVisible = false;
            dvgInscriptions.MultiSelect = false;
            dvgInscriptions.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dvgInscriptions.AllowUserToResizeColumns = false;
            dvgInscriptions.AllowUserToResizeRows = false;
            dvgInscriptions.ReadOnly = true;
            dvgInscriptions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgInscriptions.AllowUserToAddRows = false;

            dvgInscriptions.Columns[0].Visible = false;
            dvgInscriptions.Columns[1].Width = 87;
            dvgInscriptions.Columns[2].Width = 87;

            for (int k = 3; k < 7; k++)
            {
                dvgInscriptions.Columns[k].Visible = false;
            }

            fillTable();

            if (DbConnex.etatConnection() != ConnectionState.Open) DbConnex.connexionBase();
            drCreneau = DbConnex.GetDataReader("Select codeCréneau, libelléCréneau from Creneau");

            DataTable dataTable = new DataTable();
            dataTable.Load(drCreneau);

            cbxCreneau.DataSource = dataTable;
            cbxCreneau.DisplayMember = "libelléCréneau";
            cbxCreneau.ValueMember = "codeCréneau";

            drActivite = DbConnex.GetDataReader("Select codeActiv, LibelleActiv from Activite");
            dataTable = new DataTable();
            dataTable.Load(drActivite);

            cbxActivite.DataSource = dataTable;
            cbxActivite.DisplayMember = "LibelleActiv";
            cbxActivite.ValueMember = "codeActiv";

            DbConnex.connexionClose();

            cbxMembreNonInscris.Text = "";
            cbxMembreNonInscris.Enabled = false;
            cbxCreneau.Enabled = false;
            cbxActivite.Enabled = false;

        }


        private void fillTable()
        {
            if (DbConnex.etatConnection() != ConnectionState.Open) DbConnex.connexionBase();

            dataReader = DbConnex.GetDataReader("Select nom, prénom, libelléCréneau, LibelleActiv, Participer.codeMembre, Participer.codeCréneau, Participer.codeActivité From Participer, Creneau, Activite, Membre " +
                                                "WHERE Membre.codeMembre = Participer.codeMembre AND Creneau.codeCréneau = Participer.codeCréneau AND Activite.codeActiv = Participer.codeActivité"); 

            dvgInscriptions.SelectionChanged -= dvgInscriptions_SelectionChanged;

            dvgInscriptions.RowCount = 0;

            int i = 0;
            while (dataReader.Read())
            {
                dvgInscriptions.Rows.Add();

                dvgInscriptions[0, i].Value = dataReader.GetInt32(4);
                dvgInscriptions[1, i].Value = dataReader.GetString(0);
                dvgInscriptions[2, i].Value = dataReader.GetString(1);
                dvgInscriptions[3, i].Value = dataReader.GetString(2);
                dvgInscriptions[4, i].Value = dataReader.GetString(3);
                dvgInscriptions[5, i].Value = dataReader.GetString(5);
                dvgInscriptions[6, i].Value = dataReader.GetString(6);

                i++;
            }


            dvgInscriptions.SelectionChanged += dvgInscriptions_SelectionChanged;

            drMembreNonInscrit = DbConnex.GetDataReader("SELECT codeMembre, nom, prénom FROM Membre WHERE codeMembre NOT IN (Select codeMembre From Participer)");

            DataTable dataTable = new DataTable();
            dataTable.Load(drMembreNonInscrit);

            dataTable.Columns.Add("DisplayName");
            foreach (DataRow row in dataTable.Rows)
            {
                row["DisplayName"] = row["nom"].ToString() + " " + row["prénom"].ToString();
            }

            cbxMembreNonInscris.DataSource = dataTable;
            cbxMembreNonInscris.DisplayMember = "DisplayName";
            cbxMembreNonInscris.ValueMember = "codeMembre";

            DbConnex.connexionClose();
        }

        private void dvgInscriptions_SelectionChanged(object sender, EventArgs e)
        {
            cbxMembreNonInscris.Text = "";
            cbxCreneau.Text = dvgInscriptions[3, dvgInscriptions.CurrentRow.Index].Value.ToString();
            cbxActivite.Text = dvgInscriptions[4, dvgInscriptions.CurrentRow.Index].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sur de supprimer cette inscription ?", "Confirmation de suppression", MessageBoxButtons.YesNoCancel);

            if(result == DialogResult.Yes)
            {
                int codeMembre = int.Parse(dvgInscriptions[0, dvgInscriptions.CurrentRow.Index].Value.ToString());
                String codeCreneau = dvgInscriptions[5, dvgInscriptions.CurrentRow.Index].Value.ToString();
                String codeActivite = dvgInscriptions[6, dvgInscriptions.CurrentRow.Index].Value.ToString();
                if (DbConnex.etatConnection() != ConnectionState.Open) DbConnex.connexionBase();

                DbConnex.supprimerInscriptionMembre(codeMembre, codeCreneau, codeActivite);
                fillTable();
                DbConnex.connexionClose();
            }

            // Remplissage du tableau et de la liste des membres non inscrit mis à jour.
            
            dvgInscriptions.ClearSelection();
            dvgInscriptions.Rows[0].Selected = true;

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            // Activation de modification mais pas d'ajout.
            modification = true;
            ajout = false;

            dvgInscriptions.Enabled = false;

            // Activation des champs du formulaire.
            cbxMembreNonInscris.Enabled = false;
            cbxCreneau.Enabled = true;
            cbxActivite.Enabled = true;

            // Désactivation de certains boutons.
            btnDelete.Visible = false;
            btnModify.Visible = false;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Connexion à la base si elle n'est pas connecté.
            if (DbConnex.etatConnection() != ConnectionState.Open) DbConnex.connexionBase();


            // Si la validation correspond à un ajout ou une modification d'un enregistrements.
            if (ajout)
            {
                // AJOUT //


                // Récuperation des informations du formulaire.
                int codeMembre = int.Parse(cbxMembreNonInscris.SelectedValue.ToString());
                String codeCreneau = cbxCreneau.SelectedValue.ToString();
                String codeActivite = cbxActivite.SelectedValue.ToString();

                // Ajout dans la base de données.
                DbConnex.ajouterInscriptionMembre(codeMembre, codeCreneau, codeActivite);


            }
            else if (modification)
            {
                // Récuperation des valeurs actuel.
                int codeMembre = int.Parse(dvgInscriptions[0, dvgInscriptions.CurrentRow.Index].Value.ToString());
                String codeCreneau = dvgInscriptions[5, dvgInscriptions.CurrentRow.Index].Value.ToString();
                String codeActivite = dvgInscriptions[6, dvgInscriptions.CurrentRow.Index].Value.ToString();


                // Récuperation des nouvelles valeurs du formulaire.
                String newCodeCreneau = cbxCreneau.SelectedValue.ToString();
                String newCodeActivite = cbxActivite.SelectedValue.ToString();

                // Modification de l'enregistrement dans la base de données.
                DbConnex.modifierInscriptionMembre(newCodeCreneau, newCodeActivite, codeMembre, codeActivite, codeCreneau);

            }

            // Remplissage du tableau et de la liste des membres non inscrit mis à jour.
            fillTable();

            // Réactivation et Désactivation des champs et boutons.
            cbxMembreNonInscris.Enabled = false;
            cbxActivite.Enabled = false;
            cbxCreneau.Enabled = false;

            dvgInscriptions.Enabled = true;

            btnDelete.Visible = true;
            btnModify.Visible = true;

            ajout = false;
            modification = false;


            dvgInscriptions.ClearSelection();
            dvgInscriptions.Rows[0].Selected = true;

            // Fermeture de la connexion à la base de donnée
            DbConnex.connexionClose();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // Désactivation des champs du formulaire.
            cbxMembreNonInscris.Enabled = false;
            cbxCreneau.Enabled = false;
            cbxActivite.Enabled = false;

            dvgInscriptions.Enabled = true;

            btnDelete.Visible = true;
            btnModify.Visible = true;

            dvgInscriptions.Rows[dvgInscriptions.CurrentRow.Index].Selected = false;
            dvgInscriptions.Rows[dvgInscriptions.CurrentRow.Index].Selected = true;

            // Désactivation des types de modification ou ajout
            ajout = false;
            modification = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Activation d'ajout mais pas de modification.
            ajout = true;
            modification = false;

            dvgInscriptions.Enabled = false;

            cbxMembreNonInscris.Text = "";
            cbxCreneau.Text = "";
            cbxActivite.Text = "";

            // Activation des champs du formulaire.
            cbxMembreNonInscris.Enabled = true;
            cbxCreneau.Enabled = true;
            cbxActivite.Enabled = true;

            // Désactivation de certains boutons.
            btnDelete.Visible = false;
            btnModify.Visible = false;

            
        }
    }
}
