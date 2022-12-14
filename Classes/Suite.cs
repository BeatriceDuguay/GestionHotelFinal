using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotel.Classes
{
    public class Suite : EspaceLoue
    {
        // Attributs privés
        private int nbChambres; // Nombre de chambres dans la suite

        // Propriétés des attributs privés
        public int NbChambres
        {
            get { return nbChambres; }
            set { nbChambres = value; }
        }

        // Constructeur par défaut
        public Suite()
        {
            nbChambres = 0;
        }

        // Constructeur avec paramètres
        public Suite (string pNum, int pNbLits, int pPrix, string pType, int pNbChambres)
             : base(pNum, pNbLits, pPrix, pType)
        {
            this.nbChambres = pNbChambres;
        }

        // Override de la méthode abstraite CalculerPrix
        /// <summary>
        /// Calcule le prix de la suite
        /// </summary>
        /// <param name="pNbLits"></param>
        /// <param name="pPrix"></param>
        /// <returns> Le prix de la suite </returns>
        public override int CalculerPrix(int pNbLits, int pPrix)
        {
            // Prix fixe de la suite (100), additionner avec le prix d'une chambre (50) mulitplier par le nombre de lits
            pPrix = 100 + (50 * pNbLits);
            // Retourner le prix de la suite
            return pPrix;
        }

        // Méthode AfficherSuite()
        /// <summary>
        /// Affiche toutes les information de la suite 
        /// </summary>
        /// <return> Retourne les information de la suite en String </return>
        public string AfficherSuite()
        {
            return
                "# Suite : " + this.NumeroEspace + "\n" +
                "Nombre de lits : " + this.NombreLits + "\n" +
                "Prix : " + this.Prix + "\n" +
                "Nombre de chambres : " + this.NbChambres;
        }
    }
}
