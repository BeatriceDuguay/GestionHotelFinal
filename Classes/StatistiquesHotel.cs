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
    public static class StatistiquesHotel
    {
        // Attributs privés statics
        private static List<Client> listeClients; // Liste des clients
        private static List<EspaceLoue> listeEspaceLoue; // Liste des chambres
        private static List<Location> listeLocations; // Liste des locations

        // Propriétés des attributs privés statics
        public static List<Client> ListeClients
        {
            get { return listeClients; }
            set { listeClients = value; }
        }

        public static List<EspaceLoue> ListeEspaceLoue
        {
            get { return listeEspaceLoue; }
            set { listeEspaceLoue = value; }
        }

        public static List<Location> ListeLocations
        {
            get { return listeLocations; }
            set { listeLocations = value; }
        }

        // Constructeur par défaut
        static StatistiquesHotel()
        {
            listeClients = null;
            listeClients = new List<Client>();
            listeEspaceLoue = null;
            listeEspaceLoue = new List<EspaceLoue>();
            listeLocations = null;
            listeLocations = new List<Location>();
        }

        //Méthode statique NombreLocations
        /// <summary>
        /// Calcule le nombre total de locations   
        /// </summary>
        /// <returns>
        ///     Le nombre total de locations
        /// </returns>
        // Code de Hasna Hocini (GestElection)
        public static int NombreLocations()
        {
            int cpt = 0; // Créer une variable pour compter le nombre de locations

            // Parcourir la liste des locations
            foreach (Location elt in ListeLocations)
            {
                cpt++; // Incrémenter le compteur
            }

            return cpt; // Retourner le nombre total de locations
        }

        // Méthode statique LocationParDate
        /// <summary>
        /// Calcule le nombre de location par espace et par date
        /// </summary>
        /// <param name="typeEspace" Le type d'espace de l'espace></param>
        /// <param name="dtPickerDate" Le DateTimePicker de la date de location></param>
        /// <returns>
        ///     Le nombre de location par espace et par date
        /// </returns>
        // Code de Hasna Hocini (GestElection)
        public static int LocationParDate(string typeEspace, DateTimePicker dtPickerDate)
        {
            int cpt = 0; // Créer une variable pour compter le nombre de locations

            // Parcourir la liste des locations
            foreach (Location elt in ListeLocations)
            {
                // Si le type d'espace sélectionnée dans le ComboBox est la même valeur de l'attribut TypeEspace de l'objet Location
                // ET la date sélectionnée dans le DateTimePicker plus grande ou égale à la valeur de l'attribut DateDebutLocation de l'objet Location
                // ET la date sélectionnée dans le DateTimePicker plus petite ou égale à la valeur de l'attribut DateFinLocation de l'objet Location
                if (typeEspace == elt.EspaceLoue.TypeEspace & dtPickerDate.Value >= elt.DateDebutLocation & dtPickerDate.Value <= elt.DateFinLocation)
                {
                    cpt++; // Incrémenter le compteur
                }

                // Si le type d'espace sélectionnée dans le ComboBox est "Tous"
                // ET la date sélectionnée dans le DateTimePicker plus grande ou égale à la valeur de l'attribut DateDebutLocation de l'objet Location
                // ET la date sélectionnée dans le DateTimePicker plus petite ou égale à la valeur de l'attribut DateFinLocation de l'objet Location
                else if (typeEspace == "Tous" & dtPickerDate.Value >= elt.DateDebutLocation & dtPickerDate.Value <= elt.DateFinLocation)
                {
                    cpt++;  // Incrémenter le compteur
                }
            }
            return cpt++; // Retourner le nombre de locations
        }
    }
}
