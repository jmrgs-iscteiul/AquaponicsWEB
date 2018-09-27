using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquaponicsWebPortal.EntityFramework.Entities
{
    [Table("Event")]
    public class Events
    {
        public int id { get; set; }
        public DateTime Timestamp { get; set; }
        public int Event { get; set; }

    }
}
