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
        int contador;

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
            contador++;
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
                contador--;
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
                    Console.WriteLine("Pessoa: " + aux.print());
                    aux = aux.getNext();
                } while (aux != null);
                Console.WriteLine($"Existem {contador} pessoas na fila.Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
        public void printEspecifico(string nome)
        {
            Pessoa aux = head;
            int contador_aux = 0;
            bool encontrou = false;
            do
            {
                contador_aux++;
                if (aux.print() == nome)
                {
                    encontrou = true;
                    Console.WriteLine($"Pessoa encontrada! Posição: {contador_aux} - " + aux.print());
                    Console.ReadKey();
                }
                aux = aux.getNext();
            } while (aux != null);
            if (!encontrou)
            {
                Console.WriteLine("Não localizamos essa pessoa.");
                Console.ReadKey();
            }
        }
    }
}
