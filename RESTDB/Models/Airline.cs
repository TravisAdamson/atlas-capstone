using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class Airline
{
	[Key]
	public int RecordID { get; set; }

	public string? ServiceID { get; set; }
	public string? AirlineName { get; set; }
	public string? Country { get; set; }
	public DateTime? Founded { get; set; }
	public string? IATA { get; set; }
	public string? ICAO { get; set; }
	public string? FleetSize { get; set; }
	public string? LogoUrl { get; set; }

	//Navigation Properties back to Primary Key
	[ForeignKey(nameof(ServiceID))]
    public Deceased? Deceased { get; set; }
}
