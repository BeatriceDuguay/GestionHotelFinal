namespace GestionHotel.Formulaires
{
    partial class FormStatistique
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
            this.btnAfficherClients = new System.Windows.Forms.Button();
            this.lblNbClientsShow = new System.Windows.Forms.Label();
            this.lblNbClients = new System.Windows.Forms.Label();
            this.listViewLocations = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboTypeEspace = new System.Windows.Forms.ComboBox();
            this.lblTypeEspace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAfficherClients
            // 
            this.btnAfficherClients.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficherClients.Location = new System.Drawing.Point(250, 597);
            this.btnAfficherClients.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfficherClients.Name = "btnAfficherClients";
            this.btnAfficherClients.Size = new System.Drawing.Size(321, 28);
            this.btnAfficherClients.TabIndex = 35;
            this.btnAfficherClients.Text = "Afficher";
            this.btnAfficherClients.UseVisualStyleBackColor = true;
            // 
            // lblNbClientsShow
            // 
            this.lblNbClientsShow.AutoSize = true;
            this.lblNbClientsShow.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbClientsShow.Location = new System.Drawing.Point(244, 517);
            this.lblNbClientsShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbClientsShow.Name = "lblNbClientsShow";
            this.lblNbClientsShow.Size = new System.Drawing.Size(23, 25);
            this.lblNbClientsShow.TabIndex = 34;
            this.lblNbClientsShow.Text = "0";
            // 
            // lblNbClients
            // 
            this.lblNbClients.AutoSize = true;
            this.lblNbClients.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbClients.Location = new System.Drawing.Point(19, 517);
            this.lblNbClients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbClients.Name = "lblNbClients";
            this.lblNbClients.Size = new System.Drawing.Size(188, 25);
            this.lblNbClients.TabIndex = 33;
            this.lblNbClients.Text = "Nombre de clients : ";
            // 
            // listViewLocations
            // 
            this.listViewLocations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewLocations.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewLocations.FullRowSelect = true;
            this.listViewLocations.GridLines = true;
            this.listViewLocations.HideSelection = false;
            this.listViewLocations.Location = new System.Drawing.Point(24, 121);
            this.listViewLocations.Margin = new System.Windows.Forms.Padding(4);
            this.listViewLocations.Name = "listViewLocations";
            this.listViewLocations.Size = new System.Drawing.Size(757, 344);
            this.listViewLocations.TabIndex = 32;
            this.listViewLocations.UseCompatibleStateImageBehavior = false;
            this.listViewLocations.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numéro";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prénom";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nom";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date de naissance";
            this.columnHeader4.Width = 119;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "# téléphone";
            this.columnHeader5.Width = 103;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "# Espace";
            this.columnHeader6.Width = 84;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Type d\'espace";
            this.columnHeader7.Width = 130;
            // 
            // cboTypeEspace
            // 
            this.cboTypeEspace.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTypeEspace.FormattingEnabled = true;
            this.cboTypeEspace.Location = new System.Drawing.Point(208, 43);
            this.cboTypeEspace.Margin = new System.Windows.Forms.Padding(4);
            this.cboTypeEspace.Name = "cboTypeEspace";
            this.cboTypeEspace.Size = new System.Drawing.Size(320, 29);
            this.cboTypeEspace.TabIndex = 31;
            // 
            // lblTypeEspace
            // 
            this.lblTypeEspace.AutoSize = true;
            this.lblTypeEspace.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeEspace.Location = new System.Drawing.Point(19, 44);
            this.lblTypeEspace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeEspace.Name = "lblTypeEspace";
            this.lblTypeEspace.Size = new System.Drawing.Size(137, 25);
            this.lblTypeEspace.TabIndex = 30;
            this.lblTypeEspace.Text = "Type d\'espace";
            // 
            // FormStatistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 668);
            this.Controls.Add(this.btnAfficherClients);
            this.Controls.Add(this.lblNbClientsShow);
            this.Controls.Add(this.lblNbClients);
            this.Controls.Add(this.listViewLocations);
            this.Controls.Add(this.cboTypeEspace);
            this.Controls.Add(this.lblTypeEspace);
            this.Name = "FormStatistique";
            this.Text = "FormStatistique";
            this.Load += new System.EventHandler(this.FormStatistique_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfficherClients;
        private System.Windows.Forms.Label lblNbClientsShow;
        private System.Windows.Forms.Label lblNbClients;
        private System.Windows.Forms.ListView listViewLocations;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ComboBox cboTypeEspace;
        private System.Windows.Forms.Label lblTypeEspace;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}