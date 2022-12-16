using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

// Numéro étudiant : 1724602
// Nom : Béatrice Duguay

namespace GestionHotel.Classes
{
    public class Chambre : EspaceLoue
    {
        // Attributs privés
        private string miniBar; // Si la chambre possède un mini bar

        // Propriétés des attributs privés
        public string MiniBar
        {
            get { return miniBar; }
            set { miniBar = value; }
        }

        // Constructeur par défaut
        public Chambre()
        {
            miniBar = "";
        }

        // Constructeur avec paramètres 
        public Chambre(string pNum, int pNbLits, int pPrix, string pType, string pMiniBar)
             : base(pNum, pNbLits, pPrix, pType)
        {
            this.miniBar = pMiniBar;
        }

        // Override de la méthode abstraite CalculerPrix
        /// <summary>
        /// Calcule le prix de la chambre
        /// </summary>
        /// <param name="pNbLits"></param>
        /// <param name="pPrix"></param>
        /// <returns>
        ///     Le prix de la chambre 
        /// </returns>
        public override int CalculerPrix(int pNbLits, int pPrix)
        {
            // Prix fixe de la chambre (50) mulitplier par le nombre de lits
            pPrix = 50 * pNbLits;
            // Retourner le prix de la chambre
            return pPrix;
        }

        // Méthode AfficherChambre()
        /// <summary>
        /// Affiche toutes les informations de la chambre 
        /// </summary>
        /// <return> 
        ///     Les informations de la chambre en String 
        /// </return>
        public string AfficherChambre()
        {
            return
                "# Chambre : " + this.NumeroEspace + "\n" +
                "Nombre de lits : " + this.NombreLits + "\n" +
                "Prix : " + this.Prix + "\n" +
                "Mini bar : " + this.MiniBar;
        }
    }
}
