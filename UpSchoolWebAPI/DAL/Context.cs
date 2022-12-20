using Microsoft.EntityFrameworkCore;
using UpSchoolWebAPI.DAL.Entities;

namespace UpSchoolWebAPI.DAL
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=.;initial catalog=UpSchoolAPI;integrated security=true;");
		}
		public DbSet<Category> Categories { get; set; }
	}
}
