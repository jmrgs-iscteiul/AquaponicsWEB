using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AquaponicsWebPortal.Models
{
    [Table("Event")]
    public class Event
    {
        [Key]
        public int Id { get; set; }

        public DateTime Timestamp { get; set; }

        [Column("Event")]
        public int Evento { get; set; }

    }
}