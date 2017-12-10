namespace MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Auditoria")]
    public partial class Auditoria
    {
        [Key]
        [Column(Order = 0)]
        public int IdAuditoria { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string NombreUsuario { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string Accion { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(200)]
        public string Descripcion { get; set; }

        public DateTime? FechaCreacion { get; set; }
    }
}
