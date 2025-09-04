using ApHashingPessoa;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApHashingForca
{
    public partial class Form1 : Form
    {
        ITabelaDeHash<Forca> tabelaDeHash;

        public Form1()  
        {
            InitializeComponent();
        }

        private void FazerLeitura()
        {
            if (dlgAbrir.ShowDialog() == DialogResult.OK)  // usuário pressionou botão Abrir?
            {
                StreamReader arquivo = new StreamReader(dlgAbrir.FileName);
                string linha = "";
                while (!arquivo.EndOfStream)  // enquanto não acabou o arquivo
                {
                    linha = arquivo.ReadLine();
                    Forca forca = new Forca();
                    tabelaDeHash.Incluir();
                }
                arquivo.Close();
            }
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
                    MessageBox.Show("Palavra repetida.");
                else
                    MessageBox.Show("Palavra incluida em ordem.");
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
    }
}
