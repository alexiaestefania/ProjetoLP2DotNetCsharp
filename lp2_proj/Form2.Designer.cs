namespace lp2_proj
{
    partial class Form2
    {
        
        private System.ComponentModel.IContainer components = null;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBvenc = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.medbutton2 = new System.Windows.Forms.RadioButton();
            this.medbutton = new System.Windows.Forms.RadioButton();
            this.TBemail = new System.Windows.Forms.TextBox();
            this.TBnasc = new System.Windows.Forms.MaskedTextBox();
            this.TBtel = new System.Windows.Forms.MaskedTextBox();
            this.TBCPF = new System.Windows.Forms.MaskedTextBox();
            this.TBender = new System.Windows.Forms.TextBox();
            this.TBnome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROFCPFBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBFITFREEV1DataSet6 = new lp2_proj.DBFITFREEV1DataSet6();
            this.TBprof = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dBFITFREEV1DataSet4 = new lp2_proj.DBFITFREEV1DataSet4();
            this.pROFCPFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROFCPFTableAdapter = new lp2_proj.DBFITFREEV1DataSet4TableAdapters.PROFCPFTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pROFCPFTableAdapter1 = new lp2_proj.DBFITFREEV1DataSet6TableAdapters.PROFCPFTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFCPFBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFITFREEV1DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFITFREEV1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFCPFBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.TBvenc);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.medbutton2);
            this.panel1.Controls.Add(this.medbutton);
            this.panel1.Controls.Add(this.TBemail);
            this.panel1.Controls.Add(this.TBnasc);
            this.panel1.Controls.Add(this.TBtel);
            this.panel1.Controls.Add(this.TBCPF);
            this.panel1.Controls.Add(this.TBender);
            this.panel1.Controls.Add(this.TBnome);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 265);
            this.panel1.TabIndex = 0;
            // 
            // TBvenc
            // 
            this.TBvenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TBvenc.Location = new System.Drawing.Point(197, 224);
            this.TBvenc.Mask = "00/00/0000";
            this.TBvenc.Name = "TBvenc";
            this.TBvenc.Size = new System.Drawing.Size(71, 23);
            this.TBvenc.TabIndex = 16;
            this.TBvenc.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Validade do Atestado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Atestado Médico:";
            // 
            // medbutton2
            // 
            this.medbutton2.AutoSize = true;
            this.medbutton2.Location = new System.Drawing.Point(274, 197);
            this.medbutton2.Name = "medbutton2";
            this.medbutton2.Size = new System.Drawing.Size(71, 17);
            this.medbutton2.TabIndex = 13;
            this.medbutton2.Text = "Pendente";
            this.medbutton2.UseVisualStyleBackColor = true;
            // 
            // medbutton
            // 
            this.medbutton.AutoSize = true;
            this.medbutton.Location = new System.Drawing.Point(197, 197);
            this.medbutton.Name = "medbutton";
            this.medbutton.Size = new System.Drawing.Size(71, 17);
            this.medbutton.TabIndex = 12;
            this.medbutton.Text = "Aprovado";
            this.medbutton.UseVisualStyleBackColor = true;
            // 
            // TBemail
            // 
            this.TBemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TBemail.Location = new System.Drawing.Point(197, 164);
            this.TBemail.Name = "TBemail";
            this.TBemail.Size = new System.Drawing.Size(316, 23);
            this.TBemail.TabIndex = 11;
            // 
            // TBnasc
            // 
            this.TBnasc.BackColor = System.Drawing.SystemColors.Window;
            this.TBnasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TBnasc.Location = new System.Drawing.Point(197, 106);
            this.TBnasc.Mask = "00/00/0000";
            this.TBnasc.Name = "TBnasc";
            this.TBnasc.Size = new System.Drawing.Size(71, 23);
            this.TBnasc.TabIndex = 10;
            this.TBnasc.ValidatingType = typeof(System.DateTime);
            // 
            // TBtel
            // 
            this.TBtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TBtel.Location = new System.Drawing.Point(197, 135);
            this.TBtel.Mask = "(99) 00000-0000";
            this.TBtel.Name = "TBtel";
            this.TBtel.Size = new System.Drawing.Size(100, 23);
            this.TBtel.TabIndex = 9;
            // 
            // TBCPF
            // 
            this.TBCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TBCPF.Location = new System.Drawing.Point(197, 77);
            this.TBCPF.Mask = "000000000-00";
            this.TBCPF.Name = "TBCPF";
            this.TBCPF.Size = new System.Drawing.Size(100, 23);
            this.TBCPF.TabIndex = 8;
            // 
            // TBender
            // 
            this.TBender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TBender.Location = new System.Drawing.Point(197, 48);
            this.TBender.Name = "TBender";
            this.TBender.Size = new System.Drawing.Size(316, 23);
            this.TBender.TabIndex = 7;
            this.TBender.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TBnome
            // 
            this.TBnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TBnome.Location = new System.Drawing.Point(197, 19);
            this.TBnome.Name = "TBnome";
            this.TBnome.Size = new System.Drawing.Size(316, 23);
            this.TBnome.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Endereço de e-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.TBprof);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(12, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 120);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pROFCPFBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(274, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(298, 80);
            this.dataGridView1.TabIndex = 19;
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
            // pROFCPFBindingSource1
            // 
            this.pROFCPFBindingSource1.DataMember = "PROFCPF";
            this.pROFCPFBindingSource1.DataSource = this.dBFITFREEV1DataSet6;
            // 
            // dBFITFREEV1DataSet6
            // 
            this.dBFITFREEV1DataSet6.DataSetName = "DBFITFREEV1DataSet6";
            this.dBFITFREEV1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBprof
            // 
            this.TBprof.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TBprof.Location = new System.Drawing.Point(56, 56);
            this.TBprof.Mask = "000000000-00";
            this.TBprof.Name = "TBprof";
            this.TBprof.Size = new System.Drawing.Size(100, 23);
            this.TBprof.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Professor Responsável:";
            // 
            // dBFITFREEV1DataSet4
            // 
            this.dBFITFREEV1DataSet4.DataSetName = "DBFITFREEV1DataSet4";
            this.dBFITFREEV1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROFCPFBindingSource
            // 
            this.pROFCPFBindingSource.DataMember = "PROFCPF";
            this.pROFCPFBindingSource.DataSource = this.dBFITFREEV1DataSet4;
            // 
            // pROFCPFTableAdapter
            // 
            this.pROFCPFTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salvar Cadastro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Limpar Campos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pROFCPFTableAdapter1
            // 
            this.pROFCPFTableAdapter1.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(616, 544);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "FitFree - Novo Cliente";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFCPFBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFITFREEV1DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFITFREEV1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFCPFBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox TBCPF;
        private System.Windows.Forms.TextBox TBender;
        private System.Windows.Forms.TextBox TBnome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TBnasc;
        private System.Windows.Forms.MaskedTextBox TBtel;
        private System.Windows.Forms.MaskedTextBox TBvenc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton medbutton2;
        private System.Windows.Forms.RadioButton medbutton;
        private System.Windows.Forms.TextBox TBemail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox TBprof;
        private System.Windows.Forms.Label label9;
        private DBFITFREEV1DataSet4 dBFITFREEV1DataSet4;
        private System.Windows.Forms.BindingSource pROFCPFBindingSource;
        private DBFITFREEV1DataSet4TableAdapters.PROFCPFTableAdapter pROFCPFTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DBFITFREEV1DataSet6 dBFITFREEV1DataSet6;
        private System.Windows.Forms.BindingSource pROFCPFBindingSource1;
        private DBFITFREEV1DataSet6TableAdapters.PROFCPFTableAdapter pROFCPFTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
    }
}