namespace MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoProcesos")]
    public partial class TipoProceso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoProceso()
        {
            Chequeos = new HashSet<Chequeo>();
            Proyectos = new HashSet<Proyecto>();
        }

        [Key]
        public int IdTiposProcesos { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        public bool Active { get; set; }

        public bool UsoProyecto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chequeo> Chequeos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}
