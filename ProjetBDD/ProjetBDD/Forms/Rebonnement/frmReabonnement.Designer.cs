
namespace ProjetBDD.Forms.Rebonnement
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
            this.abonnementDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRenouveler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource)).BeginInit();
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
            this.abonnementDataGridView.Location = new System.Drawing.Point(25, 64);
            this.abonnementDataGridView.MultiSelect = false;
            this.abonnementDataGridView.Name = "abonnementDataGridView";
            this.abonnementDataGridView.ReadOnly = true;
            this.abonnementDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.abonnementDataGridView.Size = new System.Drawing.Size(436, 220);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Abonnements pouvant être renouvelé";
            // 
            // tbRemarque
            // 
            this.tbRemarque.Location = new System.Drawing.Point(99, 300);
            this.tbRemarque.MaxLength = 50;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(362, 20);
            this.tbRemarque.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Remarque :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnRenouveler
            // 
            this.btnRenouveler.Location = new System.Drawing.Point(325, 326);
            this.btnRenouveler.Name = "btnRenouveler";
            this.btnRenouveler.Size = new System.Drawing.Size(136, 34);
            this.btnRenouveler.TabIndex = 5;
            this.btnRenouveler.Text = "Renouveler";
            this.btnRenouveler.UseVisualStyleBackColor = true;
            this.btnRenouveler.Click += new System.EventHandler(this.btnRenouveler_Click);
            // 
            // frmReabonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 382);
            this.Controls.Add(this.btnRenouveler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.abonnementDataGridView);
            this.Name = "frmReabonnement";
            this.Text = "frmReabonnement";
            this.Load += new System.EventHandler(this.frmReabonnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonnementDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnRenouveler;
    }
}