namespace MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chequeo")]
    public partial class Chequeo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Chequeo()
        {
            DocumentoChequeos = new HashSet<DocumentoChequeo>();
        }

        [Key]
        public int IdChequeo { get; set; }

        public int? IdTiposProcesos { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        public bool Active { get; set; }

        public virtual TipoProceso TipoProceso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentoChequeo> DocumentoChequeos { get; set; }
    }
}
