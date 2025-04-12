// Models/WarsServed.cs
namespace YourProjectNamespace.Models
{
    public class WarsServed
    {
        public int Id { get; set; }
        public string WarName { get; set; } // Example: "World War II", "Vietnam War", etc.
        public string Description { get; set; } // Description of the war or specific involvement

        public int MilitaryId { get; set; }
        public Military Military { get; set; } // Navigation property to the Military class
    }
}
