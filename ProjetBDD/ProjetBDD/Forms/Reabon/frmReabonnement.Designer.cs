namespace ProjetBDD.Forms.Reabon
{
    partial class frmReabonnement
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
            this.abonDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.btnReabonner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.abonDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // abonDataGridView
            // 
            this.abonDataGridView.AllowUserToAddRows = false;
            this.abonDataGridView.AllowUserToDeleteRows = false;
            this.abonDataGridView.AutoGenerateColumns = false;
            this.abonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.abonDataGridView.DataSource = this.abonBindingSource;
            this.abonDataGridView.Location = new System.Drawing.Point(12, 12);
            this.abonDataGridView.MultiSelect = false;
            this.abonDataGridView.Name = "abonDataGridView";
            this.abonDataGridView.ReadOnly = true;
            this.abonDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.abonDataGridView.Size = new System.Drawing.Size(242, 220);
            this.abonDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomComplet";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomComplet";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // abonBindingSource
            // 
            this.abonBindingSource.DataSource = typeof(ProjetBDD.Abon);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Remarques:";
            // 
            // tbRemarque
            // 
            this.tbRemarque.Location = new System.Drawing.Point(358, 23);
            this.tbRemarque.MaxLength = 50;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(245, 20);
            this.tbRemarque.TabIndex = 3;
            // 
            // btnReabonner
            // 
            this.btnReabonner.Location = new System.Drawing.Point(358, 99);
            this.btnReabonner.Name = "btnReabonner";
            this.btnReabonner.Size = new System.Drawing.Size(169, 63);
            this.btnReabonner.TabIndex = 4;
            this.btnReabonner.Text = "Réabonner";
            this.btnReabonner.UseVisualStyleBackColor = true;
            // 
            // frmReabonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 251);
            this.Controls.Add(this.btnReabonner);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.abonDataGridView);
            this.Name = "frmReabonnement";
            this.Text = "frmReabonnement";
            this.Load += new System.EventHandler(this.frmReabonnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource abonBindingSource;
        private System.Windows.Forms.DataGridView abonDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.Button btnReabonner;
    }
}