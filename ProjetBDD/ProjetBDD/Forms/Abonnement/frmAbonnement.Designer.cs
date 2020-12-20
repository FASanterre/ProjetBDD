namespace ProjetBDD.Forms
{
    partial class frmAbonnement
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNoCivique = new System.Windows.Forms.TextBox();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbCourriel = new System.Windows.Forms.TextBox();
            this.cbSexe = new System.Windows.Forms.ComboBox();
            this.cbTypeAbonnement = new System.Windows.Forms.ComboBox();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.tbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.tbCell = new System.Windows.Forms.MaskedTextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.lblNbEnfants = new System.Windows.Forms.Label();
            this.nudNbEnfants = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbEnfants)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date de naissance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numéro civique:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rue:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ville:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Province:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Code Postal:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(303, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Téléphone:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cellulaire:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(303, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Courriel";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 388);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Type d\'abonnement:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(303, 388);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Remarque:";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(144, 6);
            this.tbNom.MaxLength = 50;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(121, 20);
            this.tbNom.TabIndex = 14;
            this.tbNom.Validating += new System.ComponentModel.CancelEventHandler(this.tbNom_Validating);
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(404, 6);
            this.tbPrenom.MaxLength = 50;
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(121, 20);
            this.tbPrenom.TabIndex = 15;
            this.tbPrenom.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenom_Validating);
            // 
            // tbNoCivique
            // 
            this.tbNoCivique.Location = new System.Drawing.Point(144, 121);
            this.tbNoCivique.MaxLength = 50;
            this.tbNoCivique.Name = "tbNoCivique";
            this.tbNoCivique.Size = new System.Drawing.Size(121, 20);
            this.tbNoCivique.TabIndex = 16;
            this.tbNoCivique.Validating += new System.ComponentModel.CancelEventHandler(this.tbNoCivique_Validating);
            // 
            // tbRue
            // 
            this.tbRue.Location = new System.Drawing.Point(404, 121);
            this.tbRue.MaxLength = 50;
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(121, 20);
            this.tbRue.TabIndex = 17;
            this.tbRue.Validating += new System.ComponentModel.CancelEventHandler(this.tbRue_Validating);
            // 
            // tbVille
            // 
            this.tbVille.Location = new System.Drawing.Point(144, 184);
            this.tbVille.MaxLength = 50;
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(121, 20);
            this.tbVille.TabIndex = 18;
            this.tbVille.Validating += new System.ComponentModel.CancelEventHandler(this.tbVille_Validating);
            // 
            // tbCourriel
            // 
            this.tbCourriel.Location = new System.Drawing.Point(404, 315);
            this.tbCourriel.MaxLength = 50;
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.Size = new System.Drawing.Size(121, 20);
            this.tbCourriel.TabIndex = 22;
            this.tbCourriel.Validating += new System.ComponentModel.CancelEventHandler(this.tbCourriel_Validating);
            // 
            // cbSexe
            // 
            this.cbSexe.FormattingEnabled = true;
            this.cbSexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.cbSexe.Location = new System.Drawing.Point(144, 63);
            this.cbSexe.Name = "cbSexe";
            this.cbSexe.Size = new System.Drawing.Size(121, 21);
            this.cbSexe.TabIndex = 23;
            this.cbSexe.Validating += new System.ComponentModel.CancelEventHandler(this.cbSexe_Validating);
            // 
            // cbTypeAbonnement
            // 
            this.cbTypeAbonnement.FormattingEnabled = true;
            this.cbTypeAbonnement.Location = new System.Drawing.Point(144, 385);
            this.cbTypeAbonnement.Name = "cbTypeAbonnement";
            this.cbTypeAbonnement.Size = new System.Drawing.Size(121, 21);
            this.cbTypeAbonnement.TabIndex = 24;
            this.cbTypeAbonnement.SelectedIndexChanged += new System.EventHandler(this.cbTypeAbonnement_SelectedIndexChanged);
            this.cbTypeAbonnement.Validating += new System.ComponentModel.CancelEventHandler(this.cbTypeAbonnement_Validating);
            // 
            // cbProvince
            // 
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(404, 184);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(121, 21);
            this.cbProvince.TabIndex = 25;
            this.cbProvince.Validating += new System.ComponentModel.CancelEventHandler(this.cbProvince_Validating);
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.Location = new System.Drawing.Point(404, 63);
            this.dtpDateNaissance.MaxDate = new System.DateTime(2002, 12, 17, 0, 0, 0, 0);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(200, 20);
            this.dtpDateNaissance.TabIndex = 27;
            this.dtpDateNaissance.Value = new System.DateTime(2002, 12, 17, 0, 0, 0, 0);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // tbCodePostal
            // 
            this.tbCodePostal.Location = new System.Drawing.Point(144, 243);
            this.tbCodePostal.Mask = "L0L 0L0";
            this.tbCodePostal.Name = "tbCodePostal";
            this.tbCodePostal.Size = new System.Drawing.Size(121, 20);
            this.tbCodePostal.TabIndex = 28;
            this.tbCodePostal.Validating += new System.ComponentModel.CancelEventHandler(this.tbCodePostal_Validating);
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(404, 243);
            this.tbTelephone.Mask = "(000)000-0000";
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(121, 20);
            this.tbTelephone.TabIndex = 29;
            this.tbTelephone.Validating += new System.ComponentModel.CancelEventHandler(this.tbTelephone_Validating);
            // 
            // tbCell
            // 
            this.tbCell.Location = new System.Drawing.Point(144, 315);
            this.tbCell.Mask = "(000)000-0000";
            this.tbCell.Name = "tbCell";
            this.tbCell.Size = new System.Drawing.Size(121, 20);
            this.tbCell.TabIndex = 30;
            this.tbCell.Validating += new System.ComponentModel.CancelEventHandler(this.tbCell_Validating);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(628, 205);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(111, 43);
            this.btnAjouter.TabIndex = 31;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // tbRemarque
            // 
            this.tbRemarque.Location = new System.Drawing.Point(404, 385);
            this.tbRemarque.MaxLength = 50;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(335, 20);
            this.tbRemarque.TabIndex = 32;
            // 
            // lblNbEnfants
            // 
            this.lblNbEnfants.AutoSize = true;
            this.lblNbEnfants.Location = new System.Drawing.Point(15, 427);
            this.lblNbEnfants.Name = "lblNbEnfants";
            this.lblNbEnfants.Size = new System.Drawing.Size(85, 13);
            this.lblNbEnfants.TabIndex = 33;
            this.lblNbEnfants.Text = "Nombre enfants:";
            this.lblNbEnfants.Visible = false;
            // 
            // nudNbEnfants
            // 
            this.nudNbEnfants.Location = new System.Drawing.Point(144, 425);
            this.nudNbEnfants.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudNbEnfants.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudNbEnfants.Name = "nudNbEnfants";
            this.nudNbEnfants.Size = new System.Drawing.Size(121, 20);
            this.nudNbEnfants.TabIndex = 34;
            this.nudNbEnfants.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudNbEnfants.Visible = false;
            // 
            // frmAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 473);
            this.Controls.Add(this.nudNbEnfants);
            this.Controls.Add(this.lblNbEnfants);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.tbCell);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.tbCodePostal);
            this.Controls.Add(this.dtpDateNaissance);
            this.Controls.Add(this.cbProvince);
            this.Controls.Add(this.cbTypeAbonnement);
            this.Controls.Add(this.cbSexe);
            this.Controls.Add(this.tbCourriel);
            this.Controls.Add(this.tbVille);
            this.Controls.Add(this.tbRue);
            this.Controls.Add(this.tbNoCivique);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAbonnement";
            this.Text = "Abonnement";
            this.Load += new System.EventHandler(this.frmAbonnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbEnfants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNoCivique;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.TextBox tbCourriel;
        private System.Windows.Forms.ComboBox cbSexe;
        private System.Windows.Forms.ComboBox cbTypeAbonnement;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.MaskedTextBox tbCell;
        private System.Windows.Forms.MaskedTextBox tbTelephone;
        private System.Windows.Forms.MaskedTextBox tbCodePostal;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.NumericUpDown nudNbEnfants;
        private System.Windows.Forms.Label lblNbEnfants;
    }
}