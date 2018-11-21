using AquaponicsWebPortal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AquaponicsWebPortal.DAL
{
    public class AquaponicsDbContext : DbContext
    {
        public AquaponicsDbContext() : base("AquaponicsDbContext") {

        }
        
            public DbSet<Event> Events { get; set; }


    }
}