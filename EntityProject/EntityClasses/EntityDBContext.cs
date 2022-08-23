using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityProject.EntityClasses.Models;
using System.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EntityProject
{
    public class EntityDBContext : DbContext
    {
        public DbSet<Login> AllLogin { get; set; }
        public DbSet<TmcGroup> AllTmcGroup { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Tmc> AllTmc { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DocumentIn> AllDocumentIn { get; set; }
        public DbSet<DocumentInItems> AllDocumentInItems { get; set; }
        public DbSet<DocumentOut> AllDocumentOut { get; set; }
        public DbSet<DocumentOutItems> AllDocumentOutItems { get; set; }
        public DbSet<DocumentMoneyIn> AllDocumentMoneyIn { get; set; }
        public DbSet<DocumentMoneyInItems> AllDocumentMoneyInItems { get; set; }
        public DbSet<DocumentMoneyOut> AllDocumentMoneyOut { get; set; }
        public DbSet<FormSetting> AllFormSetting { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        }
    }
}
