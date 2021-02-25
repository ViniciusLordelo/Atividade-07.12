using System;
using ativ_07._12.classes;
namespace ativ_07._12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instaciando a subclasse
            PessoaFisica pf = new PessoaFisica();
            PessoaFisica pessoaFisica = new PessoaFisica();

            // Atribuimos um valor para a propriedade disponivel na superclasse
            Console.WriteLine("Digite seu Nome");
            pf.nome = Console.ReadLine();

            Console.WriteLine("Digite seu CPF");
            pf.cpf = Console.ReadLine();
            
           // Mostramos no console um metodo de saudação
            Console.WriteLine( pf.DarBoasVindas(pf.nome) );

            // Mostramosno console um metodo de validação da subclasse
            Console.WriteLine( pf.ValidarCPF(pf.cpf) );




        }
    }
}
