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
    public class MovimentoStockConfiguration
    {
        public void configure(EntityTypeBuilder<movimentostock> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.dateTime).IsRequired();
            builder.Property(x => x.movimento).HasMaxLength(100).IsRequired();
        }
    }
}
