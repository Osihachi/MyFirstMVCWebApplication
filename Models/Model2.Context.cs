﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFirstWebApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BAProject1Entities1 : DbContext
    {
        public BAProject1Entities1()
            : base("name=BAProject1Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<StateOfOrigination> StateOfOriginations { get; set; }
        public virtual DbSet<UserSignUp> UserSignUps { get; set; }
    }
}
