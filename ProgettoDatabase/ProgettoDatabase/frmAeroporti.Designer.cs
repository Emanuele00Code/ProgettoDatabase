
namespace ProgettoDatabase
{
    partial class frmAeroporti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAeroporti));
            this.tblPersoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportoDataSet = new ProgettoDatabase.AeroportoDataSet();
            this.tblAeroportiTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.tblAeroportiTableAdapter();
            this.dvgAeroporti = new System.Windows.Forms.DataGridView();
            this.siglaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gatesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cittaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.militareDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.internazionaleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblAeroportiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSalva = new System.Windows.Forms.ToolStripButton();
            this.tsbNuovo = new System.Windows.Forms.ToolStripButton();
            this.tsbModifica = new System.Windows.Forms.ToolStripButton();
            this.tsbNascondi = new System.Windows.Forms.ToolStripButton();
            this.tsbElimina = new System.Windows.Forms.ToolStripButton();
            this.tsbVisualizza = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAeroporti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAeroportiBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPersoneBindingSource
            // 
            this.tblPersoneBindingSource.DataMember = "tblAeroporti";
            this.tblPersoneBindingSource.DataSource = this.aeroportoDataSet;
            // 
            // aeroportoDataSet
            // 
            this.aeroportoDataSet.DataSetName = "AeroportoDataSet";
            this.aeroportoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAeroportiTableAdapter
            // 
            this.tblAeroportiTableAdapter.ClearBeforeFill = true;
            // 
            // dvgAeroporti
            // 
            this.dvgAeroporti.AutoGenerateColumns = false;
            this.dvgAeroporti.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dvgAeroporti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAeroporti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siglaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.pisteDataGridViewTextBoxColumn,
            this.terminalDataGridViewTextBoxColumn,
            this.gatesDataGridViewTextBoxColumn,
            this.nazioneDataGridViewTextBoxColumn,
            this.cittaDataGridViewTextBoxColumn,
            this.militareDataGridViewCheckBoxColumn,
            this.internazionaleDataGridViewCheckBoxColumn});
            this.dvgAeroporti.DataSource = this.tblAeroportiBindingSource;
            this.dvgAeroporti.Location = new System.Drawing.Point(78, 76);
            this.dvgAeroporti.Margin = new System.Windows.Forms.Padding(4);
            this.dvgAeroporti.Name = "dvgAeroporti";
            this.dvgAeroporti.RowHeadersWidth = 51;
            this.dvgAeroporti.RowTemplate.Height = 24;
            this.dvgAeroporti.Size = new System.Drawing.Size(1298, 264);
            this.dvgAeroporti.TabIndex = 7;
            // 
            // siglaDataGridViewTextBoxColumn
            // 
            this.siglaDataGridViewTextBoxColumn.DataPropertyName = "Sigla";
            this.siglaDataGridViewTextBoxColumn.HeaderText = "Sigla";
            this.siglaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.siglaDataGridViewTextBoxColumn.Name = "siglaDataGridViewTextBoxColumn";
            this.siglaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // pisteDataGridViewTextBoxColumn
            // 
            this.pisteDataGridViewTextBoxColumn.DataPropertyName = "Piste";
            this.pisteDataGridViewTextBoxColumn.HeaderText = "Piste";
            this.pisteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pisteDataGridViewTextBoxColumn.Name = "pisteDataGridViewTextBoxColumn";
            this.pisteDataGridViewTextBoxColumn.Width = 125;
            // 
            // terminalDataGridViewTextBoxColumn
            // 
            this.terminalDataGridViewTextBoxColumn.DataPropertyName = "Terminal";
            this.terminalDataGridViewTextBoxColumn.HeaderText = "Terminal";
            this.terminalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.terminalDataGridViewTextBoxColumn.Name = "terminalDataGridViewTextBoxColumn";
            this.terminalDataGridViewTextBoxColumn.Width = 125;
            // 
            // gatesDataGridViewTextBoxColumn
            // 
            this.gatesDataGridViewTextBoxColumn.DataPropertyName = "Gates";
            this.gatesDataGridViewTextBoxColumn.HeaderText = "Gates";
            this.gatesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gatesDataGridViewTextBoxColumn.Name = "gatesDataGridViewTextBoxColumn";
            this.gatesDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazioneDataGridViewTextBoxColumn
            // 
            this.nazioneDataGridViewTextBoxColumn.DataPropertyName = "Nazione";
            this.nazioneDataGridViewTextBoxColumn.HeaderText = "Nazione";
            this.nazioneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazioneDataGridViewTextBoxColumn.Name = "nazioneDataGridViewTextBoxColumn";
            this.nazioneDataGridViewTextBoxColumn.Width = 125;
            // 
            // cittaDataGridViewTextBoxColumn
            // 
            this.cittaDataGridViewTextBoxColumn.DataPropertyName = "Citta";
            this.cittaDataGridViewTextBoxColumn.HeaderText = "Citta";
            this.cittaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cittaDataGridViewTextBoxColumn.Name = "cittaDataGridViewTextBoxColumn";
            this.cittaDataGridViewTextBoxColumn.Width = 125;
            // 
            // militareDataGridViewCheckBoxColumn
            // 
            this.militareDataGridViewCheckBoxColumn.DataPropertyName = "Militare";
            this.militareDataGridViewCheckBoxColumn.HeaderText = "Militare";
            this.militareDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.militareDataGridViewCheckBoxColumn.Name = "militareDataGridViewCheckBoxColumn";
            this.militareDataGridViewCheckBoxColumn.Width = 125;
            // 
            // internazionaleDataGridViewCheckBoxColumn
            // 
            this.internazionaleDataGridViewCheckBoxColumn.DataPropertyName = "Internazionale";
            this.internazionaleDataGridViewCheckBoxColumn.HeaderText = "Internazionale";
            this.internazionaleDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.internazionaleDataGridViewCheckBoxColumn.Name = "internazionaleDataGridViewCheckBoxColumn";
            this.internazionaleDataGridViewCheckBoxColumn.Width = 125;
            // 
            // tblAeroportiBindingSource
            // 
            this.tblAeroportiBindingSource.DataMember = "tblAeroporti";
            this.tblAeroportiBindingSource.DataSource = this.aeroportoDataSet;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalva,
            this.tsbNuovo,
            this.tsbModifica,
            this.tsbNascondi,
            this.tsbElimina,
            this.tsbVisualizza});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1428, 31);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSalva
            // 
            this.tsbSalva.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalva.Image")));
            this.tsbSalva.Name = "tsbSalva";
            this.tsbSalva.Size = new System.Drawing.Size(29, 28);
            this.tsbSalva.ToolTipText = "Salva";
            this.tsbSalva.Click += new System.EventHandler(this.tsbSalva_Click);
            // 
            // tsbNuovo
            // 
            this.tsbNuovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuovo.Image")));
            this.tsbNuovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuovo.Name = "tsbNuovo";
            this.tsbNuovo.Size = new System.Drawing.Size(29, 28);
            this.tsbNuovo.Text = "Inserisci";
            this.tsbNuovo.Click += new System.EventHandler(this.tsbNuovo_Click);
            // 
            // tsbModifica
            // 
            this.tsbModifica.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModifica.Image = ((System.Drawing.Image)(resources.GetObject("tsbModifica.Image")));
            this.tsbModifica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModifica.Name = "tsbModifica";
            this.tsbModifica.Size = new System.Drawing.Size(29, 28);
            this.tsbModifica.Text = "Modifica";
            this.tsbModifica.Click += new System.EventHandler(this.tsbModifica_Click);
            // 
            // tsbNascondi
            // 
            this.tsbNascondi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNascondi.Image = ((System.Drawing.Image)(resources.GetObject("tsbNascondi.Image")));
            this.tsbNascondi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNascondi.Name = "tsbNascondi";
            this.tsbNascondi.Size = new System.Drawing.Size(29, 28);
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
            this.tsbElimina.Size = new System.Drawing.Size(29, 28);
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
            this.tsbVisualizza.Size = new System.Drawing.Size(29, 28);
            this.tsbVisualizza.Text = "toolStripButton6";
            this.tsbVisualizza.ToolTipText = "Visualizza";
            this.tsbVisualizza.Click += new System.EventHandler(this.tsbVisualizza_Click);
            // 
            // frmAeroporti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1428, 404);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dvgAeroporti);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1446, 451);
            this.Name = "frmAeroporti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aeroporti";
            this.Load += new System.EventHandler(this.frmPersone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPersoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAeroporti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAeroportiBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AeroportoDataSet aeroportoDataSet;
        private System.Windows.Forms.BindingSource tblPersoneBindingSource;
        private AeroportoDataSetTableAdapters.tblAeroportiTableAdapter tblAeroportiTableAdapter;
        private System.Windows.Forms.DataGridView dvgAeroporti;
        private System.Windows.Forms.DataGridViewTextBoxColumn siglaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gatesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cittaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn militareDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn internazionaleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource tblAeroportiBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSalva;
        private System.Windows.Forms.ToolStripButton tsbNuovo;
        private System.Windows.Forms.ToolStripButton tsbModifica;
        private System.Windows.Forms.ToolStripButton tsbNascondi;
        private System.Windows.Forms.ToolStripButton tsbElimina;
        private System.Windows.Forms.ToolStripButton tsbVisualizza;
    }
}