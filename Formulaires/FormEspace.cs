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

// Numéro étudiant : 1724602
// Nom : Béatrice Duguay

namespace GestionHotel.Formulaires
{
    public partial class FormEspace : Form
    {
        public FormEspace()
        {
            InitializeComponent();
        }

        private void FormChambre_Load(object sender, EventArgs e)
        {
            // Cacher les Label, NumericUpDown et les RadioButton du nombre de chambres et du mini bar
            lblNbChambres.Visible = false;
            lblMiniBar.Visible = false;
            numericNbChambres.Visible = false;
            radioBtnOui.Visible = false;
            radioBtnNon.Visible = false;
        }

        // Méthode InitialiserLabel()
        /// <summary>
        /// Initialise tous les Label d'erreurs
        /// </summary>
        // Code de Hasna Hocini (GestElection)
        public void InitialiserLabel()
        {
            lblErreurNumEspace.Text = lblErreurNbLits.Text =
            lblErreurType.Text = lblErreurNbChambres.Text = lblErreurMiniBar.Text = "";
        }

        // Méthode InitialiserControles()
        /// <summary>
        /// Initialise tous les TextBox, ComboBox, numericUpDown et radioButton
        /// </summary>
        // Code de Hasna Hocini (GestElection)
        public void InitialiserControles()
        {
            // Réinitialiser tous les champs du formulaire
            txtNumEspace.Text = "";
            numericNbLits.Value = 1;
            cboTypeEspace.SelectedIndex = -1;
            radioBtnOui.Checked = false;
            radioBtnNon.Checked = false;
        }

        /// <summary>
        /// Vérifie qu'une des deux RadioButton est coché et qu'ils sont visibles
        /// </summary>
        /// <param name="rb1" le premier RadioButton></param>
        /// <param name="rb2" le deuxième RadioButton></param>
        /// <param name="lb" le Label du formulaire></param>
        /// <returns>
        ///     true si un des deux RadioButton est cochée et si les deux RadioButton sont visibles
        ///     false si aucun des deux RadioButton n'est cochée et si les deux RadioButton ne sont pas visibles
        /// </returns>
        public bool VerifierMiniBar(RadioButton rb1, RadioButton rb2,Label lb) 
        {
            if (rb1.Visible == true & rb2.Visible == true) 
            {
                if (rb1.Checked == false & rb2.Checked == false)
                { 
                    lb.ForeColor = Color.Red; lb.Text = "Veuillez cocher une option"; return false; 
                }

                return true;
            }

            else
                return true;

        }

        /// <summary>
        /// Vérifier le Regex des ComboBox et des Label
        /// </summary>
        /// <param name="cb" les ComboBox du formulaire></param>
        /// <param name="lb" les Label du formulaire></param>
        /// <returns> 
        ///     false si le champ entré par l'utilisateur est invalide     
        ///     true si le champ entré par l'utilisateur est valide 
        /// </returns>
        // Code de Hasna Hocini (GestElection)
        public bool VerifierCombobox(ComboBox cb, Label lb)
        {
            // Si l'utilisateur a choisi une valeur de la liste
            if (cb.Text != "") { lb.Text = ""; return true; }
            else // Sinon afficher un message d'erreur
            {
                lb.ForeColor = Color.Red; lb.Text = "Veuillez sélectionner une option "; return false;
            }
        }

        /// <summary>
        /// Vérifier le Regex 
        /// </summary>
        /// <param name="modele"></param>
        /// <param name="tb" les TextBox du formulaire></param>
        /// <param name="lb" les Label du formulaire></param>
        /// <param name="messageErreur" les messages d'erreur du formulaire></param>
        /// <returns> 
        ///     false si le champ entré par l'utilisateur est invalide      
        ///     true si le champ entré par l'utilisateur est valide 
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
            bool b_numero, b_comboBoxType, b_radioBtn;

            // Appel de la méthode VerifierRegex pour tous les champs et récupération des valeurs retournées dans les variables bouléennes
            b_numero = VerifierRegex("^[0-9]{6}$", txtNumEspace, lblErreurNumEspace, "Six chiffres");

            // Vérifier que la combobox Programme contient une valeur
            b_comboBoxType = VerifierCombobox(cboTypeEspace, lblErreurType);

            // Vérifier qu'un des deux radioButton est coché
            b_radioBtn = VerifierMiniBar(radioBtnOui, radioBtnNon, lblErreurMiniBar);

            // Si toutes les vérifications sont valides retourner true
            if (b_numero && b_comboBoxType && b_radioBtn)
                return true; // Retourner true
            else return false; // Sinon retourner false
        }

