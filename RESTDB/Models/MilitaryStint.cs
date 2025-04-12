// Models/MilitaryStint.cs
namespace YourProjectNamespace.Models
{
    public class MilitaryStint
    {
        public int Id { get; set; }
        public string Description { get; set; } // Example: "Deployed in Afghanistan"
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int MilitaryId { get; set; }
        public Military Military { get; set; } // Navigation property to the Military class
    }
}
