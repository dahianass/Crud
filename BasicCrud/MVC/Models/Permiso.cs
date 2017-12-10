namespace MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Permisos")]
    public partial class Permiso
    {
        [Key]
        public int IdPermisos { get; set; }

        public int? IdRol { get; set; }

        public int? IdVista { get; set; }

        public bool Active { get; set; }

        public virtual Rol Rol { get; set; }

        public virtual Rol Rol1 { get; set; }

        public virtual Rol Rol2 { get; set; }

        public virtual Vista Vista { get; set; }
    }
}
