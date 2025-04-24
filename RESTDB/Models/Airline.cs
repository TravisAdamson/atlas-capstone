using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class Airline
{
	[Key]
<<<<<<< HEAD
	public int ClientID { get; set; }
=======
	public int RecordID { get; set; }

	public string? ServiceID { get; set; }
>>>>>>> 4dd8b124d9da03867f5576e14f24419fe484a57b
	public string? AirlineName { get; set; }
	public string? Country { get; set; }
	public DateTime? Founded { get; set; }
	public string? IATA { get; set; }
	public string? ICAO { get; set; }
	public string? FleetSize { get; set; }
<<<<<<< HEAD
	public string? LogoUrl { get; set; }  // If you want to store the URL of the airline logo image.

	// Constructor
	public Airline() { }
	public Airline(string? airlineName, string? country, DateTime? founded, string? iata, string? icao, string? fleetSize, string? logoUrl)
	{
		AirlineName = airlineName;
		Country = country;
		Founded = founded;
		IATA = iata;
		ICAO = icao;
		FleetSize = fleetSize;
		LogoUrl = logoUrl;
	}
=======
	public string? LogoUrl { get; set; }

	//Navigation Properties back to Primary Key
	[ForeignKey(nameof(ServiceID))]
    public Deceased? Deceased { get; set; }
>>>>>>> 4dd8b124d9da03867f5576e14f24419fe484a57b
}
