using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users", @"dbo");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.UserName).HasColumnName("UserName").HasMaxLength(50).IsRequired();
            builder.Property(x => x.FirstName).HasColumnName("FirstName").HasMaxLength(50).IsRequired();
            builder.Property(x => x.LastName).HasColumnName("LastName").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Gender).HasColumnName("Gender").HasMaxLength(50).IsRequired();
            builder.Property(x => x.DateOfBirth).HasColumnName("DateOfBirth").HasMaxLength(50).IsRequired();
            builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            builder.HasData(new User
            {
                FirstName = "Mustafa Yasin",
                LastName = "Bayır",
                UserName = "mysnbyr",
                Password = "123",
                Gender = true,
                DateOfBirth = Convert.ToDateTime("30-01-1993"),
                CreatedDate = DateTime.Now,
                ID = 1,
                Adress = "Ankara",
                Email = "myb@gmail.com",


            });
        }
    }
}
