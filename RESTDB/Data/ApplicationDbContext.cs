namespace RESTDB.Data;

using Microsoft.EntityFrameworkCore;
using RESTDB.Models;


public class ApplicationDbContext : DbContext
{
     static readonly string connectionString = "Server=localhost; User ID=travis; Password=travis; Database=restdb";

     public DbSet<Deceased> Deceased { get; set; }
     public DbSet<Informant> Informant { get; set; }
 	public DbSet<Address> Address { get; set; }
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     {
         optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
     }

 	[STAThread]
 	static void Main()
 	{
 	}
}
