using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stock.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Infra.Data.EntitiesConfiguration
{
    /*public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder) 
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.usernomecompleto).HasMaxLength(100).IsRequired();
            builder.Property(x => x.useremail).HasMaxLength(100).IsRequired();
            builder.Property(x => x.useridade).IsRequired();
            builder.Property(x => x.usersector).HasMaxLength(100).IsRequired();
            builder.Property(x => x.usernacionalidade).HasMaxLength(100).IsRequired();
        }
    }*/
}
