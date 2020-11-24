namespace WindowsFormsApp1
{
    partial class FCompositeurNation
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
            this.lblNation = new System.Windows.Forms.Label();
            this.dgvCompositeur = new System.Windows.Forms.DataGridView();
            this.bsNation = new System.Windows.Forms.BindingSource(this.components);
            this.bsCompositeur = new System.Windows.Forms.BindingSource(this.components);
            this.cboNation = new System.Windows.Forms.ComboBox();
            this.btnToutesNationalite = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompositeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompositeur)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNation
            // 
            this.lblNation.AutoSize = true;
            this.lblNation.Location = new System.Drawing.Point(12, 9);
            this.lblNation.Name = "lblNation";
            this.lblNation.Size = new System.Drawing.Size(66, 13);
            this.lblNation.TabIndex = 2;
            this.lblNation.Text = "Nationalité : ";
            this.lblNation.Click += new System.EventHandler(this.Nationlbl_Click);
            // 
            // dgvCompositeur
            // 
            this.dgvCompositeur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompositeur.Location = new System.Drawing.Point(15, 77);
            this.dgvCompositeur.Name = "dgvCompositeur";
            this.dgvCompositeur.Size = new System.Drawing.Size(755, 301);
            this.dgvCompositeur.TabIndex = 4;
            this.dgvCompositeur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCompositeur_CellContentClick);
            // 
            // bsNation
            // 
            this.bsNation.CurrentChanged += new System.EventHandler(this.BsNation_CurrentChanged);
            // 
            // cboNation
            // 
            this.cboNation.FormattingEnabled = true;
            this.cboNation.Location = new System.Drawing.Point(84, 6);
            this.cboNation.Name = "cboNation";
            this.cboNation.Size = new System.Drawing.Size(121, 21);
            this.cboNation.TabIndex = 5;
            this.cboNation.SelectedIndexChanged += new System.EventHandler(this.cboNation_SelectedIndexChanged);
            // 
            // btnToutesNationalite
            // 
            this.btnToutesNationalite.Location = new System.Drawing.Point(222, 6);
            this.btnToutesNationalite.Name = "btnToutesNationalite";
            this.btnToutesNationalite.Size = new System.Drawing.Size(120, 23);
            this.btnToutesNationalite.TabIndex = 6;
            this.btnToutesNationalite.Text = "Toutes les nationalités";
            this.btnToutesNationalite.UseVisualStyleBackColor = true;
            this.btnToutesNationalite.Click += new System.EventHandler(this.BtnToutesNationalite_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(28, 402);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(75, 23);
            this.btnAjout.TabIndex = 7;
            this.btnAjout.Text = "Ajout";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(126, 402);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(75, 23);
            this.btnModif.TabIndex = 8;
            this.btnModif.Text = "Modification";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnSup
            // 
            this.btnSup.Location = new System.Drawing.Point(222, 402);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(75, 23);
            this.btnSup.TabIndex = 9;
            this.btnSup.Text = "Suppression";
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // FCompositeurNation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.btnToutesNationalite);
            this.Controls.Add(this.cboNation);
            this.Controls.Add(this.dgvCompositeur);
            this.Controls.Add(this.lblNation);
            this.Name = "FCompositeurNation";
            this.Text = "FCompositeurNation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FCompositeurNation_FormClosing);
            this.Load += new System.EventHandler(this.FCompositeurNation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompositeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompositeur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNation;
        private System.Windows.Forms.DataGridView dgvCompositeur;
        private System.Windows.Forms.BindingSource bsNation;
        private System.Windows.Forms.BindingSource bsCompositeur;
        private System.Windows.Forms.ComboBox cboNation;
        private System.Windows.Forms.Button btnToutesNationalite;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnSup;
    }
}