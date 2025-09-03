using ApHashingPessoa;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Forca : IComparable<Forca>, IEquatable<Forca>, IRegistro<Forca>
{
    // mapeamento dos campos da linha de dados do arquivo (registro de Forca)
    const int tamanhoPalavra = 30;
    const int inicioPalavra = 0;
    const int inicioDica = inicioPalavra + tamanhoPalavra;

    // atributos da classe Forca:
    string palavra, dica; // ra = palavra, nome = dica


    public string Palavra
    {
        get => palavra;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                palavra = value.PadRight(tamanhoPalavra, ' ').Substring(0, tamanhoPalavra);
            else
                throw new Exception("Palavra vazia é inválida.");
        }
    }

    public string Chave => palavra;

    public string Dica
    {
        get => dica;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                dica = value;
            else
                throw new Exception("Dica vazia é inválida.");
        }
    }

    public Forca()
    {
        Palavra = "";
        Dica = "";
    }

    public Forca(string palavra, string dica)
    {
        Palavra = palavra;
        Dica = dica;
    }

    public void LerRegistro(StreamReader arquivo)
    {
        string linhaDeDados = arquivo.ReadLine();
        if (linhaDeDados.Length < tamanhoPalavra)
            throw new Exception("Linha de dados muito curta.");

        //Palavra = linhaDeDados.Substring(inicioPalavra, tamanhoPalavra);
        Palavra = linhaDeDados.Substring(0, tamanhoPalavra).Trim(); // Remove espaços extras
        //Dica = linhaDeDados.Substring(inicioDica);
        Dica = linhaDeDados.Length > tamanhoPalavra ? linhaDeDados.Substring(tamanhoPalavra).Trim() : "";
    }

    public void EscreverRegistro(StreamWriter arquivo)
    {
        arquivo.WriteLine(ToString());
    }

    public int CompareTo(Forca outraPalavra)
    {
        return this.palavra.CompareTo(outraPalavra.palavra);
    }

    public bool Equals(Forca outraForca)
    {
        return outraForca != null && palavra.Equals(outraForca.palavra); 
    }

    public override string ToString()
    {
        return palavra + " " + dica;
    }
}