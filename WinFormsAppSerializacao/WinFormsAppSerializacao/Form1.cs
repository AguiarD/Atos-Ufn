using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WinFormsAppSerializacao
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            string mensagem;
            FileStream fs = new FileStream(@"C:\teste\teste.txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            mensagem = txbMensagemFuturo.Text;
            bf.Serialize(fs, mensagem);
            fs.Close();
            MessageBox.Show("Serializado com sucesso!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\teste\teste.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            string mensagem;
            mensagem = (string)bf.Deserialize(fs);
            lblMensagem.Text = mensagem;
            MessageBox.Show("Desserializado com sucesso");
        }

        private void btnSerializarXml_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = "Homer";
            p.idade = 48;
            p.salario = 1100;

            FileStream fs = new FileStream(@"C:\teste\Pessoa.xml", FileMode.Create);
            XmlSerializer xml = new XmlSerializer(typeof(Pessoa));

            xml.Serialize(fs, p);
            fs.Close();

            /*StreamWriter sw = new StreamWriter(@"C:\teste\Pessoa.xml");
            XmlSerializer xml = new XmlSerializer(typeof(Pessoa));
            xml.Serialize(sw.BaseStream, p);
            sw.Close();*/

            MessageBox.Show("XML Serializado com sucesso!");
        }

        private void btnDesserializarXml_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Pessoa));
            StreamReader sr = new StreamReader(@"C:\teste\Pessoa.xml");
            Pessoa pXML;
            pXML = (Pessoa) xml.Deserialize(sr.BaseStream);
            lblNome.Text = pXML.nome;
            lblIdade.Text = pXML.idade.ToString();
            lblSalario.Text = pXML.salario.ToString();
        }

        private void btnSerializarJson_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = "Bart";
            p.idade = 47;
            p.salario = 12500;
            p.telefone = new string[5];
            p.telefone[0] = "123445676";
            p.telefone[1] = "57658678";
            p.telefone[2] = "56768";


            JsonSerializer serializer = new JsonSerializer();
            StreamWriter sw = new StreamWriter(@"C:\teste\Pessoa.json");
            JsonWriter writer = new JsonTextWriter(sw);

            serializer.Serialize(writer, p);
            sw.Close();
            writer.Close();

            MessageBox.Show("é isso ai, não tem mais jeito");
        }

        private void btnDesserializarJson_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(@"C:\teste\Pessoa.json");

            Pessoa p = JsonConvert.DeserializeObject<Pessoa>(json);
            lblNomeJson.Text = p.nome;
            lblIdadeJson.Text = p.idade.ToString();
            lblSalarioJson.Text = p.salario.ToString();
            lblTel1Json.Text = p.telefone[0].ToString();
            lblTel2Json.Text = p.telefone[1].ToString();
            lblTel3Json.Text = p.telefone[2].ToString();
        }

        private void btnSerializarSoap_Click(object sender, EventArgs e)
        {
            Pessoa pSoap = new Pessoa();
            pSoap.nome = "Bart";
            pSoap.idade = 47;
            pSoap.salario = 12500;
            pSoap.telefone = new string[5];
            pSoap.telefone[0] = "123445676";
            pSoap.telefone[1] = "57658678";
            pSoap.telefone[2] = "56768";

            FileStream stream = new FileStream(@"C:\teste\Pessoa.data", FileMode.Create);
            SoapFormatter soap = new SoapFormatter();
            soap.Serialize(stream, pSoap);
            stream.Close();
            MessageBox.Show("Serializado com SOAP");

        }

        private void btnDesserializarSoap_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\teste\Pessoa.data", FileMode.Open);
            SoapFormatter soap = new SoapFormatter();
            Pessoa pessoa = new Pessoa();

            pessoa = (Pessoa)soap.Deserialize(fs);

            lblNomeSoap.Text = pessoa.nome;
            lblIdadeSoap.Text = pessoa.idade.ToString();
            lblSalarioSoap.Text = pessoa.salario.ToString();
            lblTel1Soap.Text = pessoa.telefone[0];
            lblTel2Soap.Text = pessoa.telefone[1];
            lblTel3Soap.Text = pessoa.telefone[2];

        }
    }
}
