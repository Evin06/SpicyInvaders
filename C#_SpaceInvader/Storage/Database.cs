using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace SpaceInvaders
{
    internal class Database
    {
        public MySqlConnection connection;
        private string _serverName = "localhost"; //adresse du serveur
        private string _serverUid = "root"; //identifiant de connexion
        private string _serverPwd = "root"; //mot de passe de connexion
        private string _serverPort = "6033"; //port du serveur
        private string _databaseName = "db_space_invaders"; //nom de la base de données


        List<string> listTabPlayer = new List<string>();

        public bool connected = false;

        public bool Connected
        {
            get { return connected; }
            set { this.connected = value; }
        }

        /// <summary>
        ///  se connecter à la db MySQL avec les paramètres définis 
        /// </summary>
        /// <returns>Retourne true si la connexion a réussi, false si elle a échoué</returns>
        public bool Connect()
        {
            string myConnectionString;

            //requête de connexion à la base de donnée avec le paquet MySql.Data
            myConnectionString = $"server={this._serverName}; uid={this._serverUid}; " +
                $"pwd={this._serverPwd}; database={this._databaseName}; port={this._serverPort};";

            connection = new MySqlConnection(myConnectionString);

            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
                return false;//ex.Message;
            }
        }

    }
}
