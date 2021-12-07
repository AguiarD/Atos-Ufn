
namespace WinFormsAppADONet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbLinguagem = new System.Windows.Forms.TextBox();
            this.txbBanco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txbConsultar = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConsultarId = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txbIdD = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbIdA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbBdA = new System.Windows.Forms.TextBox();
            this.txbLingA = new System.Windows.Forms.TextBox();
            this.txbNomeA = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(97, 66);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 23);
            this.txbNome.TabIndex = 1;
            // 
            // txbLinguagem
            // 
            this.txbLinguagem.Location = new System.Drawing.Point(97, 110);
            this.txbLinguagem.Name = "txbLinguagem";
            this.txbLinguagem.Size = new System.Drawing.Size(100, 23);
            this.txbLinguagem.TabIndex = 2;
            // 
            // txbBanco
            // 
            this.txbBanco.Location = new System.Drawing.Point(97, 156);
            this.txbBanco.Name = "txbBanco";
            this.txbBanco.Size = new System.Drawing.Size(100, 23);
            this.txbBanco.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Linguagem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Banco";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(487, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(236, 87);
            this.dataGridView1.TabIndex = 7;
            // 
            // txbConsultar
            // 
            this.txbConsultar.Location = new System.Drawing.Point(487, 67);
            this.txbConsultar.Name = "txbConsultar";
            this.txbConsultar.PlaceholderText = "Comando SQL";
            this.txbConsultar.Size = new System.Drawing.Size(100, 23);
            this.txbConsultar.TabIndex = 8;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(648, 66);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "1";
            // 
            // btnConsultarId
            // 
            this.btnConsultarId.Location = new System.Drawing.Point(55, 95);
            this.btnConsultarId.Name = "btnConsultarId";
            this.btnConsultarId.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarId.TabIndex = 12;
            this.btnConsultarId.Text = "Consultar";
            this.btnConsultarId.UseVisualStyleBackColor = true;
            this.btnConsultarId.Click += new System.EventHandler(this.btnConsultarId_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultarId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(258, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 146);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(31, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Consultar Todos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExcluir);
            this.groupBox3.Controls.Add(this.txbIdD);
            this.groupBox3.Location = new System.Drawing.Point(270, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Excluir";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(52, 61);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txbIdD
            // 
            this.txbIdD.Location = new System.Drawing.Point(52, 20);
            this.txbIdD.Name = "txbIdD";
            this.txbIdD.Size = new System.Drawing.Size(100, 23);
            this.txbIdD.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txbIdA);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txbBdA);
            this.groupBox4.Controls.Add(this.txbLingA);
            this.groupBox4.Controls.Add(this.txbNomeA);
            this.groupBox4.Controls.Add(this.btnAlterar);
            this.groupBox4.Location = new System.Drawing.Point(487, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(246, 208);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alteracao";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "ID";
            // 
            // txbIdA
            // 
            this.txbIdA.Location = new System.Drawing.Point(121, 21);
            this.txbIdA.Name = "txbIdA";
            this.txbIdA.Size = new System.Drawing.Size(100, 23);
            this.txbIdA.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Banco";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Linguagem";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nome";
            // 
            // txbBdA
            // 
            this.txbBdA.Location = new System.Drawing.Point(121, 128);
            this.txbBdA.Name = "txbBdA";
            this.txbBdA.Size = new System.Drawing.Size(100, 23);
            this.txbBdA.TabIndex = 10;
            // 
            // txbLingA
            // 
            this.txbLingA.Location = new System.Drawing.Point(121, 91);
            this.txbLingA.Name = "txbLingA";
            this.txbLingA.Size = new System.Drawing.Size(100, 23);
            this.txbLingA.TabIndex = 9;
            // 
            // txbNomeA
            // 
            this.txbNomeA.Location = new System.Drawing.Point(121, 50);
            this.txbNomeA.Name = "txbNomeA";
            this.txbNomeA.Size = new System.Drawing.Size(100, 23);
            this.txbNomeA.TabIndex = 8;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(102, 157);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(119, 25);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(13, 13);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(75, 23);
            this.btnForm2.TabIndex = 17;
            this.btnForm2.Text = "Form2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txbConsultar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbBanco);
            this.Controls.Add(this.txbLinguagem);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbLinguagem;
        private System.Windows.Forms.TextBox txbBanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txbConsultar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConsultarId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txbIdD;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbIdA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbBdA;
        private System.Windows.Forms.TextBox txbLingA;
        private System.Windows.Forms.TextBox txbNomeA;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnForm2;
    }
}

