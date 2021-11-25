
namespace WinFormsAula01AtosUFN
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNum2 = new System.Windows.Forms.TextBox();
            this.groupBoxMostrarNome = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelExibirResultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNum1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.txbNumero2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbNumero1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVerificarIdade = new System.Windows.Forms.Button();
            this.labelNao = new System.Windows.Forms.Label();
            this.labelSim = new System.Windows.Forms.Label();
            this.labelMaiorIdade = new System.Windows.Forms.Label();
            this.txbIdadeNome = new System.Windows.Forms.TextBox();
            this.txbNomeIdade = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEsquerda = new System.Windows.Forms.Button();
            this.btnDireita = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.groupBoxMostrarNome.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Green;
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmar.Location = new System.Drawing.Point(69, 138);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 25);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(69, 69);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 23);
            this.txbNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(69, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira o Nome";
            // 
            // txbNum2
            // 
            this.txbNum2.Location = new System.Drawing.Point(73, 110);
            this.txbNum2.Name = "txbNum2";
            this.txbNum2.Size = new System.Drawing.Size(100, 23);
            this.txbNum2.TabIndex = 3;
            // 
            // groupBoxMostrarNome
            // 
            this.groupBoxMostrarNome.Controls.Add(this.label1);
            this.groupBoxMostrarNome.Controls.Add(this.btnConfirmar);
            this.groupBoxMostrarNome.Controls.Add(this.txbNome);
            this.groupBoxMostrarNome.Location = new System.Drawing.Point(58, 37);
            this.groupBoxMostrarNome.Name = "groupBoxMostrarNome";
            this.groupBoxMostrarNome.Size = new System.Drawing.Size(232, 185);
            this.groupBoxMostrarNome.TabIndex = 4;
            this.groupBoxMostrarNome.TabStop = false;
            this.groupBoxMostrarNome.Text = "Mostrar Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelExibirResultado);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txbNum2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbNum1);
            this.groupBox1.Location = new System.Drawing.Point(313, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 213);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Somar";
            // 
            // labelExibirResultado
            // 
            this.labelExibirResultado.AutoSize = true;
            this.labelExibirResultado.Location = new System.Drawing.Point(73, 185);
            this.labelExibirResultado.Name = "labelExibirResultado";
            this.labelExibirResultado.Size = new System.Drawing.Size(0, 15);
            this.labelExibirResultado.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor 1";
            // 
            // txbNum1
            // 
            this.txbNum1.Location = new System.Drawing.Point(73, 50);
            this.txbNum1.Name = "txbNum1";
            this.txbNum1.Size = new System.Drawing.Size(100, 23);
            this.txbNum1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnSomar);
            this.groupBox2.Controls.Add(this.txbNumero2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txbNumero1);
            this.groupBox2.Location = new System.Drawing.Point(58, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 213);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Somar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 5;
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(73, 149);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(100, 23);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "Calcular";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbNumero2
            // 
            this.txbNumero2.Location = new System.Drawing.Point(73, 110);
            this.txbNumero2.Name = "txbNumero2";
            this.txbNumero2.Size = new System.Drawing.Size(100, 23);
            this.txbNumero2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Valor 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Valor 1";
            // 
            // txbNumero1
            // 
            this.txbNumero1.Location = new System.Drawing.Point(73, 50);
            this.txbNumero1.Name = "txbNumero1";
            this.txbNumero1.Size = new System.Drawing.Size(100, 23);
            this.txbNumero1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVerificarIdade);
            this.groupBox3.Controls.Add(this.labelNao);
            this.groupBox3.Controls.Add(this.labelSim);
            this.groupBox3.Controls.Add(this.labelMaiorIdade);
            this.groupBox3.Controls.Add(this.txbIdadeNome);
            this.groupBox3.Controls.Add(this.txbNomeIdade);
            this.groupBox3.Location = new System.Drawing.Point(313, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 196);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnVerificarIdade
            // 
            this.btnVerificarIdade.Location = new System.Drawing.Point(73, 93);
            this.btnVerificarIdade.Name = "btnVerificarIdade";
            this.btnVerificarIdade.Size = new System.Drawing.Size(100, 23);
            this.btnVerificarIdade.TabIndex = 5;
            this.btnVerificarIdade.Text = "Verificar";
            this.btnVerificarIdade.UseVisualStyleBackColor = true;
            this.btnVerificarIdade.Click += new System.EventHandler(this.btnVerificarIdade_Click);
            // 
            // labelNao
            // 
            this.labelNao.AutoSize = true;
            this.labelNao.Location = new System.Drawing.Point(144, 154);
            this.labelNao.Name = "labelNao";
            this.labelNao.Size = new System.Drawing.Size(29, 15);
            this.labelNao.TabIndex = 4;
            this.labelNao.Text = "Não";
            // 
            // labelSim
            // 
            this.labelSim.AutoSize = true;
            this.labelSim.Location = new System.Drawing.Point(73, 154);
            this.labelSim.Name = "labelSim";
            this.labelSim.Size = new System.Drawing.Size(27, 15);
            this.labelSim.TabIndex = 3;
            this.labelSim.Text = "Sim";
            // 
            // labelMaiorIdade
            // 
            this.labelMaiorIdade.AutoSize = true;
            this.labelMaiorIdade.Location = new System.Drawing.Point(73, 123);
            this.labelMaiorIdade.Name = "labelMaiorIdade";
            this.labelMaiorIdade.Size = new System.Drawing.Size(100, 15);
            this.labelMaiorIdade.TabIndex = 2;
            this.labelMaiorIdade.Text = "E maior de idade?";
            // 
            // txbIdadeNome
            // 
            this.txbIdadeNome.Location = new System.Drawing.Point(73, 51);
            this.txbIdadeNome.Name = "txbIdadeNome";
            this.txbIdadeNome.Size = new System.Drawing.Size(100, 23);
            this.txbIdadeNome.TabIndex = 1;
            // 
            // txbNomeIdade
            // 
            this.txbNomeIdade.Location = new System.Drawing.Point(73, 22);
            this.txbNomeIdade.Name = "txbNomeIdade";
            this.txbNomeIdade.Size = new System.Drawing.Size(100, 23);
            this.txbNomeIdade.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEsquerda);
            this.groupBox4.Controls.Add(this.btnDireita);
            this.groupBox4.Controls.Add(this.btnMover);
            this.groupBox4.Location = new System.Drawing.Point(58, 458);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 170);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // btnEsquerda
            // 
            this.btnEsquerda.Location = new System.Drawing.Point(24, 128);
            this.btnEsquerda.Name = "btnEsquerda";
            this.btnEsquerda.Size = new System.Drawing.Size(75, 23);
            this.btnEsquerda.TabIndex = 2;
            this.btnEsquerda.Text = "Esquerda";
            this.btnEsquerda.UseVisualStyleBackColor = true;
            this.btnEsquerda.Click += new System.EventHandler(this.btnEsquerda_Click);
            // 
            // btnDireita
            // 
            this.btnDireita.Location = new System.Drawing.Point(138, 128);
            this.btnDireita.Name = "btnDireita";
            this.btnDireita.Size = new System.Drawing.Size(75, 23);
            this.btnDireita.TabIndex = 1;
            this.btnDireita.Text = "Direita";
            this.btnDireita.UseVisualStyleBackColor = true;
            this.btnDireita.Click += new System.EventHandler(this.btnDireita_Click);
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(77, 35);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(75, 23);
            this.btnMover.TabIndex = 0;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 640);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxMostrarNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxMostrarNome.ResumeLayout(false);
            this.groupBoxMostrarNome.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNum2;
        private System.Windows.Forms.GroupBox groupBoxMostrarNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNum1;
        private System.Windows.Forms.Label labelExibirResultado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.TextBox txbNumero2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbNumero1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelNao;
        private System.Windows.Forms.Label labelSim;
        private System.Windows.Forms.Label labelMaiorIdade;
        private System.Windows.Forms.TextBox txbIdadeNome;
        private System.Windows.Forms.TextBox txbNomeIdade;
        private System.Windows.Forms.Button btnVerificarIdade;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEsquerda;
        private System.Windows.Forms.Button btnDireita;
        private System.Windows.Forms.Button btnMover;
    }
}

