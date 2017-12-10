namespace MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelGD : DbContext
    {
        public ModelGD()
            : base("name=ModelGD")
        {
        }

        public virtual DbSet<Chequeo> Chequeos { get; set; }
        public virtual DbSet<Ciudad> Ciudads { get; set; }
        public virtual DbSet<DocumentoChequec> DocumentoChequecs { get; set; }
        public virtual DbSet<DocumentoChequeo> DocumentoChequeos { get; set; }
        public virtual DbSet<EstadoDocumento> EstadoDocumentoes { get; set; }
        public virtual DbSet<Permiso> Permisos { get; set; }
        public virtual DbSet<Proyecto> Proyectos { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<TipoProceso> TipoProcesos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Vista> Vistas { get; set; }
        public virtual DbSet<Auditoria> Auditorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DocumentoChequeo>()
                .HasMany(e => e.DocumentoChequecs)
                .WithOptional(e => e.DocumentoChequeo)
                .HasForeignKey(e => e.IdDocumentoRequerido);

            modelBuilder.Entity<Proyecto>()
                .HasMany(e => e.DocumentoChequecs)
                .WithOptional(e => e.Proyecto)
                .HasForeignKey(e => e.IdProyecto);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.Permisos)
                .WithOptional(e => e.Rol)
                .HasForeignKey(e => e.IdRol);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.Permisos1)
                .WithOptional(e => e.Rol1)
                .HasForeignKey(e => e.IdRol);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.Permisos2)
                .WithOptional(e => e.Rol2)
                .HasForeignKey(e => e.IdRol);
        }
    }
}
