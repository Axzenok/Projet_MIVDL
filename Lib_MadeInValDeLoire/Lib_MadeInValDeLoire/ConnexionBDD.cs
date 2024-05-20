﻿using System.Configuration;
using MySql.Data.MySqlClient;

namespace Lib_MadeInValDeLoire
{
    /// <summary>
    /// Classe gérant la connexion entre la BDD et l'application
    /// </summary>
    public class ConnexionBDD
    {
        #region Propriété
        private MySqlConnection connection;
        #endregion

        #region Gestion des connexions
        /// <summary>
        /// Ouvre la connexion à la BDD
        /// </summary>
        /// <returns>Si la connexion réussie</returns>
        public MySqlConnection OuvertureConnexion()
        {
            try
            {
                connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["StringBDD"].ConnectionString);
                connection.Open();
            }
            catch (MySqlException ex)
            {
                // Console.WriteLine(ex.Message);
                connection = null;
            }

            return connection;
        }

        /// <summary>
        /// Ferme la connexion établie
        /// </summary>
        /// <param name="connexion">Nom de la Connexion</param>
        public void FermetureConnexion(MySqlConnection connexion)
        {
            connexion?.Close();

            /* Version "Classique"
            if (connexion != null)
            {
                connexion.Close();
            }*/
        }
        #endregion
    }
}
