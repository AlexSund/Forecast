﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Server.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ForecastEF : DbContext
    {
        public ForecastEF()
            : base("name=ForecastEF")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<stock> stocks { get; set; }
        public virtual DbSet<subscription_types> subscription_types { get; set; }
        public virtual DbSet<subscription> subscriptions { get; set; }
        public virtual DbSet<user_stocks> user_stocks { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<forecast> forecasts { get; set; }
    }
}