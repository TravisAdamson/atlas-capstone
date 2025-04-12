using System.ComponentModel.DataAnnotations;

namespace RESTDB.Models;

public class FlagApplication
{
	[Key]
	public int? Id { get; set; }

	public string? ApplicantName { get; set; }

	public string? RelationshipToDeceased { get; set; }

	public string? FlagType { get; set; }

	public DateTime? ApplicationDate { get; set; } = DateTime.Now;

	// Constructor
	public FlagApplication() { }

	public FlagApplication(string applicantName, string relationshipToDeceased, string flagType)
	{
		ApplicantName = applicantName;
		RelationshipToDeceased = relationshipToDeceased;
		FlagType = flagType;
	}
}
