//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fiap.Exemplo02.MVC.Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grupo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Nullable<double> Nota { get; set; }
    
        public virtual Projeto Projeto { get; set; }
    }
}
