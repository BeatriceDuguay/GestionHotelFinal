using GestionHotel.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHotel.Formulaires
{
    public partial class FormLocation : Form
    {
        public FormLocation()
        {
            InitializeComponent();
        }

        private void FormLocation_Load(object sender, EventArgs e)
        {
            // Modifier le format des DateTimePicker ghhhhh
            dtDebutLocation.Format = DateTimePickerFormat.Custom;
            dtDebutLocation.CustomFormat = "dd MMMM yyyy";
            dtFinLocation.Format = DateTimePickerFormat.Custom;
            dtFinLocation.CustomFormat = "dd MMMM yyyy";
        }

        // Méthode InitialiserLabel()
        /// <summary>
        /// Initialise tous les Label d'erreurs
        /// </summary>
        // Code de Hasna Hocini (GestElection)
        public void InitialiserLabel()
        {
            lblErreurNumLocation.Text = lblErreurNumClient.Text = lblErreurNumEspace.Text = 
            lblErreurDebutLoc.Text = lblErreurFinLoc.Text =
            lblErreurNbAdultes.Text = lblErreurNbEnfants.Text = "";
        }

        // Méthode InitialiserControles()
        /// <summary>
        /// Initialise tous les TextBox, DatePicker et NumericUpDown
        /// </summary>
        // Code de Hasna Hocini (GestElection)
        public void InitialiserControles()
        {
            // Réinitialiser tous les champs du formulaire
            txtNumLocation.Text = "";
            txtNumClient.Text = "";
            txtNumEspace.Text = "";
            dtDebutLocation.Value = DateTime.Today;
            dtFinLocation.Value = DateTime.Today;
            numericNbAdultes.Value = 1;
            numericNbEnfants.Value = 0;
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
        public bool VerifierRegex(string modele, System.Windows.Forms.TextBox tb, System.Windows.Forms.Label lb, string messageErreur)
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
        /// Vérifie que toutes les méthodes booléennes retourne true
        /// </summary>
        /// <returns>
        ///     true si toutes les informations entrées par l'utilisateur sont valides
        ///     false si toutes les informations entrées par l'utilisateur sont invalides
        /// </returns>
        // Code de Hasna Hocini (GestElection)
        public bool VerifierTous()
        {
            // Déclaration des booléens de validation des informations entrées
            bool b_numLoc, b_numClient, b_numChambre;
            // Appel de la méthode VerifierRegex pour tous les champs et récupération des valeurs retournées dans les variables bouléennes
            b_numClient = VerifierRegex("^[0-9]{5}$", txtNumClient, lblErreurNumClient, "Cinq chiffres");
            b_numChambre = VerifierRegex("^[0-9]{6}$", txtNumEspace, lblErreurNumEspace, "Six chiffres");
            b_numLoc = VerifierRegex("^[0-9]{7}$", txtNumLocation, lblErreurNumLocation, "Sept chiffres");
            // Si toutes les vérifications sont valides retourner vrai
            if (b_numLoc && b_numClient && b_numChambre)
                return true; // Retourner true
            else return false; // Sinon retourner false
        }

        // Méthode VerifierNumLoc()
        /// <summary>
        /// Vérifie que la location entrée par l'utilisateur ne se trouve pas dans la liste des locations
        /// </summary>
        /// <returns>
        ///     false si la location se trouve dans la liste
        ///     true si la location ne se trouve pas dans la liste
        /// </returns>
        // Code de Hasna Hocini (GestElection)
        public bool VerifierNumLoc()
        {
            // Parcourir la liste des locations
            foreach (Location location in StatistiquesHotel.ListeLocations)
            {
                // Si le numéro de la location entré par l'utilisateur est le même que celui dans la liste
                if (location.NumeroLocation == txtNumLocation.Text)
                {
                    MessageBox.Show("La location existe déjà. ", "Message"); // Afficher un message d'erreur
                    return false; // Retourner false 
                }
            }
            return true; // Retourner true si la location n'est pas dans la liste
        }

        // Méthode VerifierNumClient()
        /// <summary>
        /// Vérifie que le client entré par l'utilisateur se trouve dans la liste des clients
        /// </summary>
        /// <returns>
        ///     false si le client ne se trouve pas dans la liste
        ///     true si le client se trouve dans la liste
        /// </returns>
        // Code de Hasna Hocini (GestElection)
        public bool VerifierNumClient()
        {
            // Parcourir la liste des clients
            foreach (Client client in StatistiquesHotel.ListeClients)
            {
                // Si le numéro du client entré par l'utilisateur est le même que celui dans la liste
                if (client.NumeroClient == txtNumClient.Text)
                {
                    return true; // Retourner true 
                }
            }
            MessageBox.Show("Le client n'existe pas. ", "Message"); // Afficher un message d'erreur
            return false; // Retourner false si le client n'est pas dans la liste
        }

        // Méthode VerifierNumEspace()
        /// <summary>
        /// Vérifie que l'espace entré par l'utilisateur se trouve dans la liste des espaces
        /// </summary>
        /// <returns>
        ///     false si l'espace ne se trouve pas dans la liste
        ///     true si l'espace se trouve dans la liste
        /// </returns>
        // Code de Hasna Hocini (GestElection)
        public bool VerifierNumEspace()
        {
            // Parcourir la liste des espace
            foreach (EspaceLoue espace in StatistiquesHotel.ListeEspaceLoue)
            {
                // Si le numéro de l'espace entré par l'utilisateur est le même que celui dans la liste
                if (espace.NumeroEspace == txtNumEspace.Text)
                {
                    return true; // Retourner true 
                }
            }
            MessageBox.Show("L'espace n'existe pas. ", "Message"); // Afficher un message d'erreur
            return false; // Retourner false si l'espace n'est pas dans la liste
        }

        private void btnAjouterLoc_Click(object sender, EventArgs e)
        {
            // Si les méthodes VerifierTous, VerifierNumClient et VerifierNumEspace retournent true
            if (VerifierTous() && VerifierNumClient() && VerifierNumEspace()) 
            {
                // Parcourir la liste des clients
                foreach (Client elt in StatistiquesHotel.ListeClients)
                {
                    // Parcourir la liste des espaces
                    foreach (EspaceLoue elt1 in StatistiquesHotel.ListeEspaceLoue)
                    {
                        // Si le numéro du client et le numéro de l'espace entrés par l'utilisateur sont les mêmes que ceux dans la liste
                        if (elt.NumeroClient == txtNumClient.Text & elt1.NumeroEspace == txtNumEspace.Text)
                        {
                            // Instancier un objet Location avec les champs entrés par l'utilisateur
                            Location location = new Location(txtNumLocation.Text, dtDebutLocation.Value.Date,
                                                             dtFinLocation.Value.Date, (int)numericNbAdultes.Value,
                                                             (int)numericNbEnfants.Value, elt, elt1);

                            // Si la méthode VerifierNumLoc retourne true
                            if (VerifierNumLoc())
                            {
                                // Ajouter la nouvelle location à la liste des locations de la classe statique StatistiquesHotel
                                StatistiquesHotel.ListeLocations.Add(location);
                                // Appel de la méthode InitialiserControles
                                InitialiserControles();
                                // Appel de la méthode InitialiserLabel
                                InitialiserLabel();
                                // Appel de la méthode DureeSejour
                                int dureeSejour = location.DureeSejour(dtDebutLocation, dtFinLocation);
                                // Afficher les informations de la chambre dans une boîte de message
                                MessageBox.Show(location.AfficherLocation() + "\n" + 
                                                "Durée séjour : " + dureeSejour.ToString() + "\n" + "\n" +
                                                elt.AfficherClient() + "\n" + "\n" + 
                                                elt1.AfficherEspace(), "Location ajoutée");
                                break; // Arrêter de parcourir les listes
                            }
                        }
                    }
                }
            }
        }

        private void btnModifierLoc_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimerLoc_Click(object sender, EventArgs e)
        {

        }
    }
}
