//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parcela
    {
        public int IdParcela { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public int ServicoIdServicos { get; set; }
    
        public virtual Servico Servico { get; set; }
    }
}
