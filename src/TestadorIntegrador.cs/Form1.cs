using IntegradorIbge.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using IntegradorIbge.Dto;
using System.Runtime.Serialization;
using System.IO;

namespace TestadorIntegrador.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            var integrador = new BuscadorUfs();
            var retorno = integrador.BuscarUfs();
            if (retorno == null || !retorno.Any())
                return;
            var retornoTxt = JsonConvert.SerializeObject(retorno);
            richTextBox1.Text = retornoTxt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ufTextBox.Text))
                throw new Exception("Infore a UF");
            richTextBox1.Clear();
            richTextBox1.Text = new BuscadorMunicipio().BuscarMunicipiosDaUfJson(int.Parse(ufTextBox.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var objetos = JsonConvert.DeserializeObject<List<MunicipioDto>>(richTextBox1.Text);

            if (!objetos.Any())
                throw new Exception("Erro");
        }
    }
}