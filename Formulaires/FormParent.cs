using GestionHotel.Classes;
using GestionHotel.Formulaires;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            clientToolStripMenuItem.Enabled = false;
            locationToolStripMenuItem.Enabled = false;
            chambreToolStripMenuItem.Enabled = false;
            statistiquesToolStripMenuItem.Enabled = false;  

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
            f.WindowState = FormWindowState.Normal; // Mettre la taille du formulaire enfant FormClient à normal
            f.Show();
        }

        // Code de Hasna Hocini (GestElection)
        private void gererLocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLocation f = new FormLocation(); // Création d'une instance du formulaire enfant FormLocation
            f.MdiParent = this;
            f.WindowState = FormWindowState.Normal; // Mettre la taille du formulaire enfant FormLocation à normal
            f.Show();
        }

        // Code de Hasna Hocini (GestElection)
        private void gererChambresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEspace f = new FormEspace(); // Création d'une instance du formulaire enfant FormChambre
            f.MdiParent = this;
            f.WindowState = FormWindowState.Normal; // Mettre la taille du formulaire enfant FormChambre à normal
            f.Show();
        }

        // Code de Hasna Hocini (GestElection)
        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatistique f = new FormStatistique(); // Création d'une instance du formulaire enfant FormStatistique
            f.MdiParent = this;
            f.WindowState = FormWindowState.Normal; // Mettre la taille du formulaire enfant FormStatistique à normal
            f.Show();
        }

        private void afficherToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Fermer le formulaire parent FormParent
            this.Close();
        }

        private void FormParent_Activated(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            lblErreurNumEmploye.Text = "";
            lblErreurMdp.Text = "";
            foreach (Employe elt in ListeEmployes)
            {
                if (elt.NumeroEmploye == txtNumEmploye.Text & elt.MotDePasse == txtMdp.Text)
                {
                    if (elt.TypeEmploye == "Réceptionniste")
                    {
                        clientToolStripMenuItem.Enabled = true;
                        locationToolStripMenuItem.Enabled = true;
                        chambreToolStripMenuItem.Enabled = true;
                        statistiquesToolStripMenuItem.Enabled = false;
                        break;
                    }

                    else if (elt.TypeEmploye == "Gérant")
                    {
                        clientToolStripMenuItem.Enabled = true;
                        locationToolStripMenuItem.Enabled = true;
                        chambreToolStripMenuItem.Enabled = true;
                        statistiquesToolStripMenuItem.Enabled = true;
                        break;
                    }
                }
                else
                {
                    lblErreurMdp.ForeColor = Color.Red; lblErreurMdp.Text = " Numéro d'employé ou mot de passe invalide. ";
                }
            }

            MessageBox.Show("Connexion réussie.", "Message");
        }
    }
}
