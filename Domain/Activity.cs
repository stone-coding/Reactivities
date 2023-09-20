namespace Domain
{
    public class Activity
    {
        // Earlier GUID was known as UUID. UUID stands for Universally
        // Unique Identifier. We use GUID for unique identifier.
        
        public Guid Id { get; set; } // Id each activity
        
        public string Title { get; set; } // Title of activity
        
        public DateTime Date { get; set; } // Date Time of activity 

        public string Description {get; set;} /// description of activity
        
        public string Category { get; set; } // Category of activity
        
        public string City { get; set; } // City of activity

        public string Venue { get; set; } // Location of activity

    }
}