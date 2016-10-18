using System.Collections.Generic;

namespace Termineverwaltung.Data
{
    using System;
    //using System.ComponentModel.DataAnnotations;
    //using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    //  [Table("Mitarbeiter")]
    public partial class Mitarbeiter
    {
        // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        //[Required]
        //[StringLength(50)]
        public string Nachname { get; set; }

        // [StringLength(50)]
        public string Vorname { get; set; }

        public DateTime Geburtsdatum { get; set; }

        public bool IstBehandler { get; set; }

        public ICollection<Patiententermin> Termine { get; set; }

    }
}