        // Méthode VerifierNum()
        /// <summary>
        /// Vérifie que l'espace entré par l'utilisateur ne se trouve pas dans la liste des espaces
        /// </summary>
        /// <returns>
        ///     false si l'espace se trouve dans la liste
        ///     true si l'espace ne se trouve pas dans la liste
        /// </returns>
        // Code de Hasna Hocini (GestElection)
        public bool VerifierNum()
        {
            // Parcourir la liste des espaces
            foreach (EspaceLoue espace in StatistiquesHotel.ListeEspaceLoue)
            {
                // Si le numéro de l'espace entré par l'utilisateur est le même que celui dans la liste
                if (espace.NumeroEspace == txtNumEspace.Text)
                {
                    MessageBox.Show("L'espace existe déjà. ", "Message"); // Afficher un message d'erreur
                    return false; // Retourner false 
                }
            }
            return true; // Retourner true si l'espace n'est pas dans la liste
        }


        private void cboTypeEspace_DropDownClosed(object sender, EventArgs e)
        {
            // Si l'index du ComboBox séléctionné est celui de la chambre
            if (cboTypeEspace.SelectedIndex == 0)
            {
                // Rendre visible le Label mini bar
                lblMiniBar.Visible = true;

                // Rendre visible les RadioButton
                radioBtnOui.Visible = true;
                radioBtnNon.Visible = true;
            }

            // Si l'index du ComboBox séléctionné est celui de la suite
            else if (cboTypeEspace.SelectedIndex == 1)
            {
                // Rendre visible le Label nombre de chambres
                lblNbChambres.Visible = true;

                // Rendre visible le NumericUpDown du nombre de chambres
                numericNbChambres.Visible = true;
            }            
        }

        private void btnAjouterEspace_Click(object sender, EventArgs e)
        {
            if (VerifierTous()) // Si la méthode VerifierTous retourne true
            {
                if (cboTypeEspace.Text == "Chambre")
                {
                    if (radioBtnOui.Checked)
                    {
                        // Instancier un objet Chambre test pour pouvoir accéder à la méthode abstraite CalculerPrix
                        Chambre test = new Chambre();

                        // Ajouter 30$ au prix de la chambre pour le mini bar
                        int prix = test.CalculerPrix((int)numericNbLits.Value, 0) + 30;

                        // Instancier un objet Chambre avec les champs entrés par l'utilisateur
                        Chambre chambre = new Chambre(txtNumEspace.Text, (int)numericNbLits.Value, prix, cboTypeEspace.Text, radioBtnOui.Text);

                        if (VerifierNum())
                        {
                            // Ajouter la nouvelle chambre à la liste des espaces de la classe statique StatistiquesHotel
                            StatistiquesHotel.ListeEspaceLoue.Add(chambre);

                            // Appel de la méthode InitialiserControles
                            InitialiserControles();
                            // Appel de la méthode InitialiserLabel
                            InitialiserLabel();
                            // Afficher les informations de la chambre dans une boîte de message

                            MessageBox.Show(chambre.AfficherChambre(), "Chambre ajoutée");

                            // Rendre invisible le Label mini bar
                            lblMiniBar.Visible = false;
                            // Rendre invisible les RadioButton
                            radioBtnOui.Visible = false;
                            radioBtnNon.Visible = false;
                        }
                    }

                    else if (radioBtnNon.Checked)
                    {
                        // Instancier un objet Chambre test pour pouvoir accéder à la méthode abstraite CalculerPrix
                        Chambre test = new Chambre();
                        int prix = test.CalculerPrix((int)numericNbLits.Value, 0);
                        // Instancier un objet Chambre avec les champs entrés par l'utilisateur
                        Chambre chambre = new Chambre(txtNumEspace.Text, (int)numericNbLits.Value, prix, cboTypeEspace.Text, radioBtnNon.Text);

                        if (VerifierNum())
                        {
                            // Ajouter la nouvelle chambre à la liste des espaces de la classe statique StatistiquesHotel
                            StatistiquesHotel.ListeEspaceLoue.Add(chambre);

                            // Appel de la méthode InitialiserControles
                            InitialiserControles();
                            // Appel de la méthode InitialiserLabel
                            InitialiserLabel();

                            // Afficher les informations de la chambre dans une boîte de message
                            MessageBox.Show(chambre.AfficherChambre(), "Chambre ajoutée");

                            // Rendre invisible le Label mini bar
                            lblMiniBar.Visible = false;
                            // Rendre invisible les RadioButton
                            radioBtnOui.Visible = false;
                            radioBtnNon.Visible = false;
                        }
                    }
                }

                else if (cboTypeEspace.Text == "Suite")
                {
                    // Instancier un objet Suite test pour pouvoir accéder à la méthode abstraite CalculerPrix
                    Suite test = new Suite();
                    int prix = test.CalculerPrix((int)numericNbLits.Value, 0);
                    // Instancier un objet Suite avec les champs entrés par l'utilisateur
                    Suite suite = new Suite(txtNumEspace.Text, (int)numericNbLits.Value, prix, cboTypeEspace.Text, (int)numericNbChambres.Value);

                    if (VerifierNum())
                    {
                        // Ajouter la nouvelle suite à la liste des espaces de la classe statique StatistiquesHotel
                        StatistiquesHotel.ListeEspaceLoue.Add(suite);

                        // Appel de la méthode InitialiserControles
                        InitialiserControles();
                        // Appel de la méthode InitialiserLabel
                        InitialiserLabel();

                        // Afficher les informations de la chambre dans une boîte de message
                        MessageBox.Show(suite.AfficherSuite(), "Suite ajoutée");

                        // Rendre invisible le Label nombre de chambres
                        lblNbChambres.Visible = false;
                        // Rendre invisible le NumericUpDown du nombre de chambres
                        numericNbChambres.Visible = false;
                    }
                }
            }
        }

