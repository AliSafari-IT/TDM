using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class dbContext : DbContext
    {

        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {
        }

        //The OnConfiguring() method allows us to select and configure the data source to be used with a context using DbContextOptionsBuilder.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        //The OnModelCreating() method allows us to configure the model using ModelBuilder Fluent API.
        protected override void OnModelCreating(ModelBuilder modelBuilder){}


        //entities
        public DbSet<Document> Documents { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
