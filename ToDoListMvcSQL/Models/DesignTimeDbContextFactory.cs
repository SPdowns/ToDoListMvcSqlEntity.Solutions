using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ToDoListMvcSql.Models
{
  public class ToDoListMvcSqlContextFactory : IDesignTimeDbContextFactory<ToDoListMvcSqlContext>
  {

    ToDoListMvcSqlContext IDesignTimeDbContextFactory<ToDoListMvcSqlContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<ToDoListMvcSqlContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new ToDoListMvcSqlContext(builder.Options);
    }
  }
}