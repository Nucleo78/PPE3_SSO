using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace PPE3.Class
{
    class Conteneur
    {
        private string _numContainer;
        private int _dateAchat;
        private string _typeContainer;
        private int _dateDernierInsp;
        private int _codeDeclaration;
        private int _numInspection;

        private static string _selectByNum = "Select * From CONTAINER Where numContainer = ?numContainer";
        private static string _selectAll = "Select numContainer, dateAchat, typeContainer, dateDerniereInsp, codeDeclaration, numInspection From CONTAINER";

        public string NumContainer
        {
            get => _numContainer;
            set => _numContainer = value;
        }

        public int DateAchat
        {
            get => _dateAchat;
            set => _dateAchat = value;
        }

        public string TypeContainer
        {
            get => _typeContainer;
            set => _typeContainer = value;
        }

        public int DateDernierInsp
        {
            get => _dateDernierInsp;
            set => _dateDernierInsp = value;
        }

        public int CodeDeclaration
        {
            get => _codeDeclaration;
            set => _codeDeclaration = value;
        }

        public int NumInspection
        {
            get => _numInspection;
            set => _numInspection = value;
        }

        public static Conteneur getConteneurbyNum(int num)
        {
            Conteneur c = null;

            MySqlConnection connect = Utilitaires.GetDBConnection();
            connect.Open();
            MySqlCommand cmdSql = connect.CreateCommand();
            cmdSql.CommandText = _selectByNum;
            cmdSql.Parameters.Add(Utilitaires.CodeParam("?numContainer", num));
            cmdSql.Prepare();
            MySqlDataReader enregistrement = cmdSql.ExecuteReader();
            bool exist = enregistrement.Read();

            if (exist)
            {
                c = new Conteneur();
                c.NumContainer = Convert.ToString(enregistrement["numContainer"]);
                c.DateAchat = Convert.ToInt32(enregistrement["dateAchat"]);
                c.TypeContainer = Convert.ToString(enregistrement["typeContainer"]);
                c.DateDernierInsp = Convert.ToInt32(enregistrement["dateDerniereInsp"]);
                c.CodeDeclaration = Convert.ToInt32(enregistrement["codeDeclaration"]);
                c.NumInspection = Convert.ToInt32(enregistrement["numInspection"]);
            }

            connect.Close();
            return c;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}", _numContainer, _dateAchat, _typeContainer, _dateDernierInsp, _codeDeclaration, _numInspection);
        }

        public static List<Conteneur> GetAllConteneurs()
        {
            List<Conteneur> resultat = new List<Conteneur>();
            MySqlConnection connect = Utilitaires.GetDBConnection();
            connect.Open();
            MySqlCommand commandSql = connect.CreateCommand();
            commandSql.CommandText = _selectAll;
            MySqlDataReader enregistrements = commandSql.ExecuteReader();
            while (enregistrements.Read())
            {
                Conteneur c = new Conteneur();
                string numConteneur = Convert.ToString(enregistrements["numContainer"]);
                c.NumContainer = Convert.ToString(numConteneur);
                c.DateAchat = Convert.ToInt32(enregistrements["dateAchat"]);
                c.TypeContainer = enregistrements["typeContainer"].ToString();
                c.DateDernierInsp = Convert.ToInt32(enregistrements["dateDerniereInsp"]);
                c.CodeDeclaration = Convert.ToInt32(enregistrements["codeDeclaration"]);
                c.NumInspection = Convert.ToInt32(enregistrements["numInspection"]);
                resultat.Add(c);
            }
            connect.Close();
            return resultat;
        }

        public static List<Conteneur> FetchAll()
        {
            List<Conteneur> resultat = new List<Conteneur>();
            MySqlConnection connect = Utilitaires.GetDBConnection();
            connect.Open();
            MySqlCommand commandSql = connect.CreateCommand();
            commandSql.CommandText = _selectAll;
            MySqlDataReader enregistrements = commandSql.ExecuteReader();
            while (enregistrements.Read())
            {
                Conteneur c = new Conteneur();
                string numConteneur = Convert.ToString(enregistrements["numContainer"]);
                c.NumContainer = Convert.ToString(numConteneur);
                c.DateAchat = Convert.ToInt32(enregistrements["dateAchat"]);
                c.TypeContainer = enregistrements["typeContainer"].ToString();
                c.DateDernierInsp = Convert.ToInt32(enregistrements["dateDerniereInsp"]);
                c.CodeDeclaration = Convert.ToInt32(enregistrements["codeDeclaration"]);
                c.NumInspection = Convert.ToInt32(enregistrements["numInspection"]);
                resultat.Add(c);
            }
            connect.Close();
            return resultat;
        }
    }
}