namespace WindowsFormsApp1
{
    partial class FCompositeurOeuvre
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
            this.dgvCompositeur = new System.Windows.Forms.DataGridView();
            this.cboStyle = new System.Windows.Forms.ComboBox();
            this.txtDebut = new System.Windows.Forms.TextBox();
            this.lblDebut = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.bsStyle = new System.Windows.Forms.BindingSource(this.components);
            this.bsCompositeur = new System.Windows.Forms.BindingSource(this.components);
            this.lblStyle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCompositeurOeuvres = new System.Windows.Forms.Label();
            this.lblStyle1 = new System.Windows.Forms.Label();
            this.lblDeces = new System.Windows.Forms.Label();
            this.lblNaissance = new System.Windows.Forms.Label();
            this.lblNationalite = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSelection = new System.Windows.Forms.Label();
            this.dgvCompositeurDroite = new System.Windows.Forms.DataGridView();
            this.bsDroite = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompositeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompositeur)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompositeurDroite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDroite)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompositeur
            // 
            this.dgvCompositeur.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvCompositeur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompositeur.Location = new System.Drawing.Point(38, 195);
            this.dgvCompositeur.Name = "dgvCompositeur";
            this.dgvCompositeur.Size = new System.Drawing.Size(260, 234);
            this.dgvCompositeur.TabIndex = 0;
            // 
            // cboStyle
            // 
            this.cboStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cboStyle.FormattingEnabled = true;
            this.cboStyle.Location = new System.Drawing.Point(38, 76);
            this.cboStyle.Name = "cboStyle";
            this.cboStyle.Size = new System.Drawing.Size(141, 21);
            this.cboStyle.TabIndex = 2;
            // 
            // txtDebut
            // 
            this.txtDebut.Enabled = false;
            this.txtDebut.Location = new System.Drawing.Point(38, 126);
            this.txtDebut.Name = "txtDebut";
            this.txtDebut.Size = new System.Drawing.Size(77, 20);
            this.txtDebut.TabIndex = 3;
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.Location = new System.Drawing.Point(35, 110);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(36, 13);
            this.lblDebut.TabIndex = 4;
            this.lblDebut.Text = "Début";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(158, 110);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(21, 13);
            this.lblFin.TabIndex = 5;
            this.lblFin.Text = "Fin";
            // 
            // txtFin
            // 
            this.txtFin.Enabled = false;
            this.txtFin.Location = new System.Drawing.Point(161, 126);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(79, 20);
            this.txtFin.TabIndex = 6;
            // 
            // bsStyle
            // 
            this.bsStyle.CurrentChanged += new System.EventHandler(this.BsStyle_CurrentChanged);
            // 
            // bsCompositeur
            // 
            this.bsCompositeur.CurrentChanged += new System.EventHandler(this.BsCompositeur_CurrentChanged);
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStyle.Location = new System.Drawing.Point(35, 54);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(30, 13);
            this.lblStyle.TabIndex = 1;
            this.lblStyle.Text = "Style";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Compositeurs de ce style";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.lblCompositeurOeuvres);
            this.panel1.Controls.Add(this.lblStyle1);
            this.panel1.Controls.Add(this.lblDeces);
            this.panel1.Controls.Add(this.lblNaissance);
            this.panel1.Controls.Add(this.lblNationalite);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblSelection);
            this.panel1.Controls.Add(this.dgvCompositeurDroite);
            this.panel1.Location = new System.Drawing.Point(349, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 416);
            this.panel1.TabIndex = 8;
            // 
            // lblCompositeurOeuvres
            // 
            this.lblCompositeurOeuvres.AutoSize = true;
            this.lblCompositeurOeuvres.Location = new System.Drawing.Point(24, 161);
            this.lblCompositeurOeuvres.Name = "lblCompositeurOeuvres";
            this.lblCompositeurOeuvres.Size = new System.Drawing.Size(155, 13);
            this.lblCompositeurOeuvres.TabIndex = 21;
            this.lblCompositeurOeuvres.Text = "Les oeuvres de ce compositeur";
            // 
            // lblStyle1
            // 
            this.lblStyle1.AutoSize = true;
            this.lblStyle1.Location = new System.Drawing.Point(259, 42);
            this.lblStyle1.Name = "lblStyle1";
            this.lblStyle1.Size = new System.Drawing.Size(30, 13);
            this.lblStyle1.TabIndex = 20;
            this.lblStyle1.Text = "Style";
            // 
            // lblDeces
            // 
            this.lblDeces.AutoSize = true;
            this.lblDeces.Location = new System.Drawing.Point(167, 67);
            this.lblDeces.Name = "lblDeces";
            this.lblDeces.Size = new System.Drawing.Size(38, 13);
            this.lblDeces.TabIndex = 19;
            this.lblDeces.Text = "Décès";
            // 
            // lblNaissance
            // 
            this.lblNaissance.AutoSize = true;
            this.lblNaissance.Location = new System.Drawing.Point(48, 67);
            this.lblNaissance.Name = "lblNaissance";
            this.lblNaissance.Size = new System.Drawing.Size(57, 13);
            this.lblNaissance.TabIndex = 18;
            this.lblNaissance.Text = "Naissance";
            // 
            // lblNationalite
            // 
            this.lblNationalite.AutoSize = true;
            this.lblNationalite.Location = new System.Drawing.Point(48, 41);
            this.lblNationalite.Name = "lblNationalite";
            this.lblNationalite.Size = new System.Drawing.Size(57, 13);
            this.lblNationalite.TabIndex = 17;
            this.lblNationalite.Text = "Nationalité";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(27, 94);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(382, 54);
            this.textBox6.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(211, 64);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(37, 20);
            this.textBox5.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(123, 64);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(37, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(299, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 20);
            this.textBox1.TabIndex = 9;
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Location = new System.Drawing.Point(3, 15);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(114, 13);
            this.lblSelection.TabIndex = 10;
            this.lblSelection.Text = "Vous avez sélectionné";
            // 
            // dgvCompositeurDroite
            // 
            this.dgvCompositeurDroite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompositeurDroite.Location = new System.Drawing.Point(27, 182);
            this.dgvCompositeurDroite.Name = "dgvCompositeurDroite";
            this.dgvCompositeurDroite.Size = new System.Drawing.Size(382, 207);
            this.dgvCompositeurDroite.TabIndex = 11;
            // 
            // FCompositeurOeuvre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblDebut);
            this.Controls.Add(this.txtDebut);
            this.Controls.Add(this.cboStyle);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.dgvCompositeur);
            this.Name = "FCompositeurOeuvre";
            this.Text = "Les oeuvres d\'un compositeur";
            this.Load += new System.EventHandler(this.FCompositeurOeuvre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompositeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompositeur)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompositeurDroite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDroite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompositeur;
        private System.Windows.Forms.ComboBox cboStyle;
        private System.Windows.Forms.TextBox txtDebut;
        private System.Windows.Forms.Label lblDebut;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.BindingSource bsStyle;
        private System.Windows.Forms.BindingSource bsCompositeur;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.DataGridView dgvCompositeurDroite;
        private System.Windows.Forms.Label lblNaissance;
        private System.Windows.Forms.Label lblNationalite;
        private System.Windows.Forms.Label lblDeces;
        private System.Windows.Forms.Label lblStyle1;
        private System.Windows.Forms.Label lblCompositeurOeuvres;
        private System.Windows.Forms.BindingSource bsDroite;
    }
}