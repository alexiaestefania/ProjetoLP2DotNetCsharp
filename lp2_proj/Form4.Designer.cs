namespace lp2_proj
{
    partial class Form4
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PROFnasc = new System.Windows.Forms.MaskedTextBox();
            this.PROFtel = new System.Windows.Forms.MaskedTextBox();
            this.PROFcpf = new System.Windows.Forms.MaskedTextBox();
            this.PROFend = new System.Windows.Forms.TextBox();
            this.PROFnome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dBFITFREEV1DataSet8 = new lp2_proj.DBFITFREEV1DataSet8();
            this.pROFVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROFVIEWTableAdapter = new lp2_proj.DBFITFREEV1DataSet8TableAdapters.PROFVIEWTableAdapter();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereçoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gb1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBFITFREEV1DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Limpar Campos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar Cadastro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PROFnasc);
            this.panel1.Controls.Add(this.PROFtel);
            this.panel1.Controls.Add(this.PROFcpf);
            this.panel1.Controls.Add(this.PROFend);
            this.panel1.Controls.Add(this.PROFnome);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 294);
            this.panel1.TabIndex = 4;
            // 
            // PROFnasc
            // 
            this.PROFnasc.BackColor = System.Drawing.SystemColors.Window;
            this.PROFnasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PROFnasc.Location = new System.Drawing.Point(197, 187);
            this.PROFnasc.Mask = "00/00/0000";
            this.PROFnasc.Name = "PROFnasc";
            this.PROFnasc.Size = new System.Drawing.Size(71, 23);
            this.PROFnasc.TabIndex = 10;
            this.PROFnasc.ValidatingType = typeof(System.DateTime);
            // 
            // PROFtel
            // 
            this.PROFtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PROFtel.Location = new System.Drawing.Point(197, 141);
            this.PROFtel.Mask = "(99) 00000-0000";
            this.PROFtel.Name = "PROFtel";
            this.PROFtel.Size = new System.Drawing.Size(100, 23);
            this.PROFtel.TabIndex = 9;
            // 
            // PROFcpf
            // 
            this.PROFcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PROFcpf.Location = new System.Drawing.Point(197, 97);
            this.PROFcpf.Mask = "000000000-00";
            this.PROFcpf.Name = "PROFcpf";
            this.PROFcpf.Size = new System.Drawing.Size(100, 23);
            this.PROFcpf.TabIndex = 8;
            // 
            // PROFend
            // 
            this.PROFend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PROFend.Location = new System.Drawing.Point(197, 55);
            this.PROFend.Name = "PROFend";
            this.PROFend.Size = new System.Drawing.Size(316, 23);
            this.PROFend.TabIndex = 7;
            // 
            // PROFnome
            // 
            this.PROFnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PROFnome.Location = new System.Drawing.Point(197, 14);
            this.PROFnome.Name = "PROFnome";
            this.PROFnome.Size = new System.Drawing.Size(316, 23);
            this.PROFnome.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Nascimento:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 102);
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
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.panel1);
            this.gb1.Location = new System.Drawing.Point(12, 365);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(815, 347);
            this.gb1.TabIndex = 8;
            this.gb1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 357);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // dBFITFREEV1DataSet8
            // 
            this.dBFITFREEV1DataSet8.DataSetName = "DBFITFREEV1DataSet8";
            this.dBFITFREEV1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROFVIEWBindingSource
            // 
            this.pROFVIEWBindingSource.DataMember = "PROFVIEW";
            this.pROFVIEWBindingSource.DataSource = this.dBFITFREEV1DataSet8;
            // 
            // pROFVIEWTableAdapter
            // 
            this.pROFVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // endereçoDataGridViewTextBoxColumn
            // 
            this.endereçoDataGridViewTextBoxColumn.DataPropertyName = "Endereço";
            this.endereçoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.endereçoDataGridViewTextBoxColumn.Name = "endereçoDataGridViewTextBoxColumn";
            // 
            // dataDeNascimentoDataGridViewTextBoxColumn
            // 
            this.dataDeNascimentoDataGridViewTextBoxColumn.DataPropertyName = "Data de Nascimento";
            this.dataDeNascimentoDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento";
            this.dataDeNascimentoDataGridViewTextBoxColumn.Name = "dataDeNascimentoDataGridViewTextBoxColumn";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cPFDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataDeNascimentoDataGridViewTextBoxColumn,
            this.endereçoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pROFVIEWBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(230, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(578, 318);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(839, 715);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form4";
            this.Text = "FitFree -  Cadastro de Professores";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dBFITFREEV1DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox PROFnasc;
        private System.Windows.Forms.MaskedTextBox PROFtel;
        private System.Windows.Forms.MaskedTextBox PROFcpf;
        private System.Windows.Forms.TextBox PROFend;
        private System.Windows.Forms.TextBox PROFnome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DBFITFREEV1DataSet8 dBFITFREEV1DataSet8;
        private System.Windows.Forms.BindingSource pROFVIEWBindingSource;
        private DBFITFREEV1DataSet8TableAdapters.PROFVIEWTableAdapter pROFVIEWTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereçoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
    }
}