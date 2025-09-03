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
        dados[onde].Remover(dado);
        return true;
    }

    public bool Existe(T dado, out int onde)
    {
        onde = Hash(dado.Chave);
        return dados[onde].Equals(dado);
    }

    public List<string> Conteudo()
    {
        List<string> saida = new List<string>();
        for (int i = 0; i < dados.Count; i++)
            if (dados[i].QuantosNos > 0)
            {
                string linha = $"{i,5} : ";
                dados[i].ExibirLista();
                saida.Add(linha);
            }
        return saida;
    }
    public void Limpar()
    {
        for (int i = 0; i < dados.Count; i++)
            dados[i] = null;
    }
}

