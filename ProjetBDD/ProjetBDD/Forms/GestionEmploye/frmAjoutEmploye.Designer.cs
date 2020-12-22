
namespace ProjetBDD.Forms.GestionEmploye
{
    partial class frmAjoutEmploye
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
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbMDP = new System.Windows.Forms.TextBox();
            this.tbNumeroCivique = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.tbCourriel = new System.Windows.Forms.TextBox();
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
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.cbSexe = new System.Windows.Forms.ComboBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.nudSalaire = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbTypeEmploye = new System.Windows.Forms.ComboBox();
            this.noEtTypeEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.idEtNomProvinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.tbCellulaire = new System.Windows.Forms.MaskedTextBox();
            this.tbCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.btnAjouterEmp = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtTypeEmployeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idEtNomProvinceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(121, 48);
            this.tbNom.MaxLength = 50;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(159, 20);
            this.tbNom.TabIndex = 0;
            this.tbNom.Validating += new System.ComponentModel.CancelEventHandler(this.tbNom_Validating);
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(121, 74);
            this.tbPrenom.MaxLength = 50;
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(159, 20);
            this.tbPrenom.TabIndex = 1;
            this.tbPrenom.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenom_Validating);
            // 
            // tbMDP
            // 
            this.tbMDP.Location = new System.Drawing.Point(121, 100);
            this.tbMDP.MaxLength = 50;
            this.tbMDP.Name = "tbMDP";
            this.tbMDP.Size = new System.Drawing.Size(159, 20);
            this.tbMDP.TabIndex = 2;
            this.tbMDP.Validating += new System.ComponentModel.CancelEventHandler(this.tbMDP_Validating);
            // 
            // tbNumeroCivique
            // 
            this.tbNumeroCivique.Location = new System.Drawing.Point(121, 178);
            this.tbNumeroCivique.MaxLength = 50;
            this.tbNumeroCivique.Name = "tbNumeroCivique";
            this.tbNumeroCivique.Size = new System.Drawing.Size(159, 20);
            this.tbNumeroCivique.TabIndex = 5;
            this.tbNumeroCivique.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumeroCivique_Validating);
            // 
            // tbVille
            // 
            this.tbVille.Location = new System.Drawing.Point(121, 230);
            this.tbVille.MaxLength = 50;
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(159, 20);
            this.tbVille.TabIndex = 6;
            this.tbVille.Validating += new System.ComponentModel.CancelEventHandler(this.tbVille_Validating);
            // 
            // tbRue
            // 
            this.tbRue.Location = new System.Drawing.Point(121, 204);
            this.tbRue.MaxLength = 50;
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(159, 20);
            this.tbRue.TabIndex = 7;
            this.tbRue.Validating += new System.ComponentModel.CancelEventHandler(this.tbRue_Validating);
            // 
            // tbCourriel
            // 
            this.tbCourriel.Location = new System.Drawing.Point(121, 358);
            this.tbCourriel.MaxLength = 50;
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.Size = new System.Drawing.Size(159, 20);
            this.tbCourriel.TabIndex = 12;
            this.tbCourriel.Validating += new System.ComponentModel.CancelEventHandler(this.tbCourriel_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mot de passe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sexe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Age :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "NoCivique";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Rue :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ville :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Province :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Code postal :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Telephone :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 332);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Cellulaire :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 358);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Courriel :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 384);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Salaire horaire :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 410);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Type d\'employé :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 436);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Remarque :";
            // 
            // tbRemarque
            // 
            this.tbRemarque.Location = new System.Drawing.Point(121, 436);
            this.tbRemarque.MaxLength = 50;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(159, 20);
            this.tbRemarque.TabIndex = 30;
            // 
            // cbSexe
            // 
            this.cbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexe.FormattingEnabled = true;
            this.cbSexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.cbSexe.Location = new System.Drawing.Point(121, 126);
            this.cbSexe.Name = "cbSexe";
            this.cbSexe.Size = new System.Drawing.Size(159, 21);
            this.cbSexe.TabIndex = 32;
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(121, 152);
            this.nudAge.Maximum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.nudAge.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(54, 20);
            this.nudAge.TabIndex = 33;
            this.nudAge.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // nudSalaire
            // 
            this.nudSalaire.DecimalPlaces = 2;
            this.nudSalaire.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudSalaire.Location = new System.Drawing.Point(121, 382);
            this.nudSalaire.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudSalaire.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSalaire.Name = "nudSalaire";
            this.nudSalaire.Size = new System.Drawing.Size(54, 20);
            this.nudSalaire.TabIndex = 34;
            this.nudSalaire.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(181, 156);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "ans";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(181, 384);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "$/h";
            // 
            // cbTypeEmploye
            // 
            this.cbTypeEmploye.DataSource = this.noEtTypeEmployeBindingSource;
            this.cbTypeEmploye.DisplayMember = "Description";
            this.cbTypeEmploye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeEmploye.FormattingEnabled = true;
            this.cbTypeEmploye.Location = new System.Drawing.Point(121, 407);
            this.cbTypeEmploye.Name = "cbTypeEmploye";
            this.cbTypeEmploye.Size = new System.Drawing.Size(159, 21);
            this.cbTypeEmploye.TabIndex = 37;
            this.cbTypeEmploye.ValueMember = "NoType";
            // 
            // noEtTypeEmployeBindingSource
            // 
            this.noEtTypeEmployeBindingSource.DataSource = typeof(ProjetBDD.NoEtTypeEmploye);
            // 
            // cbProvince
            // 
            this.cbProvince.DataSource = this.idEtNomProvinceBindingSource;
            this.cbProvince.DisplayMember = "nom";
            this.cbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(121, 254);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(159, 21);
            this.cbProvince.TabIndex = 38;
            this.cbProvince.ValueMember = "id";
            // 
            // idEtNomProvinceBindingSource
            // 
            this.idEtNomProvinceBindingSource.DataSource = typeof(ProjetBDD.IdEtNomProvince);
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(121, 306);
            this.tbTelephone.Mask = "(000)000-0000";
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(159, 20);
            this.tbTelephone.TabIndex = 39;
            this.tbTelephone.Validating += new System.ComponentModel.CancelEventHandler(this.tbTelephone_Validating);
            // 
            // tbCellulaire
            // 
            this.tbCellulaire.Location = new System.Drawing.Point(121, 332);
            this.tbCellulaire.Mask = "(000)000-0000";
            this.tbCellulaire.Name = "tbCellulaire";
            this.tbCellulaire.Size = new System.Drawing.Size(159, 20);
            this.tbCellulaire.TabIndex = 40;
            this.tbCellulaire.Validating += new System.ComponentModel.CancelEventHandler(this.tbCellulaire_Validating);
            // 
            // tbCodePostal
            // 
            this.tbCodePostal.Location = new System.Drawing.Point(121, 281);
            this.tbCodePostal.Mask = "L0L 0L0";
            this.tbCodePostal.Name = "tbCodePostal";
            this.tbCodePostal.Size = new System.Drawing.Size(159, 20);
            this.tbCodePostal.TabIndex = 41;
            this.tbCodePostal.Validating += new System.ComponentModel.CancelEventHandler(this.tbCodePostal_Validating);
            // 
            // btnAjouterEmp
            // 
            this.btnAjouterEmp.Location = new System.Drawing.Point(28, 468);
            this.btnAjouterEmp.Name = "btnAjouterEmp";
            this.btnAjouterEmp.Size = new System.Drawing.Size(252, 23);
            this.btnAjouterEmp.TabIndex = 42;
            this.btnAjouterEmp.Text = "Ajouter l\'employé";
            this.btnAjouterEmp.UseVisualStyleBackColor = true;
            this.btnAjouterEmp.Click += new System.EventHandler(this.btnAjouterEmp_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(56, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(194, 25);
            this.label19.TabIndex = 43;
            this.label19.Text = "Ajout d\'un employé";
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // frmAjoutEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 505);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnAjouterEmp);
            this.Controls.Add(this.tbCodePostal);
            this.Controls.Add(this.tbCellulaire);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.cbProvince);
            this.Controls.Add(this.cbTypeEmploye);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.nudSalaire);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.cbSexe);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.label15);
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
            this.Controls.Add(this.tbCourriel);
            this.Controls.Add(this.tbRue);
            this.Controls.Add(this.tbVille);
            this.Controls.Add(this.tbNumeroCivique);
            this.Controls.Add(this.tbMDP);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Name = "frmAjoutEmploye";
            this.Text = "Ajout d\'un employé";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAjoutEmploye_FormClosing);
            this.Load += new System.EventHandler(this.frmAjoutEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtTypeEmployeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idEtNomProvinceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbMDP;
        private System.Windows.Forms.TextBox tbNumeroCivique;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.TextBox tbCourriel;
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.ComboBox cbSexe;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.NumericUpDown nudSalaire;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbTypeEmploye;
        private System.Windows.Forms.BindingSource noEtTypeEmployeBindingSource;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.BindingSource idEtNomProvinceBindingSource;
        private System.Windows.Forms.MaskedTextBox tbTelephone;
        private System.Windows.Forms.MaskedTextBox tbCellulaire;
        private System.Windows.Forms.MaskedTextBox tbCodePostal;
        private System.Windows.Forms.Button btnAjouterEmp;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}