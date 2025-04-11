using System.ComponentModel.DataAnnotations;

namespace RESTDB.Models;

public class Deceased
{
	[Key]
	public int? ClientID { get; set; }
	public string? Director { get; set; }
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
	public string? MiddleName { get; set; }
	public string? Title { get; set; }
	public string? Suffix { get; set; }
	public string? Status { get; set; }
	public string? StreetAddress { get; set; }
	public string? City { get; set; }
	public string? State { get; set; }
	public string? ZipCode { get; set; }
	public string? ContractBalance { get; set; }
	public DateTime? DoD { get; set; }
	public DateTime? TimeOfDeath { get; set; }
	public string? SSN { get; set; }
	public string? Gender { get; set; }
	public string? MaidenName { get; set; }
	public string? Alias { get; set; }
	public string? Vet { get; set; }
	public string? War { get; set; }
	public string? InformantName { get; set; }
	public string? IStreetAddress { get; set; }
	public string? ICity { get; set; }
	public string? IState { get; set; }
	public string? IZipCode { get; set; }
	public string? IPhoneNumber { get; set; }
	public string? InformantEmail { get; set; }
	public DateTime? InfoNotified { get; set; }
	public string? Notes { get; set; }
	public byte[]? Image { get; set; }
	public string? InformantRelation { get; set; }
}
