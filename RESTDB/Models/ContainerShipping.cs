using System.ComponentModel.DataAnnotations;

namespace RESTDB.Models;

public class ContainerShipping
{
    [Key]
    public int? Id { get; set; }

    // The location from which the shipment is being made
    public string? ShipFrom { get; set; }

    // The destination location for the shipment
    public string? ShipTo { get; set; }

    // The name of the recipient
    public string? ShipToName { get; set; }

    // The name of the sender
    public string? ShipFromName { get; set; }

    // The street address of the sender
    public string? ShipFromStreet { get; set; }

    // The zip code of the sender's location
    public string? ShipFromZip { get; set; }

    // The township of the sender's location
    public string? ShipFromTownship { get; set; }

    // The locality of the sender's location
    public string? ShipFromLocality { get; set; }

    // The state of the sender's location
    public string? ShipFromState { get; set; }

    // The country of the sender's location
    public string? ShipFromCountry { get; set; }

    // The county of the sender's location
    public string? ShipFromCounty { get; set; }

    // The street address of the recipient
    public string? ShipToStreet { get; set; }

    // The zip code of the recipient's address
    public string? ShipToZip { get; set; }

    // The township of the recipient's location
    public string? ShipToTownship { get; set; }

    // The locality of the recipient's location
    public string? ShipToLocality { get; set; }

    // The state of the recipient's location
    public string? ShipToState { get; set; }

    // The country of the recipient's location
    public string? ShipToCountry { get; set; }

    // The county of the recipient's location
    public string? ShipToCounty { get; set; }

    // Any additional notes regarding the shipment
    public string? Notes { get; set; }
}
