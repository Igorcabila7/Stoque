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
    internal class ProdutoConfiguration
    {
        public void configure(EntityTypeBuilder<produto> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.produtonome).HasMaxLength(100).IsRequired();
            builder.Property(x => x.produtoFotografia).IsRequired();
            builder.Property(x => x.categoria).HasMaxLength(100).IsRequired();
            builder.Property(x => x.tipo).HasMaxLength(100).IsRequired();
            builder.Property(x => x.preco).IsRequired();
            builder.Property(x => x.quantidade).IsRequired();
            builder.Property(x => x.Total).IsRequired();

        }
    }
}
