
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
            this.descriptionEtTypeAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionEtTypeAbonnementDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionEtTypeAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionEtTypeAbonnementDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionEtTypeAbonnementBindingSource
            // 
            this.descriptionEtTypeAbonnementBindingSource.DataSource = typeof(ProjetBDD.DescriptionEtTypeAbonnement);
            // 
            // descriptionEtTypeAbonnementDataGridView
            // 
            this.descriptionEtTypeAbonnementDataGridView.AutoGenerateColumns = false;
            this.descriptionEtTypeAbonnementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.descriptionEtTypeAbonnementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.descriptionEtTypeAbonnementDataGridView.DataSource = this.descriptionEtTypeAbonnementBindingSource;
            this.descriptionEtTypeAbonnementDataGridView.Location = new System.Drawing.Point(12, 12);
            this.descriptionEtTypeAbonnementDataGridView.Name = "descriptionEtTypeAbonnementDataGridView";
            this.descriptionEtTypeAbonnementDataGridView.Size = new System.Drawing.Size(414, 155);
            this.descriptionEtTypeAbonnementDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Prix";
            this.dataGridViewTextBoxColumn2.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Depenses";
            this.dataGridViewTextBoxColumn3.HeaderText = "Depenses";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // modificationPrixDepenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.descriptionEtTypeAbonnementDataGridView);
            this.Name = "modificationPrixDepenses";
            this.Text = "modificationPrixDepenses";
            this.Load += new System.EventHandler(this.modificationPrixDepenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.descriptionEtTypeAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionEtTypeAbonnementDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource descriptionEtTypeAbonnementBindingSource;
        private System.Windows.Forms.DataGridView descriptionEtTypeAbonnementDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}