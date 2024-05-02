using PFilaDinamica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        FilaPessoa FilaPessoa = new FilaPessoa();
        //Pessoa p1 = new ("Odair");
        //filaPessoa.push(p1);
        FilaPessoa.push(new Pessoa("Odair"));
        FilaPessoa.push(new Pessoa("Alexa"));
        FilaPessoa.push(new Pessoa("Tio Paulo"));
        FilaPessoa.print();
        FilaPessoa.pop();
        FilaPessoa.pop();
        FilaPessoa.pop();
    }
}