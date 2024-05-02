using PFilaDinamica;

internal class Program
{
    private static void Main(string[] args)
    {
        int opc;
        FilaPessoa FilaPessoa = new FilaPessoa();
        do
        {
            Console.Clear();
            Console.WriteLine("1 - Inserir\n2 - Remover primeira pessoa\n3 - Imprimir Fila\n4 - Procurar na Fila\n0 - Sair");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    FilaPessoa.push(InserirPessoa());
                    break;
                case 2:
                    FilaPessoa.pop();
                    break;
                case 3:
                    FilaPessoa.print();
                    break;
                case 4:
                    Console.WriteLine("Informe a pessoa que deseja procurar:");
                    FilaPessoa.printEspecifico(Console.ReadLine());
                    break;
                default:
                    break;
            }
        } while (opc != 0);
    }
    static Pessoa InserirPessoa()
    {
        Console.WriteLine("Informe o nome:");
        Pessoa pessoatemp = new Pessoa(Console.ReadLine());
        return pessoatemp;
    }
}
