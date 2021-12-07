
namespace WinFormsAppADONet
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txbConsultaId = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txbBancoInc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbLingInc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNomeInc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbIdAlt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txbBancoAlt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbLingAlt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNomeAlt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.txbConsultaId);
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 352);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabela";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(6, 61);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txbConsultaId
            // 
            this.txbConsultaId.Location = new System.Drawing.Point(87, 62);
            this.txbConsultaId.Name = "txbConsultaId";
            this.txbConsultaId.Size = new System.Drawing.Size(100, 23);
            this.txbConsultaId.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(7, 23);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(461, 255);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIncluir);
            this.groupBox2.Controls.Add(this.txbBancoInc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txbLingInc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txbNomeInc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(557, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inclusão";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(64, 109);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txbBancoInc
            // 
            this.txbBancoInc.Location = new System.Drawing.Point(94, 80);
            this.txbBancoInc.Name = "txbBancoInc";
            this.txbBancoInc.Size = new System.Drawing.Size(100, 23);
            this.txbBancoInc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Banco";
            // 
            // txbLingInc
            // 
            this.txbLingInc.Location = new System.Drawing.Point(94, 51);
            this.txbLingInc.Name = "txbLingInc";
            this.txbLingInc.Size = new System.Drawing.Size(100, 23);
            this.txbLingInc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Linguagem";
            // 
            // txbNomeInc
            // 
            this.txbNomeInc.Location = new System.Drawing.Point(94, 22);
            this.txbNomeInc.Name = "txbNomeInc";
            this.txbNomeInc.Size = new System.Drawing.Size(100, 23);
            this.txbNomeInc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbIdAlt);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnAlterar);
            this.groupBox3.Controls.Add(this.txbBancoAlt);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txbLingAlt);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txbNomeAlt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(557, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 162);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alteração";
            // 
            // txbIdAlt
            // 
            this.txbIdAlt.Location = new System.Drawing.Point(94, 17);
            this.txbIdAlt.Name = "txbIdAlt";
            this.txbIdAlt.Size = new System.Drawing.Size(100, 23);
            this.txbIdAlt.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "ID";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(64, 133);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txbBancoAlt
            // 
            this.txbBancoAlt.Location = new System.Drawing.Point(94, 104);
            this.txbBancoAlt.Name = "txbBancoAlt";
            this.txbBancoAlt.Size = new System.Drawing.Size(100, 23);
            this.txbBancoAlt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Banco";
            // 
            // txbLingAlt
            // 
            this.txbLingAlt.Location = new System.Drawing.Point(94, 75);
            this.txbLingAlt.Name = "txbLingAlt";
            this.txbLingAlt.Size = new System.Drawing.Size(100, 23);
            this.txbLingAlt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Linguagem";
            // 
            // txbNomeAlt
            // 
            this.txbNomeAlt.Location = new System.Drawing.Point(94, 46);
            this.txbNomeAlt.Name = "txbNomeAlt";
            this.txbNomeAlt.Size = new System.Drawing.Size(100, 23);
            this.txbNomeAlt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nome";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txbBancoInc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbLingInc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNomeInc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txbIdAlt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txbBancoAlt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbLingAlt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNomeAlt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txbConsultaId;
    }
}