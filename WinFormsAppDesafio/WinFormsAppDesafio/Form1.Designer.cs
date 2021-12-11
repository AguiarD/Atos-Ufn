
namespace WinFormsAppDesafio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAluno = new System.Windows.Forms.Button();
            this.dataG2 = new System.Windows.Forms.DataGridView();
            this.btnPessoa = new System.Windows.Forms.Button();
            this.dataG1 = new System.Windows.Forms.DataGridView();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.txbRg = new System.Windows.Forms.TextBox();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.txbMatricula = new System.Windows.Forms.TextBox();
            this.txbCdCurso = new System.Windows.Forms.TextBox();
            this.txbNCurso = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataG1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAluno);
            this.groupBox1.Controls.Add(this.dataG2);
            this.groupBox1.Controls.Add(this.btnPessoa);
            this.groupBox1.Controls.Add(this.dataG1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnAluno
            // 
            this.btnAluno.Location = new System.Drawing.Point(14, 190);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(75, 23);
            this.btnAluno.TabIndex = 5;
            this.btnAluno.Text = "Alunos";
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // dataG2
            // 
            this.dataG2.AllowUserToAddRows = false;
            this.dataG2.AllowUserToDeleteRows = false;
            this.dataG2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG2.Location = new System.Drawing.Point(97, 190);
            this.dataG2.Name = "dataG2";
            this.dataG2.ReadOnly = true;
            this.dataG2.RowTemplate.Height = 25;
            this.dataG2.Size = new System.Drawing.Size(658, 150);
            this.dataG2.TabIndex = 4;
            // 
            // btnPessoa
            // 
            this.btnPessoa.Location = new System.Drawing.Point(14, 22);
            this.btnPessoa.Name = "btnPessoa";
            this.btnPessoa.Size = new System.Drawing.Size(75, 23);
            this.btnPessoa.TabIndex = 3;
            this.btnPessoa.Text = "Pessoas";
            this.btnPessoa.UseVisualStyleBackColor = true;
            this.btnPessoa.Click += new System.EventHandler(this.btnPessoa_Click);
            // 
            // dataG1
            // 
            this.dataG1.AllowUserToAddRows = false;
            this.dataG1.AllowUserToDeleteRows = false;
            this.dataG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG1.Location = new System.Drawing.Point(97, 22);
            this.dataG1.Name = "dataG1";
            this.dataG1.ReadOnly = true;
            this.dataG1.RowTemplate.Height = 25;
            this.dataG1.Size = new System.Drawing.Size(658, 162);
            this.dataG1.TabIndex = 2;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(175, 365);
            this.txbNome.Multiline = true;
            this.txbNome.Name = "txbNome";
            this.txbNome.PlaceholderText = "Nome";
            this.txbNome.Size = new System.Drawing.Size(100, 22);
            this.txbNome.TabIndex = 1;
            this.txbNome.TextChanged += new System.EventHandler(this.txbPessoa_TextChanged);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(26, 394);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(309, 364);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.PlaceholderText = "Telefone";
            this.txbTelefone.Size = new System.Drawing.Size(100, 23);
            this.txbTelefone.TabIndex = 2;
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(445, 364);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.PlaceholderText = "Cidade";
            this.txbCidade.Size = new System.Drawing.Size(100, 23);
            this.txbCidade.TabIndex = 3;
            // 
            // txbRg
            // 
            this.txbRg.Location = new System.Drawing.Point(585, 364);
            this.txbRg.Name = "txbRg";
            this.txbRg.PlaceholderText = "Rg";
            this.txbRg.Size = new System.Drawing.Size(100, 23);
            this.txbRg.TabIndex = 4;
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(175, 415);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.PlaceholderText = "Cpf";
            this.txbCpf.Size = new System.Drawing.Size(100, 23);
            this.txbCpf.TabIndex = 5;
            // 
            // txbMatricula
            // 
            this.txbMatricula.Location = new System.Drawing.Point(309, 416);
            this.txbMatricula.Name = "txbMatricula";
            this.txbMatricula.PlaceholderText = "Matricula";
            this.txbMatricula.Size = new System.Drawing.Size(100, 23);
            this.txbMatricula.TabIndex = 6;
            // 
            // txbCdCurso
            // 
            this.txbCdCurso.Location = new System.Drawing.Point(445, 416);
            this.txbCdCurso.Name = "txbCdCurso";
            this.txbCdCurso.PlaceholderText = "Cod Curso";
            this.txbCdCurso.Size = new System.Drawing.Size(100, 23);
            this.txbCdCurso.TabIndex = 7;
            // 
            // txbNCurso
            // 
            this.txbNCurso.Location = new System.Drawing.Point(585, 415);
            this.txbNCurso.Name = "txbNCurso";
            this.txbNCurso.PlaceholderText = "Curso";
            this.txbNCurso.Size = new System.Drawing.Size(100, 23);
            this.txbNCurso.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbNCurso);
            this.Controls.Add(this.txbCdCurso);
            this.Controls.Add(this.txbMatricula);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.txbRg);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataG1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.DataGridView dataG2;
        private System.Windows.Forms.Button btnPessoa;
        private System.Windows.Forms.DataGridView dataG1;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.TextBox txbRg;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.TextBox txbMatricula;
        private System.Windows.Forms.TextBox txbCdCurso;
        private System.Windows.Forms.TextBox txbNCurso;
    }
}

