
namespace ProjetBDD
{
    partial class frmMenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miGestionEmploye = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbonnement = new System.Windows.Forms.ToolStripMenuItem();
            this.miReabonnement = new System.Windows.Forms.ToolStripMenuItem();
            this.miMAJAbonnes = new System.Windows.Forms.ToolStripMenuItem();
            this.miModifPrixDepenses = new System.Windows.Forms.ToolStripMenuItem();
            this.miInscriptionPartie = new System.Windows.Forms.ToolStripMenuItem();
            this.miInscriptionDepense = new System.Windows.Forms.ToolStripMenuItem();
            this.miVisualisation = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miGestionEmploye,
            this.miAbonnement,
            this.miReabonnement,
            this.miMAJAbonnes,
            this.miModifPrixDepenses,
            this.miInscriptionPartie,
            this.miInscriptionDepense,
            this.miVisualisation});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1139, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miGestionEmploye
            // 
            this.miGestionEmploye.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutToolStripMenuItem,
            this.modificationToolStripMenuItem,
            this.suppressionToolStripMenuItem});
            this.miGestionEmploye.Name = "miGestionEmploye";
            this.miGestionEmploye.Size = new System.Drawing.Size(134, 20);
            this.miGestionEmploye.Text = "Gestion des employés";
            // 
            // ajoutToolStripMenuItem
            // 
            this.ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            this.ajoutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.ajoutToolStripMenuItem.Click += new System.EventHandler(this.ajoutToolStripMenuItem_Click);
            this.ajoutToolStripMenuItem.Text = "Ajout";
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.modificationToolStripMenuItem.Click += new System.EventHandler(this.modificationToolStripMenuItem_Click);
            this.modificationToolStripMenuItem.Text = "Modification";
            // 
            // suppressionToolStripMenuItem
            // 
            this.suppressionToolStripMenuItem.Name = "suppressionToolStripMenuItem";
            this.suppressionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.suppressionToolStripMenuItem.Text = "Suppression";
            this.suppressionToolStripMenuItem.Click += new System.EventHandler(this.suppressionToolStripMenuItem_Click);
            // 
            // miAbonnement
            // 
            this.miAbonnement.Name = "miAbonnement";
            this.miAbonnement.Size = new System.Drawing.Size(89, 20);
            this.miAbonnement.Text = "Abonnement";
            this.miAbonnement.Click += new System.EventHandler(this.miAbonnement_Click);
            // 
            // miReabonnement
            // 
            this.miReabonnement.Name = "miReabonnement";
            this.miReabonnement.Size = new System.Drawing.Size(100, 20);
            this.miReabonnement.Text = "Réabonnement";
            // 
            // miMAJAbonnes
            // 
            this.miMAJAbonnes.Name = "miMAJAbonnes";
            this.miMAJAbonnes.Size = new System.Drawing.Size(146, 20);
            this.miMAJAbonnes.Text = "Mise à jour des abonnés";
            // 
            // miModifPrixDepenses
            // 
            this.miModifPrixDepenses.Name = "miModifPrixDepenses";
            this.miModifPrixDepenses.Size = new System.Drawing.Size(164, 20);
            this.miModifPrixDepenses.Text = "Modification prix/dépenses";
            this.miModifPrixDepenses.Click += new System.EventHandler(this.miModifPrixDepenses_Click);
            // 
            // miInscriptionPartie
            // 
            this.miInscriptionPartie.Name = "miInscriptionPartie";
            this.miInscriptionPartie.Size = new System.Drawing.Size(148, 20);
            this.miInscriptionPartie.Text = "Inscription partie de golf";
            // 
            // miInscriptionDepense
            // 
            this.miInscriptionDepense.Name = "miInscriptionDepense";
            this.miInscriptionDepense.Size = new System.Drawing.Size(122, 20);
            this.miInscriptionDepense.Text = "Inscription dépense";
            // 
            // miVisualisation
            // 
            this.miVisualisation.Name = "miVisualisation";
            this.miVisualisation.Size = new System.Drawing.Size(217, 20);
            this.miVisualisation.Text = "Visualisation des rapports/statistiques";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(12, 104);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(120, 32);
            this.btnDeconnexion.TabIndex = 1;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(154, 104);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(128, 32);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 148);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miGestionEmploye;
        private System.Windows.Forms.ToolStripMenuItem miAbonnement;
        private System.Windows.Forms.ToolStripMenuItem miReabonnement;
        private System.Windows.Forms.ToolStripMenuItem miMAJAbonnes;
        private System.Windows.Forms.ToolStripMenuItem miModifPrixDepenses;
        private System.Windows.Forms.ToolStripMenuItem miInscriptionPartie;
        private System.Windows.Forms.ToolStripMenuItem miInscriptionDepense;
        private System.Windows.Forms.ToolStripMenuItem miVisualisation;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionToolStripMenuItem;
    }
}