namespace Clinic3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class take_Appointment
    {
        [Key]
        [StringLength(101)]
        public string Doctor { get; set; }

        public DateTime? Start { get; set; }

        public DateTime? End { get; set; }
    }
}
