
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
            this.SuspendLayout();
            // 
            // btn_Aerei
            // 
            this.btn_Aerei.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Aerei.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Aerei.Location = new System.Drawing.Point(299, 43);
            this.btn_Aerei.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Aerei.Name = "btn_Aerei";
            this.btn_Aerei.Size = new System.Drawing.Size(254, 93);
            this.btn_Aerei.TabIndex = 0;
            this.btn_Aerei.Text = "AEREI";
            this.btn_Aerei.UseVisualStyleBackColor = false;
            this.btn_Aerei.Click += new System.EventHandler(this.btn_Aerei_Click);
            // 
            // btnVoli
            // 
            this.btnVoli.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVoli.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnVoli.Location = new System.Drawing.Point(299, 174);
            this.btnVoli.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnVoli.Name = "btnVoli";
            this.btnVoli.Size = new System.Drawing.Size(254, 96);
            this.btnVoli.TabIndex = 1;
            this.btnVoli.Text = "VOLI";
            this.btnVoli.UseVisualStyleBackColor = false;
            this.btnVoli.Click += new System.EventHandler(this.btnVoli_Click);
            // 
            // btnAereoporti
            // 
            this.btnAereoporti.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAereoporti.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAereoporti.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAereoporti.Location = new System.Drawing.Point(299, 314);
            this.btnAereoporti.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAereoporti.Name = "btnAereoporti";
            this.btnAereoporti.Size = new System.Drawing.Size(254, 99);
            this.btnAereoporti.TabIndex = 2;
            this.btnAereoporti.Text = "AEREOPORTI";
            this.btnAereoporti.UseVisualStyleBackColor = false;
            this.btnAereoporti.Click += new System.EventHandler(this.btnAereoporti_Click);
            // 
            // frmAvvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(866, 475);
            this.Controls.Add(this.btnAereoporti);
            this.Controls.Add(this.btnVoli);
            this.Controls.Add(this.btn_Aerei);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximumSize = new System.Drawing.Size(884, 522);
            this.MinimumSize = new System.Drawing.Size(884, 522);
            this.Name = "frmAvvio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmAvvio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Aerei;
        private System.Windows.Forms.Button btnVoli;
        private System.Windows.Forms.Button btnAereoporti;
    }
}

