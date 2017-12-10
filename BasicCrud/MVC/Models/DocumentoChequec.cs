namespace MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentoChequec")]
    public partial class DocumentoChequec
    {
        [Key]
        public int IdDocumentoChequeo { get; set; }

        public int? IdDocumentoRequerido { get; set; }

        public int? IdProyecto { get; set; }

        [Required]
        public string urlDocumento { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        public DateTime? FechaCreación { get; set; }

        public bool Cumplido { get; set; }

        public bool Active { get; set; }

        public virtual DocumentoChequeo DocumentoChequeo { get; set; }

        public virtual Proyecto Proyecto { get; set; }
    }
}
