using Aura.Trellura.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aura.Trellura.Infra.Context
{
    public class TrelluraDbContext : DbContext
    {
        public TrelluraDbContext(DbContextOptions<TrelluraDbContext> options) : base(options)
        {

        }

        public DbSet<Board> Boards { get; set; }
        public DbSet<BoardList> BoardLists { get; set; }
        public DbSet<Card> Cards { get; set; }
    }
}
