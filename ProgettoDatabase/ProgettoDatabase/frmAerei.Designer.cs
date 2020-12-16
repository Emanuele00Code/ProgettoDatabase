
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
            this.tblAereiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportoDataSet = new ProgettoDatabase.AeroportoDataSet();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnNuovo = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnFittizia = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tblAereiTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.tblAereiTableAdapter();
            this.codiceAereoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacitaMassimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.litriCarburanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroMotoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPropulsioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internazionaleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.raggioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velocitaMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compagniaAereaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAerei)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAereiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAerei
            // 
            this.dgvAerei.AutoGenerateColumns = false;
            this.dgvAerei.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAerei.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codiceAereoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
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
            this.dgvAerei.Location = new System.Drawing.Point(43, 74);
            this.dgvAerei.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAerei.MultiSelect = false;
            this.dgvAerei.Name = "dgvAerei";
            this.dgvAerei.RowHeadersWidth = 51;
            this.dgvAerei.Size = new System.Drawing.Size(1304, 185);
            this.dgvAerei.TabIndex = 0;
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
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.Brown;
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(43, 309);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(124, 44);
            this.btnSalva.TabIndex = 1;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(471, 309);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(197, 44);
            this.btnModifica.TabIndex = 2;
            this.btnModifica.Text = "MODIFICA";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnNuovo
            // 
            this.btnNuovo.BackColor = System.Drawing.Color.White;
            this.btnNuovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuovo.Location = new System.Drawing.Point(215, 309);
            this.btnNuovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(197, 44);
            this.btnNuovo.TabIndex = 3;
            this.btnNuovo.Text = "NUOVO";
            this.btnNuovo.UseVisualStyleBackColor = false;
            this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVisualizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizza.Location = new System.Drawing.Point(1150, 309);
            this.btnVisualizza.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(197, 44);
            this.btnVisualizza.TabIndex = 4;
            this.btnVisualizza.Text = "VISUALIZZA";
            this.btnVisualizza.UseVisualStyleBackColor = false;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.BackColor = System.Drawing.Color.White;
            this.btnElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.Location = new System.Drawing.Point(915, 309);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(215, 44);
            this.btnElimina.TabIndex = 5;
            this.btnElimina.Text = "ELIMINAZIONE VERA E PROPRIA";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnFittizia
            // 
            this.btnFittizia.BackColor = System.Drawing.Color.Brown;
            this.btnFittizia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFittizia.Location = new System.Drawing.Point(692, 309);
            this.btnFittizia.Name = "btnFittizia";
            this.btnFittizia.Size = new System.Drawing.Size(197, 43);
            this.btnFittizia.TabIndex = 6;
            this.btnFittizia.Text = "ELIMINAZIONE FITTIZIA";
            this.btnFittizia.UseVisualStyleBackColor = false;
            this.btnFittizia.Click += new System.EventHandler(this.btnFittizia_Click);
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
            // codiceAereoDataGridViewTextBoxColumn
            // 
            this.codiceAereoDataGridViewTextBoxColumn.DataPropertyName = "CodiceAereo";
            this.codiceAereoDataGridViewTextBoxColumn.HeaderText = "CodiceAereo";
            this.codiceAereoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codiceAereoDataGridViewTextBoxColumn.Name = "codiceAereoDataGridViewTextBoxColumn";
            this.codiceAereoDataGridViewTextBoxColumn.Width = 125;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelloDataGridViewTextBoxColumn
            // 
            this.modelloDataGridViewTextBoxColumn.DataPropertyName = "Modello";
            this.modelloDataGridViewTextBoxColumn.HeaderText = "Modello";
            this.modelloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelloDataGridViewTextBoxColumn.Name = "modelloDataGridViewTextBoxColumn";
            this.modelloDataGridViewTextBoxColumn.Width = 125;
            // 
            // capacitaMassimaDataGridViewTextBoxColumn
            // 
            this.capacitaMassimaDataGridViewTextBoxColumn.DataPropertyName = "CapacitaMassima";
            this.capacitaMassimaDataGridViewTextBoxColumn.HeaderText = "Capacita Massima";
            this.capacitaMassimaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacitaMassimaDataGridViewTextBoxColumn.Name = "capacitaMassimaDataGridViewTextBoxColumn";
            this.capacitaMassimaDataGridViewTextBoxColumn.Width = 125;
            // 
            // litriCarburanteDataGridViewTextBoxColumn
            // 
            this.litriCarburanteDataGridViewTextBoxColumn.DataPropertyName = "LitriCarburante";
            this.litriCarburanteDataGridViewTextBoxColumn.HeaderText = "Litri Carburante";
            this.litriCarburanteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.litriCarburanteDataGridViewTextBoxColumn.Name = "litriCarburanteDataGridViewTextBoxColumn";
            this.litriCarburanteDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroMotoriDataGridViewTextBoxColumn
            // 
            this.numeroMotoriDataGridViewTextBoxColumn.DataPropertyName = "NumeroMotori";
            this.numeroMotoriDataGridViewTextBoxColumn.HeaderText = "Numero Motori";
            this.numeroMotoriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroMotoriDataGridViewTextBoxColumn.Name = "numeroMotoriDataGridViewTextBoxColumn";
            this.numeroMotoriDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoPropulsioneDataGridViewTextBoxColumn
            // 
            this.tipoPropulsioneDataGridViewTextBoxColumn.DataPropertyName = "TipoPropulsione";
            this.tipoPropulsioneDataGridViewTextBoxColumn.HeaderText = "Tipo di Propulsione";
            this.tipoPropulsioneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoPropulsioneDataGridViewTextBoxColumn.Name = "tipoPropulsioneDataGridViewTextBoxColumn";
            this.tipoPropulsioneDataGridViewTextBoxColumn.Width = 125;
            // 
            // internazionaleDataGridViewCheckBoxColumn
            // 
            this.internazionaleDataGridViewCheckBoxColumn.DataPropertyName = "Internazionale";
            this.internazionaleDataGridViewCheckBoxColumn.HeaderText = "Internazionale";
            this.internazionaleDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.internazionaleDataGridViewCheckBoxColumn.Name = "internazionaleDataGridViewCheckBoxColumn";
            this.internazionaleDataGridViewCheckBoxColumn.Width = 125;
            // 
            // raggioDataGridViewTextBoxColumn
            // 
            this.raggioDataGridViewTextBoxColumn.DataPropertyName = "Raggio";
            this.raggioDataGridViewTextBoxColumn.HeaderText = "Raggio";
            this.raggioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.raggioDataGridViewTextBoxColumn.Name = "raggioDataGridViewTextBoxColumn";
            this.raggioDataGridViewTextBoxColumn.Width = 125;
            // 
            // velocitaMaxDataGridViewTextBoxColumn
            // 
            this.velocitaMaxDataGridViewTextBoxColumn.DataPropertyName = "VelocitaMax";
            this.velocitaMaxDataGridViewTextBoxColumn.HeaderText = "Velocita Max";
            this.velocitaMaxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.velocitaMaxDataGridViewTextBoxColumn.Name = "velocitaMaxDataGridViewTextBoxColumn";
            this.velocitaMaxDataGridViewTextBoxColumn.Width = 125;
            // 
            // compagniaAereaDataGridViewTextBoxColumn
            // 
            this.compagniaAereaDataGridViewTextBoxColumn.DataPropertyName = "CompagniaAerea";
            this.compagniaAereaDataGridViewTextBoxColumn.HeaderText = "Compagnia Aerea";
            this.compagniaAereaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.compagniaAereaDataGridViewTextBoxColumn.Name = "compagniaAereaDataGridViewTextBoxColumn";
            this.compagniaAereaDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmAerei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1428, 404);
            this.Controls.Add(this.btnFittizia);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnNuovo);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.dgvAerei);
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnNuovo;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnFittizia;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceAereoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
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