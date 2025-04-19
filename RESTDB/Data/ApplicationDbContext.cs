using Microsoft.EntityFrameworkCore;
using RESTDB.Models;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace RESTDB.Data;

public class ApplicationDbContext : IdentityDbContext<AppUser>
{
	static readonly string connectionString = "Server=localhost; User ID=travis; Password=travis; Database=restdb";

	public DbSet<Deceased> Deceased { get; set; }
	public DbSet<Airline> Airline { get; set; }
    public DbSet<Buyer> Buyer { get; set; }
	public DbSet<CashAdvance> CashAdvance { get; set; }
	public DbSet<CauseOfDeath> CauseOfDeath { get; set; }
    public DbSet<ContainerShipping> ContainerShipping { get; set; }
	public DbSet<Embalmer> Embalmer { get; set; }
	public DbSet<FlagApplication> FlagApplication { get; set; }
	public DbSet<Military> Military { get; set; }
	public DbSet<MilitaryStint> MilitaryStint { get; set; }
	public DbSet<Monument> Monument { get; set; }
    public DbSet<ObituaryData> ObituaryData { get; set; }
    public DbSet<PlaceOfDeath> PlaceOfDeath { get; set; }
	public DbSet<Products> Products { get; set; }
    public DbSet<ServiceContract> ServiceContract { get; set; }
	public DbSet<Services> Services { get; set; }
    public DbSet<Survivors> Survivors { get; set; }
	public DbSet<WarsServed> WarsServed { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
	}

	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options)
	{
	}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Deceased>()
            .HasIndex(e => e.ServiceID)
            .IsUnique();

        ConfigureDeceasedRelationship<Airline>(
            modelBuilder,
            a => a.Deceased,
            d => d.Airline
        );

        ConfigureDeceasedRelationship<Buyer>(
            modelBuilder,
            b => b.Deceased,
            d => d.Buyer
        );

        ConfigureDeceasedRelationship<CashAdvance>(
            modelBuilder,
            p => p.Deceased,
            d => d.CashAdvance
        );

        ConfigureDeceasedRelationship<CauseOfDeath>(
            modelBuilder,
            p => p.Deceased,
            d => d.CauseOfDeath
        );

        ConfigureDeceasedRelationship<ContainerShipping>(
            modelBuilder,
            p => p.Deceased,
            d => d.ContainerShipping
        );

        ConfigureDeceasedRelationship<Embalmer>(
            modelBuilder,
            p => p.Deceased,
            d => d.Embalmer
        );

        ConfigureDeceasedRelationship<FlagApplication>(
            modelBuilder,
            p => p.Deceased,
            d => d.FlagApplication
        );

        ConfigureDeceasedRelationship<Military>(
            modelBuilder,
            p => p.Deceased,
            d => d.Military
        );

        ConfigureDeceasedRelationship<MilitaryStint>(
            modelBuilder,
            p => p.Deceased,
            d => d.MilitaryStint
        );

        ConfigureDeceasedRelationship<Monument>(
            modelBuilder,
            p => p.Deceased,
            d => d.Monument
        );

        ConfigureDeceasedRelationship<ObituaryData>(
            modelBuilder,
            p => p.Deceased,
            d => d.ObituaryData
        );

        ConfigureDeceasedRelationship<PlaceOfDeath>(
            modelBuilder,
            p => p.Deceased,
            d => d.PlaceOfDeath
        );

        ConfigureDeceasedRelationship<Products>(
            modelBuilder,
            p => p.Deceased,
            d => d.Products
        );

        ConfigureDeceasedRelationship<ServiceContract>(
            modelBuilder,
            p => p.Deceased,
            d => d.ServiceContract
        );

        ConfigureDeceasedRelationship<Services>(
            modelBuilder,
            p => p.Deceased,
            d => d.Services
        );

        ConfigureDeceasedRelationship<Survivors>(
            modelBuilder,
            p => p.Deceased,
            d => d.Survivors
        );

        ConfigureDeceasedRelationship<WarsServed>(
            modelBuilder,
            p => p.Deceased,
            d => d.WarsServed
        );

		base.OnModelCreating(modelBuilder);
    }

	private void ConfigureDeceasedRelationship<TEntity>(
		ModelBuilder modelBuilder,
		Expression<Func<TEntity, Deceased?>> deceasedNav,
		Expression<Func<Deceased, IEnumerable<TEntity>>> deceasedCollection
	) where TEntity : class
	{
		modelBuilder.Entity<TEntity>()
			.HasOne(deceasedNav)
			.WithMany(deceasedCollection)
			.HasForeignKey("ServiceID")
			.OnDelete(DeleteBehavior.Cascade);
	}

	[STAThread]
	static void Main()
	{
	}
}
