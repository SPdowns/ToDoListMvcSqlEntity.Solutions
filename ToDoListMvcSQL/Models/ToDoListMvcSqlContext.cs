using Microsoft.EntityFrameworkCore;

namespace ToDoListMvcSql.Models
{
  public class ToDoListMvcSqlContext : DbContext
  {
    public virtual DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<CategoryItem> CategoryItem { get; set;}

    public ToDoListMvcSqlContext(DbContextOptions options) : base(options) { }
  }
}