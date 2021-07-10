namespace LeeryEscribir
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Empleados
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Cedula { get; set; }

        
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "numeric")]
        public decimal Sueldo { get; set; }

        [Required]
        [StringLength(6)]
        public string Moneda { get; set; }
    }
}
