using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

public class BlogDataContext : DbContext
{
    static readonly string connectionString = "Server=localhost; User ID=travis; Password=travis; Database=blog";

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

public class Deceased
{
	[Key]
	public required int ClientID { get; set; }

	public required string FirstName { get; set; }
	public required string LastName { get; set; }
	public string? MiddleName { get; set; }
	public string? Title { get; set; }
	public string? Suffix { get; set; }
	public string? Status { get; set; }
	public Address? Address { get; set; }
	public string? ContractBalance { get; set; }
	public DateTime? DoD { get; set; }
	public DateTime? TimeOfDeath { get; set; }
	public int? SSN { get; set; }
	public string? Gender { get; set; }
	public string? MaidenName { get; set; }
	public string? Alias { get; set; }
	public int? PhoneNum { get; set; }
	public int? Vet { get; set; }
	public string? War { get; set; }
	public Informant? Informant { get; set; }
	public string? InformEmail { get; set; }
	public DateTime? InfoNotified { get; set; }
	public string? Notes { get; set; }

}

public class Informant
{
	[Key]
	public required int InfoId { get; set; }

	public required string FirstName { get; set; }
	public required string LastName { get; set; }
	public string? MiddleName { get; set; }
	public Address? Address { get; set; }
	public string? Email { get; set; }

}

public class Address
{
	[Key]
	public required string Street { get; set; }

	public string? AptNo { get; set; }
	public required int ZipCode { get; set; }
	public required string City { get; set; }
	public required string State { get; set; }
	public string? County { get; set; }
}
