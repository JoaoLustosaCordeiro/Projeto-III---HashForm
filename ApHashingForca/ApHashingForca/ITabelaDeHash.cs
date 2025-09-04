using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApHashingPessoa
{
    public interface ITabelaDeHash<T> where T : IRegistro<T>, IComparable<T>, IEquatable<T>, new()
    {
        bool Incluir(T dado);
        bool Existe(T dado, out int onde);
        bool Excluir(T dado);
        bool Alterar(T dado);
        void Limpar();
        List<string> Conteudo();
    }
}
