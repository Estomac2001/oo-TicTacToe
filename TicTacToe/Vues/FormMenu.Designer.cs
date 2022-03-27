namespace TicTacToe
{
    partial class FormMenu
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
            this.btnNouvellePartie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNouvellePartie
            // 
            this.btnNouvellePartie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNouvellePartie.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouvellePartie.Location = new System.Drawing.Point(173, 219);
            this.btnNouvellePartie.Name = "btnNouvellePartie";
            this.btnNouvellePartie.Size = new System.Drawing.Size(142, 23);
            this.btnNouvellePartie.TabIndex = 0;
            this.btnNouvellePartie.Text = "Nouvelle partie";
            this.btnNouvellePartie.UseVisualStyleBackColor = false;
            this.btnNouvellePartie.Click += new System.EventHandler(this.btnNouvellePartie_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 431);
            this.Controls.Add(this.btnNouvellePartie);
            this.Name = "FormMenu";
            this.Text = "Tic-Tac-Toe - Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNouvellePartie;
    }
}

