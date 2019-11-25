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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.cLIENTVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFITFREEV1DataSet7 = new lp2_proj.DBFITFREEV1DataSet7();
            this.cLIENTVIEWTableAdapter = new lp2_proj.DBFITFREEV1DataSet7TableAdapters.CLIENTVIEWTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFITFREEV1DataSet7)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackgroundImage = global::lp2_proj.Properties.Resources.b43799373adcfe4eb738048cdc8a447b;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(-65, -86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 912);
            this.panel2.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::lp2_proj.Properties.Resources.pngtree_creative_synthesis_neon_gradient_image_41603;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(473, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 906);
            this.panel1.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::lp2_proj.Properties.Resources.butt2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(328, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 26;
            this.button2.Text = "Excluir Cadastro";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::lp2_proj.Properties.Resources.butt2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(113, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 25;
            this.button1.Text = "Editar Cadastro";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(62, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(492, 49);
            this.label10.TabIndex = 21;
            this.label10.Text = "CLIENTES CADASTRADOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(1, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(602, 310);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endereçoDataGridViewTextBoxColumn
            // 
            this.endereçoDataGridViewTextBoxColumn.DataPropertyName = "Endereço";
            this.endereçoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.endereçoDataGridViewTextBoxColumn.Name = "endereçoDataGridViewTextBoxColumn";
            this.endereçoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "e-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "e-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDeNascimentoDataGridViewTextBoxColumn
            // 
            this.dataDeNascimentoDataGridViewTextBoxColumn.DataPropertyName = "Data de Nascimento";
            this.dataDeNascimentoDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento";
            this.dataDeNascimentoDataGridViewTextBoxColumn.Name = "dataDeNascimentoDataGridViewTextBoxColumn";
            this.dataDeNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDoAtestadoMédicoDataGridViewTextBoxColumn
            // 
            this.statusDoAtestadoMédicoDataGridViewTextBoxColumn.DataPropertyName = "Status do Atestado Médico";
            this.statusDoAtestadoMédicoDataGridViewTextBoxColumn.HeaderText = "Status do Atestado Médico";
            this.statusDoAtestadoMédicoDataGridViewTextBoxColumn.Name = "statusDoAtestadoMédicoDataGridViewTextBoxColumn";
            this.statusDoAtestadoMédicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vencimentoDoAtestadoMédicoDataGridViewTextBoxColumn
            // 
            this.vencimentoDoAtestadoMédicoDataGridViewTextBoxColumn.DataPropertyName = "Vencimento do Atestado Médico";
            this.vencimentoDoAtestadoMédicoDataGridViewTextBoxColumn.HeaderText = "Vencimento do Atestado Médico";
            this.vencimentoDoAtestadoMédicoDataGridViewTextBoxColumn.Name = "vencimentoDoAtestadoMédicoDataGridViewTextBoxColumn";
            this.vencimentoDoAtestadoMédicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // professorResponsávelDataGridViewTextBoxColumn
            // 
            this.professorResponsávelDataGridViewTextBoxColumn.DataPropertyName = "Professor Responsável";
            this.professorResponsávelDataGridViewTextBoxColumn.HeaderText = "Professor Responsável";
            this.professorResponsávelDataGridViewTextBoxColumn.Name = "professorResponsávelDataGridViewTextBoxColumn";
            this.professorResponsávelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1077, 591);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Fit Free";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFITFREEV1DataSet7)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}