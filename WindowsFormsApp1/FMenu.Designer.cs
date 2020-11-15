namespace WindowsFormsApp1
{
    partial class FMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.villeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batimentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeOeuvreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compositeursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parNationalitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parOeuvresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.villeToolStripMenuItem,
            this.salleToolStripMenuItem,
            this.batimentToolStripMenuItem,
            this.typeOeuvreToolStripMenuItem,
            this.compositeursToolStripMenuItem,
            this.gestionToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.menuToolStripMenuItem.Text = "Liste";
            // 
            // villeToolStripMenuItem
            // 
            this.villeToolStripMenuItem.Name = "villeToolStripMenuItem";
            this.villeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.villeToolStripMenuItem.Text = "Ville";
            this.villeToolStripMenuItem.Click += new System.EventHandler(this.VilleToolStripMenuItem_Click);
            // 
            // salleToolStripMenuItem
            // 
            this.salleToolStripMenuItem.Name = "salleToolStripMenuItem";
            this.salleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salleToolStripMenuItem.Text = "Salle";
            this.salleToolStripMenuItem.Click += new System.EventHandler(this.SalleToolStripMenuItem_Click);
            // 
            // batimentToolStripMenuItem
            // 
            this.batimentToolStripMenuItem.Name = "batimentToolStripMenuItem";
            this.batimentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.batimentToolStripMenuItem.Text = "Batiment";
            this.batimentToolStripMenuItem.Click += new System.EventHandler(this.BatimentToolStripMenuItem_Click);
            // 
            // typeOeuvreToolStripMenuItem
            // 
            this.typeOeuvreToolStripMenuItem.Name = "typeOeuvreToolStripMenuItem";
            this.typeOeuvreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.typeOeuvreToolStripMenuItem.Text = "Type Oeuvre";
            this.typeOeuvreToolStripMenuItem.Click += new System.EventHandler(this.TypeOeuvreToolStripMenuItem_Click);
            // 
            // compositeursToolStripMenuItem
            // 
            this.compositeursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parNationalitéToolStripMenuItem,
            this.parStyleToolStripMenuItem,
            this.parOeuvresToolStripMenuItem});
            this.compositeursToolStripMenuItem.Name = "compositeursToolStripMenuItem";
            this.compositeursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.compositeursToolStripMenuItem.Text = "Compositeurs";
            this.compositeursToolStripMenuItem.Click += new System.EventHandler(this.CompositeursToolStripMenuItem_Click);
            // 
            // parNationalitéToolStripMenuItem
            // 
            this.parNationalitéToolStripMenuItem.Name = "parNationalitéToolStripMenuItem";
            this.parNationalitéToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.parNationalitéToolStripMenuItem.Text = "Par nationalité";
            this.parNationalitéToolStripMenuItem.Click += new System.EventHandler(this.ParNationalitéToolStripMenuItem_Click);
            // 
            // parStyleToolStripMenuItem
            // 
            this.parStyleToolStripMenuItem.Name = "parStyleToolStripMenuItem";
            this.parStyleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.parStyleToolStripMenuItem.Text = "Par style ";
            this.parStyleToolStripMenuItem.Click += new System.EventHandler(this.ParStyleToolStripMenuItem_Click);
            // 
            // parOeuvresToolStripMenuItem
            // 
            this.parOeuvresToolStripMenuItem.Name = "parOeuvresToolStripMenuItem";
            this.parOeuvresToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.parOeuvresToolStripMenuItem.Text = "Par oeuvres";
            this.parOeuvresToolStripMenuItem.Click += new System.EventHandler(this.ParOeuvresToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.folle_journee;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMenu";
            this.Text = "MusicAtout 2018";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem villeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batimentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeOeuvreToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem compositeursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parNationalitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parOeuvresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
    }
}

