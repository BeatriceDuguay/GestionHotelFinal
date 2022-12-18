using GestionHotel.Classes;
using GestionHotel.Formulaires;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

// Numéro étudiant : 1724602
// Nom : Béatrice Duguay

namespace GestionHotel
{
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
        }

        // Créer une liste d'employés
        List<Employe> ListeEmployes = new List<Employe>();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ajouter des employés à la liste pour la connexion
            ListeEmployes.Add(new Employe("1111", "pw1", "Réceptionniste"));
            ListeEmployes.Add(new Employe("2222", "pw2", "Réceptionniste"));
            ListeEmployes.Add(new Employe("3333", "pw3", "Gérant"));
            ListeEmployes.Add(new Employe("4444", "pw4", "Gérant"));

            // Ajouter des clients à la liste des clients pour les tests
            StatistiquesHotel.ListeClients.Add(new Client("11111", "Hasna", "Hocini", DateTime.MinValue, "8191111111"));
            StatistiquesHotel.ListeClients.Add(new Client("22222", "Arno", "Ménard", DateTime.MinValue, "8192222222"));
            StatistiquesHotel.ListeClients.Add(new Client("33333", "Mylène", "Ménard", DateTime.MinValue, "8193333333"));
            StatistiquesHotel.ListeClients.Add(new Client("44444", "Mario", "Duguay", DateTime.MinValue, "8194444444"));

            // Ajouter des espaces à la liste des espaces pour les tests
            StatistiquesHotel.ListeEspaceLoue.Add(new Chambre("111111", 2, 0, "Chambre", "Oui"));
            StatistiquesHotel.ListeEspaceLoue.Add(new Chambre("222222", 1, 0, "Chambre", "Non"));
            StatistiquesHotel.ListeEspaceLoue.Add(new Suite("333333", 3, 0, "Suite", 3));
            StatistiquesHotel.ListeEspaceLoue.Add(new Suite("444444", 2, 0, "Suite", 2));

            // Rendre les ToolStripMenuItem inaccessible avant la connexion
            clientToolStripMenuItem.Enabled = false;
            locationToolStripMenuItem.Enabled = false;
            chambreToolStripMenuItem.Enabled = false;
            statistiquesToolStripMenuItem.Enabled = false;  

            // Rendre les Label, TextBox et Buttons de connexion invisibles
            lblNumEmploye.Visible = false;
            txtNumEmploye.Visible = false;
            lblErreurNumEmploye.Visible = false;
            lblMdp.Visible = false;
            txtMdp.Visible = false;
            lblErreurMdp.Visible = false;
            btnConnexion.Visible = false;
        }

        // Code de Hasna Hocini (GestElection)
        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            // Rendre les Label, TextBox et le Button visibles
            lblNumEmploye.Visible = true;
            txtNumEmploye.Visible = true;
            lblErreurNumEmploye.Visible = true;
            lblMdp.Visible = true;
            txtMdp.Visible = true;
            lblErreurMdp.Visible = true;
            btnConnexion.Visible = true;
        }

        // Code de Hasna Hocini (GestElection)
        private void gererClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClient f = new FormClient(); // Création d'une instance du formulaire enfant FormClient
            f.MdiParent = this;
            f.WindowState = FormWindowState.Normal; // Mettre la taille du formulaire enfant FormClient à normale
            f.Show();
        }

        // Code de Hasna Hocini (GestElection)
        private void gererLocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLocation f = new FormLocation(); // Création d'une instance du formulaire enfant FormLocation
            f.MdiParent = this;
            f.WindowState = FormWindowState.Normal; // Mettre la taille du formulaire enfant FormLocation à normale
            f.Show();
        }

        // Code de Hasna Hocini (GestElection)
        private void gererChambresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEspace f = new FormEspace(); // Création d'une instance du formulaire enfant FormChambre
            f.MdiParent = this;
            f.WindowState = FormWindowState.Normal; // Mettre la taille du formulaire enfant FormChambre à normale
            f.Show();
        }

        // Code de Hasna Hocini (GestElection)
        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatistique f = new FormStatistique(); // Création d'une instance du formulaire enfant FormStatistique
            f.MdiParent = this;
            f.WindowState = FormWindowState.Normal; // Mettre la taille du formulaire enfant FormStatistique à normale
            f.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Fermer le formulaire parent FormParent
            this.Close();
        }

        // Méthode InitialiserLabel()
        /// <summary>
        /// Initialise tous les Label d'erreurs
        /// </summary>
        // Code de Hasna Hocini (GestElection)
        public void InitialiserLabel()
        {
            lblErreurNumEmploye.Text = lblErreurMdp.Text = "";
        }

        // Méthode InitialiserControles()
        /// <summary>
        /// Initialise tous les TextBox 
        /// </summary>
        // Code de Hasna Hocini (GestElection)
        public void InitialiserControles()
        {
            // Réinitialiser tous les champs du formulaire
            txtNumEmploye.Text = "";
            txtMdp.Text = "";
        }

        /// <summary>
        /// Vérifier le Regex 
        /// </summary>
        /// <param name="modele"></param>
        /// <param name="tb" les TextBox du formulaire></param>
        /// <param name="lb" les Label du formulaire></param>
        /// <param name="messageErreur" les messages d'erreur du formulaire></param>
        /// <returns> 
        ///     true si le champ entré par l'utilisateur est valide
        ///     false si le champ entré par l'utilisateur est invalide 
        /// </returns>
        // Code de Hasna Hocini (GestElection)
        public bool VerifierRegex(string modele, TextBox tb, Label lb, string messageErreur)
        {
            // Créer du Regex reg
            Regex reg = new Regex(modele);
            // Vérifier la correspondance entre le champ entré dans la textBox et le modèle
            if (!reg.IsMatch(tb.Text))
            {
                // Afficher message d'erreur
                lb.ForeColor = Color.Red;
                lb.Text = messageErreur;
                // Efface la textBox
                tb.Clear();
                return false;
            }

            else lb.Text = ""; // Effacer le label si le champ entré est valide
            return true;
        }

        /// <summary>
        /// Vérifie que la méthode booléenne retourne true
        /// </summary>
        /// <returns>
        ///     true si l'information entrée par l'utilisateur est valide
        ///     false si l'information entrée par l'utilisateur est invalide
        /// </returns>
        // Code de Hasna Hocini (GestElection)
        public bool VerifierTous()
        {
            // Déclaration des booléens de validation de l'information entrée
            bool b_numero;

            // Appel de la méthode VerifierRegex pour le champ et récupération de la valeur retournée dans la variable bouléenne
            b_numero = VerifierRegex("^[0-9]{4}$", txtNumEmploye, lblErreurNumEmploye, "Quatre chiffres");

            // Si la vérification est valide retourner vrai
            if (b_numero)
                return true; // Retourner true

            else return false; // Sinon retourner false
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (VerifierTous()) // Si la méthode VerifierTous retourne true
            {
                // Parcourir la liste des employés
                foreach (Employe elt in ListeEmployes)
                {
                    // Si le numéro de l'employé entré par l'utilisateur existe dans la liste et que
                    // le mot de passe entré par l'utilisateur est le même que correspond à l'employé
                    if (elt.NumeroEmploye == txtNumEmploye.Text & elt.MotDePasse == txtMdp.Text)
                    {
                        if (elt.TypeEmploye == "Réceptionniste") // Si l'employé est du type "Réceptionniste" 
                        {
                            // Rendre les ToolStripMenuItem accessibles (sauf ceux qui permettent d'accéder aux statistiques et à la manipulation de chambres)
                            clientToolStripMenuItem.Enabled = true;
                            locationToolStripMenuItem.Enabled = true;
                            chambreToolStripMenuItem.Enabled = false;
                            statistiquesToolStripMenuItem.Enabled = false;

                            // Appel de la méthode InitialiserControles
                            InitialiserControles();
                            // Appel de la méthode InitialiserLabel
                            InitialiserLabel();
                            // Afficher un message de réussite de connexion

                            MessageBox.Show("Connexion réussie.", "Message");
                            break; // Arrêter de parcourir la liste
                        }

                        else if (elt.TypeEmploye == "Gérant") // Si l'employé est du type "Gérant"
                        {
                            // Rendre les ToolStripMenuItem accessibles
                            clientToolStripMenuItem.Enabled = true;
                            locationToolStripMenuItem.Enabled = true;
                            chambreToolStripMenuItem.Enabled = true;
                            statistiquesToolStripMenuItem.Enabled = true;

                            // Appel de la méthode InitialiserControles
                            InitialiserControles();
                            // Appel de la méthode InitialiserLabel
                            InitialiserLabel();

                            // Afficher un message de réussite de connexion
                            MessageBox.Show("Connexion réussie.", "Message");
                            break; // Arrêter de parcourir la liste
                        }
                    }

                    else
                    {
                        lblErreurMdp.ForeColor = Color.Red; lblErreurMdp.Text = " Numéro d'employé ou mot de passe invalide. "; // Afficher un message d'erreur
                    }
                }
            }
        }
    }
}
