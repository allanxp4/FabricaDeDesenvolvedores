using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula1.UI.Model
{
    public class PessoaFisica : Pessoa, IContribuinte
    {
        //prop -> tab tab
        public string _cpf { get; set; }
        public decimal Renda { get; set; }

        public PessoaFisica(string nome):base(nome)
        {

        }

        public override void Comprar(string item)
        {
            Console.WriteLine("PF comprando: " + item);
            
        }

        public decimal CalcularImposto()
        {
            return 0.27m * Renda;
        }
    }

  
}
