using System;
using System.Data.Entity;
using AquaponicsWebPortal.EntityFramework.Entities;

namespace AquaponicsWebPortal.EntityFramework
{
    public class AquaponicsContext : DbContext
    {
        public AquaponicsContext() : base("Aquaponics")
        {

        }

        public DbSet<Events> Events { get; set; }
    }
}
