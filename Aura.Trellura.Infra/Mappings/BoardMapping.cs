using Aura.Trellura.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aura.Trellura.Infra.Mappings
{
    public class BoardMapping : IEntityTypeConfiguration<Board>
    {
        public void Configure(EntityTypeBuilder<Board> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Title)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.HasMany(b => b.BoardLists)
                .WithOne(l => l.Board)
                .HasForeignKey(l => l.BoardId);
        }
    }
}
