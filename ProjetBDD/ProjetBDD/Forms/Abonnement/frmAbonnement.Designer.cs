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
            this.label15 = new System.Windows.Forms.Label();
            this.gbAjoutAbonnement = new System.Windows.Forms.GroupBox();
            this.gbDependants = new System.Windows.Forms.GroupBox();
            this.btnAjouterDep = new System.Windows.Forms.Button();
            this.lblDependantNb = new System.Windows.Forms.Label();
            this.tbRemarqueDep = new System.Windows.Forms.TextBox();
            this.tbNomDep = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbPrenomDep = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpDateNaissanceDep = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.cbSexeDep = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbEnfants)).BeginInit();
            this.gbAjoutAbonnement.SuspendLayout();
            this.gbDependants.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date de naissance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numéro civique:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rue:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ville:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Province:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Code Postal:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Téléphone:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cellulaire:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(72, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Courriel";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(71, 357);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Type d\'abonnement:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(72, 410);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Remarque:";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(186, 40);
            this.tbNom.MaxLength = 50;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(121, 20);
            this.tbNom.TabIndex = 14;
            this.tbNom.Validating += new System.ComponentModel.CancelEventHandler(this.tbNom_Validating);
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(186, 66);
            this.tbPrenom.MaxLength = 50;
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(121, 20);
            this.tbPrenom.TabIndex = 15;
            this.tbPrenom.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenom_Validating);
            // 
            // tbNoCivique
            // 
            this.tbNoCivique.Location = new System.Drawing.Point(186, 145);
            this.tbNoCivique.MaxLength = 50;
            this.tbNoCivique.Name = "tbNoCivique";
            this.tbNoCivique.Size = new System.Drawing.Size(121, 20);
            this.tbNoCivique.TabIndex = 16;
            this.tbNoCivique.Validating += new System.ComponentModel.CancelEventHandler(this.tbNoCivique_Validating);
            // 
            // tbRue
            // 
            this.tbRue.Location = new System.Drawing.Point(186, 171);
            this.tbRue.MaxLength = 50;
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(121, 20);
            this.tbRue.TabIndex = 17;
            this.tbRue.Validating += new System.ComponentModel.CancelEventHandler(this.tbRue_Validating);
            // 
            // tbVille
            // 
            this.tbVille.Location = new System.Drawing.Point(186, 197);
            this.tbVille.MaxLength = 50;
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(121, 20);
            this.tbVille.TabIndex = 18;
            this.tbVille.Validating += new System.ComponentModel.CancelEventHandler(this.tbVille_Validating);
            // 
            // tbCourriel
            // 
            this.tbCourriel.Location = new System.Drawing.Point(186, 328);
            this.tbCourriel.MaxLength = 50;
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.Size = new System.Drawing.Size(121, 20);
            this.tbCourriel.TabIndex = 22;
            this.tbCourriel.Validating += new System.ComponentModel.CancelEventHandler(this.tbCourriel_Validating);
            // 
            // cbSexe
            // 
            this.cbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexe.FormattingEnabled = true;
            this.cbSexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.cbSexe.Location = new System.Drawing.Point(186, 92);
            this.cbSexe.Name = "cbSexe";
            this.cbSexe.Size = new System.Drawing.Size(121, 21);
            this.cbSexe.TabIndex = 23;
            this.cbSexe.Validating += new System.ComponentModel.CancelEventHandler(this.cbSexe_Validating);
            // 
            // cbTypeAbonnement
            // 
            this.cbTypeAbonnement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeAbonnement.FormattingEnabled = true;
            this.cbTypeAbonnement.Location = new System.Drawing.Point(186, 354);
            this.cbTypeAbonnement.Name = "cbTypeAbonnement";
            this.cbTypeAbonnement.Size = new System.Drawing.Size(121, 21);
            this.cbTypeAbonnement.TabIndex = 24;
            this.cbTypeAbonnement.SelectedIndexChanged += new System.EventHandler(this.cbTypeAbonnement_SelectedIndexChanged);
            this.cbTypeAbonnement.Validating += new System.ComponentModel.CancelEventHandler(this.cbTypeAbonnement_Validating);
            // 
            // cbProvince
            // 
            this.cbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(186, 223);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(121, 21);
            this.cbProvince.TabIndex = 25;
            this.cbProvince.Validating += new System.ComponentModel.CancelEventHandler(this.cbProvince_Validating);
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.Location = new System.Drawing.Point(186, 119);
            this.dtpDateNaissance.MaxDate = new System.DateTime(2002, 12, 17, 0, 0, 0, 0);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(121, 20);
            this.dtpDateNaissance.TabIndex = 27;
            this.dtpDateNaissance.Value = new System.DateTime(2002, 12, 17, 0, 0, 0, 0);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // tbCodePostal
            // 
            this.tbCodePostal.Location = new System.Drawing.Point(186, 250);
            this.tbCodePostal.Mask = "L0L 0L0";
            this.tbCodePostal.Name = "tbCodePostal";
            this.tbCodePostal.Size = new System.Drawing.Size(121, 20);
            this.tbCodePostal.TabIndex = 28;
            this.tbCodePostal.Validating += new System.ComponentModel.CancelEventHandler(this.tbCodePostal_Validating);
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(186, 276);
            this.tbTelephone.Mask = "(000)000-0000";
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(121, 20);
            this.tbTelephone.TabIndex = 29;
            this.tbTelephone.Validating += new System.ComponentModel.CancelEventHandler(this.tbTelephone_Validating);
            // 
            // tbCell
            // 
            this.tbCell.Location = new System.Drawing.Point(186, 302);
            this.tbCell.Mask = "(000)000-0000";
            this.tbCell.Name = "tbCell";
            this.tbCell.Size = new System.Drawing.Size(121, 20);
            this.tbCell.TabIndex = 30;
            this.tbCell.Validating += new System.ComponentModel.CancelEventHandler(this.tbCell_Validating);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(99, 449);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(172, 26);
            this.btnAjouter.TabIndex = 31;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // tbRemarque
            // 
            this.tbRemarque.Location = new System.Drawing.Point(186, 407);
            this.tbRemarque.MaxLength = 50;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(121, 20);
            this.tbRemarque.TabIndex = 32;
            // 
            // lblNbEnfants
            // 
            this.lblNbEnfants.AutoSize = true;
            this.lblNbEnfants.Location = new System.Drawing.Point(71, 383);
            this.lblNbEnfants.Name = "lblNbEnfants";
            this.lblNbEnfants.Size = new System.Drawing.Size(85, 13);
            this.lblNbEnfants.TabIndex = 33;
            this.lblNbEnfants.Text = "Nombre enfants:";
            this.lblNbEnfants.Visible = false;
            // 
            // nudNbEnfants
            // 
            this.nudNbEnfants.Location = new System.Drawing.Point(186, 381);
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(70, 1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(232, 25);
            this.label15.TabIndex = 35;
            this.label15.Text = "Ajout d\'un abonnement";
            // 
            // gbAjoutAbonnement
            // 
            this.gbAjoutAbonnement.Controls.Add(this.btnAjouter);
            this.gbAjoutAbonnement.Controls.Add(this.label15);
            this.gbAjoutAbonnement.Controls.Add(this.label1);
            this.gbAjoutAbonnement.Controls.Add(this.nudNbEnfants);
            this.gbAjoutAbonnement.Controls.Add(this.label2);
            this.gbAjoutAbonnement.Controls.Add(this.lblNbEnfants);
            this.gbAjoutAbonnement.Controls.Add(this.label3);
            this.gbAjoutAbonnement.Controls.Add(this.tbRemarque);
            this.gbAjoutAbonnement.Controls.Add(this.label4);
            this.gbAjoutAbonnement.Controls.Add(this.label5);
            this.gbAjoutAbonnement.Controls.Add(this.tbCell);
            this.gbAjoutAbonnement.Controls.Add(this.label6);
            this.gbAjoutAbonnement.Controls.Add(this.tbNom);
            this.gbAjoutAbonnement.Controls.Add(this.tbTelephone);
            this.gbAjoutAbonnement.Controls.Add(this.label7);
            this.gbAjoutAbonnement.Controls.Add(this.tbCodePostal);
            this.gbAjoutAbonnement.Controls.Add(this.label8);
            this.gbAjoutAbonnement.Controls.Add(this.dtpDateNaissance);
            this.gbAjoutAbonnement.Controls.Add(this.label9);
            this.gbAjoutAbonnement.Controls.Add(this.cbProvince);
            this.gbAjoutAbonnement.Controls.Add(this.label10);
            this.gbAjoutAbonnement.Controls.Add(this.cbTypeAbonnement);
            this.gbAjoutAbonnement.Controls.Add(this.label11);
            this.gbAjoutAbonnement.Controls.Add(this.cbSexe);
            this.gbAjoutAbonnement.Controls.Add(this.label12);
            this.gbAjoutAbonnement.Controls.Add(this.tbCourriel);
            this.gbAjoutAbonnement.Controls.Add(this.label13);
            this.gbAjoutAbonnement.Controls.Add(this.tbVille);
            this.gbAjoutAbonnement.Controls.Add(this.label14);
            this.gbAjoutAbonnement.Controls.Add(this.tbRue);
            this.gbAjoutAbonnement.Controls.Add(this.tbNoCivique);
            this.gbAjoutAbonnement.Controls.Add(this.tbPrenom);
            this.gbAjoutAbonnement.Location = new System.Drawing.Point(20, 12);
            this.gbAjoutAbonnement.Name = "gbAjoutAbonnement";
            this.gbAjoutAbonnement.Size = new System.Drawing.Size(368, 497);
            this.gbAjoutAbonnement.TabIndex = 36;
            this.gbAjoutAbonnement.TabStop = false;
            // 
            // gbDependants
            // 
            this.gbDependants.Controls.Add(this.btnAjouterDep);
            this.gbDependants.Controls.Add(this.lblDependantNb);
            this.gbDependants.Controls.Add(this.tbRemarqueDep);
            this.gbDependants.Controls.Add(this.tbNomDep);
            this.gbDependants.Controls.Add(this.label16);
            this.gbDependants.Controls.Add(this.label20);
            this.gbDependants.Controls.Add(this.label19);
            this.gbDependants.Controls.Add(this.tbPrenomDep);
            this.gbDependants.Controls.Add(this.label18);
            this.gbDependants.Controls.Add(this.dtpDateNaissanceDep);
            this.gbDependants.Controls.Add(this.label17);
            this.gbDependants.Controls.Add(this.cbSexeDep);
            this.gbDependants.Enabled = false;
            this.gbDependants.Location = new System.Drawing.Point(6, 12);
            this.gbDependants.Name = "gbDependants";
            this.gbDependants.Size = new System.Drawing.Size(368, 238);
            this.gbDependants.TabIndex = 37;
            this.gbDependants.TabStop = false;
            this.gbDependants.Visible = false;
            // 
            // btnAjouterDep
            // 
            this.btnAjouterDep.Location = new System.Drawing.Point(114, 186);
            this.btnAjouterDep.Name = "btnAjouterDep";
            this.btnAjouterDep.Size = new System.Drawing.Size(110, 26);
            this.btnAjouterDep.TabIndex = 50;
            this.btnAjouterDep.Text = "Ajouter";
            this.btnAjouterDep.UseVisualStyleBackColor = true;
            this.btnAjouterDep.Click += new System.EventHandler(this.btnAjouterDep_Click);
            // 
            // lblDependantNb
            // 
            this.lblDependantNb.AutoSize = true;
            this.lblDependantNb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDependantNb.Location = new System.Drawing.Point(78, 0);
            this.lblDependantNb.Name = "lblDependantNb";
            this.lblDependantNb.Size = new System.Drawing.Size(194, 25);
            this.lblDependantNb.TabIndex = 49;
            this.lblDependantNb.Text = "Ajout dépendant(s)";
            // 
            // tbRemarqueDep
            // 
            this.tbRemarqueDep.Location = new System.Drawing.Point(151, 147);
            this.tbRemarqueDep.Name = "tbRemarqueDep";
            this.tbRemarqueDep.Size = new System.Drawing.Size(121, 20);
            this.tbRemarqueDep.TabIndex = 48;
            // 
            // tbNomDep
            // 
            this.tbNomDep.Location = new System.Drawing.Point(151, 42);
            this.tbNomDep.Name = "tbNomDep";
            this.tbNomDep.Size = new System.Drawing.Size(121, 20);
            this.tbNomDep.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(49, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 47;
            this.label16.Text = "Remarques:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(47, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 13);
            this.label20.TabIndex = 38;
            this.label20.Text = "Nom:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(49, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Sexe:";
            // 
            // tbPrenomDep
            // 
            this.tbPrenomDep.Location = new System.Drawing.Point(151, 68);
            this.tbPrenomDep.Name = "tbPrenomDep";
            this.tbPrenomDep.Size = new System.Drawing.Size(121, 20);
            this.tbPrenomDep.TabIndex = 45;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(47, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "Prénom:";
            // 
            // dtpDateNaissanceDep
            // 
            this.dtpDateNaissanceDep.Location = new System.Drawing.Point(151, 121);
            this.dtpDateNaissanceDep.Name = "dtpDateNaissanceDep";
            this.dtpDateNaissanceDep.Size = new System.Drawing.Size(121, 20);
            this.dtpDateNaissanceDep.TabIndex = 44;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(49, 124);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "Date de naissance:";
            // 
            // cbSexeDep
            // 
            this.cbSexeDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexeDep.FormattingEnabled = true;
            this.cbSexeDep.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.cbSexeDep.Location = new System.Drawing.Point(151, 94);
            this.cbSexeDep.Name = "cbSexeDep";
            this.cbSexeDep.Size = new System.Drawing.Size(121, 21);
            this.cbSexeDep.TabIndex = 43;
            // 
            // frmAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 522);
            this.Controls.Add(this.gbDependants);
            this.Controls.Add(this.gbAjoutAbonnement);
            this.Name = "frmAbonnement";
            this.Text = "Abonnement";
            this.Load += new System.EventHandler(this.frmAbonnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbEnfants)).EndInit();
            this.gbAjoutAbonnement.ResumeLayout(false);
            this.gbAjoutAbonnement.PerformLayout();
            this.gbDependants.ResumeLayout(false);
            this.gbDependants.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gbDependants;
        private System.Windows.Forms.GroupBox gbAjoutAbonnement;
        private System.Windows.Forms.TextBox tbRemarqueDep;
        private System.Windows.Forms.TextBox tbNomDep;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbPrenomDep;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpDateNaissanceDep;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbSexeDep;
        private System.Windows.Forms.Label lblDependantNb;
        private System.Windows.Forms.Button btnAjouterDep;
    }
}