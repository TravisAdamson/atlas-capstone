using System.ComponentModel.DataAnnotations;

namespace RESTDB.Models;

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
