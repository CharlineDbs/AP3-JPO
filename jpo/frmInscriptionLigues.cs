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
    public partial class frmInscriptionLigues : Form
    {

        private bool enregModifierLigue;
        private bool ajoutLigue;

        private OleDbDataReader drLiguesNonInscrites;
        private OleDbDataReader drEquipementNonSelectione;

        public frmInscriptionLigues()
        {
            InitializeComponent();
        }



        private void frmInscriptionLigues_Load(object sender, EventArgs e)
        {

            btnModifier.Visible = true;
            btndésinscrire.Visible = true;
            btnEnregistrer.Visible = false;
            btnAnnuler.Visible = false;


            // on initialise le dgv
            dgvLigues.ColumnCount = 5;
            dgvLigues.Columns[0].Visible = false;
            dgvLigues.Columns[1].Visible = false;
            dgvLigues.Columns[2].Width = 200;
            dgvLigues.Columns[3].Visible = false;
            dgvLigues.Columns[4].Visible = false;

            dgvEquip.ColumnCount = 4;
            dgvEquip.Columns[0].Visible = false;
            dgvEquip.Columns[1].Visible = false;
            dgvEquip.Columns[2].Width = 200;
            dgvEquip.Columns[3].Visible = false;


            dgvLigues.RowHeadersVisible = false;
            dgvLigues.ColumnHeadersVisible = false;
            dgvLigues.MultiSelect = false;
            dgvLigues.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvLigues.AllowUserToResizeColumns = false;
            dgvLigues.AllowUserToResizeRows = false;
            dgvLigues.ReadOnly = true;
            dgvLigues.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLigues.AllowUserToAddRows = false;

            dgvEquip.RowHeadersVisible = false;
            dgvEquip.ColumnHeadersVisible = false;
            dgvEquip.MultiSelect = false;
            dgvEquip.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvEquip.AllowUserToResizeColumns = false;
            dgvEquip.AllowUserToResizeRows = false;
            dgvEquip.ReadOnly = true;
            dgvEquip.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquip.AllowUserToAddRows = false;



            fillTable();
            cbxLigues.Text = "";

            if (dgvLigues.RowCount > 0)
            {
                dgvLigues.CurrentRow.Selected = false;
                dgvLigues.Rows[0].Selected = true;
            }

            tbxQuantite.Enabled = false;
            cbxEquipement.Enabled = false;
            btnEquipement.Enabled = false;
            btnValiderEquip.Visible = false;
            btnModifierEquipement.Visible = false;

        }

        // on ajoute
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            btnModifier.Visible = false;
            btndésinscrire.Visible = false;
            btnEnregistrer.Visible = true;
            btnAnnuler.Visible = true;

            tbxStandLongueur.Text = "";
            tbxStandLargeur.Text = "";
            tbxQuantite.Text = "";

            tbxStandLongueur.Enabled = true;
            tbxStandLargeur.Enabled = true;
            cbxLigues.Enabled = true;

            ajoutLigue = true;
            enregModifierLigue = false;

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

            if (DbConnex.etatConnection() != ConnectionState.Open)
            {
                DbConnex.connexionBase();
            }

            if (ajoutLigue)
            {

                int codeLigue = int.Parse(cbxLigues.SelectedValue.ToString());
                int longueurStand = int.Parse(tbxStandLongueur.Text);
                int largeurStand = int.Parse(tbxStandLargeur.Text);

                DbConnex.ajouterInscripLigue(longueurStand, largeurStand, codeLigue);


            }
            else if (enregModifierLigue)
            {
                int idInscription = int.Parse(dgvLigues[0, dgvLigues.CurrentRow.Index].Value.ToString());
                int longueurStand = int.Parse(tbxStandLongueur.Text);
                int largeurStand = int.Parse(tbxStandLargeur.Text);
                int idLigue = int.Parse(dgvLigues[1, dgvLigues.CurrentRow.Index].Value.ToString());

                DbConnex.modifierInscripLigue(idInscription, longueurStand, largeurStand, idLigue);


            }

            fillTable();

            tbxStandLargeur.Text = "";
            tbxStandLongueur.Text = "";
            tbxQuantite.Text = "";
            cbxLigues.Text = "";

            tbxStandLongueur.Enabled = false;
            tbxStandLargeur.Enabled = false;
            tbxQuantite.Enabled = false;
            cbxLigues.Enabled = false;

            btnAjouter.Visible = true;
            btnAnnuler.Visible = false;
            btndésinscrire.Visible = true;
            btnModifier.Visible = true;
            btnEnregistrer.Visible = false;

            DbConnex.connexionClose();

            ajoutLigue = false;
            enregModifierLigue = false;


        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            tbxStandLargeur.Text = "";
            tbxStandLongueur.Text = "";
            tbxQuantite.Text = "";
            cbxLigues.Text = "";

            tbxStandLongueur.Enabled = false;
            tbxStandLargeur.Enabled = false;
            tbxQuantite.Enabled = false;
            cbxLigues.Enabled = false;

            btnAjouter.Visible = true;
            btnAnnuler.Visible = false;
            btndésinscrire.Visible = true;
            btnModifier.Visible = true;
            btnEnregistrer.Visible = false;
            btnModifierEquipement.Visible = false;

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (DbConnex.etatConnection() != ConnectionState.Open)
            {
                DbConnex.connexionBase();
            }

            enregModifierLigue = true;
            ajoutLigue = false;

            tbxStandLongueur.Enabled = true;
            tbxStandLargeur.Enabled = true;
            cbxLigues.Enabled = false;

            btnAjouter.Visible = false;
            btnAnnuler.Visible = true;
            btndésinscrire.Visible = false;
            btnModifier.Visible = false;
            btnEnregistrer.Visible = true;
            btnEquipement.Visible = true;

            btnModifierEquipement.Visible = true;

        }

        private void btndésinscrire_Click(object sender, EventArgs e)
        {
            if (DbConnex.etatConnection() != ConnectionState.Open)
            {
                DbConnex.connexionBase();
            }
            const string message = "Es-tu sûr de vouloir désinscrire cette ligue ?";
            const string caption = "Supprimer";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int idInscripLigue = int.Parse(dgvLigues[0, dgvLigues.CurrentRow.Index].Value.ToString());
                DbConnex.supprimerInscripLigue(idInscripLigue);


                fillTable();

            }

            tbxStandLargeur.Text = "";
            tbxStandLongueur.Text = "";
            tbxQuantite.Text = "";
            cbxLigues.Text = "";

            tbxStandLongueur.Enabled = false;
            tbxStandLargeur.Enabled = false;
            tbxQuantite.Enabled = false;
            cbxLigues.Enabled = false;

            btnAjouter.Visible = true;
            btnAnnuler.Visible = false;
            btndésinscrire.Visible = true;
            btnModifier.Visible = true;
            btnEnregistrer.Visible = false;

            dgvLigues.ClearSelection();
            dgvLigues.Rows[0].Selected = true;

        }

        private void btnEquipement_Click(object sender, EventArgs e)
        {

        }

        private void dgvLigues_SelectionChanged(object sender, EventArgs e)
        {

            tbxStandLongueur.Text = dgvLigues[3, dgvLigues.CurrentRow.Index].Value.ToString();
            tbxStandLargeur.Text = dgvLigues[4, dgvLigues.CurrentRow.Index].Value.ToString();

            tbxStandLongueur.Enabled = false;
            tbxStandLargeur.Enabled = false;
            cbxLigues.Enabled = false;

            fillEquipement();


        }

        private void cbxEquipement_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void fillTable()
        {
            if (DbConnex.etatConnection() != ConnectionState.Open)
            {
                DbConnex.connexionBase();
            }

            OleDbDataReader drInscription = DbConnex.GetDataReader("Select numInscription, Inscription.CodeLigue, nomLigue, longueur, largeur from Ligues Inner Join Inscription ON Inscription.CodeLigue = Ligues.CodeLigue");


            dgvLigues.SelectionChanged -= dgvLigues_SelectionChanged;

            dgvLigues.RowCount = 0;

            int i = 0;

            while (drInscription.Read())
            {
                dgvLigues.Rows.Add();

                dgvLigues[0, i].Value = drInscription.GetInt32(0).ToString();
                dgvLigues[1, i].Value = drInscription.GetInt32(1).ToString();
                dgvLigues[2, i].Value = drInscription.GetString(2).ToString();
                dgvLigues[3, i].Value = drInscription.GetInt16(3).ToString();
                dgvLigues[4, i].Value = drInscription.GetInt16(4).ToString();

                i++;
            }


            dgvLigues.SelectionChanged += dgvLigues_SelectionChanged;


            drLiguesNonInscrites = DbConnex.GetDataReader("SELECT codeLigue, nomLigue From Ligues WHERE codeLigue NOT IN (Select codeLigue From Inscription)");

            DataTable dataTable = new DataTable();
            dataTable.Load(drLiguesNonInscrites);

            cbxLigues.DataSource = dataTable;
            cbxLigues.DisplayMember = "nomLigue";
            cbxLigues.ValueMember = "codeLigue";


            DbConnex.connexionClose();
        }


        private void fillEquipement()
        {
            if (DbConnex.etatConnection() != ConnectionState.Open) DbConnex.connexionBase();


            OleDbDataReader dataReader = DbConnex.GetDataReader("SELECT numInscription, Demander.codeEquipement, libellé, quantite FROM Demander, Equipement WHERE Equipement.codeEquipement = Demander.codeEquipement");


            dgvEquip.SelectionChanged -= dgvEquip_SelectionChanged;

            dgvEquip.RowCount = 0;

            int i = 0;

            int numInscription = int.Parse(dgvLigues[0, dgvLigues.CurrentRow.Index].Value.ToString());

            while (dataReader.Read())
            {
                if (dataReader.GetInt32(0) == numInscription)
                {
                    dgvEquip.Rows.Add();

                    dgvEquip[0, i].Value = dataReader.GetInt32(0).ToString();
                    dgvEquip[1, i].Value = dataReader.GetString(1);
                    dgvEquip[2, i].Value = dataReader.GetString(2).ToString();
                    dgvEquip[3, i].Value = dataReader.GetInt32(3).ToString();

                    i++;
                }
            }


            dgvEquip.SelectionChanged += dgvEquip_SelectionChanged;

            drEquipementNonSelectione = DbConnex.GetDataReader("SELECT codeEquipement, libellé From Equipement WHERE codeEquipement NOT IN (Select codeEquipement From Demander)");

            DataTable dataTable = new DataTable();
            dataTable.Load(drEquipementNonSelectione);

            cbxEquipement.DataSource = dataTable;
            cbxEquipement.DisplayMember = "libellé";
            cbxEquipement.ValueMember = "codeEquipement";

            dgvEquip.ClearSelection();
            if (dgvEquip.CurrentRow != null && dgvEquip.RowCount > 0)
            {
                dgvEquip.Rows[dgvEquip.CurrentRow.Index].Selected = true;
            }
            else if (dgvEquip.CurrentRow == null & dgvEquip.RowCount > 0)
            {
                dgvEquip.Rows[dgvEquip.CurrentRow.Index].Selected = true;
            }


            DbConnex.connexionClose();
        }

        private void dgvEquip_SelectionChanged(object sender, EventArgs e)
        {
            cbxEquipement.Text = "";
            tbxQuantite.Text = dgvEquip[3, dgvEquip.CurrentRow.Index].Value.ToString();
        }


        private void btnModifierEquip_Click(object sender, EventArgs e)
        {
            if (enregModifierLigue && !ajoutLigue)
            {
                tbxQuantite.Enabled = true;
                btnValiderEquip.Visible = true;
                btnModifierEquipement.Enabled = false;
            }
        }

        private void btnValiderEquip_Click(object sender, EventArgs e)
        {
            if (enregModifierLigue && !ajoutLigue)
            {
                MessageBox.Show("oui");
                int quantite = int.Parse(tbxQuantite.Text);
                int numInscription = int.Parse(dgvEquip[0, dgvEquip.CurrentRow.Index].Value.ToString());
                String codeEquipement = dgvEquip[1, dgvEquip.CurrentRow.Index].Value.ToString();

                DbConnex.modifierInscriptionEquipement(numInscription, codeEquipement, quantite);

            }

            fillEquipement();

            dgvEquip.Rows[dgvEquip.CurrentRow.Index].Selected = true;

            tbxQuantite.Enabled = false;
            btnValiderEquip.Visible = false;
            btnModifierEquipement.Visible = false;
            btnModifierEquipement.Enabled = true;
        }
    }
}
