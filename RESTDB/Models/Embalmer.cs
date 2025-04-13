using System.ComponentModel.DataAnnotations;

namespace RESTDB.Models;

public class Embalmer
{
	[Key]
    public int? Id { get; set; }

    // Whether permission has been given for embalming
    public bool PermissionToEmbalm { get; set; }

    // Whether the embalming has been performed
    public bool Embalmed { get; set; }

    // The date when embalming was performed
    public DateTime? EmbalmedDate { get; set; }

    // The time when embalming was performed
    public DateTime? EmbalmedTime { get; set; }

    // The name of the embalmer
    public string? EmbalmedBy { get; set; }

    // The person who authorized the embalming
    public string? EmbalmingAuthorizor { get; set; }
}
