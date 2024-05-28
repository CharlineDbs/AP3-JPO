using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace jpo
{
    class DbConnex
    {
        private static OleDbConnection connex = new System.Data.OleDb.OleDbConnection();
        private static string connexString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source=..\..\..\..\jpo.accdb";

        public static void connexionBase()
        {
            try
            {
                connex.ConnectionString = connexString;
                connex.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static System.Data.ConnectionState etatConnection()
        {
            return connex.State;
        }

        public static void connexionClose()
        {
            connex.Close();
        
        }

        public static OleDbDataReader GetDataReader(string uneRequete)
        {
            try
            {
                OleDbCommand oleCommande = new OleDbCommand(uneRequete, connex);
                OleDbDataReader reader = oleCommande.ExecuteReader();
                return reader;
            }

            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }


        public static int Unscalar(string uneRequete)
        {
            try
            {
                OleDbCommand oleCommande = new OleDbCommand(uneRequete, connex);
                int unNB = (Int32)oleCommande.ExecuteScalar();
                return unNB;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public static int nonQuery(string uneRequete)
        {
            try
            {
                OleDbCommand oleCommande = new OleDbCommand(uneRequete, connex);
                int reponse = oleCommande.ExecuteNonQuery();
                return reponse;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
        // ============= Enregistrements Membres ================ //
        public static void ajouterMembre(String unNom, String unPrenom, String unTelephone, String unMail, int uneLigue)
        {

            try
            {


                string uneRequete = "insert into membre (nom, prénom, téléphone, mail, codeLigue) values (@unNom ,@unPrenom,  @unTelephone , @unMail , @uneLigue)";

                if(etatConnection() != ConnectionState.Open) connexionBase();
                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);
                uneCommande.CommandType = CommandType.Text;

                uneCommande.Parameters.Add("@unNom", OleDbType.VarWChar).Value = unNom;
                uneCommande.Parameters.Add("@unPrenom", OleDbType.VarWChar).Value = unPrenom;
                uneCommande.Parameters.Add("@unTelephone", OleDbType.VarWChar).Value = unTelephone;
                uneCommande.Parameters.Add("@unMail", OleDbType.VarWChar).Value = unMail;
                uneCommande.Parameters.Add("@uneLigue", OleDbType.Integer).Value = uneLigue;

                uneCommande.ExecuteNonQuery();
                connex.Close();

            }
            catch (OleDbException e)
            {
                MessageBox.Show(e.Message);
            }


        }


        public static String getNomLigue(int codeLigue)
        {
            String nomLigue = "";
            try
            {


                string uneRequete = "Select nomLigue from Ligues where codeLigue = @codeLigue";

                if (etatConnection() != ConnectionState.Open) connexionBase();
                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);
                uneCommande.CommandType = CommandType.Text;

                uneCommande.Parameters.Add("@codeLigue", OleDbType.Integer).Value = codeLigue;
                OleDbDataReader dataLigueReader = uneCommande.ExecuteReader();
                while (dataLigueReader.Read())
                {
                    nomLigue = dataLigueReader.GetString(0);
                }
                connex.Close();

            }
            catch (OleDbException e)
            {
                MessageBox.Show(e.Message);
            }

            return nomLigue;
        }

        public static void modifierMembre(String unNom, String unPrenom, String unTelephone, String unMail, int uneLigue, int codeMembre)
        {

            try
            {


                string uneRequete = "update membre set  nom = @unNom, prénom = @unPrenom, téléphone = @unTelephone, mail = @unMail, codeLigue = @uneLigue where codeMembre = @codeMembre";

                if (etatConnection() != ConnectionState.Open) connexionBase();
                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);
                uneCommande.CommandType = CommandType.Text;

                uneCommande.Parameters.Add("@unNom", OleDbType.VarWChar).Value = unNom;
                uneCommande.Parameters.Add("@unPrenom", OleDbType.VarWChar).Value = unPrenom;
                uneCommande.Parameters.Add("@unTelephone", OleDbType.VarWChar).Value = unTelephone;
                uneCommande.Parameters.Add("@unMail", OleDbType.VarWChar).Value = unMail;
                uneCommande.Parameters.Add("@uneLigue", OleDbType.Integer).Value = uneLigue;
                uneCommande.Parameters.Add("@codeMembre", OleDbType.Integer).Value = codeMembre;

                uneCommande.ExecuteNonQuery();
                connex.Close();

            }
            catch (OleDbException e)
            {
                MessageBox.Show(e.Message);
            }


        }

        public static void supprimerMembre(int codeMembre)
        {
            try
            {
                String uneRequete = "delete from Membre where codeMembre = @codeMembre";
                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);
                uneCommande.CommandType = CommandType.Text;

                uneCommande.Parameters.Add("@codeMembre", OleDbType.Integer).Value = codeMembre;

                uneCommande.ExecuteNonQuery();
                connex.Close();

            } catch (OleDbException e)
            {
                MessageBox.Show(e.Message);
            }
            
        }


        // ============= Inscriptions Membres ================ //
        public static void ajouterInscriptionMembre(int unCodeMembre, String unCodeCreneau, String unCodeActivite)
        {

            try
            {


                string uneRequete = "insert into participer values (@unCodeMembre ,@unCodeCreneau,  @unCodeActivite)";

                if (etatConnection() != ConnectionState.Open) connexionBase();
                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);
                uneCommande.CommandType = CommandType.Text;

                uneCommande.Parameters.Add("@unCodeMembre", OleDbType.Integer).Value = unCodeMembre;
                uneCommande.Parameters.Add("@unCodeCreneau", OleDbType.VarWChar).Value = unCodeCreneau;
                uneCommande.Parameters.Add("@unCodeActivite", OleDbType.VarWChar).Value = unCodeActivite;

                uneCommande.ExecuteNonQuery();
                connex.Close();

            }
            catch (OleDbException e)
            {
                MessageBox.Show(e.Message);
            }


        }

        public static void modifierInscriptionMembre(String newCodeCreneau, String newCodeActivite, int codeMembre, String codeActivite, String codeCreneau)
        {

            try
            { 
                string uneRequete = "UPDATE membre SET  codeActivité = @unCodeActivite, codeCréneau = @unCodeCreneau WHERE codeMembre = @codeMembre AND codeActivité = @codeActivite AND codeCréneau = @codeCreneau";

                if (etatConnection() != ConnectionState.Open) connexionBase();
                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);
                uneCommande.CommandType = CommandType.Text;

                uneCommande.Parameters.Add("@unCodeActivite", OleDbType.VarWChar).Value = newCodeActivite;
                uneCommande.Parameters.Add("@unCodeCreneau", OleDbType.VarWChar).Value = newCodeCreneau;
                uneCommande.Parameters.Add("@codeMembre", OleDbType.Integer).Value = codeMembre;
                uneCommande.Parameters.Add("@codeActivite", OleDbType.VarWChar).Value = codeActivite;
                uneCommande.Parameters.Add("@codeCreneau", OleDbType.Integer).Value = codeCreneau;

                uneCommande.ExecuteNonQuery();
                connex.Close();

            }
            catch (OleDbException e)
            {
                MessageBox.Show(e.Message);
            }


        }

        public static void supprimerInscriptionMembre(int codeMembre, String codeCreneau, String codeActivite)
        {
            try
            {
                String uneRequete = "DELETE FROM participer WHERE codeMembre = @codeMembre and codeCréneau = @codeCreneau and codeActivité = @codeActivite";
                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);
                uneCommande.CommandType = CommandType.Text;

                uneCommande.Parameters.Add("@codeMembre", OleDbType.Integer).Value = codeMembre;
                uneCommande.Parameters.Add("@codeCreneau", OleDbType.VarChar).Value = codeCreneau;
                uneCommande.Parameters.Add("@codeActivite", OleDbType.VarChar).Value = codeActivite;

                uneCommande.ExecuteNonQuery();
                connex.Close();
            }
            catch (OleDbException e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public static void ajouterLigue(String unNom, String uneAdresse, String unCp, String uneVille, String uneDiscipline)
        {
            try
            {
                String uneRequete = "insert into ligues (nomLigue, adresse, cp, ville, discipline) Values (@nomLigue, @adresseLigue, @cpLigue, @villeLigue, @disciplineLigue)";
                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);
                uneCommande.CommandType = CommandType.Text;
                uneCommande.Parameters.Add("@nomLigue", OleDbType.VarWChar).Value = unNom;
                uneCommande.Parameters.Add("@adresseLigue", OleDbType.VarWChar).Value = uneAdresse;
                uneCommande.Parameters.Add("@cpLigue", OleDbType.VarWChar).Value = unCp;
                uneCommande.Parameters.Add("@villeligue", OleDbType.VarWChar).Value = uneVille;
                uneCommande.Parameters.Add("@disciplineLigue", OleDbType.VarWChar).Value = uneDiscipline;
                uneCommande.ExecuteNonQuery();
                connex.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        public static void modifierLigue(int unIdLigue, String unNom, String uneAdresse, String unCp, String uneVille, String uneDiscipline)
        {
            try
            {
                String uneRequete = "update ligues set nomLigue = @unNom, adresse = @uneAdresse, cp = @unCp, ville = @uneVille, discipline = @uneDiscipline where codeLigue = @unIdLigue";
                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);
                uneCommande.CommandType = CommandType.Text;
                uneCommande.Parameters.Add("@nomLigue", OleDbType.VarWChar).Value = unNom;
                uneCommande.Parameters.Add("@adresseLigue", OleDbType.VarWChar).Value = uneAdresse;
                uneCommande.Parameters.Add("@cpLigue", OleDbType.VarWChar).Value = unCp;
                uneCommande.Parameters.Add("@villeligue", OleDbType.VarWChar).Value = uneVille;
                uneCommande.Parameters.Add("@disciplineLigue", OleDbType.VarWChar).Value = uneDiscipline;
                uneCommande.Parameters.Add("@unIdLigue", OleDbType.Integer).Value = unIdLigue;
                uneCommande.ExecuteNonQuery();
                connex.Close();
            }
            catch (OleDbException e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public static void supprimerLigue(int unIdLigue)
        {
            try
            {
                string uneRequete = "delete from ligues where codeLigue = @unIdLigue";
                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);
                uneCommande.CommandType = CommandType.Text;
                uneCommande.Parameters.Add("@unIdLigue", OleDbType.Integer).Value = unIdLigue;
                uneCommande.ExecuteNonQuery();
                connex.Close();
            }
            catch (DataException de)
            {
                MessageBox.Show(de.Message);

            }

        }

        public static void ajouterInscripLigue(int uneLongueur, int uneLargeur, int unCodeLigue)
        {
            try
            {
                String uneRequete = " insert into inscription (longueur, largeur, codeligue) Values (@longueur, @largeur, @codeligue)";
                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);
                uneCommande.CommandType = CommandType.Text;

                uneCommande.Parameters.Add("@longueur", OleDbType.Integer).Value = uneLongueur;
                uneCommande.Parameters.Add("@largeur", OleDbType.Integer).Value = uneLargeur;
                uneCommande.Parameters.Add("@codeligue", OleDbType.Integer).Value = unCodeLigue;
                uneCommande.ExecuteNonQuery();
                connex.Close();
            }
            catch (OleDbException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void modifierInscripLigue(int unIdInscri, int uneLongueur, int uneLargeur, int unCodeLigue)
        {
            try
            {
                String uneRequete = "update inscription set longueur = @uneLongueur, largeur = @uneLargeur, codeligue = @unCodeLigue where numInscription = @unIdInscri";
                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);
                uneCommande.CommandType = CommandType.Text;
                uneCommande.Parameters.Add("@longueur", OleDbType.Integer).Value = uneLongueur;
                uneCommande.Parameters.Add("@largeur", OleDbType.Integer).Value = uneLargeur;
                uneCommande.Parameters.Add("@codeligue", OleDbType.Integer).Value = unCodeLigue;
                uneCommande.Parameters.Add("@numInscription", OleDbType.Integer).Value = unIdInscri;
                uneCommande.ExecuteNonQuery();
                connex.Close();
            }
            catch (OleDbException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void supprimerInscripLigue(int unIdInscri)
        {
            try
            {
                string uneRequete = "delete from inscription where numInscription = @unIdInscri";
                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);
                uneCommande.CommandType = CommandType.Text;
                uneCommande.Parameters.Add("@unIdInscri", OleDbType.Integer).Value = unIdInscri;
                uneCommande.ExecuteNonQuery();
                connex.Close();
            }
            catch (OleDbException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void modifierInscriptionEquipement(int numInscription, string codeEquipement, int quantite)
        {
            try
            {
                String uneRequete = "UPDATE demander SET quantite = @quantite WHERE numInscription = @numInscription AND codeEquipement = @codeEquipement";

                MessageBox.Show(uneRequete.Replace("@quantite", "" + quantite).Replace("@numInscription", "" + numInscription).Replace("@codeEquipement", codeEquipement));

                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);

                uneCommande.CommandType = CommandType.Text;

                uneCommande.Parameters.Add("@quantite", OleDbType.Integer).Value = quantite;
                uneCommande.Parameters.Add("@codeEquipement", OleDbType.VarChar).Value = codeEquipement;
                uneCommande.Parameters.Add("@numInscription", OleDbType.Integer).Value = numInscription;

                uneCommande.ExecuteNonQuery();

                connex.Close();
            }
            catch (OleDbException e)
            {
                MessageBox.Show(e.Message);
            }
        }









    }
}
