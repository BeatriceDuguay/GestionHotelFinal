namespace GestionHotel.Formulaires
{
    partial class FormEspace
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
            this.lblErreurNumEspace = new System.Windows.Forms.Label();
            this.txtNumEspace = new System.Windows.Forms.TextBox();
            this.lblNumEspace = new System.Windows.Forms.Label();
            this.lblNombreLits = new System.Windows.Forms.Label();
            this.numericNbLits = new System.Windows.Forms.NumericUpDown();
            this.cboTypeEspace = new System.Windows.Forms.ComboBox();
            this.lblTypeEspace = new System.Windows.Forms.Label();
            this.lblErreurNbLits = new System.Windows.Forms.Label();
            this.lblErreurType = new System.Windows.Forms.Label();
            this.btnSupprimerEspace = new System.Windows.Forms.Button();
            this.btnModifierEspace = new System.Windows.Forms.Button();
            this.btnAjouterEspace = new System.Windows.Forms.Button();
            this.radioBtnOui = new System.Windows.Forms.RadioButton();
            this.radioBtnNon = new System.Windows.Forms.RadioButton();
            this.lblMiniBar = new System.Windows.Forms.Label();
            this.lblNbChambres = new System.Windows.Forms.Label();
            this.numericNbChambres = new System.Windows.Forms.NumericUpDown();
            this.lblErreurNbChambres = new System.Windows.Forms.Label();
            this.lblErreurMiniBar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericNbLits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNbChambres)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErreurNumEspace
            // 
            this.lblErreurNumEspace.AutoSize = true;
            this.lblErreurNumEspace.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreurNumEspace.Location = new System.Drawing.Point(332, 108);
            this.lblErreurNumEspace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErreurNumEspace.Name = "lblErreurNumEspace";
            this.lblErreurNumEspace.Size = new System.Drawing.Size(0, 19);
            this.lblErreurNumEspace.TabIndex = 35;
            // 
            // txtNumEspace
            // 
            this.txtNumEspace.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumEspace.Location = new System.Drawing.Point(336, 69);
            this.txtNumEspace.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumEspace.Name = "txtNumEspace";
            this.txtNumEspace.Size = new System.Drawing.Size(320, 34);
            this.txtNumEspace.TabIndex = 34;
            // 
            // lblNumEspace
            // 
            this.lblNumEspace.AutoSize = true;
            this.lblNumEspace.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEspace.Location = new System.Drawing.Point(145, 69);
            this.lblNumEspace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumEspace.Name = "lblNumEspace";
            this.lblNumEspace.Size = new System.Drawing.Size(93, 25);
            this.lblNumEspace.TabIndex = 33;
            this.lblNumEspace.Text = "# Espace";
            // 
            // lblNombreLits
            // 
            this.lblNombreLits.AutoSize = true;
            this.lblNombreLits.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLits.Location = new System.Drawing.Point(145, 151);
            this.lblNombreLits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreLits.Name = "lblNombreLits";
            this.lblNombreLits.Size = new System.Drawing.Size(141, 25);
            this.lblNombreLits.TabIndex = 36;
            this.lblNombreLits.Text = "Nombre de lits";
            // 
            // numericNbLits
            // 
            this.numericNbLits.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericNbLits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericNbLits.Location = new System.Drawing.Point(336, 144);
            this.numericNbLits.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericNbLits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNbLits.Name = "numericNbLits";
            this.numericNbLits.ReadOnly = true;
            this.numericNbLits.Size = new System.Drawing.Size(176, 32);
            this.numericNbLits.TabIndex = 37;
            this.numericNbLits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboTypeEspace
            // 
            this.cboTypeEspace.AutoCompleteCustomSource.AddRange(new string[] {
            "Chambre",
            "Suite"});
            this.cboTypeEspace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeEspace.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTypeEspace.FormattingEnabled = true;
            this.cboTypeEspace.Items.AddRange(new object[] {
            "Chambre",
            "Suite"});
            this.cboTypeEspace.Location = new System.Drawing.Point(336, 213);
            this.cboTypeEspace.Margin = new System.Windows.Forms.Padding(4);
            this.cboTypeEspace.Name = "cboTypeEspace";
            this.cboTypeEspace.Size = new System.Drawing.Size(320, 29);
            this.cboTypeEspace.TabIndex = 40;
            this.cboTypeEspace.DropDownClosed += new System.EventHandler(this.cboTypeEspace_DropDownClosed);
            // 
            // lblTypeEspace
            // 
            this.lblTypeEspace.AutoSize = true;
            this.lblTypeEspace.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeEspace.Location = new System.Drawing.Point(145, 213);
            this.lblTypeEspace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeEspace.Name = "lblTypeEspace";
            this.lblTypeEspace.Size = new System.Drawing.Size(122, 25);
            this.lblTypeEspace.TabIndex = 41;
            this.lblTypeEspace.Text = "Type espace";
            // 
            // lblErreurNbLits
            // 
            this.lblErreurNbLits.AutoSize = true;
            this.lblErreurNbLits.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreurNbLits.Location = new System.Drawing.Point(332, 182);
            this.lblErreurNbLits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErreurNbLits.Name = "lblErreurNbLits";
            this.lblErreurNbLits.Size = new System.Drawing.Size(0, 19);
            this.lblErreurNbLits.TabIndex = 42;
            // 
            // lblErreurType
            // 
            this.lblErreurType.AutoSize = true;
            this.lblErreurType.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreurType.Location = new System.Drawing.Point(332, 246);
            this.lblErreurType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErreurType.Name = "lblErreurType";
            this.lblErreurType.Size = new System.Drawing.Size(0, 19);
            this.lblErreurType.TabIndex = 44;
            // 
            // btnSupprimerEspace
            // 
            this.btnSupprimerEspace.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerEspace.Location = new System.Drawing.Point(543, 371);
            this.btnSupprimerEspace.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimerEspace.Name = "btnSupprimerEspace";
            this.btnSupprimerEspace.Size = new System.Drawing.Size(208, 28);
            this.btnSupprimerEspace.TabIndex = 47;
            this.btnSupprimerEspace.Text = "Supprimer";
            this.btnSupprimerEspace.UseVisualStyleBackColor = true;
            this.btnSupprimerEspace.Click += new System.EventHandler(this.btnSupprimerEspace_Click);
            // 
            // btnModifierEspace
            // 
            this.btnModifierEspace.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierEspace.Location = new System.Drawing.Point(295, 371);
            this.btnModifierEspace.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierEspace.Name = "btnModifierEspace";
            this.btnModifierEspace.Size = new System.Drawing.Size(208, 28);
            this.btnModifierEspace.TabIndex = 46;
            this.btnModifierEspace.Text = "Modifier";
            this.btnModifierEspace.UseVisualStyleBackColor = true;
            this.btnModifierEspace.Click += new System.EventHandler(this.btnModifierEspace_Click);
            // 
            // btnAjouterEspace
            // 
            this.btnAjouterEspace.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterEspace.Location = new System.Drawing.Point(50, 371);
            this.btnAjouterEspace.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterEspace.Name = "btnAjouterEspace";
            this.btnAjouterEspace.Size = new System.Drawing.Size(208, 28);
            this.btnAjouterEspace.TabIndex = 45;
            this.btnAjouterEspace.Text = "Ajouter";
            this.btnAjouterEspace.UseVisualStyleBackColor = true;
            this.btnAjouterEspace.Click += new System.EventHandler(this.btnAjouterEspace_Click);
            // 
            // radioBtnOui
            // 
            this.radioBtnOui.AutoSize = true;
            this.radioBtnOui.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnOui.Location = new System.Drawing.Point(336, 288);
            this.radioBtnOui.Name = "radioBtnOui";
            this.radioBtnOui.Size = new System.Drawing.Size(50, 21);
            this.radioBtnOui.TabIndex = 48;
            this.radioBtnOui.TabStop = true;
            this.radioBtnOui.Text = "Oui";
            this.radioBtnOui.UseVisualStyleBackColor = true;
            // 
            // radioBtnNon
            // 
            this.radioBtnNon.AutoSize = true;
            this.radioBtnNon.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnNon.Location = new System.Drawing.Point(458, 288);
            this.radioBtnNon.Name = "radioBtnNon";
            this.radioBtnNon.Size = new System.Drawing.Size(54, 21);
            this.radioBtnNon.TabIndex = 49;
            this.radioBtnNon.TabStop = true;
            this.radioBtnNon.Text = "Non";
            this.radioBtnNon.UseVisualStyleBackColor = true;
            // 
            // lblMiniBar
            // 
            this.lblMiniBar.AutoSize = true;
            this.lblMiniBar.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiniBar.Location = new System.Drawing.Point(145, 288);
            this.lblMiniBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiniBar.Name = "lblMiniBar";
            this.lblMiniBar.Size = new System.Drawing.Size(84, 25);
            this.lblMiniBar.TabIndex = 50;
            this.lblMiniBar.Text = "Mini bar";
            // 
            // lblNbChambres
            // 
            this.lblNbChambres.AutoSize = true;
            this.lblNbChambres.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbChambres.Location = new System.Drawing.Point(145, 288);
            this.lblNbChambres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbChambres.Name = "lblNbChambres";
            this.lblNbChambres.Size = new System.Drawing.Size(174, 25);
            this.lblNbChambres.TabIndex = 51;
            this.lblNbChambres.Text = "Nombre chambres";
            // 
            // numericNbChambres
            // 
            this.numericNbChambres.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericNbChambres.Location = new System.Drawing.Point(336, 281);
            this.numericNbChambres.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericNbChambres.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNbChambres.Name = "numericNbChambres";
            this.numericNbChambres.ReadOnly = true;
            this.numericNbChambres.Size = new System.Drawing.Size(176, 32);
            this.numericNbChambres.TabIndex = 52;
            this.numericNbChambres.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblErreurNbChambres
            // 
            this.lblErreurNbChambres.AutoSize = true;
            this.lblErreurNbChambres.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreurNbChambres.Location = new System.Drawing.Point(332, 316);
            this.lblErreurNbChambres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErreurNbChambres.Name = "lblErreurNbChambres";
            this.lblErreurNbChambres.Size = new System.Drawing.Size(0, 19);
            this.lblErreurNbChambres.TabIndex = 53;
            // 
            // lblErreurMiniBar
            // 
            this.lblErreurMiniBar.AutoSize = true;
            this.lblErreurMiniBar.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreurMiniBar.Location = new System.Drawing.Point(332, 316);
            this.lblErreurMiniBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErreurMiniBar.Name = "lblErreurMiniBar";
            this.lblErreurMiniBar.Size = new System.Drawing.Size(0, 19);
            this.lblErreurMiniBar.TabIndex = 54;
            // 
            // FormEspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.lblErreurMiniBar);
            this.Controls.Add(this.lblErreurNbChambres);
            this.Controls.Add(this.numericNbChambres);
            this.Controls.Add(this.lblNbChambres);
            this.Controls.Add(this.lblMiniBar);
            this.Controls.Add(this.radioBtnNon);
            this.Controls.Add(this.radioBtnOui);
            this.Controls.Add(this.btnSupprimerEspace);
            this.Controls.Add(this.btnModifierEspace);
            this.Controls.Add(this.btnAjouterEspace);
            this.Controls.Add(this.lblErreurType);
            this.Controls.Add(this.lblErreurNbLits);
            this.Controls.Add(this.lblTypeEspace);
            this.Controls.Add(this.cboTypeEspace);
            this.Controls.Add(this.numericNbLits);
            this.Controls.Add(this.lblNombreLits);
            this.Controls.Add(this.lblErreurNumEspace);
            this.Controls.Add(this.txtNumEspace);
            this.Controls.Add(this.lblNumEspace);
            this.Name = "FormEspace";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Espace";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericNbLits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNbChambres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErreurNumEspace;
        private System.Windows.Forms.TextBox txtNumEspace;
        private System.Windows.Forms.Label lblNumEspace;
        private System.Windows.Forms.Label lblNombreLits;
        private System.Windows.Forms.NumericUpDown numericNbLits;
        private System.Windows.Forms.ComboBox cboTypeEspace;
        private System.Windows.Forms.Label lblTypeEspace;
        private System.Windows.Forms.Label lblErreurNbLits;
        private System.Windows.Forms.Label lblErreurType;
        private System.Windows.Forms.Button btnSupprimerEspace;
        private System.Windows.Forms.Button btnModifierEspace;
        private System.Windows.Forms.Button btnAjouterEspace;
        private System.Windows.Forms.RadioButton radioBtnOui;
        private System.Windows.Forms.RadioButton radioBtnNon;
        private System.Windows.Forms.Label lblMiniBar;
        private System.Windows.Forms.Label lblNbChambres;
        private System.Windows.Forms.NumericUpDown numericNbChambres;
        private System.Windows.Forms.Label lblErreurNbChambres;
        private System.Windows.Forms.Label lblErreurMiniBar;
    }
}