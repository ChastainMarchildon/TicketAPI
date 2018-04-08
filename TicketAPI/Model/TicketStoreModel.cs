using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketAPI.Model
{
    public class TicketStoreModel : DbContext
    {
        public TicketStoreModel(DbContextOptions<TicketStoreModel> options) : base(options)
        {

        }
        public DbSet<Venue> Venues { get; set; }
    }
}
