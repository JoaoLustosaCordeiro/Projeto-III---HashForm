using ApHashingPessoa;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApHashingForca
{
    public partial class Form1 : Form
    {
        ITabelaDeHash<Forca> tabelaDeHash;
        Forca forca;

        public Form1()  
        {
            InitializeComponent();
        }

        private void btnBucketHash_CheckedChanged(object sender, EventArgs e)
        {
            tabelaDeHash = new BucketHash<Forca>();
        }

        private void btnSgmLinear_CheckedChanged(object sender, EventArgs e)
        {
            tabelaDeHash = new HashSondagemLinear<Forca>();
        }

        private void btnDuploHash_CheckedChanged(object sender, EventArgs e)
        {
            tabelaDeHash = new HashDuplo<Forca>();
        }

        private void btnSdmQuadratica_CheckedChanged(object sender, EventArgs e)
        {
            tabelaDeHash = new HashSondagemQuadratica<Forca>();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtPalavra.Text != "" && txtDica.Text != "")
            {
                var novaPalavra = new Forca(txtPalavra.Text, txtDica.Text);
                if (!tabelaDeHash.Incluir(novaPalavra))
                    MessageBox.Show("Palavra incluida em ordem.");
                else
                    MessageBox.Show("Palavra repetida.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtPalavra.Text != "")   
            {
                var palavraProc = new Forca(txtPalavra.Text, "-");
                if (!tabelaDeHash.Excluir(palavraProc))
                    MessageBox.Show("Palavra não encontrada!");
                else    
                    MessageBox.Show("Palavra excluída.");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtPalavra.Text != "" && txtDica.Text != "")
            {
                var palavra = new Forca(txtPalavra.Text, txtDica.Text);
                if (!tabelaDeHash.Alterar(palavra))
                    MessageBox.Show("Palavra não encontrada.");
                else
                    MessageBox.Show("Palavra alterada.");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lsbListagem.Items.Clear();
            var dadosDaLista = tabelaDeHash.Conteudo();
            foreach (string palavra in dadosDaLista)
                lsbListagem.Items.Add(palavra);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fileContent = string.Empty;
            string filePath = string.Empty;

            dlgAbrir.InitialDirectory = "c:\\";
            dlgAbrir.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dlgAbrir.RestoreDirectory = true;

            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                filePath = dlgAbrir.FileName;

                var fileStream = dlgAbrir.OpenFile();

                using (StreamReader arquivo = new StreamReader(fileStream))
                {
                    string linha = "";
                    while (!arquivo.EndOfStream)  // enquanto não acabou o arquivo
                    {
                        linha = arquivo.ReadLine();
                        forca = new Forca();
                        forca.LerRegistro(arquivo);
                        tabelaDeHash.Incluir(forca);
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dlgSalvar.ShowDialog() == DialogResult.OK)
            {
                StreamWriter arquivo = new StreamWriter(dlgSalvar.FileName);
                List<string> conteudo = tabelaDeHash.Conteudo();
                for (int i = 0; i < conteudo.Count; i++)
                    arquivo.WriteLine(conteudo[i].ToString());
                arquivo.Close();
            }
        }
    }
}
