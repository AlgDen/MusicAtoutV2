namespace WindowsFormsApp1
{
    partial class FCompositeurStyle
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
            this.lblStyle = new System.Windows.Forms.Label();
            this.cboStyle = new System.Windows.Forms.ComboBox();
            this.txtDebut = new System.Windows.Forms.TextBox();
            this.lblDebut = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.bsStyle = new System.Windows.Forms.BindingSource(this.components);
            this.bsCompositeur = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompositeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompositeur)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompositeur
            // 
            this.dgvCompositeur.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvCompositeur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompositeur.Location = new System.Drawing.Point(38, 54);
            this.dgvCompositeur.Name = "dgvCompositeur";
            this.dgvCompositeur.Size = new System.Drawing.Size(725, 375);
            this.dgvCompositeur.TabIndex = 0;
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Location = new System.Drawing.Point(35, 19);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(159, 13);
            this.lblStyle.TabIndex = 1;
            this.lblStyle.Text = "Sélectionner un style ou époque";
            // 
            // cboStyle
            // 
            this.cboStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cboStyle.FormattingEnabled = true;
            this.cboStyle.Location = new System.Drawing.Point(200, 16);
            this.cboStyle.Name = "cboStyle";
            this.cboStyle.Size = new System.Drawing.Size(114, 21);
            this.cboStyle.TabIndex = 2;
            // 
            // txtDebut
            // 
            this.txtDebut.Enabled = false;
            this.txtDebut.Location = new System.Drawing.Point(488, 16);
            this.txtDebut.Name = "txtDebut";
            this.txtDebut.Size = new System.Drawing.Size(77, 20);
            this.txtDebut.TabIndex = 3;
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.Location = new System.Drawing.Point(407, 19);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(75, 13);
            this.lblDebut.TabIndex = 4;
            this.lblDebut.Text = "Début du style";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(609, 19);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(60, 13);
            this.lblFin.TabIndex = 5;
            this.lblFin.Text = "Fin du style";
            // 
            // txtFin
            // 
            this.txtFin.Enabled = false;
            this.txtFin.Location = new System.Drawing.Point(684, 16);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(79, 20);
            this.txtFin.TabIndex = 6;
            // 
            // bsStyle
            // 
            this.bsStyle.CurrentChanged += new System.EventHandler(this.BsStyle_CurrentChanged);
            // 
            // FCompositeurStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblDebut);
            this.Controls.Add(this.txtDebut);
            this.Controls.Add(this.cboStyle);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.dgvCompositeur);
            this.Name = "FCompositeurStyle";
            this.Text = "Compositeurs d\'un style";
            this.Load += new System.EventHandler(this.FCompositeurStyle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompositeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompositeur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompositeur;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.ComboBox cboStyle;
        private System.Windows.Forms.TextBox txtDebut;
        private System.Windows.Forms.Label lblDebut;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.BindingSource bsStyle;
        private System.Windows.Forms.BindingSource bsCompositeur;
    }
}