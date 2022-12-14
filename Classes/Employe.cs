using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotel.Classes
{
    internal class Employe
    {
        // Attributs privés
        private string numeroEmploye; // Numéro de l'employé
        private string motDePasse; // Mot de passe de l'employé
        private string typeEmploye; // Si l'employé est un réceptionniste ou un gérant

        // Propriétés des attributs privés
        public string NumeroEmploye
        {
            get { return numeroEmploye; }
            set { numeroEmploye = value; }
        }

        public string MotDePasse
        {
            get { return motDePasse; }
            set { motDePasse = value; }
        }

        public string TypeEmploye
        {
            get { return typeEmploye; }
            set { typeEmploye = value; }
        }

        // Constructeur par défaut
        public Employe()
        {
            numeroEmploye = "";
            motDePasse = "";
            typeEmploye = "";
        }

        // Constructeur avec paramètres 
        public Employe(string pNum, string pMdp, string pType)
        {
            this.numeroEmploye = pNum;
            this.motDePasse = pMdp;
            this.typeEmploye = pType;
        }
    }
}
