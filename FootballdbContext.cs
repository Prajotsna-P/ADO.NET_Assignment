using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FootballLeague.Models
{
        public class FootBalldbContext : DbContext
        {
            public FootBalldbContext()
                : base("name = FootballConnection")
            {

            }
            public DbSet<Football> FootballTable { get; set; }
        }
    
}