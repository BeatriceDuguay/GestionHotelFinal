namespace GestionHotel
{
    partial class FormParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererLocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chambreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererChambresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lblErreurMdp = new System.Windows.Forms.Label();
            this.txtNumEmploye = new System.Windows.Forms.TextBox();
            this.lblNumEmploye = new System.Windows.Forms.Label();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.lblErreurNumEmploye = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.locationToolStripMenuItem,
            this.chambreToolStripMenuItem,
            this.statistiquesToolStripMenuItem,
            this.afficherToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.afficherToolStripMenuItem;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(900, 30);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(93, 26);
            this.connexionToolStripMenuItem.Text = "Connexion";
            this.connexionToolStripMenuItem.Click += new System.EventHandler(this.connexionToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererClientsToolStripMenuItem});
            this.clientToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // gererClientsToolStripMenuItem
            // 
            this.gererClientsToolStripMenuItem.Name = "gererClientsToolStripMenuItem";
            this.gererClientsToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.gererClientsToolStripMenuItem.Text = "Gérer clients";
            this.gererClientsToolStripMenuItem.Click += new System.EventHandler(this.gererClientsToolStripMenuItem_Click);
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererLocToolStripMenuItem});
            this.locationToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(82, 26);
            this.locationToolStripMenuItem.Text = "Location";
            // 
            // gererLocToolStripMenuItem
            // 
            this.gererLocToolStripMenuItem.Name = "gererLocToolStripMenuItem";
            this.gererLocToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.gererLocToolStripMenuItem.Text = "Gérer locations";
            this.gererLocToolStripMenuItem.Click += new System.EventHandler(this.gererLocToolStripMenuItem_Click);
            // 
            // chambreToolStripMenuItem
            // 
            this.chambreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererChambresToolStripMenuItem});
            this.chambreToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.chambreToolStripMenuItem.Name = "chambreToolStripMenuItem";
            this.chambreToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.chambreToolStripMenuItem.Text = "Chambre";
            this.chambreToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // gererChambresToolStripMenuItem
            // 
            this.gererChambresToolStripMenuItem.Name = "gererChambresToolStripMenuItem";
            this.gererChambresToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.gererChambresToolStripMenuItem.Text = "Gérer chambres";
            this.gererChambresToolStripMenuItem.Click += new System.EventHandler(this.gererChambresToolStripMenuItem_Click);
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(105, 26);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            this.statistiquesToolStripMenuItem.Click += new System.EventHandler(this.statistiquesToolStripMenuItem_Click);
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.afficherToolStripMenuItem.Text = "Afficher";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(69, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // btnConnexion
            // 
            this.btnConnexion.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.Location = new System.Drawing.Point(346, 369);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(208, 28);
            this.btnConnexion.TabIndex = 69;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lblErreurMdp
            // 
            this.lblErreurMdp.AutoSize = true;
            this.lblErreurMdp.BackColor = System.Drawing.Color.Transparent;
            this.lblErreurMdp.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreurMdp.Location = new System.Drawing.Point(382, 274);
            this.lblErreurMdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErreurMdp.Name = "lblErreurMdp";
            this.lblErreurMdp.Size = new System.Drawing.Size(0, 19);
            this.lblErreurMdp.TabIndex = 67;
            // 
            // txtNumEmploye
            // 
            this.txtNumEmploye.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumEmploye.Location = new System.Drawing.Point(386, 166);
            this.txtNumEmploye.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumEmploye.Name = "txtNumEmploye";
            this.txtNumEmploye.Size = new System.Drawing.Size(320, 34);
            this.txtNumEmploye.TabIndex = 66;
            // 
            // lblNumEmploye
            // 
            this.lblNumEmploye.AutoSize = true;
            this.lblNumEmploye.BackColor = System.Drawing.Color.Transparent;
            this.lblNumEmploye.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEmploye.Location = new System.Drawing.Point(195, 166);
            this.lblNumEmploye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumEmploye.Name = "lblNumEmploye";
            this.lblNumEmploye.Size = new System.Drawing.Size(103, 25);
            this.lblNumEmploye.TabIndex = 65;
            this.lblNumEmploye.Text = "# Employé";
            // 
            // txtMdp
            // 
            this.txtMdp.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMdp.Location = new System.Drawing.Point(386, 236);
            this.txtMdp.Margin = new System.Windows.Forms.Padding(4);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(320, 34);
            this.txtMdp.TabIndex = 64;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.BackColor = System.Drawing.Color.Transparent;
            this.lblMdp.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.Location = new System.Drawing.Point(195, 236);
            this.lblMdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(132, 25);
            this.lblMdp.TabIndex = 63;
            this.lblMdp.Text = "Mot de passe";
            // 
            // lblErreurNumEmploye
            // 
            this.lblErreurNumEmploye.AutoSize = true;
            this.lblErreurNumEmploye.BackColor = System.Drawing.Color.Transparent;
            this.lblErreurNumEmploye.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreurNumEmploye.Location = new System.Drawing.Point(382, 204);
            this.lblErreurNumEmploye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErreurNumEmploye.Name = "lblErreurNumEmploye";
            this.lblErreurNumEmploye.Size = new System.Drawing.Size(0, 19);
            this.lblErreurNumEmploye.TabIndex = 68;
            // 
            // FormParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.lblErreurNumEmploye);
            this.Controls.Add(this.lblErreurMdp);
            this.Controls.Add(this.txtNumEmploye);
            this.Controls.Add(this.lblNumEmploye);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.lblMdp);
            this.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormParent";
            this.Text = "Gestion de l\'hôtel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MdiChildActivate += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gererClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererLocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererChambresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem chambreToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblErreurMdp;
        private System.Windows.Forms.TextBox txtNumEmploye;
        private System.Windows.Forms.Label lblNumEmploye;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblErreurNumEmploye;
    }
}

