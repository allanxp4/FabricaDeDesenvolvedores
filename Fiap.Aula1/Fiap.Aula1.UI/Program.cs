using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiap.Aula1.UI.Model;

namespace Fiap.Aula1.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar uma PJ

            PessoaJuridica p = new PessoaJuridica("Fiap");
            //var pj = new Pessoajurica(); <- mesma coisa!

            p.Cnpj = "12.123.212/0001-01";
            p.Nome = "Fiap";
            p.Porte = Porte.LTDA;

            //Comparar
            if(p.Porte == Porte.SA)
            {
                Console.WriteLine("Fiap é SA");
            }
            if(p.Nome == "Fiap")
            {
                Console.WriteLine("Fiap não é SA");
            }

           

            //instanciar PF

            var pf = new PessoaFisica("Danilo")
            {
                Nome = "Danilo2",
                _cpf = "426.016.338-83"
            };

            //Coleção : criar uma lista de pessoa 3

            var lista = new List<PessoaFisica>();
            lista.Add(new PessoaFisica("Thiago") { Renda = 10 });
            lista.Add(new PessoaFisica("Danilo") { Renda = 100});
            lista.Add(new PessoaFisica("Mopa") { Renda = 200 });


            //Exbir o imposto da pessoa

            foreach (var pessoa in lista)
            {
                Console.WriteLine(pessoa.CalcularImposto());
            }

            Console.WriteLine(p.Nome + pf.Nome);

            Console.ReadLine();
            
        }
    }
}
