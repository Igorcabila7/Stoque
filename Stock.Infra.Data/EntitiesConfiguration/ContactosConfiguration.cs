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
    public class ContactosConfiguration
    {
        public void configure(EntityTypeBuilder<Contactos> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.usercodigopais).HasMaxLength(100).IsRequired();
            builder.Property(x => x.usertelefone1).HasMaxLength(100).IsRequired();
            builder.Property(x => x.usertelefone2).IsRequired();
            builder.Property(x => x.usertelefonefixo).HasMaxLength(100).IsRequired();

            builder.HasOne(x => x.usuarios).WithMany(x => x.Contactos)
              .HasForeignKey(x => x.usuarioid).OnDelete(DeleteBehavior.NoAction);

            
            
        }
    }
}
