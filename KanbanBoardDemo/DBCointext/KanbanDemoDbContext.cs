using KanbanBoardDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace KanbanBoardDemo.DBCointext
{
    public class KanbanDemoDbContext : DbContext
    {
        public KanbanDemoDbContext(DbContextOptions<KanbanDemoDbContext> options): base(options)
        {
        }

        public DbSet<Board> Boards { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Column> Columns { get; set; }
    }
}
