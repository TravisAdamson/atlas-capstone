using System.ComponentModel.DataAnnotations;

namespace RESTDB.Models;

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