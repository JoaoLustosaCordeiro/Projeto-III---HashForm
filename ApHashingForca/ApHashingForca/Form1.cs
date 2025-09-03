using ApHashingPessoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApHashingForca
{
    public partial class Form1 : Form
    {
        Forca forca;
        ITabelaDeHash<Forca> tabelaDeHash;

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
            string palavra = txtPalavra.Text;
            string dica = txtDica.Text;
            forca = new Forca(palavra, dica);
            tabelaDeHash.Incluir(forca);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string palavra = txtPalavra.Text;
            string dica = txtDica.Text;
            forca = new Forca(palavra, dica);
            tabelaDeHash.Excluir(forca);
        }
    }
}
