using System.ComponentModel.DataAnnotations;

namespace RESTDB.Models;

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
