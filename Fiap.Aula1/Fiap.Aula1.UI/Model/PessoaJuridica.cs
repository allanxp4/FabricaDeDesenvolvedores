﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula1.UI.Model
{
    public class PessoaJuridica : Pessoa
    {
        public Porte Porte { get; set; }
        //propfull - tab tab
        private string _cnpj;

        public PessoaJuridica(string nome):base(nome)
        {

        }

        public string Cnpj
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        public override void Comprar(string item)
        {

            Console.WriteLine("PJ comprando: " + item);
        }

        //sobrescrita de metdodo
        public override void Vender(String item)
        {
            Console.WriteLine("PJ Comprando: " + item);

        }
    }
}
