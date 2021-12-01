
namespace WinFormsAppControlesDinamicos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTeste = new System.Windows.Forms.Button();
            this.txbTeste = new System.Windows.Forms.TextBox();
            this.txbX = new System.Windows.Forms.TextBox();
            this.txbY = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(109, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(600, 236);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(75, 23);
            this.btnTeste.TabIndex = 1;
            this.btnTeste.Text = "Botao Teste";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // txbTeste
            // 
            this.txbTeste.Location = new System.Drawing.Point(587, 66);
            this.txbTeste.Name = "txbTeste";
            this.txbTeste.Size = new System.Drawing.Size(100, 23);
            this.txbTeste.TabIndex = 2;
            // 
            // txbX
            // 
            this.txbX.Location = new System.Drawing.Point(587, 123);
            this.txbX.Name = "txbX";
            this.txbX.Size = new System.Drawing.Size(100, 23);
            this.txbX.TabIndex = 3;
            // 
            // txbY
            // 
            this.txbY.Location = new System.Drawing.Point(587, 184);
            this.txbY.Name = "txbY";
            this.txbY.Size = new System.Drawing.Size(100, 23);
            this.txbY.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbY);
            this.Controls.Add(this.txbX);
            this.Controls.Add(this.txbTeste);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.TextBox txbTeste;
        private System.Windows.Forms.TextBox txbX;
        private System.Windows.Forms.TextBox txbY;
        private System.Windows.Forms.Button button1;
    }
}

