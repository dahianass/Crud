namespace MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentoChequeo")]
    public partial class DocumentoChequeo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocumentoChequeo()
        {
            DocumentoChequecs = new HashSet<DocumentoChequec>();
        }

        [Key]
        public int IdDocumento { get; set; }

        public int? IdEstadoDocumento { get; set; }

        public int? IdChequeo { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        public bool Requerido { get; set; }

        public bool Active { get; set; }

        public virtual Chequeo Chequeo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentoChequec> DocumentoChequecs { get; set; }

        public virtual EstadoDocumento EstadoDocumento { get; set; }
    }
}
