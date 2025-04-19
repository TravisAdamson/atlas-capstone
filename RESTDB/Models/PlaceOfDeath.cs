using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class PlaceOfDeath
{
	[Key]
	public int RecordID { get; set; }

	public string? ServiceID { get; set; }
	public string? Name { get; set; }
	public string? MedicalRecordNumber { get; set; }
	public string? StreetAddress { get; set; }
	public string? AptNumber { get; set; }
	public string? TypeOfFacility { get; set; }
	public string? CallTakenBy { get; set; }
	public string? ZipCode { get; set; }
	public string? LocalityType { get; set; }
	public string? Township { get; set; }
	public string? Locality { get; set; }
	public string? State { get; set; }
	public string? County { get; set; }
	public string? Country { get; set; }
	public bool InCityLimits { get; set; }
	public DateTime? DirectorNotifyDate { get; set; }
	public DateTime? DirectorNotifedTime { get; set; }
	public DateTime? AdmissionDate { get; set; }
	public DateTime? BodyReleaseTime { get; set; }

	//Navigation Properties back to Primary Key
	[ForeignKey(nameof(ServiceID))]
    public Deceased? Deceased { get; set; }
}
