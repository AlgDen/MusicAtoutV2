namespace WindowsFormsApp1
{
    partial class FAjoutModifCompositeur
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
            this.lblNomCompositeur = new System.Windows.Forms.Label();
            this.lblNationalite = new System.Windows.Forms.Label();
            this.lblAnMort = new System.Windows.Forms.Label();
            this.lblPrenomCompositeur = new System.Windows.Forms.Label();
            this.lblRemarque = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblAnNais = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.cboStyle = new System.Windows.Forms.ComboBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtRemarque = new System.Windows.Forms.TextBox();
            this.txtAnNais = new System.Windows.Forms.TextBox();
            this.txtAnMort = new System.Windows.Forms.TextBox();
            this.cboNation = new System.Windows.Forms.ComboBox();
            this.bsStyle = new System.Windows.Forms.BindingSource(this.components);
            this.bsNationalite = new System.Windows.Forms.BindingSource(this.components);
            this.bsCompositeur = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNationalite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompositeur)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomCompositeur
            // 
            this.lblNomCompositeur.AutoSize = true;
            this.lblNomCompositeur.Location = new System.Drawing.Point(41, 55);
            this.lblNomCompositeur.Name = "lblNomCompositeur";
            this.lblNomCompositeur.Size = new System.Drawing.Size(91, 13);
            this.lblNomCompositeur.TabIndex = 0;
            this.lblNomCompositeur.Text = "nom Compositeur:";
            // 
            // lblNationalite
            // 
            this.lblNationalite.AutoSize = true;
            this.lblNationalite.Location = new System.Drawing.Point(41, 255);
            this.lblNationalite.Name = "lblNationalite";
            this.lblNationalite.Size = new System.Drawing.Size(60, 13);
            this.lblNationalite.TabIndex = 1;
            this.lblNationalite.Text = "Nationalité:";
            // 
            // lblAnMort
            // 
            this.lblAnMort.AutoSize = true;
            this.lblAnMort.Location = new System.Drawing.Point(504, 225);
            this.lblAnMort.Name = "lblAnMort";
            this.lblAnMort.Size = new System.Drawing.Size(46, 13);
            this.lblAnMort.TabIndex = 2;
            this.lblAnMort.Text = "an Mort:";
            // 
            // lblPrenomCompositeur
            // 
            this.lblPrenomCompositeur.AutoSize = true;
            this.lblPrenomCompositeur.Location = new System.Drawing.Point(41, 88);
            this.lblPrenomCompositeur.Name = "lblPrenomCompositeur";
            this.lblPrenomCompositeur.Size = new System.Drawing.Size(106, 13);
            this.lblPrenomCompositeur.TabIndex = 3;
            this.lblPrenomCompositeur.Text = "prenom Compositeur:";
            // 
            // lblRemarque
            // 
            this.lblRemarque.AutoSize = true;
            this.lblRemarque.Location = new System.Drawing.Point(41, 121);
            this.lblRemarque.Name = "lblRemarque";
            this.lblRemarque.Size = new System.Drawing.Size(54, 13);
            this.lblRemarque.TabIndex = 4;
            this.lblRemarque.Text = "remarque:";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Location = new System.Drawing.Point(41, 288);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(33, 13);
            this.lblStyle.TabIndex = 5;
            this.lblStyle.Text = "Style:";
            // 
            // lblAnNais
            // 
            this.lblAnNais.AutoSize = true;
            this.lblAnNais.Location = new System.Drawing.Point(41, 225);
            this.lblAnNais.Name = "lblAnNais";
            this.lblAnNais.Size = new System.Drawing.Size(46, 13);
            this.lblAnNais.TabIndex = 6;
            this.lblAnNais.Text = "an Nais:";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(304, 349);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(420, 349);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 8;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // cboStyle
            // 
            this.cboStyle.FormattingEnabled = true;
            this.cboStyle.Location = new System.Drawing.Point(163, 277);
            this.cboStyle.Name = "cboStyle";
            this.cboStyle.Size = new System.Drawing.Size(121, 21);
            this.cboStyle.TabIndex = 9;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(163, 55);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 10;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(163, 88);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 11;
            // 
            // txtRemarque
            // 
            this.txtRemarque.Location = new System.Drawing.Point(163, 121);
            this.txtRemarque.Multiline = true;
            this.txtRemarque.Name = "txtRemarque";
            this.txtRemarque.Size = new System.Drawing.Size(589, 88);
            this.txtRemarque.TabIndex = 12;
            // 
            // txtAnNais
            // 
            this.txtAnNais.Location = new System.Drawing.Point(163, 218);
            this.txtAnNais.Name = "txtAnNais";
            this.txtAnNais.Size = new System.Drawing.Size(100, 20);
            this.txtAnNais.TabIndex = 13;
            // 
            // txtAnMort
            // 
            this.txtAnMort.Location = new System.Drawing.Point(604, 218);
            this.txtAnMort.Name = "txtAnMort";
            this.txtAnMort.Size = new System.Drawing.Size(100, 20);
            this.txtAnMort.TabIndex = 14;
            // 
            // cboNation
            // 
            this.cboNation.FormattingEnabled = true;
            this.cboNation.Location = new System.Drawing.Point(163, 247);
            this.cboNation.Name = "cboNation";
            this.cboNation.Size = new System.Drawing.Size(121, 21);
            this.cboNation.TabIndex = 15;
            // 
            // bsCompositeur
            // 
            this.bsCompositeur.CurrentChanged += new System.EventHandler(this.bsCompositeur_CurrentChanged);
            // 
            // FAjoutModifCompositeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboNation);
            this.Controls.Add(this.txtAnMort);
            this.Controls.Add(this.txtAnNais);
            this.Controls.Add(this.txtRemarque);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.cboStyle);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblAnNais);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.lblRemarque);
            this.Controls.Add(this.lblPrenomCompositeur);
            this.Controls.Add(this.lblAnMort);
            this.Controls.Add(this.lblNationalite);
            this.Controls.Add(this.lblNomCompositeur);
            this.Name = "FAjoutModifCompositeur";
            this.Text = "FAjoutModifCompositeur";
            this.Load += new System.EventHandler(this.FAjoutModifCompositeur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNationalite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompositeur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomCompositeur;
        private System.Windows.Forms.Label lblNationalite;
        private System.Windows.Forms.Label lblAnMort;
        private System.Windows.Forms.Label lblPrenomCompositeur;
        private System.Windows.Forms.Label lblRemarque;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblAnNais;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.ComboBox cboStyle;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtRemarque;
        private System.Windows.Forms.TextBox txtAnNais;
        private System.Windows.Forms.TextBox txtAnMort;
        private System.Windows.Forms.ComboBox cboNation;
        private System.Windows.Forms.BindingSource bsStyle;
        private System.Windows.Forms.BindingSource bsNationalite;
        private System.Windows.Forms.BindingSource bsCompositeur;
    }
}