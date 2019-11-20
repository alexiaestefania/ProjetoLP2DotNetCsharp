namespace lp2_proj
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereçoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDoAtestadoMédicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimentoDoAtestadoMédicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorResponsávelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFITFREEV1DataSet7 = new lp2_proj.DBFITFREEV1DataSet7();
            this.cLIENTVIEWTableAdapter = new lp2_proj.DBFITFREEV1DataSet7TableAdapters.CLIENTVIEWTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFITFREEV1DataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.endereçoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dataDeNascimentoDataGridViewTextBoxColumn,
            this.statusDoAtestadoMédicoDataGridViewTextBoxColumn,
            this.vencimentoDoAtestadoMédicoDataGridViewTextBoxColumn,
            this.professorResponsávelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLIENTVIEWBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1049, 474);
            this.dataGridView1.TabIndex = 0;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            // 
            // endereçoDataGridViewTextBoxColumn
            // 
            this.endereçoDataGridViewTextBoxColumn.DataPropertyName = "Endereço";
            this.endereçoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.endereçoDataGridViewTextBoxColumn.Name = "endereçoDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "e-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "e-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // dataDeNascimentoDataGridViewTextBoxColumn
            // 
            this.dataDeNascimentoDataGridViewTextBoxColumn.DataPropertyName = "Data de Nascimento";
            this.dataDeNascimentoDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento";
            this.dataDeNascimentoDataGridViewTextBoxColumn.Name = "dataDeNascimentoDataGridViewTextBoxColumn";
            // 
            // statusDoAtestadoMédicoDataGridViewTextBoxColumn
            // 
            this.statusDoAtestadoMédicoDataGridViewTextBoxColumn.DataPropertyName = "Status do Atestado Médico";
            this.statusDoAtestadoMédicoDataGridViewTextBoxColumn.HeaderText = "Status do Atestado Médico";
            this.statusDoAtestadoMédicoDataGridViewTextBoxColumn.Name = "statusDoAtestadoMédicoDataGridViewTextBoxColumn";
            // 
            // vencimentoDoAtestadoMédicoDataGridViewTextBoxColumn
            // 
            this.vencimentoDoAtestadoMédicoDataGridViewTextBoxColumn.DataPropertyName = "Vencimento do Atestado Médico";
            this.vencimentoDoAtestadoMédicoDataGridViewTextBoxColumn.HeaderText = "Vencimento do Atestado Médico";
            this.vencimentoDoAtestadoMédicoDataGridViewTextBoxColumn.Name = "vencimentoDoAtestadoMédicoDataGridViewTextBoxColumn";
            // 
            // professorResponsávelDataGridViewTextBoxColumn
            // 
            this.professorResponsávelDataGridViewTextBoxColumn.DataPropertyName = "Professor Responsável";
            this.professorResponsávelDataGridViewTextBoxColumn.HeaderText = "Professor Responsável";
            this.professorResponsávelDataGridViewTextBoxColumn.Name = "professorResponsávelDataGridViewTextBoxColumn";
            // 
            // cLIENTVIEWBindingSource
            // 
            this.cLIENTVIEWBindingSource.DataMember = "CLIENTVIEW";
            this.cLIENTVIEWBindingSource.DataSource = this.dBFITFREEV1DataSet7;
            // 
            // dBFITFREEV1DataSet7
            // 
            this.dBFITFREEV1DataSet7.DataSetName = "DBFITFREEV1DataSet7";
            this.dBFITFREEV1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTVIEWTableAdapter
            // 
            this.cLIENTVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1310, 918);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form3";
            this.Text = "Fit Free - Consulta de Clientes";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFITFREEV1DataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DBFITFREEV1DataSet7 dBFITFREEV1DataSet7;
        private System.Windows.Forms.BindingSource cLIENTVIEWBindingSource;
        private DBFITFREEV1DataSet7TableAdapters.CLIENTVIEWTableAdapter cLIENTVIEWTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereçoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDoAtestadoMédicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimentoDoAtestadoMédicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorResponsávelDataGridViewTextBoxColumn;
    }
}