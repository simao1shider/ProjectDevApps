﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbStandContainerDA : DbContext
    {
        public dbStandContainerDA()
            : base("name=dbStandContainerDA")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Venda> Venda { get; set; }
        public virtual DbSet<Carro> Carro { get; set; }
        public virtual DbSet<Aluguer> Aluguer { get; set; }
        public virtual DbSet<Parcela> Parcela { get; set; }
        public virtual DbSet<Servico> Servico { get; set; }
    }
}
