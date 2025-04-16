namespace RESTDB.Data;

using Microsoft.EntityFrameworkCore;
using RESTDB.Models;

public class ApplicationDbContext : DbContext
{
	static readonly string connectionString = "Server=localhost; User ID=travis; Password=travis; Database=restdb";

	public DbSet<Deceased> Deceased { get; set; }
	public DbSet<CashAdvance> CashAdvance { get; set; }
    public DbSet<ObituaryData> ObituaryData { get; set; }
    public DbSet<Survivors> Survivors { get; set; }
    public DbSet<Buyer> Buyer { get; set; }
    public DbSet<ServiceContract> ServiceContract { get; set; }
	public DbSet<Services> Services { get; set; }
    public DbSet<PlaceOfDeath> PlaceOfDeath { get; set; }
    public DbSet<ContainerShipping> ContainerShipping { get; set; }
	public DbSet<Military> Military { get; set; }
	public DbSet<Embalmer> Embalmer { get; set; }
	public DbSet<Airline> Airline { get; set; }
	public DbSet<FlagApplication> FlagApplication { get; set; }
	public DbSet<Monument> Monument { get; set; }
	public DbSet<Products> Products { get; set; }
	public DbSet<MilitaryStint> MilitaryStint { get; set; }
	public DbSet<WarsServed> WarsServed { get; set; }
	public DbSet<CauseOfDeath> CauseOfDeath { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
	}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Deceased>()
            .HasIndex(e => e.ServiceID)
            .IsUnique();
    }

	[STAThread]
	static void Main()
	{
	}
}
