namespace MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ciudad")]
    public partial class Ciudad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ciudad()
        {
            Proyectos = new HashSet<Proyecto>();
        }

        [Key]
        public int IdCiudad { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(500)]
        public string Descriptcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}
