using System;

namespace Termineverwaltung.Data
{
    public class Patiententermin
    {
        public int Id { get; set; }

        public DateTime Termin { get; set; }

        public TimeSpan Dauer { get; set; }

        public int MitareiterId { get; set; }

        public Mitarbeiter Behandler { get; set; }




    }
}
