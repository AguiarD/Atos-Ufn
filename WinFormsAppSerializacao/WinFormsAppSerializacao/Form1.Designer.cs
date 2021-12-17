
namespace WinFormsAppSerializacao
{
    partial class form1
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
            this.txbMensagemFuturo = new System.Windows.Forms.TextBox();
            this.btnSerializar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBXml = new System.Windows.Forms.GroupBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnDesserializarXml = new System.Windows.Forms.Button();
            this.btnSerializarXml = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTel3Json = new System.Windows.Forms.Label();
            this.lblTel2Json = new System.Windows.Forms.Label();
            this.lblTel1Json = new System.Windows.Forms.Label();
            this.lblSalarioJson = new System.Windows.Forms.Label();
            this.lblIdadeJson = new System.Windows.Forms.Label();
            this.lblNomeJson = new System.Windows.Forms.Label();
            this.btnDesserializarJson = new System.Windows.Forms.Button();
            this.btnSerializarJson = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTel3Soap = new System.Windows.Forms.Label();
            this.lblTel2Soap = new System.Windows.Forms.Label();
            this.lblTel1Soap = new System.Windows.Forms.Label();
            this.lblSalarioSoap = new System.Windows.Forms.Label();
            this.lblIdadeSoap = new System.Windows.Forms.Label();
            this.lblNomeSoap = new System.Windows.Forms.Label();
            this.btnDesserializarSoap = new System.Windows.Forms.Button();
            this.btnSerializarSoap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBXml.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbMensagemFuturo
            // 
            this.txbMensagemFuturo.Location = new System.Drawing.Point(6, 33);
            this.txbMensagemFuturo.Name = "txbMensagemFuturo";
            this.txbMensagemFuturo.Size = new System.Drawing.Size(197, 23);
            this.txbMensagemFuturo.TabIndex = 0;
            // 
            // btnSerializar
            // 
            this.btnSerializar.Location = new System.Drawing.Point(6, 81);
            this.btnSerializar.Name = "btnSerializar";
            this.btnSerializar.Size = new System.Drawing.Size(75, 23);
            this.btnSerializar.TabIndex = 1;
            this.btnSerializar.Text = "Serializar";
            this.btnSerializar.UseVisualStyleBackColor = true;
            this.btnSerializar.Click += new System.EventHandler(this.btnSerializar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Desserializar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(96, 59);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(10, 15);
            this.lblMensagem.TabIndex = 3;
            this.lblMensagem.Text = ".";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbMensagemFuturo);
            this.groupBox1.Controls.Add(this.lblMensagem);
            this.groupBox1.Controls.Add(this.btnSerializar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 127);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serialização";
            // 
            // groupBXml
            // 
            this.groupBXml.Controls.Add(this.lblSalario);
            this.groupBXml.Controls.Add(this.lblIdade);
            this.groupBXml.Controls.Add(this.lblNome);
            this.groupBXml.Controls.Add(this.btnDesserializarXml);
            this.groupBXml.Controls.Add(this.btnSerializarXml);
            this.groupBXml.Location = new System.Drawing.Point(252, 28);
            this.groupBXml.Name = "groupBXml";
            this.groupBXml.Size = new System.Drawing.Size(237, 149);
            this.groupBXml.TabIndex = 5;
            this.groupBXml.TabStop = false;
            this.groupBXml.Text = "XML";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(126, 112);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 15);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salario";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(126, 72);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(36, 15);
            this.lblIdade.TabIndex = 3;
            this.lblIdade.Text = "Idade";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(126, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // btnDesserializarXml
            // 
            this.btnDesserializarXml.Location = new System.Drawing.Point(6, 72);
            this.btnDesserializarXml.Name = "btnDesserializarXml";
            this.btnDesserializarXml.Size = new System.Drawing.Size(75, 23);
            this.btnDesserializarXml.TabIndex = 1;
            this.btnDesserializarXml.Text = "Desserializar";
            this.btnDesserializarXml.UseVisualStyleBackColor = true;
            this.btnDesserializarXml.Click += new System.EventHandler(this.btnDesserializarXml_Click);
            // 
            // btnSerializarXml
            // 
            this.btnSerializarXml.Location = new System.Drawing.Point(6, 43);
            this.btnSerializarXml.Name = "btnSerializarXml";
            this.btnSerializarXml.Size = new System.Drawing.Size(75, 23);
            this.btnSerializarXml.TabIndex = 0;
            this.btnSerializarXml.Text = "Serializar";
            this.btnSerializarXml.UseVisualStyleBackColor = true;
            this.btnSerializarXml.Click += new System.EventHandler(this.btnSerializarXml_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTel3Json);
            this.groupBox2.Controls.Add(this.lblTel2Json);
            this.groupBox2.Controls.Add(this.lblTel1Json);
            this.groupBox2.Controls.Add(this.lblSalarioJson);
            this.groupBox2.Controls.Add(this.lblIdadeJson);
            this.groupBox2.Controls.Add(this.lblNomeJson);
            this.groupBox2.Controls.Add(this.btnDesserializarJson);
            this.groupBox2.Controls.Add(this.btnSerializarJson);
            this.groupBox2.Location = new System.Drawing.Point(507, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 140);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "JSON";
            // 
            // lblTel3Json
            // 
            this.lblTel3Json.AutoSize = true;
            this.lblTel3Json.Location = new System.Drawing.Point(133, 122);
            this.lblTel3Json.Name = "lblTel3Json";
            this.lblTel3Json.Size = new System.Drawing.Size(57, 15);
            this.lblTel3Json.TabIndex = 7;
            this.lblTel3Json.Text = "Telefone3";
            // 
            // lblTel2Json
            // 
            this.lblTel2Json.AutoSize = true;
            this.lblTel2Json.Location = new System.Drawing.Point(133, 103);
            this.lblTel2Json.Name = "lblTel2Json";
            this.lblTel2Json.Size = new System.Drawing.Size(57, 15);
            this.lblTel2Json.TabIndex = 6;
            this.lblTel2Json.Text = "Telefone2";
            // 
            // lblTel1Json
            // 
            this.lblTel1Json.AutoSize = true;
            this.lblTel1Json.Location = new System.Drawing.Point(133, 82);
            this.lblTel1Json.Name = "lblTel1Json";
            this.lblTel1Json.Size = new System.Drawing.Size(57, 15);
            this.lblTel1Json.TabIndex = 5;
            this.lblTel1Json.Text = "Telefone1";
            // 
            // lblSalarioJson
            // 
            this.lblSalarioJson.AutoSize = true;
            this.lblSalarioJson.Location = new System.Drawing.Point(133, 63);
            this.lblSalarioJson.Name = "lblSalarioJson";
            this.lblSalarioJson.Size = new System.Drawing.Size(42, 15);
            this.lblSalarioJson.TabIndex = 4;
            this.lblSalarioJson.Text = "Salario";
            // 
            // lblIdadeJson
            // 
            this.lblIdadeJson.AutoSize = true;
            this.lblIdadeJson.Location = new System.Drawing.Point(133, 41);
            this.lblIdadeJson.Name = "lblIdadeJson";
            this.lblIdadeJson.Size = new System.Drawing.Size(36, 15);
            this.lblIdadeJson.TabIndex = 3;
            this.lblIdadeJson.Text = "Idade";
            // 
            // lblNomeJson
            // 
            this.lblNomeJson.AutoSize = true;
            this.lblNomeJson.Location = new System.Drawing.Point(133, 14);
            this.lblNomeJson.Name = "lblNomeJson";
            this.lblNomeJson.Size = new System.Drawing.Size(40, 15);
            this.lblNomeJson.TabIndex = 2;
            this.lblNomeJson.Text = "Nome";
            // 
            // btnDesserializarJson
            // 
            this.btnDesserializarJson.Location = new System.Drawing.Point(7, 62);
            this.btnDesserializarJson.Name = "btnDesserializarJson";
            this.btnDesserializarJson.Size = new System.Drawing.Size(75, 23);
            this.btnDesserializarJson.TabIndex = 1;
            this.btnDesserializarJson.Text = "Desserializar";
            this.btnDesserializarJson.UseVisualStyleBackColor = true;
            this.btnDesserializarJson.Click += new System.EventHandler(this.btnDesserializarJson_Click);
            // 
            // btnSerializarJson
            // 
            this.btnSerializarJson.Location = new System.Drawing.Point(6, 34);
            this.btnSerializarJson.Name = "btnSerializarJson";
            this.btnSerializarJson.Size = new System.Drawing.Size(75, 23);
            this.btnSerializarJson.TabIndex = 0;
            this.btnSerializarJson.Text = "Serializar";
            this.btnSerializarJson.UseVisualStyleBackColor = true;
            this.btnSerializarJson.Click += new System.EventHandler(this.btnSerializarJson_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTel3Soap);
            this.groupBox3.Controls.Add(this.lblTel2Soap);
            this.groupBox3.Controls.Add(this.lblTel1Soap);
            this.groupBox3.Controls.Add(this.lblSalarioSoap);
            this.groupBox3.Controls.Add(this.lblIdadeSoap);
            this.groupBox3.Controls.Add(this.lblNomeSoap);
            this.groupBox3.Controls.Add(this.btnDesserializarSoap);
            this.groupBox3.Controls.Add(this.btnSerializarSoap);
            this.groupBox3.Location = new System.Drawing.Point(18, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 156);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SOAP";
            // 
            // lblTel3Soap
            // 
            this.lblTel3Soap.AutoSize = true;
            this.lblTel3Soap.Location = new System.Drawing.Point(103, 133);
            this.lblTel3Soap.Name = "lblTel3Soap";
            this.lblTel3Soap.Size = new System.Drawing.Size(57, 15);
            this.lblTel3Soap.TabIndex = 13;
            this.lblTel3Soap.Text = "Telefone3";
            // 
            // lblTel2Soap
            // 
            this.lblTel2Soap.AutoSize = true;
            this.lblTel2Soap.Location = new System.Drawing.Point(102, 114);
            this.lblTel2Soap.Name = "lblTel2Soap";
            this.lblTel2Soap.Size = new System.Drawing.Size(57, 15);
            this.lblTel2Soap.TabIndex = 12;
            this.lblTel2Soap.Text = "Telefone2";
            // 
            // lblTel1Soap
            // 
            this.lblTel1Soap.AutoSize = true;
            this.lblTel1Soap.Location = new System.Drawing.Point(103, 93);
            this.lblTel1Soap.Name = "lblTel1Soap";
            this.lblTel1Soap.Size = new System.Drawing.Size(57, 15);
            this.lblTel1Soap.TabIndex = 11;
            this.lblTel1Soap.Text = "Telefone1";
            // 
            // lblSalarioSoap
            // 
            this.lblSalarioSoap.AutoSize = true;
            this.lblSalarioSoap.Location = new System.Drawing.Point(103, 74);
            this.lblSalarioSoap.Name = "lblSalarioSoap";
            this.lblSalarioSoap.Size = new System.Drawing.Size(42, 15);
            this.lblSalarioSoap.TabIndex = 10;
            this.lblSalarioSoap.Text = "Salario";
            // 
            // lblIdadeSoap
            // 
            this.lblIdadeSoap.AutoSize = true;
            this.lblIdadeSoap.Location = new System.Drawing.Point(103, 52);
            this.lblIdadeSoap.Name = "lblIdadeSoap";
            this.lblIdadeSoap.Size = new System.Drawing.Size(36, 15);
            this.lblIdadeSoap.TabIndex = 9;
            this.lblIdadeSoap.Text = "Idade";
            // 
            // lblNomeSoap
            // 
            this.lblNomeSoap.AutoSize = true;
            this.lblNomeSoap.Location = new System.Drawing.Point(103, 25);
            this.lblNomeSoap.Name = "lblNomeSoap";
            this.lblNomeSoap.Size = new System.Drawing.Size(40, 15);
            this.lblNomeSoap.TabIndex = 8;
            this.lblNomeSoap.Text = "Nome";
            // 
            // btnDesserializarSoap
            // 
            this.btnDesserializarSoap.Location = new System.Drawing.Point(7, 97);
            this.btnDesserializarSoap.Name = "btnDesserializarSoap";
            this.btnDesserializarSoap.Size = new System.Drawing.Size(75, 23);
            this.btnDesserializarSoap.TabIndex = 1;
            this.btnDesserializarSoap.Text = "Desserializar";
            this.btnDesserializarSoap.UseVisualStyleBackColor = true;
            this.btnDesserializarSoap.Click += new System.EventHandler(this.btnDesserializarSoap_Click);
            // 
            // btnSerializarSoap
            // 
            this.btnSerializarSoap.Location = new System.Drawing.Point(7, 52);
            this.btnSerializarSoap.Name = "btnSerializarSoap";
            this.btnSerializarSoap.Size = new System.Drawing.Size(75, 23);
            this.btnSerializarSoap.TabIndex = 0;
            this.btnSerializarSoap.Text = "Serializar";
            this.btnSerializarSoap.UseVisualStyleBackColor = true;
            this.btnSerializarSoap.Click += new System.EventHandler(this.btnSerializarSoap_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBXml);
            this.Controls.Add(this.groupBox1);
            this.Name = "form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBXml.ResumeLayout(false);
            this.groupBXml.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbMensagemFuturo;
        private System.Windows.Forms.Button btnSerializar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBXml;
        private System.Windows.Forms.Button btnDesserializarXml;
        private System.Windows.Forms.Button btnSerializarXml;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDesserializarJson;
        private System.Windows.Forms.Button btnSerializarJson;
        private System.Windows.Forms.Label lblTel3Json;
        private System.Windows.Forms.Label lblTel2Json;
        private System.Windows.Forms.Label lblTel1Json;
        private System.Windows.Forms.Label lblSalarioJson;
        private System.Windows.Forms.Label lblIdadeJson;
        private System.Windows.Forms.Label lblNomeJson;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDesserializarSoap;
        private System.Windows.Forms.Button btnSerializarSoap;
        private System.Windows.Forms.Label lblTel3Soap;
        private System.Windows.Forms.Label lblTel2Soap;
        private System.Windows.Forms.Label lblTel1Soap;
        private System.Windows.Forms.Label lblSalarioSoap;
        private System.Windows.Forms.Label lblIdadeSoap;
        private System.Windows.Forms.Label lblNomeSoap;
        private System.Windows.Forms.Button btnDesserializarSopa;
    }
}

