using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        /// <summary>
        /// Affiche le nombre de client par type d'espace
        /// </summary>
        /// <param name="typeEspace"></param>
        /// <returns> Le nombre de clients par type d'espace </returns>
        public static int ClientsParEspace(string typeEspace)
        {
            int cpt = 0; // Créer une variable pour compter le nombre d'étudiants
            // Parcourir la liste des locations
            foreach (Location elt in ListeLocations)
            {
                // Si la valeur TypeEspace de l'objet EspaceLoue est la même que celle sélectionnée dans le ComboBox
                if (typeEspace == elt.EspaceLoue.TypeEspace)
                {
                    // Incrémenter le compteur
                    cpt++;
                }

                // Sinon si la valeur sélectionnée dans le ComboBox du type d'espace est "Tous" 
                else if (typeEspace == "tous")
                {
                    // Incrémenter le compteur
                    cpt++;  
                }
            }
            return cpt; // Retourner le nombre de clients par type d'espace
        }
    }
}
