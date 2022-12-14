using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Numéro étudiant : 1724602
// Nom : Béatrice Duguay

namespace GestionHotel.Classes
{
    public class Client
    {
        // Attributs privés
        private string numeroClient; // Numéro du client
        private string prenom; // Prénom du client
        private string nom; // Nom du client
        private DateTime dateNaiss; // Date de naissance du client
        private string numTelephone; // Numéro de téléphone du client

        // Propriétés des attributs privés
        public string NumeroClient
        {
            get { return numeroClient; }
            set { numeroClient = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public DateTime DateNaiss
        {
            get { return dateNaiss; }
            set { dateNaiss = value; }
        }

        public string NumTelephone
        {
            get { return numTelephone; }
            set { numTelephone = value; }
        }

        // Constructeur par défaut
        public Client()
        {
            numeroClient = "";
            prenom = "";
            nom = "";
            numTelephone = "";
        }

        // Constructeur avec paramètres 
        public Client(string pNum, string pPrenom, string pNom, DateTime pDateNaiss, string pNumTel)
        {
            this.numeroClient = pNum;
            this.prenom = pPrenom;
            this.nom = pNom;
            this.dateNaiss = pDateNaiss;
            this.numTelephone = pNumTel;
        }

        /// <summary>
        /// Calcule l'âge du client en utilisant la date d'aujourd'hui et la date de naissance du client
        /// </summary>
        /// <param name="date" date de naissance du client></param>
        /// <returns> L'âge du client </returns>
        /// CODE DE : https://stackoverflow.com/a/1595311
        public static int Age(DateTimePicker dtPicker)
        {
            // Créer une variable agePersonne pour calculer son âge
            int ageClient = DateTime.Now.Year - dtPicker.Value.Date.Year;
            if (DateTime.Now.Month < dtPicker.Value.Date.Month || // Si le mois d'aujourd'hui est plus petit que le mois entré par l'utilisateur OU
               (DateTime.Now.Month == dtPicker.Value.Date.Month && // Le mois d'aujourd'hui est égal au mois entré par l'utilisateur ET
                DateTime.Now.Day < dtPicker.Value.Date.Day)) // Le jour d'aujourd'hui est plus petit que le jour entré par l'utilisateur
                ageClient--;

            return ageClient; // Retourner l'âge de la personne
        }

        // Méthode AfficherClient()
        /// <summary>
        /// Affiche toutes les information du client 
        /// </summary>
        /// <return> Retourne les information du client en String </return>
        public string AfficherClient()
        {
            return
                "# Client : " + this.NumeroClient + "\n" +
                "Prénom : " + this.Prenom + "\n" +
                "Nom : " + this.Nom + "\n" +
                "Date de naissance : " + this.DateNaiss.ToString() + "\n" +
                "# Téléphone : " + this.NumTelephone;
        }
    }
}
