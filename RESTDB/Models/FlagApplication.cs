using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class FlagApplication
{
	[Key]
<<<<<<< HEAD
	public int ClientID { get; set; }
=======
	public int RecordID { get; set; }

	public string? ServiceID { get; set; }
>>>>>>> 4dd8b124d9da03867f5576e14f24419fe484a57b
	public string? ApplicantName { get; set; }
	public string? RelationshipToDeceased { get; set; }
	public string? FlagType { get; set; }
	public DateTime? ApplicationDate { get; set; } = DateTime.Now;

<<<<<<< HEAD
	// Constructor
	public FlagApplication() { }
	public FlagApplication(string applicantName, string relationshipToDeceased, string flagType)
	{
		ApplicantName = applicantName;
		RelationshipToDeceased = relationshipToDeceased;
		FlagType = flagType;
	}
=======
	//Navigation Properties back to Primary Key
	[ForeignKey(nameof(ServiceID))]
    public Deceased? Deceased { get; set; }
>>>>>>> 4dd8b124d9da03867f5576e14f24419fe484a57b
}
