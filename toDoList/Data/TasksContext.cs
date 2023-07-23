using Microsoft.EntityFrameworkCore;
using toDoList.Models;

namespace toDoList.Data
{
	public class TasksContext : DbContext
	{
		public DbSet<Tasks> Tasks { get; set; }
		protected readonly string ConnectionString;

		public TasksContext(string connectionString)
		{
			ConnectionString = connectionString;
		}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString);
        }
    }
}

