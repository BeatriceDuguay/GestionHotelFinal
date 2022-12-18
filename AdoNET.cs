using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Numéro étudiant : 1724602
// Nom : Béatrice Duguay

namespace GestionHotel.Classes
{
    internal class AdoNET
    {
        // Attributs privés
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataSet dsGestionHotel;
        private DataTable dtClient;
        private DataTable dtEmploye;
        private DataTable dtEspaceLoue;
        private DataTable dtChambre;
        private DataTable dtSuite;
        private DataTable dtLocation;
        private string connectionString;

        // Propriétés des attributs privés
        public SqlConnection Connection { get => connection; set => connection = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public DataSet DsGestionHotel { get => dsGestionHotel; set => dsGestionHotel = value; }
        public DataTable DtClient { get => dtClient; set => dtClient = value; }
        public DataTable DtEmploye { get => dtEmploye; set => dtEmploye = value; }
        public DataTable DtEspaceLoue { get => dtEspaceLoue; set => dtEspaceLoue = value; }
        public DataTable DtChambre { get => dtChambre; set => dtChambre = value; }
        public DataTable DtSuite { get => dtSuite; set => dtSuite = value; }
        public DataTable DtLocation { get => dtLocation; set => dtLocation = value; }
        public string ConnectionString { get => connectionString; }

        // Constructeur par défaut
        public AdoNET()
        {
            connectionString = " Data Source = LAPTOP - HC74J3SB\\MONSQL;Initial Catalog = GestionHotel; User ID = sa; Password = sql";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            adapter = new SqlDataAdapter();
            dsGestionHotel = new DataSet();
            dtClient = new DataTable();
            dtEmploye = new DataTable();
            dtEspaceLoue = new DataTable();
            dtChambre = new DataTable();
            dtSuite = new DataTable();
            dtLocation = new DataTable();
        }
    }
}
