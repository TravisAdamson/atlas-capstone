using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class ContainerShipping
{
	[Key]
	public int RecordID { get; set; }

	public string? ServiceID { get; set; }
	public string? ShipFrom { get; set; }
	public string? ShipTo { get; set; }
	public string? ShipToName { get; set; }
	public string? ShipFromName { get; set; }
	public string? ShipFromStreet { get; set; }
	public string? ShipFromZip { get; set; }
	public string? ShipFromTownship { get; set; }
	public string? ShipFromLocality { get; set; }
	public string? ShipFromState { get; set; }
	public string? ShipFromCountry { get; set; }
	public string? ShipFromCounty { get; set; }
	public string? ShipToStreet { get; set; }
	public string? ShipToZip { get; set; }
	public string? ShipToTownship { get; set; }
	public string? ShipToLocality { get; set; }
	public string? ShipToState { get; set; }
	public string? ShipToCountry { get; set; }
	public string? ShipToCounty { get; set; }
	public string? Notes { get; set; }

	//Navigation Properties back to Primary Key
	[ForeignKey(nameof(ServiceID))]
    public Deceased? Deceased { get; set; }
}
