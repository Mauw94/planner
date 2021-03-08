using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planner.API.Models
{
    /// <summary>
    /// Class defining an event.
    /// </summary>
    public class Event
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
