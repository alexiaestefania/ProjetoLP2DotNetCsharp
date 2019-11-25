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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
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
            this.profCadastrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fITFREEDBDataSet3 = new lp2_proj.FITFREEDBDataSet3();
            this.pROFVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFITFREEV1DataSet8 = new lp2_proj.DBFITFREEV1DataSet8();
            this.pROFVIEWTableAdapter = new lp2_proj.DBFITFREEV1DataSet8TableAdapters.PROFVIEWTableAdapter();
            this.profCadastrosTableAdapter = new lp2_proj.FITFREEDBDataSet3TableAdapters.ProfCadastrosTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profCadastrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITFREEDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFITFREEV1DataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(793, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Limpar Campos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(594, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar Cadastro";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::lp2_proj.Properties.Resources.fdf03373b9578db3ea13358a9b7473ed;
            this.panel1.Location = new System.Drawing.Point(-33, -32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 689);
            this.panel1.TabIndex = 4;
            // 
            // PROFnasc
            // 
            this.PROFnasc.BackColor = System.Drawing.SystemColors.Window;
            this.PROFnasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PROFnasc.Location = new System.Drawing.Point(704, 329);
            this.PROFnasc.Mask = "00/00/0000";
            this.PROFnasc.Name = "PROFnasc";
            this.PROFnasc.Size = new System.Drawing.Size(71, 23);
            this.PROFnasc.TabIndex = 10;
            this.PROFnasc.ValidatingType = typeof(System.DateTime);
            // 
            // PROFtel
            // 
            this.PROFtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PROFtel.Location = new System.Drawing.Point(704, 283);
            this.PROFtel.Mask = "(99) 00000-0000";
            this.PROFtel.Name = "PROFtel";
            this.PROFtel.Size = new System.Drawing.Size(100, 23);
            this.PROFtel.TabIndex = 9;
            // 
            // PROFcpf
            // 
            this.PROFcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PROFcpf.Location = new System.Drawing.Point(704, 239);
            this.PROFcpf.Mask = "000000000-00";
            this.PROFcpf.Name = "PROFcpf";
            this.PROFcpf.Size = new System.Drawing.Size(100, 23);
            this.PROFcpf.TabIndex = 8;
            // 
            // PROFend
            // 
            this.PROFend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PROFend.Location = new System.Drawing.Point(704, 197);
            this.PROFend.Name = "PROFend";
            this.PROFend.Size = new System.Drawing.Size(316, 23);
            this.PROFend.TabIndex = 7;
            // 
            // PROFnome
            // 
            this.PROFnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PROFnome.Location = new System.Drawing.Point(704, 156);
            this.PROFnome.Name = "PROFnome";
            this.PROFnome.Size = new System.Drawing.Size(316, 23);
            this.PROFnome.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(510, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Nascimento:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(510, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(510, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(510, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(510, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // profCadastrosBindingSource
            // 
            this.profCadastrosBindingSource.DataMember = "ProfCadastros";
            this.profCadastrosBindingSource.DataSource = this.fITFREEDBDataSet3;
            // 
            // fITFREEDBDataSet3
            // 
            this.fITFREEDBDataSet3.DataSetName = "FITFREEDBDataSet3";
            this.fITFREEDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROFVIEWBindingSource
            // 
            this.pROFVIEWBindingSource.DataMember = "PROFVIEW";
            this.pROFVIEWBindingSource.DataSource = this.dBFITFREEV1DataSet8;
            // 
            // dBFITFREEV1DataSet8
            // 
            this.dBFITFREEV1DataSet8.DataSetName = "DBFITFREEV1DataSet8";
            this.dBFITFREEV1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROFVIEWTableAdapter
            // 
            this.pROFVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // profCadastrosTableAdapter
            // 
            this.profCadastrosTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(524, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(483, 49);
            this.label10.TabIndex = 22;
            this.label10.Text = "CADASTRAR PROFESSOR";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = global::lp2_proj.Properties.Resources.preview_249306_t2du5CLepT_high_0014;
            this.ClientSize = new System.Drawing.Size(1032, 566);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PROFnasc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PROFtel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PROFcpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PROFend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PROFnome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "FitFree";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profCadastrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITFREEDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFITFREEV1DataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DBFITFREEV1DataSet8 dBFITFREEV1DataSet8;
        private System.Windows.Forms.BindingSource pROFVIEWBindingSource;
        private DBFITFREEV1DataSet8TableAdapters.PROFVIEWTableAdapter pROFVIEWTableAdapter;
        private FITFREEDBDataSet3 fITFREEDBDataSet3;
        private System.Windows.Forms.BindingSource profCadastrosBindingSource;
        private FITFREEDBDataSet3TableAdapters.ProfCadastrosTableAdapter profCadastrosTableAdapter;
        private System.Windows.Forms.Label label10;
    }
}