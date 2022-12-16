using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Numéro étudiant : 1724602
// Nom : Béatrice Duguay

namespace GestionHotel.Classes
{
    public abstract class EspaceLoue
    {
        // Attributs privés
        private string numeroEspace; // Numéro de l'espace
        private int nombreLits; // Nombre de lits dans l'espace
        private int prix; // Prix de l'espace
        private string typeEspace; // Type de l'espace loué (chambre ou suite)

        // Propriétés des attributs privés
        public string NumeroEspace
        {
            get { return numeroEspace; }
            set { numeroEspace = value; }
        }

        public int NombreLits
        {
            get { return nombreLits; }
            set { nombreLits = value; }
        }

        public int Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public string TypeEspace
        {
            get { return typeEspace; }
            set { typeEspace = value; }
        }

        // Constructeur par défaut
        public EspaceLoue()
        {
            numeroEspace = "";
            nombreLits = 0;
            prix = 0;
            typeEspace = "";
        }

        // Constructeur avec paramètres 
        public EspaceLoue(string pNum, int pNbLits, int pPrix, string pType)
        {
            this.numeroEspace = pNum;
            this.nombreLits = pNbLits;
            this.prix = pPrix;
            this.typeEspace = pType;
        }

        // Méthode abstraite CalculerPrix
        /// <summary>
        /// Calcule le prix de l'espace loué
        /// </summary>
        public abstract int CalculerPrix(int pNbLits, int pPrix);

        // Méthode AfficherEspace()
        /// <summary>
        /// Affiche toutes les informations de l'espace 
        /// </summary>
        /// <return> 
        ///     Retourne les informations de l'espace en String 
        /// </return>
        public string AfficherEspace()
        {
            return
                "# Espace : " + this.NumeroEspace + "\n" +
                "Type d'espace : " + this.TypeEspace + "\n" +
                "Nombre de lits : " + this.NombreLits.ToString() + "\n" +
                "Prix : " + this.Prix.ToString();
        }
    }

    
}