namespace MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Proyectos")]
    public partial class Proyecto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proyecto()
        {
            DocumentoChequecs = new HashSet<DocumentoChequec>();
        }

        [Key]
        public int IdProyectos { get; set; }

        public int? IdCiudad { get; set; }

        public int? IdTiposProcesos { get; set; }

        [Required]
        [StringLength(50)]
        public string CodigoProyecto { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreProyecto { get; set; }

        public DateTime? FechaCreación { get; set; }

        public bool Active { get; set; }

        public virtual Ciudad Ciudad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentoChequec> DocumentoChequecs { get; set; }

        public virtual TipoProceso TipoProceso { get; set; }
    }
}
