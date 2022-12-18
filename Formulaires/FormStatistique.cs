using GestionHotel.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// Numéro étudiant : 1724602
// Nom : Béatrice Duguay

namespace GestionHotel.Formulaires
{
    public partial class FormStatistique : Form
    {
        public FormStatistique()
        {
            InitializeComponent();
        }

        // Méthode AfficherLocations()
        /// <summary>
        /// Affiche la liste des locations dans la ListView
        /// </summary>
        /// <param name="location" l'objet Location instancié></param>
        // Code de Hasna Hocini (GestElection)
        public void AfficherLocations(Location location)
        {
            ListViewItem item;
            string[] list = new string[9];

            // Mettre les items dans un tableau
            list[0] = location.NumeroLocation;
            list[1] = location.DateDebutLocation.ToLongDateString().ToString();
            list[2] = location.DateFinLocation.ToLongDateString().ToString();
            list[3] = location.Duree.ToString();
            list[4] = location.NombreAdultes.ToString();
            list[5] = location.NombreEnfants.ToString();
            list[6] = location.EspaceLoue.NumeroEspace;
            list[7] = location.EspaceLoue.TypeEspace;
            list[8] = location.Client.NumeroClient;

            // Créer un objet ListViewItem 
            item = new ListViewItem(list);

            // Ajouter l'item ListViewItem à la ListView
            listViewLocations.Items.Add(item);
        }

        private void FormStatistique_Load(object sender, EventArgs e)
        {
            // Initialiser le Label du nombre de clients
            lblNbLocDateEspShow.Text = "";

            // Ajouter des valeurs au ComboBox
            cboTypeEspace.Items.Add("Tous");
            cboTypeEspace.Items.Add("Chambre");
            cboTypeEspace.Items.Add("Suite");

            // Modifier le format du DateTimePicker 
            dtDateLocation.Format = DateTimePickerFormat.Custom;
            dtDateLocation.CustomFormat = "dd MMMM yyyy";

            // Mettre les ComboBox au premier index
            cboTypeEspace.SelectedIndex = 0;

            // Appel de la fonction NombreLocations
            string nombreLocation = StatistiquesHotel.NombreLocations().ToString();
            lblNbLocationShow.Text = nombreLocation;
        }

        private void btnAfficherLocations_Click(object sender, EventArgs e)
        {
            // Effacer la ListView
            listViewLocations.Items.Clear();

            // Parcourir la liste des locations
            foreach (Location elt in StatistiquesHotel.ListeLocations)
            {
                // Si le type d'espace sélectionnée dans le ComboBox est la même valeur de l'attribut TypeEspace de l'objet Location
                // ET la date sélectionnée dans le DateTimePicker plus grande ou égale à la valeur de l'attribut DateDebutLocation de l'objet Location
                // ET la date sélectionnée dans le DateTimePicker plus petite ou égale à la valeur de l'attribut DateFinLocation de l'objet Location
                if (elt.EspaceLoue.TypeEspace == cboTypeEspace.Text & dtDateLocation.Value >= elt.DateDebutLocation & dtDateLocation.Value <= elt.DateFinLocation)
                {
                    // Appel de la méthode AfficherLocation
                    AfficherLocations(elt);
                    // Appel de la fonction LocationParDate et la transformer en string
                    string s = StatistiquesHotel.LocationEspaceDate(cboTypeEspace.Text, dtDateLocation).ToString();
                    // Afficher le nombre de locations
                    lblNbLocDateEspShow.Text = s;
                }

                // Si le type d'espace sélectionnée dans le ComboBox est "Tous"
                // ET la date sélectionnée dans le DateTimePicker plus grande ou égale à la valeur de l'attribut DateDebutLocation de l'objet Location
                // ET la date sélectionnée dans le DateTimePicker plus petite ou égale à la valeur de l'attribut DateFinLocation de l'objet Location
                else if (cboTypeEspace.Text == "Tous" & dtDateLocation.Value >= elt.DateDebutLocation & dtDateLocation.Value <= elt.DateFinLocation)
                {
                    // Appel de la méthode AfficherLocation
                    AfficherLocations(elt);
                    // Appel de la fonction LocationParDate et la transformer en string
                    string s = StatistiquesHotel.LocationEspaceDate(cboTypeEspace.Text, dtDateLocation).ToString();
                    // Afficher le nombre de locations
                    lblNbLocDateEspShow.Text = s;
                }
            }
            // Appel de la fonction LocationParDate et la transformer en string
            string str = StatistiquesHotel.LocationEspaceDate(cboTypeEspace.Text, dtDateLocation).ToString();
            // Afficher le nombre de locations
            lblNbLocDateEspShow.Text = str;
        }
    }
}
