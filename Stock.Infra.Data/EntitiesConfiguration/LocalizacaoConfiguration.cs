using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Stock.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Infra.Data.EntitiesConfiguration
{
    public class LocalizacaoConfiguration
    {
        public void configure(EntityTypeBuilder<Localizacao> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.userpais).HasMaxLength(100).IsRequired();
            builder.Property(x => x.userprovincia).HasMaxLength(100).IsRequired();
            builder.Property(x => x.usercomuna).HasMaxLength(100) .IsRequired();
            builder.Property(x => x.userbairro).HasMaxLength(100).IsRequired();
            builder.Property(x => x.usernumerocasa).HasMaxLength(100).IsRequired();

            /*builder.HasOne(x => x.usuario).WithMany(x => x.localizacao)
              .HasForeignKey(x => x.usuarioid).OnDelete(DeleteBehavior.NoAction);*/
        }
    }
}
