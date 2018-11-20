using System;
using System.Data.Entity;
using AquaponicsWebPortal.EntityFramework.Entities;

namespace AquaponicsWebPortal.EntityFramework
{
    public class AquaponicsContext : DbContext
    {
        public AquaponicsContext() : base("name=AquaponicsDbContext")
        {

        }

        public IDbSet<Events> Events { get; set; }
    }
}
