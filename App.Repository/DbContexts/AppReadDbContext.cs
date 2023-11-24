using App.Domain.Entities;
using App.Repository.TypeConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository.Contexts
{
    public class AppReadDbContext : DbContext
    {
        public AppReadDbContext()
        {
        }

        public AppReadDbContext(DbContextOptions<AppReadDbContext> options) : base(options)
        {
        }
        public DbSet<Product> products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //warning To protect potentially sensitive information in your connection string,
        //you should move it out of source code. You can avoid scaffolding the connection string by using
        //the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148.
        //For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("Data Source=DESKTOP-BQPQRM2;Initial Catalog=GeneralApp;Integrated Security=True;Encrypt=False");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductEntityTypeConfiguration());
        }

    }
}
