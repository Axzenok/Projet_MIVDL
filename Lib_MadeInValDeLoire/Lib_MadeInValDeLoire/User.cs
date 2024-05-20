using System;
using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;

namespace Lib_MadeInValDeLoire
{
    /// <summary>
    /// Classe gérant les utilisateurs de la base de données
    /// </summary>
    public class User
    {
        #region Inscription
        /// <summary>
        /// Ajoute un utilisateur avec des données précises
        /// Sachant que le mot de passe est hashé
        /// </summary>
        /// <param name="connexion">Nom de la connexion</param>
        /// <param name="nom">Nom de l'utilisateur</param>
        /// <param name="prenom">Prénom de l'utilisateur</param>
        /// <param name="dateNaissance">Date de naissance de l'utilisateur</param>
        /// <param name="mail">Adresse mail de l'utilisateur</param>
        /// <param name="login"></param>
        /// <param name="motDePasse">Mot de passe de l'utilisateur</param>
        /// <returns>Booléen si l'ajout a été fait (1 = réussi)</returns>
        public int Inscription(MySqlConnection connexion, String nom, String prenom, DateTime dateNaissance, 
            String mail, String login, String motDePasse)
        {
            // Initialisation du résultat
            int ajoutPossible = 0; 

            if (connexion != null)
            {
                try
                {
                    // Création de la commande
                    using (MySqlCommand cmd = new MySqlCommand("func_ajout_joueur", connexion))
                    {
                        // Spécification du type de commande (procédure stockée)
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // Ajout des paramètres de la fonction stockée
                        cmd.Parameters.Add(new MySqlParameter("@nomEntre", nom));
                        cmd.Parameters.Add(new MySqlParameter("@prenomEntre", prenom));
                        cmd.Parameters.Add(new MySqlParameter("@dateNaissanceEntre", dateNaissance));
                        cmd.Parameters.Add(new MySqlParameter("@mailEntre", mail));
                        cmd.Parameters.Add(new MySqlParameter("@loginEntre", login));
                        // Ajout + Hashage pour le mot de passe
                        cmd.Parameters.Add(new MySqlParameter("@motDePasseEntre", HashSHA256(motDePasse)));

                        // Ajout du paramètre de retour
                        MySqlParameter returnValue = cmd.Parameters.Add("@result", MySqlDbType.Bit);
                        returnValue.Direction = System.Data.ParameterDirection.ReturnValue;

                        // Exécution de la commande
                        cmd.ExecuteNonQuery();

                        // Récupération de la valeur de retour directement
                        ajoutPossible = (int)returnValue.Value;
                    }
                }
                catch (Exception ex)
                {
                    // Gérer l'exception
                    Console.WriteLine("Une erreur s'est produite lors de l'ajout du joueur : " + ex.Message);
                }
            }
            // Retourner le résultat
            return ajoutPossible;
        }
        #endregion

        #region Connexion
        /// <summary>
        /// Vérifie les données de connexion
        /// </summary>
        /// <param name="connexion">Nom de la connexion</param>
        /// <param name="login">Login entré par l'utilisateur</param>
        /// <param name="motDePasse">Mot de passe entré par l'utilisateur</param>
        /// <returns>Si les données entrées sont bonnes (1 = Réussi)</returns>
        public int VerifierJoueur(MySqlConnection connexion, String login, String motDePasse)
        {
            // déclaration
            int connexionPossible = 0;

            if (connexion != null)
            {
                try
                {
                    // Création de la commande
                    using (MySqlCommand cmd = new MySqlCommand("func_verif_Joueur", connexion))
                    {
                        // Spécification du type de commande (procédure stockée)
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // Ajout des paramètres de la fonction stockée
                        cmd.Parameters.Add(new MySqlParameter("@loginEntre", login));
                        // Ajout + Hashage pour le mot de passe
                        cmd.Parameters.Add(new MySqlParameter("@motDePasseEntre", HashSHA256(motDePasse)));

                        // Ajout du paramètre de retour
                        MySqlParameter returnValue = cmd.Parameters.Add("@ajoutPossible", MySqlDbType.Bit);
                        returnValue.Direction = System.Data.ParameterDirection.ReturnValue;

                        // Exécution de la commande
                        cmd.ExecuteNonQuery();

                        // Récupération de la valeur de retour directement
                        connexionPossible = (int)returnValue.Value;
                    }
                }
                catch (Exception ex)
                {
                    // Gérer l'exception
                    Console.WriteLine("Une erreur s'est produite lors de la vérification du joueur : " + ex.Message);
                }
            }
            // Retourner le résultat
            return connexionPossible;
        }
        #endregion

        #region Hashage
        // Fonction pour hasher une chaîne avec SHA256
        private String HashSHA256(String input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convertir la chaîne en un tableau d'octets
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Convertir le tableau d'octets en une chaîne hexadécimale
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        #endregion
    }
}
