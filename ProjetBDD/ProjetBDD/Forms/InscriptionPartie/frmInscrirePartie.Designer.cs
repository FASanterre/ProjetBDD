
namespace ProjetBDD.Forms.InscriptionPartie
{
    partial class frmInscrirePartie
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
            this.abonnementDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTerrain = new System.Windows.Forms.ComboBox();
            this.noEtNomTerrainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbPointage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnInscrire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomTerrainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // abonnementDataGridView
            // 
            this.abonnementDataGridView.AllowUserToAddRows = false;
            this.abonnementDataGridView.AllowUserToDeleteRows = false;
            this.abonnementDataGridView.AutoGenerateColumns = false;
            this.abonnementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abonnementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.abonnementDataGridView.DataSource = this.abonnementBindingSource;
            this.abonnementDataGridView.Location = new System.Drawing.Point(12, 12);
            this.abonnementDataGridView.MultiSelect = false;
            this.abonnementDataGridView.Name = "abonnementDataGridView";
            this.abonnementDataGridView.ReadOnly = true;
            this.abonnementDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.abonnementDataGridView.Size = new System.Drawing.Size(371, 176);
            this.abonnementDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn4.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // abonnementBindingSource
            // 
            this.abonnementBindingSource.DataSource = typeof(ProjetBDD.Abonnement);
            // 
            // cbTerrain
            // 
            this.cbTerrain.DataSource = this.noEtNomTerrainBindingSource;
            this.cbTerrain.DisplayMember = "Nom";
            this.cbTerrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTerrain.FormattingEnabled = true;
            this.cbTerrain.Location = new System.Drawing.Point(73, 202);
            this.cbTerrain.Name = "cbTerrain";
            this.cbTerrain.Size = new System.Drawing.Size(170, 21);
            this.cbTerrain.TabIndex = 2;
            this.cbTerrain.ValueMember = "Id";
            // 
            // noEtNomTerrainBindingSource
            // 
            this.noEtNomTerrainBindingSource.DataSource = typeof(ProjetBDD.NoEtNomTerrain);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Terrain :";
            // 
            // tbPointage
            // 
            this.tbPointage.Location = new System.Drawing.Point(73, 233);
            this.tbPointage.MaxLength = 50;
            this.tbPointage.Name = "tbPointage";
            this.tbPointage.Size = new System.Drawing.Size(170, 20);
            this.tbPointage.TabIndex = 4;
            this.tbPointage.Validating += new System.ComponentModel.CancelEventHandler(this.tbPointage_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pointage :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Remarque :";
            // 
            // tbRemarque
            // 
            this.tbRemarque.Location = new System.Drawing.Point(73, 265);
            this.tbRemarque.MaxLength = 50;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(170, 20);
            this.tbRemarque.TabIndex = 7;
            this.tbRemarque.Validating += new System.ComponentModel.CancelEventHandler(this.tbRemarque_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnInscrire
            // 
            this.btnInscrire.Location = new System.Drawing.Point(267, 213);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.Size = new System.Drawing.Size(116, 59);
            this.btnInscrire.TabIndex = 8;
            this.btnInscrire.Text = "Inscrire la partie";
            this.btnInscrire.UseVisualStyleBackColor = true;
            this.btnInscrire.Click += new System.EventHandler(this.btnInscrire_Click);
            // 
            // frmInscrirePartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 319);
            this.Controls.Add(this.btnInscrire);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPointage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTerrain);
            this.Controls.Add(this.abonnementDataGridView);
            this.Name = "frmInscrirePartie";
            this.Text = "Inscription d\'une partie de golf";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInscrirePartie_FormClosing);
            this.Load += new System.EventHandler(this.frmInscrirePartie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonnementDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomTerrainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource abonnementBindingSource;
        private System.Windows.Forms.DataGridView abonnementDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox cbTerrain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource noEtNomTerrainBindingSource;
        private System.Windows.Forms.TextBox tbPointage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnInscrire;
    }
}