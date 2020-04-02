namespace ClientAjoutPrestationWCF
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNomDemande = new System.Windows.Forms.Label();
            this.lbTypeDemande = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNomDemande = new System.Windows.Forms.TextBox();
            this.tbTypeDemande = new System.Windows.Forms.TextBox();
            this.bt_Inscrire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNomDemande
            // 
            this.lbNomDemande.AutoSize = true;
            this.lbNomDemande.Location = new System.Drawing.Point(82, 130);
            this.lbNomDemande.Name = "lbNomDemande";
            this.lbNomDemande.Size = new System.Drawing.Size(135, 17);
            this.lbNomDemande.TabIndex = 0;
            this.lbNomDemande.Text = "Nom de la demande";
            // 
            // lbTypeDemande
            // 
            this.lbTypeDemande.AutoSize = true;
            this.lbTypeDemande.Location = new System.Drawing.Point(82, 178);
            this.lbTypeDemande.Name = "lbTypeDemande";
            this.lbTypeDemande.Size = new System.Drawing.Size(138, 17);
            this.lbTypeDemande.TabIndex = 1;
            this.lbTypeDemande.Text = "Type de la demande";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(650, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "lnscrire une emande de protestation de service";
            // 
            // tbNomDemande
            // 
            this.tbNomDemande.Location = new System.Drawing.Point(235, 127);
            this.tbNomDemande.Name = "tbNomDemande";
            this.tbNomDemande.Size = new System.Drawing.Size(280, 22);
            this.tbNomDemande.TabIndex = 3;
            // 
            // tbTypeDemande
            // 
            this.tbTypeDemande.Location = new System.Drawing.Point(235, 178);
            this.tbTypeDemande.Name = "tbTypeDemande";
            this.tbTypeDemande.Size = new System.Drawing.Size(280, 22);
            this.tbTypeDemande.TabIndex = 4;
            this.tbTypeDemande.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bt_Inscrire
            // 
            this.bt_Inscrire.Location = new System.Drawing.Point(418, 230);
            this.bt_Inscrire.Name = "bt_Inscrire";
            this.bt_Inscrire.Size = new System.Drawing.Size(97, 23);
            this.bt_Inscrire.TabIndex = 5;
            this.bt_Inscrire.Text = "Inscrire";
            this.bt_Inscrire.UseVisualStyleBackColor = true;
            this.bt_Inscrire.Click += new System.EventHandler(this.bt_Inscrire_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 347);
            this.Controls.Add(this.bt_Inscrire);
            this.Controls.Add(this.tbTypeDemande);
            this.Controls.Add(this.tbNomDemande);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTypeDemande);
            this.Controls.Add(this.lbNomDemande);
            this.Name = "Form1";
            this.Text = "Prestation-Ajout ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNomDemande;
        private System.Windows.Forms.Label lbTypeDemande;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNomDemande;
        private System.Windows.Forms.TextBox tbTypeDemande;
        private System.Windows.Forms.Button bt_Inscrire;
    }
}

