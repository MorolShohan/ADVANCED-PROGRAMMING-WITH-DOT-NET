﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabTask1.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class labtaskEntities1 : DbContext
    {
        public labtaskEntities1()
            : base("name=labtaskEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<courseTbl> courseTbls { get; set; }
        public virtual DbSet<departmentTbl> departmentTbls { get; set; }
        public virtual DbSet<studentTbl> studentTbls { get; set; }
    }
}