namespace RESTDB.Data;

using Microsoft.EntityFrameworkCore;
using RESTDB.Models;


public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options) { }

	public DbSet<Deceased> Deceased { get; set; }
	public DbSet<Informant> Informant { get; set; }
	public DbSet<Address> Address { get; set; }
}