        // Méthode AjouterChambre(Chambre chambre)
        /// <summary>
        /// Vérifie que la chambre n'est pas déjà dans la liste des espaces, sinon, l'ajoute dans la liste des espaces
        /// </summary>
        /// <param name="chambre" la chambre instanciée></param>
        // Code de Hasna Hocini (GestElection)
        public void AjouterChambre(Chambre chambre)
        {
            // Si la chambre n'est pas dans la liste des espaces, l'ajouter à la liste
            if (!StatistiquesHotel.ListeEspaceLoue.Contains(chambre))
                StatistiquesHotel.ListeEspaceLoue.Add(chambre);

            // Sinon afficher un message d'erreur
            else MessageBox.Show("La chambre existe déjà. ", "Message");
        }

        // Méthode AjouterSuite(Suite suite)
        /// <summary>
        /// Vérifie que la suite n'est pas déjà dans la liste des espaces, sinon, l'ajoute dans la liste des espaces
        /// </summary>
        /// <param name="suite" la suite instanciée></param>
        // Code de Hasna Hocini (GestElection)
        public void AjouterSuite(Suite suite)
        {
            // Si la suite n'est pas dans la liste des espaces, l'ajouter à la liste
            if (!StatistiquesHotel.ListeEspaceLoue.Contains(suite))
                StatistiquesHotel.ListeEspaceLoue.Add(suite);

            // Sinon afficher un message d'erreur
            else MessageBox.Show("La suite existe déjà. ", "Message");
        }

