using Aura.Trellura.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aura.Trellura.Infra.Mappings
{
    public class BoardListMapping : IEntityTypeConfiguration<BoardList>
    {
        public void Configure(EntityTypeBuilder<BoardList> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Title)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.HasMany(b => b.Cards)
                .WithOne(c => c.BoardList)
                .HasForeignKey(c => c.BoardListId);
        }
    }
}
