
namespace ProjetBDD.Forms.ModificationPrix
{
    partial class modificationPrixDepenses
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
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.prixDepensesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prixDepensesAbonnementDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesAbonnementDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblErreur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(387, 118);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(205, 36);
            this.btnEnregistrer.TabIndex = 8;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // prixDepensesAbonnementBindingSource
            // 
            this.prixDepensesAbonnementBindingSource.DataSource = typeof(ProjetBDD.PrixDepensesAbonnement);
            // 
            // prixDepensesAbonnementDataGridView
            // 
            this.prixDepensesAbonnementDataGridView.AllowUserToAddRows = false;
            this.prixDepensesAbonnementDataGridView.AllowUserToDeleteRows = false;
            this.prixDepensesAbonnementDataGridView.AutoGenerateColumns = false;
            this.prixDepensesAbonnementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prixDepensesAbonnementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.prixDepensesAbonnementDataGridView.DataSource = this.prixDepensesAbonnementBindingSource;
            this.prixDepensesAbonnementDataGridView.Location = new System.Drawing.Point(292, 28);
            this.prixDepensesAbonnementDataGridView.MultiSelect = false;
            this.prixDepensesAbonnementDataGridView.Name = "prixDepensesAbonnementDataGridView";
            this.prixDepensesAbonnementDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prixDepensesAbonnementDataGridView.Size = new System.Drawing.Size(409, 51);
            this.prixDepensesAbonnementDataGridView.TabIndex = 9;
            this.prixDepensesAbonnementDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.prixDepensesAbonnementDataGridView_CellEndEdit);
            this.prixDepensesAbonnementDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.prixDepensesAbonnementDataGridView_CellValidating);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prix";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DepensesObligatoires";
            this.dataGridViewTextBoxColumn4.HeaderText = "DepensesObligatoires";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(ProjetBDD.TypesAbonnement);
            this.typesAbonnementBindingSource.CurrentChanged += new System.EventHandler(this.typesAbonnementBindingSource_CurrentChanged);
            // 
            // typesAbonnementDataGridView
            // 
            this.typesAbonnementDataGridView.AllowUserToAddRows = false;
            this.typesAbonnementDataGridView.AllowUserToDeleteRows = false;
            this.typesAbonnementDataGridView.AutoGenerateColumns = false;
            this.typesAbonnementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typesAbonnementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.typesAbonnementDataGridView.DataSource = this.typesAbonnementBindingSource;
            this.typesAbonnementDataGridView.Location = new System.Drawing.Point(12, 12);
            this.typesAbonnementDataGridView.MultiSelect = false;
            this.typesAbonnementDataGridView.Name = "typesAbonnementDataGridView";
            this.typesAbonnementDataGridView.ReadOnly = true;
            this.typesAbonnementDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.typesAbonnementDataGridView.Size = new System.Drawing.Size(240, 159);
            this.typesAbonnementDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.ForeColor = System.Drawing.Color.Red;
            this.lblErreur.Location = new System.Drawing.Point(289, 95);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(0, 13);
            this.lblErreur.TabIndex = 10;
            // 
            // modificationPrixDepenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 220);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.typesAbonnementDataGridView);
            this.Controls.Add(this.prixDepensesAbonnementDataGridView);
            this.Controls.Add(this.btnEnregistrer);
            this.Name = "modificationPrixDepenses";
            this.Text = "modificationPrixDepenses";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.modificationPrixDepenses_FormClosing);
            this.Load += new System.EventHandler(this.modificationPrixDepenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.BindingSource prixDepensesAbonnementBindingSource;
        private System.Windows.Forms.DataGridView prixDepensesAbonnementDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
        private System.Windows.Forms.DataGridView typesAbonnementDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lblErreur;
    }
}