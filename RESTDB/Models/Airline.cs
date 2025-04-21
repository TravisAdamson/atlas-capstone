using System.ComponentModel.DataAnnotations;

namespace RESTDB.Models;

public class Airline
{
	[Key]
	public int ClientID { get; set; }
	public string? AirlineName { get; set; }
	public string? Country { get; set; }
	public DateTime? Founded { get; set; }
	public string? IATA { get; set; }
	public string? ICAO { get; set; }
	public string? FleetSize { get; set; }
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
}