        private void btnModifierEspace_Click(object sender, EventArgs e)
        {
            if (VerifierTous()) // Si la méthode VerifierTous retourne true
            {
                if (cboTypeEspace.Text == "Chambre")
                {
                    // Parcourir la liste des espaces
                    foreach (EspaceLoue elt in StatistiquesHotel.ListeEspaceLoue.ToList())
                    {
                        // Si le numéro de l'espace entré par l'utilisateur existe dans la liste
                        if (elt.NumeroEspace == txtNumEspace.Text)
                        {
                            if (radioBtnOui.Checked)
                            {
                                // Supprimer l'élément de la liste 
                                StatistiquesHotel.ListeEspaceLoue.Remove(elt);

                                // Instancier un objet Chambre test pour pouvoir accéder à la méthode abstraite CalculerPrix
                                Chambre test = new Chambre();

                                // Ajouter 30$ au prix de la chambre pour le mini bar
                                int prix = test.CalculerPrix((int)numericNbLits.Value, 0) + 30;

                                // Instancier un objet Chambre avec les champs entrés par l'utilisateur
                                Chambre chambre = new Chambre(txtNumEspace.Text, (int)numericNbLits.Value, prix, cboTypeEspace.Text, radioBtnOui.Text);

                                // Ajouter la nouvelle chambre à la liste des espaces de la classe statique StatistiquesHotel
                                StatistiquesHotel.ListeEspaceLoue.Add(chambre);

                                // Appel de la méthode InitialiserControles
                                InitialiserControles();
                                // Appel de la méthode InitialiserLabel
                                InitialiserLabel();

                                // Afficher les informations de la chambre dans une boîte de message
                                MessageBox.Show(chambre.AfficherChambre(), "Chambre modifiée");

                                // Rendre invisible le Label mini bar
                                lblMiniBar.Visible = false;
                                // Rendre invisible les RadioButton
                                radioBtnOui.Visible = false;
                                radioBtnNon.Visible = false;
                            }

                            else if (radioBtnNon.Checked)
                            {
                                // Supprimer l'élément de la liste 
                                StatistiquesHotel.ListeEspaceLoue.Remove(elt);

                                // Instancier un objet Chambre test pour pouvoir accéder à la méthode abstraite CalculerPrix
                                Chambre test = new Chambre();
                                int prix = test.CalculerPrix((int)numericNbLits.Value, 0);

                                // Instancier un objet Chambre avec les champs entrés par l'utilisateur
                                Chambre chambre = new Chambre(txtNumEspace.Text, (int)numericNbLits.Value, prix, cboTypeEspace.Text, radioBtnNon.Text);

                                // Ajouter la nouvelle chambre à la liste des espaces de la classe statique StatistiquesHotel
                                StatistiquesHotel.ListeEspaceLoue.Add(chambre);

                                // Appel de la méthode InitialiserControles
                                InitialiserControles();
                                // Appel de la méthode InitialiserLabel
                                InitialiserLabel();

                                // Afficher les informations de la chambre dans une boîte de message
                                MessageBox.Show(chambre.AfficherChambre(), "Chambre modifiée");

                                // Rendre invisible le Label mini bar
                                lblMiniBar.Visible = false;
                                // Rendre invisible les RadioButton
                                radioBtnOui.Visible = false;
                                radioBtnNon.Visible = false;
                            }
                        }
                    }
                }

                else if (cboTypeEspace.Text == "Suite")
                {
                    // Parcourir la liste des espaces
                    foreach (EspaceLoue elt in StatistiquesHotel.ListeEspaceLoue.ToList()) 
                    {
                        // Si le numéro de l'espace entré par l'utilisateur existe dans la liste
                        if (elt.NumeroEspace == txtNumEspace.Text)
                        {
                            // Supprimer l'élément de la liste 
                            StatistiquesHotel.ListeEspaceLoue.Remove(elt);

                            // Instancier un objet Suite test pour pouvoir accéder à la méthode abstraite CalculerPrix
                            Suite test = new Suite();
                            int prix = test.CalculerPrix((int)numericNbLits.Value, 0);

                            // Instancier un objet Suite avec les champs entrés par l'utilisateur
                            Suite suite = new Suite(txtNumEspace.Text, (int)numericNbLits.Value, prix, cboTypeEspace.Text, (int)numericNbChambres.Value);

                            // Ajouter la nouvelle suite à la liste des espaces de la classe statique StatistiquesHotel
                            StatistiquesHotel.ListeEspaceLoue.Add(suite);

                            // Appel de la méthode InitialiserControles
                            InitialiserControles();
                            // Appel de la méthode InitialiserLabel
                            InitialiserLabel();

                            // Afficher les informations de la chambre dans une boîte de message
                            MessageBox.Show(suite.AfficherSuite(), "Suite modifiée");

                            // Rendre invisible le Label nombre de chambres
                            lblNbChambres.Visible = false;
                            // Rendre invisible le NumericUpDown du nombre de chambres
                            numericNbChambres.Visible = false;
                        }
                    }
                }

                else MessageBox.Show("Espace inexistant", "Message"); // Sinon afficher message d'erreur
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
            b_numero = VerifierRegex("^[0-9]{6}$", txtNumEspace, lblErreurNumEspace, "Six chiffres");
            if (b_numero)
                return true;
            else return false; //Sinon retourner faux
        }

        private void btnSupprimerEspace_Click(object sender, EventArgs e)
        {
            if (VerifierNumero()) // Si la méthode VerifierNumero retourne true
            {
                // Parcourir la liste des espaces
                foreach (EspaceLoue elt in StatistiquesHotel.ListeEspaceLoue.ToList())
                {
                    // Si le numéro de l'espace entré par l'utilisateur existe dans la liste
                    if (elt.NumeroEspace == txtNumEspace.Text)
                    {
                        if (elt.TypeEspace == "Chambre") // Si le type d'espace de l'élément a la valeur Chambre
                        {
                            // Supprimer le client de la liste
                            StatistiquesHotel.ListeEspaceLoue.Remove(elt);

                            // Appel de la méthode InitialiserControles
                            InitialiserControles();
                            // Appel de la méthode InitialiserLabel
                            InitialiserLabel();
                            // Afficher un message de confirmation dans une boîte de message

                            MessageBox.Show("La chambre a bien été supprimée.", "Chambre supprimée");
                        }

                        else if (elt.TypeEspace == "Suite") // Si le type d'espace de l'élément a la valeur Suite
                        {
                            // Supprimer le client de la liste
                            StatistiquesHotel.ListeEspaceLoue.Remove(elt);

                            // Appel de la méthode InitialiserControles
                            InitialiserControles();
                            // Appel de la méthode InitialiserLabel
                            InitialiserLabel();

                            // Afficher un message de confirmation dans une boîte de message
                            MessageBox.Show("La suite a bien été supprimée.", "Suite supprimée");
                        }

                        break; // Arrêter de parcourir la liste
                    }
                    else MessageBox.Show("Espace inexistant ", "Message"); // Sinon afficher un message d'erreur
                }
            }
        }
    }
}
