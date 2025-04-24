using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDB.Models;

public class ContainerShipping
{
	[Key]
<<<<<<< HEAD
	public int ClientID { get; set; }
	public string? ShipFrom { get; set; } // The location from which the shipment is being made
	public string? ShipTo { get; set; } // The destination location for the shipment
	public string? ShipToName { get; set; } // The name of the recipient
	public string? ShipFromName { get; set; } // The name of the sender
	public string? ShipFromStreet { get; set; } // The street address of the sender
	public string? ShipFromZip { get; set; } // The zip code of the sender's location
	public string? ShipFromTownship { get; set; } // The township of the sender's location
	public string? ShipFromLocality { get; set; } // The locality of the sender's location
	public string? ShipFromState { get; set; } // The state of the sender's location
	public string? ShipFromCountry { get; set; } // The country of the sender's location
	public string? ShipFromCounty { get; set; } // The county of the sender's location
	public string? ShipToStreet { get; set; } // The street address of the recipient
	public string? ShipToZip { get; set; } // The zip code of the recipient's address
	public string? ShipToTownship { get; set; } // The township of the recipient's location
	public string? ShipToLocality { get; set; } // The locality of the recipient's location
	public string? ShipToState { get; set; } // The state of the recipient's location
	public string? ShipToCountry { get; set; } // The country of the recipient's location
	public string? ShipToCounty { get; set; } // The county of the recipient's location
	public string? Notes { get; set; } // Any additional notes regarding the shipment
=======
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
>>>>>>> 4dd8b124d9da03867f5576e14f24419fe484a57b
}
