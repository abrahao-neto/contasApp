using ContasApp.Data.Configurations;
using ContasApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasApp.Data.Contexts
{
    //Regra 1: Herdar a classe DbContext
    public class DataContext : DbContext
    {
        //Regra 2: Sobrescrever o método OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //definindo o tipo de banco de dados do projeto
            optionsBuilder.UseSqlServer("Data Source=NETO\\SQLEXPRESS;Initial Catalog=BDContasApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            //optionsBuilder.UseSqlServer("Data Source=SQL8005.site4now.net,1433;Initial Catalog=db_a99f04_bdcontasapp;User Id=db_a99f04_bdcontasapp_admin;Password=Jesus@2023;");
        }

        //Regra 3: Sobrescrever o método OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //adicionar cada classe de configuração criada no projeto
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new ContaConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        }

        //Regra 4: Mapear cada entidade do projeto através do DbSet
        public DbSet<Categoria>? Categoria { get; set; }
        public DbSet<Conta>? Conta { get; set; }
        public DbSet<Usuario>? Usuario { get; set; }
    }
}
