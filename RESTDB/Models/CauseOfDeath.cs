using System.ComponentModel.DataAnnotations;

namespace RESTDB.Models;

public class CauseOfDeath
{
	[Key]
	public int? Id { get; set; }

	// The manner of death
	public string? Manner { get; set; }

	// Other cause of death
	public string? Other { get; set; }

	public string? CauseFactors { get; set; }

	public string? OtherFactors { get; set; }

	public string? TypeofFactor { get; set; }

	public string? Diabetic { get; set; }

	public string? DContributed { get; set; }

	public string? TobaccoUse { get; set; }

	public string? AlcoholUse { get; set; }

	public string? Hospitalized { get; set; }

	public string? DefferedDiag { get; set; }

	public string? CommDisease { get; set; }

	public string? DonationConsidered { get; set; }

	public string? DonationConsented { get; set; }

	public string? AnatGiftConsidered { get; set; }

	public string? Viewed { get; set; }

	public string? Biopsy { get; set; }

	public string? AnatGift { get; set; }
}
