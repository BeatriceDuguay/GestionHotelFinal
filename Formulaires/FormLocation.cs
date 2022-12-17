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

// Numéro étudiant : 1724602
// Nom : Béatrice Duguay

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
            // Modifier le format des DateTimePicker 
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
            bool b_numLoc, b_numClient, b_numChambre, b_duree, b_dispo;

            // Appel de la méthode VerifierRegex pour tous les champs et récupération des valeurs retournées dans les variables bouléennes
            b_numClient = VerifierRegex("^[0-9]{5}$", txtNumClient, lblErreurNumClient, "Cinq chiffres");
            b_numChambre = VerifierRegex("^[0-9]{6}$", txtNumEspace, lblErreurNumEspace, "Six chiffres");
            b_numLoc = VerifierRegex("^[0-9]{7}$", txtNumLocation, lblErreurNumLocation, "Sept chiffres");

            // Appel de la métode VerifierDuree pour vérifier la durée de la location
            b_duree = VerifierDuree(dtDebutLocation, lblErreurDebutLoc, lblErreurFinLoc);

            // Appel de la méthode VerifierDispo pour vérifier si l'espace est disponible
            b_dispo = VerifierDispo(dtDebutLocation, dtFinLocation, lblErreurNumEspace);

            // Si toutes les vérifications sont valides retourner vrai
            if (b_numLoc && b_numClient && b_numChambre && b_duree && b_dispo)
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
            MessageBox.Show("Le client ou l'espace n'existe pas. ", "Message"); // Afficher un message d'erreur
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
            MessageBox.Show("Le client ou l'espace n'existe pas. ", "Message"); // Afficher un message d'erreur
            return false; // Retourner false si l'espace n'est pas dans la liste
        }

        // Méthode VerifierDuree()
        /// <summary>
        /// Vérifie que la durée de la location est de 1 jour et plus, mais de 28 jours maximum
        /// Vérifie que la date du début de la location est plus grande ou égale à la date d'aujourd'hui
        /// </summary>
        /// <param name="dtpickerDebut" Le premier DateTimePicker du formulaire></param>
        /// <param name="lb1" Le premier Label du formulaire></param>
        /// <param name="lb2" Le deuxièeme Label du formulaire></param>
        /// <returns>
        ///     true si la location est d'une durée minimale de 1 jour et maximal de 28 jours
        ///     false si la date DateTimePicker du début de la location est plus petite que la date d'aujourd'hui
        ///     false si la location n'est pas d'une durée minimale de 1 jour et maximal de 28 jours
        /// </returns>
        public bool VerifierDuree(DateTimePicker dtpickerDebut, Label lb1, Label lb2)
        {
            // Instancier un objet test Location pour accéder à la méthode DureeSejour
            Location test = new Location();

            // Si la date DateTimePicker du début de la location est plus petite que la date d'aujourd'hui
            if (dtpickerDebut.Value.Date < DateTime.Now)
            {
                lb1.ForeColor = Color.Red;
                lb1.Text = "Date indisponible"; // Afficher un message d'erreur
                return false; // Retourner false
            }

            // Appel de la méthode DureeSejour
            // Si la location est d'une durée minimale de 1 jour et maximal de 28 jours
            if (test.DureeSejour(dtDebutLocation, dtFinLocation) >= 1 & test.DureeSejour(dtDebutLocation, dtFinLocation) <= 28)
            {
                return true; // Retourner true
            }

            else
            {
                lb2.ForeColor = Color.Red;
                lb2.Text = "1 jour minimum et 28 jours maximum"; // Afficher un message d'erreur
                return false; // Retourner false
            }
        }

        // Méthode VerifierDispo
        /// <summary>
        /// Vérifie que l'espace n'est pas déjà loué
        /// </summary>
        /// <param name="dtpickerDebut" Le DateTimePicker du début de la location></param>
        /// <param name="dtpickerFin" Le DateTimePicker de la fin de la location></param>
        /// <param name="lb" Le Label d'erreur du numéro de la chambre></param>
        /// <returns></returns>
        public bool VerifierDispo(DateTimePicker dtpickerDebut, DateTimePicker dtpickerFin, Label lb)
        {
            // Parcourir la liste des locations
            foreach (Location elt in StatistiquesHotel.ListeLocations)
            {
                // Si le numéro de l'espace dans la liste est le même que celui entré par l'utilisateur
                // ET la date du début de la location entrée par l'utilisateur est plus petite que la date de la fin de la location dans la liste
                // ET LOGIQUE la date du début de la location dans la liste est plus petite que la date de la fin de la location entrée par l'utilisateur
                if (elt.EspaceLoue.NumeroEspace == txtNumEspace.Text & dtpickerDebut.Value < elt.DateFinLocation && elt.DateDebutLocation < dtpickerFin.Value) // CODE DE : https://stackoverflow.com/a/13513973
                {
                    lb.ForeColor = Color.Red;
                    lb.Text = "Espace déjà loué"; // Afficher un message d'erreur
                    return false; // Retourner false
                }
            }
            return true; // Retourner true
        }

        private void btnAjouterLoc_Click(object sender, EventArgs e)
        {
            InitialiserLabel(); // Appel de la méthode InitialiserLabel
            // Si les méthodes VerifierTous, VerifierNumClient et VerifierNumEspace retournent true
            if (VerifierTous()) 
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
                            // Instancier un objet test Location pour accéder à la méthode DureeSejour
                            Location test = new Location();

                            // Appel de la méthode DureeSejour
                            int dureeSejour = test.DureeSejour(dtDebutLocation, dtFinLocation);

                            // Instancier un objet Location avec les champs entrés par l'utilisateur
                            Location location = new Location(txtNumLocation.Text, dtDebutLocation.Value.Date,
                                                             dtFinLocation.Value.Date, dureeSejour, (int)numericNbAdultes.Value,
                                                             (int)numericNbEnfants.Value, elt, elt1);

                            // Si la méthode VerifierNumLoc retourne true
                            if (VerifierNumLoc())
                            {
                                // Ajouter la nouvelle location à la liste des locations de la classe statique StatistiquesHotel
                                StatistiquesHotel.ListeLocations.Add(location);

                                // Afficher les informations de la chambre dans une boîte de message
                                MessageBox.Show(location.AfficherLocation() + "\n" + 
                                                elt.AfficherClient() + "\n" + "\n" + 
                                                elt1.AfficherEspace(), "Location ajoutée");

                                // Appel de la méthode InitialiserControles
                                InitialiserControles();
                                // Appel de la méthode InitialiserLabel
                                InitialiserLabel();
                                break; // Arrêter de parcourir la liste
                            }
                            break; // Arrêter de parcourir la liste
                        }
                    }
                }
            }
        }

        // Méthode VerifierNumLoc()
        /// <summary>
        /// Vérifie que la location entrée par l'utilisateur se trouve dans la liste des locations
        /// </summary>
        /// <returns>
        ///     true si la location se trouve dans la liste
        ///     false si la location ne se trouve pas dans la liste
        /// </returns>
        // Code de Hasna Hocini (GestElection)
        public bool VerifierNumLocPresent()
        {
            // Parcourir la liste des locations
            foreach (Location location in StatistiquesHotel.ListeLocations)
            {
                // Si le numéro de la location entré par l'utilisateur est le même que celui dans la liste
                if (location.NumeroLocation == txtNumLocation.Text)
                {
                    return true; // Retourner true 
                }
            }
            MessageBox.Show("La location existe déjà. ", "Message"); // Afficher un message d'erreur
            return true; // Retourner true si la location n'est pas dans la liste
        }

        private void btnModifierLoc_Click(object sender, EventArgs e)
        {
            InitialiserLabel(); // Appel de la méthode InitialiserLabel
            // Si les méthodes VerifierTous, VerifierNumClient et VerifierNumEspace retournent true
            if (VerifierTous())
            {
                // Parcourir la liste des locations
                foreach (Location elt in StatistiquesHotel.ListeLocations.ToList())
                {
                    // Si le numéro de la location entré par l'utilisateur existe dans la liste
                    if (elt.NumeroLocation == txtNumLocation.Text)
                    {
                        // Parcourir la liste des clients
                        foreach (Client elt1 in StatistiquesHotel.ListeClients)
                        {
                            // Parcourir la liste des espaces
                            foreach (EspaceLoue elt2 in StatistiquesHotel.ListeEspaceLoue)
                            {
                                // Si le numéro du client et le numéro de l'espace entrés par l'utilisateur sont les mêmes que ceux dans la liste
                                if (elt1.NumeroClient == txtNumClient.Text & elt2.NumeroEspace == txtNumEspace.Text)
                                {
                                    // Instancier un objet test Location pour accéder à la méthode DureeSejour
                                    Location test = new Location();

                                    // Appel de la méthode DureeSejour
                                    int dureeSejour = test.DureeSejour(dtDebutLocation, dtFinLocation);

                                    // Supprimer l'élément de la liste 
                                    StatistiquesHotel.ListeLocations.Remove(elt);

                                    // Instancier un objet Location avec les champs entrés par l'utilisateur
                                    Location location = new Location(txtNumLocation.Text, dtDebutLocation.Value.Date,
                                                                     dtFinLocation.Value.Date, dureeSejour, (int)numericNbAdultes.Value,
                                                                     (int)numericNbEnfants.Value, elt1, elt2);

                                    // Ajouter la nouvelle location à la liste des locations de la classe statique StatistiquesHotel
                                    StatistiquesHotel.ListeLocations.Add(location);

                                    // Appel de la méthode InitialiserControles
                                    InitialiserControles();
                                    // Appel de la méthode InitialiserLabel
                                    InitialiserLabel();

                                    // Afficher les nouvelles informations de la chambre dans une boîte de message
                                    MessageBox.Show(location.AfficherLocation() + "\n" +
                                                    elt1.AfficherClient() + "\n" + "\n" +
                                                    elt2.AfficherEspace(), "Location ajoutée");
                                    break; // Arrêter de parcourir les listes
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnSupprimerLoc_Click(object sender, EventArgs e)
        {
            // Parcourir la liste des locations
            foreach (Location elt in StatistiquesHotel.ListeLocations.ToList())
            {
                // Si le numéro de la location entrée par l'utilisateur se trouve dans la liste 
                if (elt.NumeroLocation == txtNumLocation.Text) 
                {
                    StatistiquesHotel.ListeLocations.Remove(elt); // Supprimer la location de la liste

                    // Appel de la méthode InitialiserControles
                    InitialiserControles();
                    // Appel de la méthode InitialiserLabel
                    InitialiserLabel();
                    // Afficher un message de confirmation de suppression

                    MessageBox.Show("La location a bien été supprimée.", "Location supprimée");

                }
                MessageBox.Show("La location n'existe pas.", "Message"); // Afficher un message d'erreur
            } 
        }

        private void btnConsulterLoc_Click(object sender, EventArgs e)
        {
            foreach (Location elt in StatistiquesHotel.ListeLocations.ToList())
            {
                // Si le numéro de la location entrée par l'utilisateur se trouve dans la liste 
                if (elt.NumeroLocation == txtNumLocation.Text)
                {
                    int nbPersonnes = elt.NombreEnfants + elt.NombreAdultes; // Calculer le nombre de personnes dans la location

                    // Afficher les statistiques de la location
                    MessageBox.Show("Nombre de jours : " + elt.Duree + "\n" +
                                    "Nombre de personnes : " + nbPersonnes.ToString() + "\n" +
                                    "Check-in : " + elt.DateDebutLocation.ToString() + " 15h" + "\n" + 
                                    "Check-out : " + elt.DateFinLocation.ToString() + " 11h", "Consulter la location");
                }

                else
                {
                    MessageBox.Show("La location n'existe pas.", "Message"); // Afficher un message d'erreur
                }
            }
        }
    }
}
