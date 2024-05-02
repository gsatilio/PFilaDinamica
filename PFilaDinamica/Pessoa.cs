using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFilaDinamica
{
    internal class Pessoa
    {
        string? nome;
        Pessoa proximo;

        public Pessoa(string? nome)
        {
            this.nome = nome;
            this.proximo = null;
        }

        public void setNext(Pessoa aux)
        {
            this.proximo = aux;
        }
        public Pessoa getNext()
        {
            return this.proximo;
        }
        public string print()
        {
            return "\nPessoa: " + nome;
        }

    }
}
