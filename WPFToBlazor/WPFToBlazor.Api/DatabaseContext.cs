using Microsoft.EntityFrameworkCore;
using WPFToBlazor.Data.Model;

namespace WPFToBlazor.Api
{
    public class DatabaseContext : DbContext
    {
        public static readonly string workingDirectory = Directory.GetCurrentDirectory();
        public string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=" +
          Path.Combine(projectDirectory, "Database.db"));

        

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<TestModel> TM { get; set; }
        public object Categories { get; internal set; }
        public DbSet<WPFToBlazor.Data.Model.BillDataModel> BillDataModel { get; set; } = default!;
        public DbSet<WPFToBlazor.Data.Model.BillRowItem> BillRowItem { get; set; } = default!;
        public DbSet<WPFToBlazor.Data.Model.Category> Category { get; set; } = default!;
        public DbSet<WPFToBlazor.Data.Model.Transaction> Transaction { get; set; } = default!;
        //public DbSet<BillRowItem> BillRowItems { get; set; }

        //public DbSet<Transaction> Transactions { get; set; }
    }
}
