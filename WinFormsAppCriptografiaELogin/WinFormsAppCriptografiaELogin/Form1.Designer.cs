
namespace WinFormsAppCriptografiaELogin
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
            this.groupBCadUsuario = new System.Windows.Forms.GroupBox();
            this.btnGravarAssimetrica = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnValidarS = new System.Windows.Forms.Button();
            this.txbLoginSenha = new System.Windows.Forms.TextBox();
            this.txbLoginEmail = new System.Windows.Forms.TextBox();
            this.groupBCadUsuario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBCadUsuario
            // 
            this.groupBCadUsuario.Controls.Add(this.btnGravarAssimetrica);
            this.groupBCadUsuario.Controls.Add(this.btnGravar);
            this.groupBCadUsuario.Controls.Add(this.txbSenha);
            this.groupBCadUsuario.Controls.Add(this.txbEmail);
            this.groupBCadUsuario.Controls.Add(this.txbNome);
            this.groupBCadUsuario.Location = new System.Drawing.Point(22, 21);
            this.groupBCadUsuario.Name = "groupBCadUsuario";
            this.groupBCadUsuario.Size = new System.Drawing.Size(214, 222);
            this.groupBCadUsuario.TabIndex = 0;
            this.groupBCadUsuario.TabStop = false;
            this.groupBCadUsuario.Text = "Cadastro Usuario";
            // 
            // btnGravarAssimetrica
            // 
            this.btnGravarAssimetrica.Location = new System.Drawing.Point(62, 186);
            this.btnGravarAssimetrica.Name = "btnGravarAssimetrica";
            this.btnGravarAssimetrica.Size = new System.Drawing.Size(75, 23);
            this.btnGravarAssimetrica.TabIndex = 4;
            this.btnGravarAssimetrica.Text = "Assimetrica";
            this.btnGravarAssimetrica.UseVisualStyleBackColor = true;
            this.btnGravarAssimetrica.Click += new System.EventHandler(this.btnGravarAssimetrica_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(62, 156);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 3;
            this.btnGravar.Text = "Simetrica";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(52, 119);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PlaceholderText = "Senha";
            this.txbSenha.Size = new System.Drawing.Size(100, 23);
            this.txbSenha.TabIndex = 2;
            this.txbSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(52, 74);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PlaceholderText = "Email";
            this.txbEmail.Size = new System.Drawing.Size(100, 23);
            this.txbEmail.TabIndex = 1;
            this.txbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(52, 32);
            this.txbNome.Name = "txbNome";
            this.txbNome.PlaceholderText = "Nome";
            this.txbNome.Size = new System.Drawing.Size(100, 23);
            this.txbNome.TabIndex = 0;
            this.txbNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnValidarS);
            this.groupBox1.Controls.Add(this.txbLoginSenha);
            this.groupBox1.Controls.Add(this.txbLoginEmail);
            this.groupBox1.Location = new System.Drawing.Point(22, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // btnValidarS
            // 
            this.btnValidarS.Location = new System.Drawing.Point(62, 122);
            this.btnValidarS.Name = "btnValidarS";
            this.btnValidarS.Size = new System.Drawing.Size(75, 23);
            this.btnValidarS.TabIndex = 2;
            this.btnValidarS.Text = "Validar";
            this.btnValidarS.UseVisualStyleBackColor = true;
            this.btnValidarS.Click += new System.EventHandler(this.btnValidarS_Click);
            // 
            // txbLoginSenha
            // 
            this.txbLoginSenha.Location = new System.Drawing.Point(52, 84);
            this.txbLoginSenha.Name = "txbLoginSenha";
            this.txbLoginSenha.PlaceholderText = "Senha";
            this.txbLoginSenha.Size = new System.Drawing.Size(100, 23);
            this.txbLoginSenha.TabIndex = 1;
            this.txbLoginSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbLoginSenha.UseSystemPasswordChar = true;
            // 
            // txbLoginEmail
            // 
            this.txbLoginEmail.Location = new System.Drawing.Point(52, 44);
            this.txbLoginEmail.Name = "txbLoginEmail";
            this.txbLoginEmail.PlaceholderText = "Email";
            this.txbLoginEmail.Size = new System.Drawing.Size(100, 23);
            this.txbLoginEmail.TabIndex = 0;
            this.txbLoginEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBCadUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBCadUsuario.ResumeLayout(false);
            this.groupBCadUsuario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBCadUsuario;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Button btnGravarAssimetrica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnValidarS;
        private System.Windows.Forms.TextBox txbLoginSenha;
        private System.Windows.Forms.TextBox txbLoginEmail;
    }
}

