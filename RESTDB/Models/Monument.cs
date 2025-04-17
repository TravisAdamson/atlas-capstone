using System.ComponentModel.DataAnnotations;

namespace RESTDB.Models;

public class Monument
{
	[Key]

	public int ClientID { get; set; }

	public string? MonumentType { get; set; }

	public string? Material { get; set; }

	public string? Engraving { get; set; }

	public DateTime? CreatedAt { get; set; } = DateTime.Now;

	// Constructor
	public Monument() { }

	public Monument(string monumentType, string material, string engraving)
	{
		MonumentType = monumentType;
		Material = material;
		Engraving = engraving;
	}
}
