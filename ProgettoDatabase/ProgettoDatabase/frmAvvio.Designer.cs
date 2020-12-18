
namespace ProgettoDatabase
{
    partial class frmAvvio
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvvio));
            this.btn_Aerei = new System.Windows.Forms.Button();
            this.btnVoli = new System.Windows.Forms.Button();
            this.btnAereoporti = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.nuovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aereoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aeroportoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Aerei
            // 
            this.btn_Aerei.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Aerei.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Aerei.Location = new System.Drawing.Point(299, 43);
            this.btn_Aerei.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Aerei.Name = "btn_Aerei";
            this.btn_Aerei.Size = new System.Drawing.Size(254, 93);
            this.btn_Aerei.TabIndex = 0;
            this.btn_Aerei.Text = "AEREI";
            this.btn_Aerei.UseVisualStyleBackColor = false;
            this.btn_Aerei.Click += new System.EventHandler(this.btn_Aerei_Click);
            // 
            // btnVoli
            // 
            this.btnVoli.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVoli.ForeColor = System.Drawing.Color.Maroon;
            this.btnVoli.Location = new System.Drawing.Point(299, 174);
            this.btnVoli.Margin = new System.Windows.Forms.Padding(5);
            this.btnVoli.Name = "btnVoli";
            this.btnVoli.Size = new System.Drawing.Size(254, 96);
            this.btnVoli.TabIndex = 1;
            this.btnVoli.Text = "VOLI";
            this.btnVoli.UseVisualStyleBackColor = false;
            this.btnVoli.Click += new System.EventHandler(this.btnVoli_Click);
            // 
            // btnAereoporti
            // 
            this.btnAereoporti.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAereoporti.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAereoporti.ForeColor = System.Drawing.Color.Maroon;
            this.btnAereoporti.Location = new System.Drawing.Point(299, 314);
            this.btnAereoporti.Margin = new System.Windows.Forms.Padding(5);
            this.btnAereoporti.Name = "btnAereoporti";
            this.btnAereoporti.Size = new System.Drawing.Size(254, 99);
            this.btnAereoporti.TabIndex = 2;
            this.btnAereoporti.Text = "AEREOPORTI";
            this.btnAereoporti.UseVisualStyleBackColor = false;
            this.btnAereoporti.Click += new System.EventHandler(this.btnAereoporti_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(866, 31);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovoToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // nuovoToolStripMenuItem
            // 
            this.nuovoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aereoToolStripMenuItem,
            this.voloToolStripMenuItem,
            this.aeroportoToolStripMenuItem});
            this.nuovoToolStripMenuItem.Name = "nuovoToolStripMenuItem";
            this.nuovoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nuovoToolStripMenuItem.Text = "Nuovo...";
            // 
            // aereoToolStripMenuItem
            // 
            this.aereoToolStripMenuItem.Name = "aereoToolStripMenuItem";
            this.aereoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aereoToolStripMenuItem.Text = "Aereo";
            this.aereoToolStripMenuItem.Click += new System.EventHandler(this.aereoToolStripMenuItem_Click);
            // 
            // voloToolStripMenuItem
            // 
            this.voloToolStripMenuItem.Name = "voloToolStripMenuItem";
            this.voloToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.voloToolStripMenuItem.Text = "Volo";
            this.voloToolStripMenuItem.Click += new System.EventHandler(this.voloToolStripMenuItem_Click);
            // 
            // aeroportoToolStripMenuItem
            // 
            this.aeroportoToolStripMenuItem.Name = "aeroportoToolStripMenuItem";
            this.aeroportoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aeroportoToolStripMenuItem.Text = "Aeroporto";
            this.aeroportoToolStripMenuItem.Click += new System.EventHandler(this.aeroportoToolStripMenuItem_Click);
            // 
            // frmAvvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(866, 475);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnAereoporti);
            this.Controls.Add(this.btnVoli);
            this.Controls.Add(this.btn_Aerei);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(884, 522);
            this.MinimumSize = new System.Drawing.Size(884, 522);
            this.Name = "frmAvvio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmAvvio_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Aerei;
        private System.Windows.Forms.Button btnVoli;
        private System.Windows.Forms.Button btnAereoporti;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem nuovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aereoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aeroportoToolStripMenuItem;
    }
}

