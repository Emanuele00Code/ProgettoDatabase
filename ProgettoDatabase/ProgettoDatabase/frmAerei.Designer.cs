
namespace ProgettoDatabase
{
    partial class frmAerei
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAerei));
            this.dgvAerei = new System.Windows.Forms.DataGridView();
            this.codiceAereoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacitaMassimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.litriCarburanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroMotoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPropulsioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internazionaleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.raggioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velocitaMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compagniaAereaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAereiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportoDataSet = new ProgettoDatabase.AeroportoDataSet();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tblAereiTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.tblAereiTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuovo = new System.Windows.Forms.ToolStripButton();
            this.tsbModifica = new System.Windows.Forms.ToolStripButton();
            this.tsbNascondi = new System.Windows.Forms.ToolStripButton();
            this.tsbElimina = new System.Windows.Forms.ToolStripButton();
            this.tsbVisualizza = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAerei)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAereiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAerei
            // 
            this.dgvAerei.AllowUserToAddRows = false;
            this.dgvAerei.AllowUserToDeleteRows = false;
            this.dgvAerei.AutoGenerateColumns = false;
            this.dgvAerei.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvAerei.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAerei.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codiceAereoDataGridViewTextBoxColumn,
            this.modelloDataGridViewTextBoxColumn,
            this.capacitaMassimaDataGridViewTextBoxColumn,
            this.litriCarburanteDataGridViewTextBoxColumn,
            this.numeroMotoriDataGridViewTextBoxColumn,
            this.tipoPropulsioneDataGridViewTextBoxColumn,
            this.internazionaleDataGridViewCheckBoxColumn,
            this.raggioDataGridViewTextBoxColumn,
            this.velocitaMaxDataGridViewTextBoxColumn,
            this.compagniaAereaDataGridViewTextBoxColumn});
            this.dgvAerei.DataSource = this.tblAereiBindingSource;
            this.dgvAerei.Location = new System.Drawing.Point(78, 76);
            this.dgvAerei.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAerei.MultiSelect = false;
            this.dgvAerei.Name = "dgvAerei";
            this.dgvAerei.ReadOnly = true;
            this.dgvAerei.RowHeadersWidth = 51;
            this.dgvAerei.Size = new System.Drawing.Size(1298, 264);
            this.dgvAerei.TabIndex = 0;
            // 
            // codiceAereoDataGridViewTextBoxColumn
            // 
            this.codiceAereoDataGridViewTextBoxColumn.DataPropertyName = "CodiceAereo";
            this.codiceAereoDataGridViewTextBoxColumn.HeaderText = "Codice Aereo";
            this.codiceAereoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codiceAereoDataGridViewTextBoxColumn.Name = "codiceAereoDataGridViewTextBoxColumn";
            this.codiceAereoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codiceAereoDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelloDataGridViewTextBoxColumn
            // 
            this.modelloDataGridViewTextBoxColumn.DataPropertyName = "Modello";
            this.modelloDataGridViewTextBoxColumn.HeaderText = "Modello";
            this.modelloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelloDataGridViewTextBoxColumn.Name = "modelloDataGridViewTextBoxColumn";
            this.modelloDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelloDataGridViewTextBoxColumn.Width = 125;
            // 
            // capacitaMassimaDataGridViewTextBoxColumn
            // 
            this.capacitaMassimaDataGridViewTextBoxColumn.DataPropertyName = "CapacitaMassima";
            this.capacitaMassimaDataGridViewTextBoxColumn.HeaderText = "Capacita Massima";
            this.capacitaMassimaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacitaMassimaDataGridViewTextBoxColumn.Name = "capacitaMassimaDataGridViewTextBoxColumn";
            this.capacitaMassimaDataGridViewTextBoxColumn.ReadOnly = true;
            this.capacitaMassimaDataGridViewTextBoxColumn.Width = 125;
            // 
            // litriCarburanteDataGridViewTextBoxColumn
            // 
            this.litriCarburanteDataGridViewTextBoxColumn.DataPropertyName = "LitriCarburante";
            this.litriCarburanteDataGridViewTextBoxColumn.HeaderText = "Litri Carburante";
            this.litriCarburanteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.litriCarburanteDataGridViewTextBoxColumn.Name = "litriCarburanteDataGridViewTextBoxColumn";
            this.litriCarburanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.litriCarburanteDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroMotoriDataGridViewTextBoxColumn
            // 
            this.numeroMotoriDataGridViewTextBoxColumn.DataPropertyName = "NumeroMotori";
            this.numeroMotoriDataGridViewTextBoxColumn.HeaderText = "Numero Motori";
            this.numeroMotoriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroMotoriDataGridViewTextBoxColumn.Name = "numeroMotoriDataGridViewTextBoxColumn";
            this.numeroMotoriDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroMotoriDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoPropulsioneDataGridViewTextBoxColumn
            // 
            this.tipoPropulsioneDataGridViewTextBoxColumn.DataPropertyName = "TipoPropulsione";
            this.tipoPropulsioneDataGridViewTextBoxColumn.HeaderText = "Tipo di Propulsione";
            this.tipoPropulsioneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoPropulsioneDataGridViewTextBoxColumn.Name = "tipoPropulsioneDataGridViewTextBoxColumn";
            this.tipoPropulsioneDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoPropulsioneDataGridViewTextBoxColumn.Width = 125;
            // 
            // internazionaleDataGridViewCheckBoxColumn
            // 
            this.internazionaleDataGridViewCheckBoxColumn.DataPropertyName = "Internazionale";
            this.internazionaleDataGridViewCheckBoxColumn.HeaderText = "Internazionale";
            this.internazionaleDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.internazionaleDataGridViewCheckBoxColumn.Name = "internazionaleDataGridViewCheckBoxColumn";
            this.internazionaleDataGridViewCheckBoxColumn.ReadOnly = true;
            this.internazionaleDataGridViewCheckBoxColumn.Width = 125;
            // 
            // raggioDataGridViewTextBoxColumn
            // 
            this.raggioDataGridViewTextBoxColumn.DataPropertyName = "Raggio";
            this.raggioDataGridViewTextBoxColumn.HeaderText = "Raggio";
            this.raggioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.raggioDataGridViewTextBoxColumn.Name = "raggioDataGridViewTextBoxColumn";
            this.raggioDataGridViewTextBoxColumn.ReadOnly = true;
            this.raggioDataGridViewTextBoxColumn.Width = 125;
            // 
            // velocitaMaxDataGridViewTextBoxColumn
            // 
            this.velocitaMaxDataGridViewTextBoxColumn.DataPropertyName = "VelocitaMax";
            this.velocitaMaxDataGridViewTextBoxColumn.HeaderText = "Velocita Max";
            this.velocitaMaxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.velocitaMaxDataGridViewTextBoxColumn.Name = "velocitaMaxDataGridViewTextBoxColumn";
            this.velocitaMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.velocitaMaxDataGridViewTextBoxColumn.Width = 125;
            // 
            // compagniaAereaDataGridViewTextBoxColumn
            // 
            this.compagniaAereaDataGridViewTextBoxColumn.DataPropertyName = "CompagniaAerea";
            this.compagniaAereaDataGridViewTextBoxColumn.HeaderText = "Compagnia Aerea";
            this.compagniaAereaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.compagniaAereaDataGridViewTextBoxColumn.Name = "compagniaAereaDataGridViewTextBoxColumn";
            this.compagniaAereaDataGridViewTextBoxColumn.ReadOnly = true;
            this.compagniaAereaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblAereiBindingSource
            // 
            this.tblAereiBindingSource.DataMember = "tblAerei";
            this.tblAereiBindingSource.DataSource = this.aeroportoDataSet;
            // 
            // aeroportoDataSet
            // 
            this.aeroportoDataSet.DataSetName = "AeroportoDataSet";
            this.aeroportoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tblAereiTableAdapter
            // 
            this.tblAereiTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuovo,
            this.tsbModifica,
            this.tsbNascondi,
            this.tsbElimina,
            this.tsbVisualizza});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1428, 27);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuovo
            // 
            this.tsbNuovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuovo.Image")));
            this.tsbNuovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuovo.Name = "tsbNuovo";
            this.tsbNuovo.Size = new System.Drawing.Size(29, 24);
            this.tsbNuovo.Text = "Inserisci";
            this.tsbNuovo.Click += new System.EventHandler(this.tsbNuovo_Click);
            // 
            // tsbModifica
            // 
            this.tsbModifica.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModifica.Image = ((System.Drawing.Image)(resources.GetObject("tsbModifica.Image")));
            this.tsbModifica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModifica.Name = "tsbModifica";
            this.tsbModifica.Size = new System.Drawing.Size(29, 24);
            this.tsbModifica.Text = "Modifica";
            this.tsbModifica.Click += new System.EventHandler(this.tsbModifica_Click);
            // 
            // tsbNascondi
            // 
            this.tsbNascondi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNascondi.Image = ((System.Drawing.Image)(resources.GetObject("tsbNascondi.Image")));
            this.tsbNascondi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNascondi.Name = "tsbNascondi";
            this.tsbNascondi.Size = new System.Drawing.Size(29, 24);
            this.tsbNascondi.Text = "toolStripButton4";
            this.tsbNascondi.ToolTipText = "Nascondi";
            this.tsbNascondi.Click += new System.EventHandler(this.tsbNascondi_Click);
            // 
            // tsbElimina
            // 
            this.tsbElimina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbElimina.Image = ((System.Drawing.Image)(resources.GetObject("tsbElimina.Image")));
            this.tsbElimina.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbElimina.Name = "tsbElimina";
            this.tsbElimina.Size = new System.Drawing.Size(29, 24);
            this.tsbElimina.Text = "toolStripButton5";
            this.tsbElimina.ToolTipText = "Elimina";
            this.tsbElimina.Click += new System.EventHandler(this.tsbElimina_Click);
            // 
            // tsbVisualizza
            // 
            this.tsbVisualizza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbVisualizza.Image = ((System.Drawing.Image)(resources.GetObject("tsbVisualizza.Image")));
            this.tsbVisualizza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVisualizza.Name = "tsbVisualizza";
            this.tsbVisualizza.Size = new System.Drawing.Size(29, 24);
            this.tsbVisualizza.Text = "toolStripButton6";
            this.tsbVisualizza.ToolTipText = "Visualizza";
            this.tsbVisualizza.Click += new System.EventHandler(this.tsbVisualizza_Click);
            // 
            // frmAerei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1428, 404);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvAerei);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1446, 451);
            this.MinimumSize = new System.Drawing.Size(1446, 451);
            this.Name = "frmAerei";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aerei";
            this.Load += new System.EventHandler(this.frmAerei_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAerei)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAereiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAerei;
        private AeroportoDataSet aeroportoDataSet;
        private System.Windows.Forms.BindingSource tblAereiBindingSource;
        private AeroportoDataSetTableAdapters.tblAereiTableAdapter tblAereiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceAereiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuovo;
        private System.Windows.Forms.ToolStripButton tsbModifica;
        private System.Windows.Forms.ToolStripButton tsbNascondi;
        private System.Windows.Forms.ToolStripButton tsbElimina;
        private System.Windows.Forms.ToolStripButton tsbVisualizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceAereoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacitaMassimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn litriCarburanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroMotoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPropulsioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn internazionaleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raggioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velocitaMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compagniaAereaDataGridViewTextBoxColumn;
    }
}