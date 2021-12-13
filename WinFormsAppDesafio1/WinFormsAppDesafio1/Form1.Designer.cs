
namespace WinFormsAppDesafio1
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
            this.gBDesafio1 = new System.Windows.Forms.GroupBox();
            this.btnContPessoas = new System.Windows.Forms.Button();
            this.btnContAluno = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnPessoa = new System.Windows.Forms.Button();
            this.dataGListar = new System.Windows.Forms.DataGridView();
            this.gBDesafio1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGListar)).BeginInit();
            this.SuspendLayout();
            // 
            // gBDesafio1
            // 
            this.gBDesafio1.Controls.Add(this.btnContPessoas);
            this.gBDesafio1.Controls.Add(this.btnContAluno);
            this.gBDesafio1.Controls.Add(this.btnImportar);
            this.gBDesafio1.Controls.Add(this.btnAluno);
            this.gBDesafio1.Controls.Add(this.btnPessoa);
            this.gBDesafio1.Controls.Add(this.dataGListar);
            this.gBDesafio1.Location = new System.Drawing.Point(12, 12);
            this.gBDesafio1.Name = "gBDesafio1";
            this.gBDesafio1.Size = new System.Drawing.Size(649, 361);
            this.gBDesafio1.TabIndex = 0;
            this.gBDesafio1.TabStop = false;
            this.gBDesafio1.Text = "Desafio1";
            // 
            // btnContPessoas
            // 
            this.btnContPessoas.Location = new System.Drawing.Point(18, 277);
            this.btnContPessoas.Name = "btnContPessoas";
            this.btnContPessoas.Size = new System.Drawing.Size(75, 23);
            this.btnContPessoas.TabIndex = 5;
            this.btnContPessoas.Text = "C. Pessoas";
            this.btnContPessoas.UseVisualStyleBackColor = true;
            this.btnContPessoas.Click += new System.EventHandler(this.btnContPessoas_Click);
            // 
            // btnContAluno
            // 
            this.btnContAluno.Location = new System.Drawing.Point(18, 311);
            this.btnContAluno.Name = "btnContAluno";
            this.btnContAluno.Size = new System.Drawing.Size(75, 23);
            this.btnContAluno.TabIndex = 4;
            this.btnContAluno.Text = "C. Aluno";
            this.btnContAluno.UseVisualStyleBackColor = true;
            this.btnContAluno.Click += new System.EventHandler(this.btnContAluno_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(18, 134);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.Location = new System.Drawing.Point(18, 82);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(75, 23);
            this.btnAluno.TabIndex = 2;
            this.btnAluno.Text = "Aluno";
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // btnPessoa
            // 
            this.btnPessoa.Location = new System.Drawing.Point(18, 32);
            this.btnPessoa.Name = "btnPessoa";
            this.btnPessoa.Size = new System.Drawing.Size(75, 23);
            this.btnPessoa.TabIndex = 1;
            this.btnPessoa.Text = "Pessoa";
            this.btnPessoa.UseVisualStyleBackColor = true;
            this.btnPessoa.Click += new System.EventHandler(this.btnPessoa_Click);
            // 
            // dataGListar
            // 
            this.dataGListar.AllowUserToAddRows = false;
            this.dataGListar.AllowUserToDeleteRows = false;
            this.dataGListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGListar.Location = new System.Drawing.Point(105, 32);
            this.dataGListar.Name = "dataGListar";
            this.dataGListar.ReadOnly = true;
            this.dataGListar.RowTemplate.Height = 25;
            this.dataGListar.Size = new System.Drawing.Size(521, 302);
            this.dataGListar.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBDesafio1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBDesafio1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGListar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBDesafio1;
        private System.Windows.Forms.Button btnPessoa;
        private System.Windows.Forms.DataGridView dataGListar;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnContAluno;
        private System.Windows.Forms.Button btnContPessoas;
    }
}

