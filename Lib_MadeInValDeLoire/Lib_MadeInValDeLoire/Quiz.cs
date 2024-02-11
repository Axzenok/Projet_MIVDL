using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Lib_MadeInValDeLoire
{
    /// <summary>
    /// Classe permettant de faire le quiz
    /// </summary>
    public class Quiz
    {
        #region récupération des données

        /// <summary>
        /// Récupère tous les thèmes
        /// </summary>
        /// <param name="connexion">Nom de la Connexion</param>
        /// <returns>Tous les thèmes de la BDD</returns>
        public DataSet RecupThemes(MySqlConnection connexion)
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.Connection = connexion;
            cmd.CommandText = "proc_liste_theme";
            cmd.CommandType = CommandType.StoredProcedure;

            da.Fill(ds, "theme");

            return ds;
        }

        /// <summary>
        /// Récupère tous les niveaux de difficulté
        /// </summary>
        /// <param name="connexion">Nom de la Connexion</param>
        /// <returns>Tous les niveaux de difficulté de la BDD</returns>
        public DataSet RecupNiveauDifficulte(MySqlConnection connexion)
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.Connection = connexion;
            cmd.CommandText = "proc_liste_niveauDifficulte";
            cmd.CommandType = CommandType.StoredProcedure;

            da.Fill(ds, "niveaudifficulte");

            return ds;
        }

        /*
        /// <summary>
        /// Récupère tous les quiz possibles selon la difficulté et le thème
        /// </summary>
        /// <param name="Difficulte">Difficulté</param>
        /// <param name="Theme">Thème</param>
        /// <param name="connexion">Nom de la connexion</param>
        /// <returns>Tous les quiz de la BDD</returns>
        public DataSet RecupQuiz(String Difficulte, String Theme, MySqlConnection connexion)
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.Connection = connexion;
            cmd.CommandText = "proc_liste_quiz_theme_difficulte";
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlParameter laDifficulte = new MySqlParameter("@Difficulte", MySqlDbType.VarChar);
            MySqlParameter leTheme = new MySqlParameter("@Theme", MySqlDbType.VarChar);
            
            laDifficulte.Value = Difficulte;
            leTheme.Value = Theme;

            cmd.Parameters.Add(laDifficulte);
            cmd.Parameters.Add(leTheme);

            da.Fill(ds, "quiz");

            return ds;
        }

        /// <summary>
        /// Récupère toutes les questions selon le quiz
        /// </summary>
        /// <param name="Quiz">Quiz</param>
        /// <param name="connexion">Nom de la connexion</param>
        /// <returns>Toutes les questions de la BDD</returns>
        public DataSet RecupQuestions(String Quiz, MySqlConnection connexion)
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.Connection = connexion;
            cmd.CommandText = "proc_liste_questions_quiz";
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlParameter leQuiz = new MySqlParameter("@nomQuiz", MySqlDbType.VarChar);
            
            leQuiz.Value = Quiz;
            
            cmd.Parameters.Add(leQuiz);

            da.Fill(ds, "questions");

            return ds;
        }
        */

        /// <summary>
        /// Récupère toutes les réponses selon la question
        /// </summary>
        /// <param name="Question">Intitulé de la question</param>
        /// <param name="connexion">Nom de la Connexion</param>
        /// <returns>Toutes les Réponses de la BDD</returns>
        public DataSet RecupReponses(String Question, MySqlConnection connexion)
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.Connection = connexion;
            cmd.CommandText = "proc_liste_reponses_question";
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlParameter laQuestion = new MySqlParameter("@libelleQuestion", MySqlDbType.VarChar);
            laQuestion.Value = Question;
            cmd.Parameters.Add(laQuestion);

            da.Fill(ds, "reponses");

            return ds;
        }

        /// <summary>
        /// Retourne les questions selon le thème et la difficulté
        /// </summary>
        /// <param name="theme"></param>
        /// <param name="difficulte"></param>
        /// <param name="connexion"></param>
        /// <returns>Retourne les questions</returns>
        public DataSet RecupQuestions(String theme, String difficulte, MySqlConnection connexion)
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.Connection = connexion;
            cmd.CommandText = "proc_liste_questions_theme_difficulte";
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlParameter leTheme = new MySqlParameter("@theme", MySqlDbType.VarChar);
            MySqlParameter laDifficulte = new MySqlParameter("@difficulte", MySqlDbType.VarChar);

            leTheme.Value = theme;
            laDifficulte.Value = difficulte;

            cmd.Parameters.Add(leTheme);
            cmd.Parameters.Add(laDifficulte);

            da.Fill(ds, "questions");

            return ds;
        }
        #endregion
    }
}
