using System.ComponentModel.DataAnnotations;

namespace RESTDB.Models;

public class CauseOfDeath
{
	[Key]

	public int ClientID { get; set; }
	public string? Manner { get; set; } // The manner of death
	public string? Other { get; set; } // Other cause of death
	public string? CauseFactors { get; set; }
	public string? OtherFactors { get; set; }
	public string? TypeofFactor { get; set; }
	public string? Diabetic { get; set; }
	public bool DContributed { get; set; }
	public string? TobaccoUse { get; set; }
	public string? AlcoholUse { get; set; }
	public bool Hospitalized { get; set; }
	public bool DefferedDiag { get; set; }
	public bool CommDisease { get; set; }
	public bool DonationConsidered { get; set; }
	public bool DonationConsented { get; set; }
	public bool AnatGiftConsidered { get; set; }
	public bool Viewed { get; set; }
	public bool Biopsy { get; set; }
	public string? AnatGift { get; set; }
}
