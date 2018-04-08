using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketAPI.Model
{
    public class Venue
    {
        [Column("Venue Name")]
        [StringLength(50)]
        public string Venue_Name { get; set; }

        [Column("Venue Location")]
        public string Venue_Location { get; set; }

        public int? Tickets { get; set; }

        public int VenueID { get; set; }

        [Column("Artist Name")]
        [StringLength(50)]
        public string Artist_Name { get; set; }
    }
}
