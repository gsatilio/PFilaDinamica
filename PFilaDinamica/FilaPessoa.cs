using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace PFilaDinamica
{
    internal class FilaPessoa
    {
        Pessoa? head;
        Pessoa? tail;

        public FilaPessoa()
        {
            this.head = null;
            this.tail = null;
        }

        public void push(Pessoa aux)
        {
            if (isEmpty())
            {
                this.head = this.tail = aux;
            }
            else
            {
                this.tail.setNext(aux);
                this.tail = aux;
            }
        }
        internal bool isEmpty()
        {
            return head == null && tail == null;
        }
        public void pop()
        {
            if (!isEmpty())
            {
                if (tail == head) // se cabeca = cauda entao so tem 1 elemento na fila
                {
                    head = tail = null;
                }
                else
                {
                    this.head = this.head.getNext();
                }
            }
        }
        public void print()
        {
            Pessoa aux = head;
            if (isEmpty())
            {
                Console.WriteLine("Fila Vazia!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                do
                {
                    Console.WriteLine(aux.print());
                    aux = aux.getNext();
                } while (aux != null);
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
