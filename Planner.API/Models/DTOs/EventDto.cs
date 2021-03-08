namespace Planner.API.Models.DTOs
{
    /// <summary>
    /// The DTO for an event class.
    /// </summary>
    public class EventDto
    {
        /// <summary>
        /// The id.
        /// </summary>
        public long Id { get; set; }
        
        /// <summary>
        /// The description.
        /// </summary>
        public string Description { get; set; }
    }
}