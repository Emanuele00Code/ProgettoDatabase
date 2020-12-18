
namespace ProgettoDatabase
{
    partial class frmVoli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoli));
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnFittizia = new System.Windows.Forms.Button();
            this.dvgVoli = new System.Windows.Forms.DataGridView();
            this.tblVoliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportoDataSet = new ProgettoDatabase.AeroportoDataSet();
            this.tblVoliTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.tblVoliTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSalva = new System.Windows.Forms.ToolStripButton();
            this.tsbNuovo = new System.Windows.Forms.ToolStripButton();
            this.tsbModifica = new System.Windows.Forms.ToolStripButton();
            this.tsbNascondi = new System.Windows.Forms.ToolStripButton();
            this.tsbElimina = new System.Windows.Forms.ToolStripButton();
            this.tsbVisualizza = new System.Windows.Forms.ToolStripButton();
            this.codiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataOraPartenzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataOraArrivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internazionaleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.partenzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gatePartenzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinazioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codiceAereoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVoli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(0, 0);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 23);
            this.btnSalva.TabIndex = 9;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(0, 0);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(75, 23);
            this.btnModifica.TabIndex = 9;
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(0, 0);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizza.TabIndex = 11;
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(0, 0);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(75, 23);
            this.btnElimina.TabIndex = 10;
            // 
            // btnFittizia
            // 
            this.btnFittizia.Location = new System.Drawing.Point(0, 0);
            this.btnFittizia.Name = "btnFittizia";
            this.btnFittizia.Size = new System.Drawing.Size(75, 23);
            this.btnFittizia.TabIndex = 9;
            // 
            // dvgVoli
            // 
            this.dvgVoli.AutoGenerateColumns = false;
            this.dvgVoli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgVoli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codiceDataGridViewTextBoxColumn,
            this.dataOraPartenzaDataGridViewTextBoxColumn,
            this.dataOraArrivoDataGridViewTextBoxColumn,
            this.internazionaleDataGridViewCheckBoxColumn,
            this.partenzaDataGridViewTextBoxColumn,
            this.gatePartenzaDataGridViewTextBoxColumn,
            this.durataDataGridViewTextBoxColumn,
            this.destinazioneDataGridViewTextBoxColumn,
            this.codiceAereoDataGridViewTextBoxColumn});
            this.dvgVoli.DataSource = this.tblVoliBindingSource;
            this.dvgVoli.Location = new System.Drawing.Point(93, 75);
            this.dvgVoli.Name = "dvgVoli";
            this.dvgVoli.RowHeadersWidth = 51;
            this.dvgVoli.RowTemplate.Height = 24;
            this.dvgVoli.Size = new System.Drawing.Size(1236, 264);
            this.dvgVoli.TabIndex = 7;
            // 
            // tblVoliBindingSource
            // 
            this.tblVoliBindingSource.DataMember = "tblVoli";
            this.tblVoliBindingSource.DataSource = this.aeroportoDataSet;
            // 
            // aeroportoDataSet
            // 
            this.aeroportoDataSet.DataSetName = "AeroportoDataSet";
            this.aeroportoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblVoliTableAdapter
            // 
            this.tblVoliTableAdapter.ClearBeforeFill = true;
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
            this.toolStrip1.Size = new System.Drawing.Size(1428, 27);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSalva
            // 
            this.tsbSalva.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalva.Image")));
            this.tsbSalva.Name = "tsbSalva";
            this.tsbSalva.Size = new System.Drawing.Size(29, 24);
            this.tsbSalva.Click += new System.EventHandler(this.tsbSalva_Click);
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
            // codiceDataGridViewTextBoxColumn
            // 
            this.codiceDataGridViewTextBoxColumn.DataPropertyName = "Codice";
            this.codiceDataGridViewTextBoxColumn.HeaderText = "Codice";
            this.codiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codiceDataGridViewTextBoxColumn.Name = "codiceDataGridViewTextBoxColumn";
            this.codiceDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataOraPartenzaDataGridViewTextBoxColumn
            // 
            this.dataOraPartenzaDataGridViewTextBoxColumn.DataPropertyName = "DataOraPartenza";
            this.dataOraPartenzaDataGridViewTextBoxColumn.HeaderText = "Data e Ora Partenza";
            this.dataOraPartenzaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataOraPartenzaDataGridViewTextBoxColumn.Name = "dataOraPartenzaDataGridViewTextBoxColumn";
            this.dataOraPartenzaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataOraArrivoDataGridViewTextBoxColumn
            // 
            this.dataOraArrivoDataGridViewTextBoxColumn.DataPropertyName = "DataOraArrivo";
            this.dataOraArrivoDataGridViewTextBoxColumn.HeaderText = "Data e Ora Arrivo";
            this.dataOraArrivoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataOraArrivoDataGridViewTextBoxColumn.Name = "dataOraArrivoDataGridViewTextBoxColumn";
            this.dataOraArrivoDataGridViewTextBoxColumn.Width = 125;
            // 
            // internazionaleDataGridViewCheckBoxColumn
            // 
            this.internazionaleDataGridViewCheckBoxColumn.DataPropertyName = "Internazionale";
            this.internazionaleDataGridViewCheckBoxColumn.HeaderText = "Internazionale";
            this.internazionaleDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.internazionaleDataGridViewCheckBoxColumn.Name = "internazionaleDataGridViewCheckBoxColumn";
            this.internazionaleDataGridViewCheckBoxColumn.Width = 125;
            // 
            // partenzaDataGridViewTextBoxColumn
            // 
            this.partenzaDataGridViewTextBoxColumn.DataPropertyName = "Partenza";
            this.partenzaDataGridViewTextBoxColumn.HeaderText = "Partenza";
            this.partenzaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partenzaDataGridViewTextBoxColumn.Name = "partenzaDataGridViewTextBoxColumn";
            this.partenzaDataGridViewTextBoxColumn.Width = 125;
            // 
            // gatePartenzaDataGridViewTextBoxColumn
            // 
            this.gatePartenzaDataGridViewTextBoxColumn.DataPropertyName = "GatePartenza";
            this.gatePartenzaDataGridViewTextBoxColumn.HeaderText = "Gate di Partenza";
            this.gatePartenzaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gatePartenzaDataGridViewTextBoxColumn.Name = "gatePartenzaDataGridViewTextBoxColumn";
            this.gatePartenzaDataGridViewTextBoxColumn.Width = 125;
            // 
            // durataDataGridViewTextBoxColumn
            // 
            this.durataDataGridViewTextBoxColumn.DataPropertyName = "Durata";
            this.durataDataGridViewTextBoxColumn.HeaderText = "Durata";
            this.durataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durataDataGridViewTextBoxColumn.Name = "durataDataGridViewTextBoxColumn";
            this.durataDataGridViewTextBoxColumn.Width = 125;
            // 
            // destinazioneDataGridViewTextBoxColumn
            // 
            this.destinazioneDataGridViewTextBoxColumn.DataPropertyName = "Destinazione";
            this.destinazioneDataGridViewTextBoxColumn.HeaderText = "Destinazione";
            this.destinazioneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinazioneDataGridViewTextBoxColumn.Name = "destinazioneDataGridViewTextBoxColumn";
            this.destinazioneDataGridViewTextBoxColumn.Width = 125;
            // 
            // codiceAereoDataGridViewTextBoxColumn
            // 
            this.codiceAereoDataGridViewTextBoxColumn.DataPropertyName = "CodiceAereo";
            this.codiceAereoDataGridViewTextBoxColumn.HeaderText = "Codice Aereo";
            this.codiceAereoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codiceAereoDataGridViewTextBoxColumn.Name = "codiceAereoDataGridViewTextBoxColumn";
            this.codiceAereoDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmVoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1428, 404);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dvgVoli);
            this.Controls.Add(this.btnFittizia);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnSalva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1446, 451);
            this.MinimumSize = new System.Drawing.Size(1446, 451);
            this.Name = "frmVoli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voli";
            this.Load += new System.EventHandler(this.frmVoli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgVoli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AeroportoDataSet aeroportoDataSet;

        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnFittizia;
        private System.Windows.Forms.DataGridView dvgVoli;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn expr8DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn expr9DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr11DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr12DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr14DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr15DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr16DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn expr17DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn expr18DataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource tblVoliBindingSource;
        private AeroportoDataSetTableAdapters.tblVoliTableAdapter tblVoliTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSalva;
        private System.Windows.Forms.ToolStripButton tsbNuovo;
        private System.Windows.Forms.ToolStripButton tsbModifica;
        private System.Windows.Forms.ToolStripButton tsbNascondi;
        private System.Windows.Forms.ToolStripButton tsbElimina;
        private System.Windows.Forms.ToolStripButton tsbVisualizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOraPartenzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOraArrivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn internazionaleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partenzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gatePartenzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinazioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceAereoDataGridViewTextBoxColumn;
    }
}