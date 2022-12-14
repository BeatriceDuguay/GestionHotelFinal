using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Numéro étudiant : 1724602
// Nom : Béatrice Duguay

namespace GestionHotel.Classes
{
    public class Location
    {
        // Attributs privés
        private string numeroLocation; // Numéro de la location
        private DateTime dateDebutLocation; // Date du début de la location
        private DateTime dateFinLocation; // Date de la fin de la location
        private int nombreAdultes; // Nombre d'adultes dans la location
        private int nombreEnfants; // Nombre d'enfants dans la location
        private Client client; // Le client qui a fait la location
        private EspaceLoue espaceLoue; // L'espace inclue dans la location

        // Propriétés des attributs privés
        public string NumeroLocation
        {
            get { return numeroLocation; }
            set { numeroLocation = value; }
        }

        public DateTime DateDebutLocation
        {
            get { return dateDebutLocation; }
            set { dateDebutLocation = value; }
        }

        public DateTime DateFinLocation
        {
            get { return dateFinLocation; }
            set { dateFinLocation = value; }
        }

        public int NombreAdultes
        {
            get { return nombreAdultes; }
            set { nombreAdultes = value; }
        }

        public int NombreEnfants
        {
            get { return nombreEnfants;}
            set { nombreEnfants = value; }
        }

        public Client Client
        {
            get { return client; }
            set { client = value; }
        }

        public EspaceLoue EspaceLoue
        {
            get { return espaceLoue; }
            set { espaceLoue = value; }
        }

        // Constructeur par défaut
        public Location()
        {
            numeroLocation = "";
            nombreAdultes = 0;
            nombreEnfants = 0;
        }

        // Constructeur avec paramètres 
        public Location(string pNum, DateTime pDateDeb, DateTime pDateFin, int pNbAdu, int pNbEnf, Client pClient, EspaceLoue pEspace)
        {
            this.numeroLocation = pNum;
            this.dateDebutLocation = pDateDeb;
            this.dateFinLocation = pDateFin;
            this.nombreAdultes = pNbAdu;
            this.nombreEnfants = pNbEnf;
            this.client = pClient;
            this.espaceLoue = pEspace;
        }

        public int DureeSejour(DateTimePicker dtPickerDebut, DateTimePicker dtPickerFin)
        {
            DateTime debutSejour = dtPickerDebut.Value;
            DateTime finSejour = dtPickerFin.Value;

            TimeSpan jours = finSejour.Subtract(debutSejour);

            return
                jours.Days;
        }

        // Méthode AfficherLocation()
        /// <summary>
        /// Affiche toutes les information de la location 
        /// </summary>
        /// <return> Retourne les information de la location en String </return>
        public string AfficherLocation()
        {
            return
                "# Location : " + this.NumeroLocation + "\n" +
                "Arrivée : " + this.DateDebutLocation.ToString() + "\n" +
                "Départ : " + this.DateFinLocation.ToString() + "\n" +
                "Nombre d'adultes : " + this.NombreAdultes.ToString();
        }
    }
}
