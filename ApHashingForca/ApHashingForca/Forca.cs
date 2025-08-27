using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Forca : IComparable<Forca>, IRegistro
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

    public Forca(string linhaDeDados)
    {
        if (linhaDeDados.Length < tamanhoPalavra)
            throw new Exception("Linha de dados muito curta.");

        //Palavra = linhaDeDados.Substring(inicioPalavra, tamanhoPalavra);
        Palavra = linhaDeDados.Substring(0, tamanhoPalavra).Trim(); // Remove espaços extras
        //Dica = linhaDeDados.Substring(inicioDica);
        Dica = linhaDeDados.Length > tamanhoPalavra ? linhaDeDados.Substring(tamanhoPalavra).Trim() : "";

    }

    public Forca(string palavra, string dica)
    {
        Palavra = palavra;
        Dica = dica;
    }

    public int CompareTo(Forca outraPalavra)
    {
        return this.palavra.CompareTo(outraPalavra.palavra);
    }

    public override string ToString()
    {
        return palavra + " " + dica;
    }

    public string FormatoDeArquivo()
    {
        return $"{palavra}{dica}";
    }
}