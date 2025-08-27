using System.Collections;
using System.Collections.Generic;
using ApHashingPessoa;

public class BucketHash<T> : ITabelaDeHash<T> where T : IRegistro<T>, new()
{
    private const int SIZE = 10007; // para gerar mais colisões; o ideal é primo > 100
    List<ListaSimples<T>> dados;
    
    public BucketHash()
    {
        dados = new List<ListaSimples<T>>(SIZE);
        for (int i = 0; i < SIZE; i++)
            dados[i] = new ListaSimples<T>();
    }

    private int Hash(string chave)
    {
        long tot = 0;
        for (int i = 0; i < chave.Length; i++)
            tot += 37 * tot + (char)chave[i];
        tot = tot % dados.Count;
        if (tot < 0)
            tot += dados.Count;
        return (int)tot;
    }

    public bool Incluir(T novoDado)
    {
        int valorDeHash = Hash(novoDado.Chave);
        if (dados[valorDeHash].Equals(novoDado))
        {
            return false; // ja tem esse valor na lista
        }
        dados[valorDeHash].InserirAposOFim(novoDado);
        return true;
    }

    public bool Excluir(T dado)
    {
        int onde = 0;
        if (!Existe(dado, out onde))
            return false;
        dados[onde].(dado);
        return true;
    }

    public bool Existe(T dado, out int onde)
    {
        onde = Hash(dado.Chave);
        return dados[onde].Contains(dado);
    }

    public List<string> Conteudo()
    {
        List<string> saida = new List<string>();
        for (int i = 0; i < dados.Length; i++)
            if (dados[i].Count > 0)
            {
                string linha = $"{i,5} : ";
                foreach (string chave in dados[i])
                    linha += " | " + chave;
                saida.Add(linha);
            }
        return saida;
    }
    public void Limpar()
    {
        for (int i = 0; i < dados.Length; i++)
            dados[i] = null;
    }
}

