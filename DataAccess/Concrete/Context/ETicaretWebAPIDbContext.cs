using DataAccess.Concrete.EntityFramework.Mapping;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Context
{
    public class ETicaretWebAPIDbContext:DbContext
    {
        public ETicaretWebAPIDbContext(DbContextOptions<ETicaretWebAPIDbContext> options) : base(options)
        {

        }
        public ETicaretWebAPIDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-E6USJ5B\\SQLEXPRESS; Initial Catalog=Veritabani; Integrated Security=False;");
        }
        //Data Source=.\\SQLEXPRESS; inital catalog=ApiDb; Integrated Security=True
        protected override void OnModelCreating(ModelBuilder optionsBuilder)
        {
            optionsBuilder.ApplyConfiguration(new UserMap());
        }
        public virtual DbSet<User> Users { get; set; }

    }
}
