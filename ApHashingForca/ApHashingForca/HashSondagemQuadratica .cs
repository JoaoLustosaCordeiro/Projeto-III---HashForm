using System.Collections.Generic;
using ApHashingPessoa;


class HashSondagemQuadratica<T> : ITabelaDeHash<T> where T : IRegistro<T>, new()
{
    const int tamanhoPadrao = 10007;
    T[] tabelaDeHash;

    public HashSondagemQuadratica() : this(tamanhoPadrao) { }

    public HashSondagemQuadratica(int tamanhoDesejado)
    {
        tabelaDeHash = new T[tamanhoDesejado];
    }

    private int Hash(string chave)
    {
        int tot = 0;
        for (int i = 0; i < chave.Length; i++) 
            tot += (int)chave[i];
        return tot % tabelaDeHash.Length;
    }

    public bool Incluir(T novoDado)
    {
        bool colidiu = false;
        int valorDeHash = Hash(novoDado.Chave); // posicao calculada do registro
        if (tabelaDeHash[valorDeHash] != null) // já há dado armazenado nessa posição
            colidiu = true;
        tabelaDeHash[valorDeHash] = novoDado;
        return colidiu;
    }

    public bool Existe(T dado, out int posicao)
    {
        posicao = Hash(dado.Chave);
        return tabelaDeHash[posicao].Equals(dado);
    }

    public List<string> Conteudo()
    {
        var saida = new List<string>();
        for (int i = 0; i < tabelaDeHash.Length; i++)
            if (tabelaDeHash[i] != null)
                saida.Add($"{i,5} : {tabelaDeHash[i]}");
        return saida;
    }

    public bool Excluir(T dado)
    {
        int ondeAchou;
        if (Existe(dado, out ondeAchou))
        {
            tabelaDeHash[ondeAchou] = default(T);
            return true;
        }
        return false;
    }

    public void Limpar()
    {
        for (int i = 0; i < tabelaDeHash.Length; i++)
            tabelaDeHash[i] = default(T);
    }
}
