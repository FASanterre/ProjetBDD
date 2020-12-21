
namespace ProjetBDD.Forms.InscriptionDepenses
{
    partial class frmInscrireDepenses
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.nudMontant = new System.Windows.Forms.NumericUpDown();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.cbTypeService = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.abonnementDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontant)).BeginInit();
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
            this.abonnementDataGridView.Size = new System.Drawing.Size(399, 228);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Montant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Remarque :";
            // 
            // tbRemarque
            // 
            this.tbRemarque.Location = new System.Drawing.Point(80, 296);
            this.tbRemarque.MaxLength = 50;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(331, 20);
            this.tbRemarque.TabIndex = 4;
            // 
            // nudMontant
            // 
            this.nudMontant.DecimalPlaces = 2;
            this.nudMontant.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudMontant.Location = new System.Drawing.Point(80, 262);
            this.nudMontant.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMontant.Name = "nudMontant";
            this.nudMontant.Size = new System.Drawing.Size(120, 20);
            this.nudMontant.TabIndex = 5;
            this.nudMontant.Validating += new System.ComponentModel.CancelEventHandler(this.nudMontant_Validating);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(91, 332);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(239, 39);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter la dépense";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(206, 264);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(89, 13);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Type de service :";
            // 
            // cbTypeService
            // 
            this.cbTypeService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeService.FormattingEnabled = true;
            this.cbTypeService.Items.AddRange(new object[] {
            "Magasin Pro Shop",
            "Restaurant",
            "Leçon de golf"});
            this.cbTypeService.Location = new System.Drawing.Point(294, 261);
            this.cbTypeService.Name = "cbTypeService";
            this.cbTypeService.Size = new System.Drawing.Size(117, 21);
            this.cbTypeService.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmInscrireDepenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 383);
            this.Controls.Add(this.cbTypeService);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.nudMontant);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.abonnementDataGridView);
            this.Name = "frmInscrireDepenses";
            this.Text = "frmInscrireDepenses";
            this.Load += new System.EventHandler(this.frmInscrireDepenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonnementDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontant)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.NumericUpDown nudMontant;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbTypeService;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}