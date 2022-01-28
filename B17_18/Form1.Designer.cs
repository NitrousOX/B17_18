namespace B17_18
{
    partial class Form1
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
            this.podaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodjacmodelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradovigrupeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podaciToolStripMenuItem,
            this.analizaToolStripMenuItem,
            this.krajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // podaciToolStripMenuItem
            // 
            this.podaciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gradoviToolStripMenuItem,
            this.poliseToolStripMenuItem});
            this.podaciToolStripMenuItem.Name = "podaciToolStripMenuItem";
            this.podaciToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.podaciToolStripMenuItem.Text = "Podaci";
            // 
            // gradoviToolStripMenuItem
            // 
            this.gradoviToolStripMenuItem.Name = "gradoviToolStripMenuItem";
            this.gradoviToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gradoviToolStripMenuItem.Text = "Gradovi";
            this.gradoviToolStripMenuItem.Click += new System.EventHandler(this.GradoviToolStripMenuItem_Click);
            // 
            // poliseToolStripMenuItem
            // 
            this.poliseToolStripMenuItem.Name = "poliseToolStripMenuItem";
            this.poliseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poliseToolStripMenuItem.Text = "Polise";
            this.poliseToolStripMenuItem.Click += new System.EventHandler(this.PoliseToolStripMenuItem_Click);
            // 
            // analizaToolStripMenuItem
            // 
            this.analizaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proizvodjacmodelToolStripMenuItem,
            this.gradovigrupeToolStripMenuItem});
            this.analizaToolStripMenuItem.Name = "analizaToolStripMenuItem";
            this.analizaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.analizaToolStripMenuItem.Text = "Analiza";
            // 
            // proizvodjacmodelToolStripMenuItem
            // 
            this.proizvodjacmodelToolStripMenuItem.Name = "proizvodjacmodelToolStripMenuItem";
            this.proizvodjacmodelToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.proizvodjacmodelToolStripMenuItem.Text = "Proizvodjac-model";
            this.proizvodjacmodelToolStripMenuItem.Click += new System.EventHandler(this.ProizvodjacmodelToolStripMenuItem_Click);
            // 
            // gradovigrupeToolStripMenuItem
            // 
            this.gradovigrupeToolStripMenuItem.Name = "gradovigrupeToolStripMenuItem";
            this.gradovigrupeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gradovigrupeToolStripMenuItem.Text = "Gradovi-grupe";
            this.gradovigrupeToolStripMenuItem.Click += new System.EventHandler(this.GradovigrupeToolStripMenuItem_Click);
            // 
            // krajToolStripMenuItem
            // 
            this.krajToolStripMenuItem.Name = "krajToolStripMenuItem";
            this.krajToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.krajToolStripMenuItem.Text = "kraj";
            this.krajToolStripMenuItem.Click += new System.EventHandler(this.KrajToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem podaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodjacmodelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradovigrupeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajToolStripMenuItem;
    }
}

