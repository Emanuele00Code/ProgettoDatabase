
namespace TestDatabase
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
            this.components = new System.ComponentModel.Container();
            this.lblVoliMarconi = new System.Windows.Forms.Label();
            this.lblAereoPiuVoli = new System.Windows.Forms.Label();
            this.lblVoliPiuPasseggeri = new System.Windows.Forms.Label();
            this.lblVoliConPilota = new System.Windows.Forms.Label();
            this.lblVoliPiuIncasso = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stStripStatus = new System.Windows.Forms.StatusStrip();
            this.tstLabelOra = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codiceVoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeroportoArrivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwListaPasseggeriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportoDataSet = new TestDatabase.AeroportoDataSet();
            this.vwListaPasseggeriTableAdapter = new TestDatabase.AeroportoDataSetTableAdapters.vwListaPasseggeriTableAdapter();
            this.lblVoliArrivatiMarconi = new System.Windows.Forms.Label();
            this.vwNumeroVoliBolognaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwNumeroVoliBolognaTableAdapter = new TestDatabase.AeroportoDataSetTableAdapters.vwNumeroVoliBolognaTableAdapter();
            this.lblVoliPilotiBordo = new System.Windows.Forms.Label();
            this.vwVoliConPilotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwVoliConPilotaTableAdapter = new TestDatabase.AeroportoDataSetTableAdapters.vwVoliConPilotaTableAdapter();
            this.vwAereiConMaggiorNumeroVoliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwAereiConMaggiorNumeroVoliTableAdapter = new TestDatabase.AeroportoDataSetTableAdapters.vwAereiConMaggiorNumeroVoliTableAdapter();
            this.lblAereoMaggioriVoli = new System.Windows.Forms.Label();
            this.lblVoliMaggioriPasseggeri = new System.Windows.Forms.Label();
            this.lblVoliMaggioreIncasso = new System.Windows.Forms.Label();
            this.vwVoliConPiuIncasso = new System.Windows.Forms.BindingSource(this.components);
            this.vwVoliConPiuIncassoTableAdapter = new TestDatabase.AeroportoDataSetTableAdapters.vwVoliConPiuIncassoTableAdapter();
            this.vwVoliConPiuPasseggeri = new System.Windows.Forms.BindingSource(this.components);
            this.vwVoliConPiuPasseggeriTableAdapter = new TestDatabase.AeroportoDataSetTableAdapters.vwVoliConPiuPasseggeriTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.personeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stStripStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwListaPasseggeriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwNumeroVoliBolognaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwVoliConPilotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAereiConMaggiorNumeroVoliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwVoliConPiuIncasso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwVoliConPiuPasseggeri)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVoliMarconi
            // 
            this.lblVoliMarconi.AutoSize = true;
            this.lblVoliMarconi.Location = new System.Drawing.Point(57, 180);
            this.lblVoliMarconi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoliMarconi.Name = "lblVoliMarconi";
            this.lblVoliMarconi.Size = new System.Drawing.Size(151, 17);
            this.lblVoliMarconi.TabIndex = 6;
            this.lblVoliMarconi.Text = "Voli arrivati al Marconi ";
            // 
            // lblAereoPiuVoli
            // 
            this.lblAereoPiuVoli.AutoSize = true;
            this.lblAereoPiuVoli.Location = new System.Drawing.Point(57, 63);
            this.lblAereoPiuVoli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAereoPiuVoli.Name = "lblAereoPiuVoli";
            this.lblAereoPiuVoli.Size = new System.Drawing.Size(237, 17);
            this.lblAereoPiuVoli.TabIndex = 7;
            this.lblAereoPiuVoli.Text = "Aereo/i con il maggior numero di voli";
            // 
            // lblVoliPiuPasseggeri
            // 
            this.lblVoliPiuPasseggeri.AutoSize = true;
            this.lblVoliPiuPasseggeri.Location = new System.Drawing.Point(57, 123);
            this.lblVoliPiuPasseggeri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoliPiuPasseggeri.Name = "lblVoliPiuPasseggeri";
            this.lblVoliPiuPasseggeri.Size = new System.Drawing.Size(276, 17);
            this.lblVoliPiuPasseggeri.TabIndex = 8;
            this.lblVoliPiuPasseggeri.Text = "Volo/i con il maggior numero di passeggeri";
            // 
            // lblVoliConPilota
            // 
            this.lblVoliConPilota.AutoSize = true;
            this.lblVoliConPilota.Location = new System.Drawing.Point(57, 238);
            this.lblVoliConPilota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoliConPilota.Name = "lblVoliConPilota";
            this.lblVoliConPilota.Size = new System.Drawing.Size(144, 17);
            this.lblVoliConPilota.TabIndex = 9;
            this.lblVoliConPilota.Text = "Voli con piloti a bordo";
            // 
            // lblVoliPiuIncasso
            // 
            this.lblVoliPiuIncasso.AutoSize = true;
            this.lblVoliPiuIncasso.Location = new System.Drawing.Point(57, 298);
            this.lblVoliPiuIncasso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoliPiuIncasso.Name = "lblVoliPiuIncasso";
            this.lblVoliPiuIncasso.Size = new System.Drawing.Size(177, 17);
            this.lblVoliPiuIncasso.TabIndex = 10;
            this.lblVoliPiuIncasso.Text = "Volo/i con maggior incasso";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stStripStatus
            // 
            this.stStripStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstLabelOra});
            this.stStripStatus.Location = new System.Drawing.Point(0, 651);
            this.stStripStatus.Name = "stStripStatus";
            this.stStripStatus.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.stStripStatus.Size = new System.Drawing.Size(1351, 22);
            this.stStripStatus.TabIndex = 11;
            this.stStripStatus.Text = "statusStrip1";
            // 
            // tstLabelOra
            // 
            this.tstLabelOra.Name = "tstLabelOra";
            this.tstLabelOra.Size = new System.Drawing.Size(0, 16);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cognomeDataGridViewTextBoxColumn,
            this.codiceDataGridViewTextBoxColumn,
            this.codiceVoloDataGridViewTextBoxColumn,
            this.aeroportoArrivoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vwListaPasseggeriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(61, 369);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1212, 191);
            this.dataGridView1.TabIndex = 12;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            this.cognomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cognomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // codiceDataGridViewTextBoxColumn
            // 
            this.codiceDataGridViewTextBoxColumn.DataPropertyName = "Codice";
            this.codiceDataGridViewTextBoxColumn.HeaderText = "Codice";
            this.codiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codiceDataGridViewTextBoxColumn.Name = "codiceDataGridViewTextBoxColumn";
            this.codiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.codiceDataGridViewTextBoxColumn.Width = 125;
            // 
            // codiceVoloDataGridViewTextBoxColumn
            // 
            this.codiceVoloDataGridViewTextBoxColumn.DataPropertyName = "CodiceVolo";
            this.codiceVoloDataGridViewTextBoxColumn.HeaderText = "CodiceVolo";
            this.codiceVoloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codiceVoloDataGridViewTextBoxColumn.Name = "codiceVoloDataGridViewTextBoxColumn";
            this.codiceVoloDataGridViewTextBoxColumn.ReadOnly = true;
            this.codiceVoloDataGridViewTextBoxColumn.Width = 125;
            // 
            // aeroportoArrivoDataGridViewTextBoxColumn
            // 
            this.aeroportoArrivoDataGridViewTextBoxColumn.DataPropertyName = "AeroportoArrivo";
            this.aeroportoArrivoDataGridViewTextBoxColumn.HeaderText = "AeroportoArrivo";
            this.aeroportoArrivoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aeroportoArrivoDataGridViewTextBoxColumn.Name = "aeroportoArrivoDataGridViewTextBoxColumn";
            this.aeroportoArrivoDataGridViewTextBoxColumn.ReadOnly = true;
            this.aeroportoArrivoDataGridViewTextBoxColumn.Width = 125;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // vwListaPasseggeriBindingSource
            // 
            this.vwListaPasseggeriBindingSource.DataMember = "vwListaPasseggeri";
            this.vwListaPasseggeriBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.aeroportoDataSet;
            this.bindingSource1.Position = 0;
            // 
            // aeroportoDataSet
            // 
            this.aeroportoDataSet.DataSetName = "AeroportoDataSet";
            this.aeroportoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwListaPasseggeriTableAdapter
            // 
            this.vwListaPasseggeriTableAdapter.ClearBeforeFill = true;
            // 
            // lblVoliArrivatiMarconi
            // 
            this.lblVoliArrivatiMarconi.AutoSize = true;
            this.lblVoliArrivatiMarconi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwNumeroVoliBolognaBindingSource, "VoliBologna", true));
            this.lblVoliArrivatiMarconi.Location = new System.Drawing.Point(253, 180);
            this.lblVoliArrivatiMarconi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoliArrivatiMarconi.Name = "lblVoliArrivatiMarconi";
            this.lblVoliArrivatiMarconi.Size = new System.Drawing.Size(0, 17);
            this.lblVoliArrivatiMarconi.TabIndex = 13;
            // 
            // vwNumeroVoliBolognaBindingSource
            // 
            this.vwNumeroVoliBolognaBindingSource.DataMember = "vwNumeroVoliBologna";
            this.vwNumeroVoliBolognaBindingSource.DataSource = this.aeroportoDataSet;
            // 
            // vwNumeroVoliBolognaTableAdapter
            // 
            this.vwNumeroVoliBolognaTableAdapter.ClearBeforeFill = true;
            // 
            // lblVoliPilotiBordo
            // 
            this.lblVoliPilotiBordo.AutoSize = true;
            this.lblVoliPilotiBordo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwVoliConPilotaBindingSource, "VoliConPilota", true));
            this.lblVoliPilotiBordo.Location = new System.Drawing.Point(233, 238);
            this.lblVoliPilotiBordo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoliPilotiBordo.Name = "lblVoliPilotiBordo";
            this.lblVoliPilotiBordo.Size = new System.Drawing.Size(0, 17);
            this.lblVoliPilotiBordo.TabIndex = 14;
            // 
            // vwVoliConPilotaBindingSource
            // 
            this.vwVoliConPilotaBindingSource.DataMember = "vwVoliConPilota";
            this.vwVoliConPilotaBindingSource.DataSource = this.aeroportoDataSet;
            // 
            // vwVoliConPilotaTableAdapter
            // 
            this.vwVoliConPilotaTableAdapter.ClearBeforeFill = true;
            // 
            // vwAereiConMaggiorNumeroVoliBindingSource
            // 
            this.vwAereiConMaggiorNumeroVoliBindingSource.DataMember = "vwAereiConMaggiorNumeroVoli";
            this.vwAereiConMaggiorNumeroVoliBindingSource.DataSource = this.aeroportoDataSet;
            // 
            // vwAereiConMaggiorNumeroVoliTableAdapter
            // 
            this.vwAereiConMaggiorNumeroVoliTableAdapter.ClearBeforeFill = true;
            // 
            // lblAereoMaggioriVoli
            // 
            this.lblAereoMaggioriVoli.AutoSize = true;
            this.lblAereoMaggioriVoli.Location = new System.Drawing.Point(355, 63);
            this.lblAereoMaggioriVoli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAereoMaggioriVoli.Name = "lblAereoMaggioriVoli";
            this.lblAereoMaggioriVoli.Size = new System.Drawing.Size(0, 17);
            this.lblAereoMaggioriVoli.TabIndex = 15;
            // 
            // lblVoliMaggioriPasseggeri
            // 
            this.lblVoliMaggioriPasseggeri.AutoSize = true;
            this.lblVoliMaggioriPasseggeri.Location = new System.Drawing.Point(375, 122);
            this.lblVoliMaggioriPasseggeri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoliMaggioriPasseggeri.Name = "lblVoliMaggioriPasseggeri";
            this.lblVoliMaggioriPasseggeri.Size = new System.Drawing.Size(0, 17);
            this.lblVoliMaggioriPasseggeri.TabIndex = 16;
            // 
            // lblVoliMaggioreIncasso
            // 
            this.lblVoliMaggioreIncasso.AutoSize = true;
            this.lblVoliMaggioreIncasso.Location = new System.Drawing.Point(285, 298);
            this.lblVoliMaggioreIncasso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoliMaggioreIncasso.Name = "lblVoliMaggioreIncasso";
            this.lblVoliMaggioreIncasso.Size = new System.Drawing.Size(0, 17);
            this.lblVoliMaggioreIncasso.TabIndex = 17;
            // 
            // vwVoliConPiuIncasso
            // 
            this.vwVoliConPiuIncasso.DataMember = "vwVoliConPiuIncasso";
            this.vwVoliConPiuIncasso.DataSource = this.aeroportoDataSet;
            // 
            // vwVoliConPiuIncassoTableAdapter
            // 
            this.vwVoliConPiuIncassoTableAdapter.ClearBeforeFill = true;
            // 
            // vwVoliConPiuPasseggeri
            // 
            this.vwVoliConPiuPasseggeri.DataMember = "vwVoliConPiuPasseggeri";
            this.vwVoliConPiuPasseggeri.DataSource = this.aeroportoDataSet;
            // 
            // vwVoliConPiuPasseggeriTableAdapter
            // 
            this.vwVoliConPiuPasseggeriTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1351, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personeToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(120, 26);
            this.toolStripMenuItem2.Text = "Apri";
            // 
            // personeToolStripMenuItem
            // 
            this.personeToolStripMenuItem.Name = "personeToolStripMenuItem";
            this.personeToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.personeToolStripMenuItem.Text = "Persone";
            this.personeToolStripMenuItem.Click += new System.EventHandler(this.personeToolStripMenuItem_Click);
            // 
            // frmAvvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 673);
            this.Controls.Add(this.lblVoliMaggioreIncasso);
            this.Controls.Add(this.lblVoliMaggioriPasseggeri);
            this.Controls.Add(this.lblAereoMaggioriVoli);
            this.Controls.Add(this.lblVoliPilotiBordo);
            this.Controls.Add(this.lblVoliArrivatiMarconi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.stStripStatus);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblVoliPiuIncasso);
            this.Controls.Add(this.lblVoliConPilota);
            this.Controls.Add(this.lblVoliPiuPasseggeri);
            this.Controls.Add(this.lblAereoPiuVoli);
            this.Controls.Add(this.lblVoliMarconi);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAvvio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avvio";
            this.Load += new System.EventHandler(this.frmAvvio_Load);
            this.stStripStatus.ResumeLayout(false);
            this.stStripStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwListaPasseggeriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwNumeroVoliBolognaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwVoliConPilotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAereiConMaggiorNumeroVoliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwVoliConPiuIncasso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwVoliConPiuPasseggeri)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVoliMarconi;
        private System.Windows.Forms.Label lblAereoPiuVoli;
        private System.Windows.Forms.Label lblVoliPiuPasseggeri;
        private System.Windows.Forms.Label lblVoliConPilota;
        private System.Windows.Forms.Label lblVoliPiuIncasso;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip stStripStatus;
        private System.Windows.Forms.ToolStripStatusLabel tstLabelOra;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AeroportoDataSet aeroportoDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vwListaPasseggeriBindingSource;
        private AeroportoDataSetTableAdapters.vwListaPasseggeriTableAdapter vwListaPasseggeriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceVoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroportoArrivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblVoliArrivatiMarconi;
        private System.Windows.Forms.BindingSource vwNumeroVoliBolognaBindingSource;
        private AeroportoDataSetTableAdapters.vwNumeroVoliBolognaTableAdapter vwNumeroVoliBolognaTableAdapter;
        private System.Windows.Forms.Label lblVoliPilotiBordo;
        private System.Windows.Forms.BindingSource vwVoliConPilotaBindingSource;
        private AeroportoDataSetTableAdapters.vwVoliConPilotaTableAdapter vwVoliConPilotaTableAdapter;
        private System.Windows.Forms.BindingSource vwAereiConMaggiorNumeroVoliBindingSource;
        private AeroportoDataSetTableAdapters.vwAereiConMaggiorNumeroVoliTableAdapter vwAereiConMaggiorNumeroVoliTableAdapter;
        private System.Windows.Forms.Label lblAereoMaggioriVoli;
        private System.Windows.Forms.Label lblVoliMaggioriPasseggeri;
        private System.Windows.Forms.Label lblVoliMaggioreIncasso;
        private System.Windows.Forms.BindingSource vwVoliConPiuIncasso;
        private AeroportoDataSetTableAdapters.vwVoliConPiuIncassoTableAdapter vwVoliConPiuIncassoTableAdapter;
        private System.Windows.Forms.BindingSource vwVoliConPiuPasseggeri;
        private AeroportoDataSetTableAdapters.vwVoliConPiuPasseggeriTableAdapter vwVoliConPiuPasseggeriTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem personeToolStripMenuItem;
    }
}

