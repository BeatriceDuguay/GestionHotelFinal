using GestionHotel.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

// Numéro étudiant : 1724602
// Nom : Béatrice Duguay

namespace GestionHotel.Formulaires
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            // Modifier le format du DateTimePicker
            dtDateNaissance.Format = DateTimePickerFormat.Custom;
            dtDateNaissance.CustomFormat = "dd MMMM yyyy";
        }

        // Méthode InitialiserLabel()
        /// <summary>
        /// Initialise tous les Label d'erreurs
        /// </summary>
        // Code de Hasna Hocini (GestElection)
        public void InitialiserLabel()
        {
            lblErreurNumClient.Text = lblErreurPrenom.Text = lblErreurNom.Text = 
            lblErreurDateNaiss.Text = lblErreurTelephone.Text = "";
        }

        // Méthode InitialiserControles()
        /// <summary>
        /// Initialise tous les TextBox et remet le DatePicker à la date d'aujourd'hui
        /// </summary>
        // Code de Hasna Hocini (GestElection)
        public void InitialiserControles()
        {
            // Réinitialiser tous les champs du formulaire
            txtNumClient.Text = "";
            txtNom.Text = "";
            txtPrenom.Text = "";
            dtDateNaissance.Value = DateTime.Today;
            txtTelephone.Text = "";
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

        // Méthode VerifierAge(DateTimePicker dtpicker, System.Windows.Forms.Label lb)
        /// <summary>
        /// Vérifie si la date du DatePicker a été modifiée 
        /// Vérifie si le client a 18 et plus en appelant la méthode Age
        /// </summary>
        /// <param name="dtPicker" le DateTimePicker du formulaire></param>
        /// <param name="lb" le Label du formulaire></param>
        /// <returns> 
        ///     false si le client n'a pas modifié la date du DatePicker
        ///     true si le client a 18 ans et plus 
        ///     false si le client a moins de 18 ans 
        /// </returns>
        // Code de Hasna Hocini (GestElection)
        public bool VerifierAge(DateTimePicker dtpicker, Label lb)
        {
            // Obtenir la difference en années entre la date d'aujourd'hui et la date de naissance entrées
            if (dtpicker.Value.Date.Year == DateTime.Now.Year &
                dtpicker.Value.Date.Month == DateTime.Now.Month &
                dtpicker.Value.Date.Day == DateTime.Now.Day)
            {
                MessageBox.Show("Veuillez entrer une date de naissance. ", "Message"); // Afficher un message d'erreur
                return false; // Retourner false si la date du DatePicker n'a pas été modifiée
            }

            else
            {
                // Retourner true si le client a 18 ans et plus
                if (Client.Age(dtDateNaissance) >= 18) { lb.Text = ""; return true; }
                // Retourner false si le client a moins de 18 ans
                else { lb.ForeColor = Color.Red; lb.Text = "Le client doit avoir au moins 18 ans. "; return false; }
            }
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
            bool b_numero, b_nom, b_prenom, b_age, b_numTel;

            // Appel de la méthode VerifierRegex pour tous les champs et récupération des valeurs retournées dans les variables bouléennes
            b_numero = VerifierRegex("^[0-9]{5}$", txtNumClient, lblErreurNumClient, "Cinq chiffres");
            b_nom = VerifierRegex("^[A-Z]{1}[a-z]{1,20}$", txtNom, lblErreurNom, "Lettre majuscule suivie de 1 à 20 lettres minuscules");
            b_prenom = VerifierRegex("^[A-Z]{1}[a-z]{1,20}$", txtPrenom, lblErreurPrenom, "Lettre majuscule suivie de 1 à 20 lettres minuscules");
            b_numTel = VerifierRegex("^[0-9]{10}$", txtTelephone, lblErreurTelephone, "Dix chiffres");

            // Appel de la métode VerifierAge pour vérifier l'âge de la personne
            b_age = VerifierAge(dtDateNaissance, lblErreurDateNaiss);

            // Si toutes les vérifications sont valides retourner vrai
            if (b_numero && b_nom && b_prenom && b_age && b_numTel)
                return true; // Retourner true
            else return false; // Sinon retourner false
        }

        // Méthode VerifierNum()
        /// <summary>
        /// Vérifie que le client entré par l'utilisateur ne se trouve pas dans la liste des clients
        /// </summary>
        /// <returns>
        ///     false si le client se trouve dans la liste
        ///     true si le client ne se trouve pas dans la liste
        /// </returns>
        // Code de Hasna Hocini (GestElection)
        public bool VerifierNum()
        {
            // Parcourir la liste des client
            foreach (Client client in StatistiquesHotel.ListeClients)
            {
                // Si le numéro du client entré par l'utilisateur est le même que celui dans la liste
                if (client.NumeroClient == txtNumClient.Text)
                {
                    MessageBox.Show("Le client existe déjà. ", "Message"); // Afficher un message d'erreur
                    return false; // Retourner false 
                }
            }
            return true; // Retourner true si le client n'est pas dans la liste
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            if (VerifierTous()) // Si la méthode VerifierTous retourne true
            {
                // Instancier un objet Client avec les champs entrés par l'utilisateur
                Client client = new Client(txtNumClient.Text, txtPrenom.Text, txtNom.Text, dtDateNaissance.Value.Date,
                                           txtTelephone.Text);
                if (VerifierNum())
                {
                    // Ajouter le nouveau client à la liste des clients de la classe statique StatistiquesHotel
                    StatistiquesHotel.ListeClients.Add(client);

                    // Appel de la méthode InitialiserControles
                    InitialiserControles();
                    // Appel de la méthode InitialiserLabel
                    InitialiserLabel();

                    // Afficher les informations du client dans une boîte de message en appelant la méthode AfficherClient
                    MessageBox.Show(client.AfficherClient(), "Client ajouté");
                }
            }
        }

        // Méthode AjouterClient(Client client)
        /// <summary>
        /// Vérifie que le client n'est pas déjà dans la liste des clients, sinon, l'ajoute dans la liste des clients
        /// </summary>
        /// <param name="client" le client instancié></param>
        // Code de Hasna Hocini (GestElection)
        public void AjouterClient(Client client)
        {
            // Si le client n'est pas dans la liste des clients, l'ajouter à la liste
            if (!StatistiquesHotel.ListeClients.Contains(client))
                StatistiquesHotel.ListeClients.Add(client); 
            
            // Sinon afficher un message d'erreur
            else MessageBox.Show("Le client existe déjà. ", "Message");
        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            if (VerifierTous()) // Si la méthode VerifierTous retourne true
            {
                // Parcourir la liste des clients
                foreach (Client elt in StatistiquesHotel.ListeClients)
                {
                    // Si le numéro du client entré par l'utilisateur existe dans la liste
                    if (elt.NumeroClient == txtNumClient.Text)
                    {
                        // Instancier un objet Client avec les champs entrés par l'utilisateur
                        Client client = new Client(txtNumClient.Text, txtPrenom.Text, txtNom.Text, dtDateNaissance.Value.Date,
                                                   txtTelephone.Text);

                        // Supprimer le client de la liste
                        StatistiquesHotel.ListeClients.Remove(elt);

                        // Ajouter les nouvelles informations du client à la liste
                        AjouterClient(client);
                        // Appel de la méthode InitialiserControles
                        InitialiserControles();
                        // Appel de la méthode InitialiserLabel
                        InitialiserLabel();

                        // Afficher les nouvelles informations du client dans une boîte de message
                        MessageBox.Show(client.AfficherClient(), "Client modifié");
                        break; // Arrêter de parcourir la liste
                    }

                    else MessageBox.Show("Client Inexistant", "Message"); // Sinon afficher message d'erreur
                }
            }
        }

        /// <summary>
        /// Vérifie que toutes les méthodes booléennes retourne true
        /// </summary>
        /// <returns>
        ///     true le numéro entré par l'utilisateur est valide
        ///     false si le numéro entré par l'utilisateur est invalide
        /// </returns>
        // Code de Hasna Hocini (GestElection)
        public bool VerifierNumero()
        {
            // Déclaration du booléen de validation de l'informations entrée
            bool b_numero;

            // Appel de la méthode VerifierRegex pour le champs Numero et récupération de la valeur retournée dans la variable bouléenne
            b_numero = VerifierRegex("^[0-9]{5}$", txtNumClient, lblErreurNumClient, "Cinq chiffres");
            if (b_numero)
                return true;
            else return false; //Sinon retourner faux
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            if (VerifierNumero()) // Si la méthode VerifierNumero retourne true
            {
                // Parcourir la liste des clients
                foreach (Client elt in StatistiquesHotel.ListeClients)
                {
                    // Si le numéro du client entré par l'utilisateur existe dans la liste
                    if (elt.NumeroClient == txtNumClient.Text)
                    {
                        // Supprimer le client de la liste
                        StatistiquesHotel.ListeClients.Remove(elt);

                        // Appel de la méthode InitialiserControles
                        InitialiserControles();
                        // Appel de la méthode InitialiserLabel
                        InitialiserLabel();

                        // Afficher un message de confirmation dans une boîte de message
                        MessageBox.Show("Le client a bien été supprimé.", "Client supprimé");
                        break; // Arrêter de parcourir la liste
                    }

                    else MessageBox.Show("Client inexistant ", "Message"); // Sinon afficher un message d'erreur
                }
            }
        }
    }
}
