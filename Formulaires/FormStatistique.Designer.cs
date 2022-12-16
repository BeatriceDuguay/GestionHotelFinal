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
            this.btnAfficherLocations = new System.Windows.Forms.Button();
            this.lblNbClientsEspaceShow = new System.Windows.Forms.Label();
            this.lblNbClientsEspace = new System.Windows.Forms.Label();
            this.listViewLocations = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboTypeEspace = new System.Windows.Forms.ComboBox();
            this.lblTypeEspace = new System.Windows.Forms.Label();
            this.lblNbClientsLocationShow = new System.Windows.Forms.Label();
            this.lblNbClientsLocation = new System.Windows.Forms.Label();
            this.lblDateLocation = new System.Windows.Forms.Label();
            this.dtDateLocation = new System.Windows.Forms.DateTimePicker();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAfficherLocations
            // 
            this.btnAfficherLocations.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficherLocations.Location = new System.Drawing.Point(250, 597);
            this.btnAfficherLocations.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfficherLocations.Name = "btnAfficherLocations";
            this.btnAfficherLocations.Size = new System.Drawing.Size(321, 28);
            this.btnAfficherLocations.TabIndex = 35;
            this.btnAfficherLocations.Text = "Afficher";
            this.btnAfficherLocations.UseVisualStyleBackColor = true;
            this.btnAfficherLocations.Click += new System.EventHandler(this.btnAfficherLocations_Click);
            // 
            // lblNbClientsEspaceShow
            // 
            this.lblNbClientsEspaceShow.AutoSize = true;
            this.lblNbClientsEspaceShow.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbClientsEspaceShow.Location = new System.Drawing.Point(312, 517);
            this.lblNbClientsEspaceShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbClientsEspaceShow.Name = "lblNbClientsEspaceShow";
            this.lblNbClientsEspaceShow.Size = new System.Drawing.Size(23, 25);
            this.lblNbClientsEspaceShow.TabIndex = 34;
            this.lblNbClientsEspaceShow.Text = "0";
            // 
            // lblNbClientsEspace
            // 
            this.lblNbClientsEspace.AutoSize = true;
            this.lblNbClientsEspace.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbClientsEspace.Location = new System.Drawing.Point(19, 517);
            this.lblNbClientsEspace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbClientsEspace.Name = "lblNbClientsEspace";
            this.lblNbClientsEspace.Size = new System.Drawing.Size(291, 25);
            this.lblNbClientsEspace.TabIndex = 33;
            this.lblNbClientsEspace.Text = "Nombre de clients par espace : ";
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
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewLocations.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewLocations.FullRowSelect = true;
            this.listViewLocations.GridLines = true;
            this.listViewLocations.HideSelection = false;
            this.listViewLocations.Location = new System.Drawing.Point(24, 143);
            this.listViewLocations.Margin = new System.Windows.Forms.Padding(4);
            this.listViewLocations.Name = "listViewLocations";
            this.listViewLocations.Size = new System.Drawing.Size(757, 344);
            this.listViewLocations.TabIndex = 32;
            this.listViewLocations.UseCompatibleStateImageBehavior = false;
            this.listViewLocations.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "# Location";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date début";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date fin";
            this.columnHeader3.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Duree";
            this.columnHeader4.Width = 52;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nombre adultes";
            this.columnHeader5.Width = 103;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nombre enfants";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 6;
            this.columnHeader9.Text = "# Client";
            this.columnHeader9.Width = 73;
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
            // lblNbClientsLocationShow
            // 
            this.lblNbClientsLocationShow.AutoSize = true;
            this.lblNbClientsLocationShow.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbClientsLocationShow.Location = new System.Drawing.Point(334, 551);
            this.lblNbClientsLocationShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbClientsLocationShow.Name = "lblNbClientsLocationShow";
            this.lblNbClientsLocationShow.Size = new System.Drawing.Size(23, 25);
            this.lblNbClientsLocationShow.TabIndex = 37;
            this.lblNbClientsLocationShow.Text = "0";
            // 
            // lblNbClientsLocation
            // 
            this.lblNbClientsLocation.AutoSize = true;
            this.lblNbClientsLocation.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbClientsLocation.Location = new System.Drawing.Point(19, 551);
            this.lblNbClientsLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbClientsLocation.Name = "lblNbClientsLocation";
            this.lblNbClientsLocation.Size = new System.Drawing.Size(315, 25);
            this.lblNbClientsLocation.TabIndex = 36;
            this.lblNbClientsLocation.Text = "Nombre de clients avec location :  ";
            // 
            // lblDateLocation
            // 
            this.lblDateLocation.AutoSize = true;
            this.lblDateLocation.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateLocation.Location = new System.Drawing.Point(19, 93);
            this.lblDateLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateLocation.Name = "lblDateLocation";
            this.lblDateLocation.Size = new System.Drawing.Size(60, 25);
            this.lblDateLocation.TabIndex = 38;
            this.lblDateLocation.Text = "Date ";
            // 
            // dtDateLocation
            // 
            this.dtDateLocation.CalendarFont = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateLocation.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateLocation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateLocation.Location = new System.Drawing.Point(208, 87);
            this.dtDateLocation.Margin = new System.Windows.Forms.Padding(4);
            this.dtDateLocation.Name = "dtDateLocation";
            this.dtDateLocation.Size = new System.Drawing.Size(320, 34);
            this.dtDateLocation.TabIndex = 47;
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 7;
            this.columnHeader7.Text = "# Espace";
            this.columnHeader7.Width = 75;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 8;
            this.columnHeader8.Text = "Type espace";
            this.columnHeader8.Width = 121;
            // 
            // FormStatistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 668);
            this.Controls.Add(this.dtDateLocation);
            this.Controls.Add(this.lblDateLocation);
            this.Controls.Add(this.lblNbClientsLocationShow);
            this.Controls.Add(this.lblNbClientsLocation);
            this.Controls.Add(this.btnAfficherLocations);
            this.Controls.Add(this.lblNbClientsEspaceShow);
            this.Controls.Add(this.lblNbClientsEspace);
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

        private System.Windows.Forms.Button btnAfficherLocations;
        private System.Windows.Forms.Label lblNbClientsEspaceShow;
        private System.Windows.Forms.Label lblNbClientsEspace;
        private System.Windows.Forms.ListView listViewLocations;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ComboBox cboTypeEspace;
        private System.Windows.Forms.Label lblTypeEspace;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label lblNbClientsLocationShow;
        private System.Windows.Forms.Label lblNbClientsLocation;
        private System.Windows.Forms.Label lblDateLocation;
        private System.Windows.Forms.DateTimePicker dtDateLocation;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}