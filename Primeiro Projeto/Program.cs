namespace Primeiro_Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nome = "João Araujo";
            int Idade = 16;
            string Cidade = "Campos do Jordão";

            Console.WriteLine("Digite seu nome:");
          Nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
          Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua Cidade: ");
          Cidade = Console.ReadLine();

            Console.WriteLine("nome: {0} ", Nome);
            Console.WriteLine("cidade: {0}", Idade);
            Console.WriteLine("cidade: {0}", Cidade);
            Console.WriteLine("nome: {0} \n idade: {1} anos \n cidade: {2}", Nome, Idade, Cidade);
        }
    }

}


