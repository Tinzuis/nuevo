﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ContextoContainer : DbContext
    {
        public ContextoContainer()
            : base("name=ContextoContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Formulario> Formulario { get; set; }
        public virtual DbSet<permiso> permisoSet { get; set; }
        public virtual DbSet<Perfil> Perfiles { get; set; }
        public virtual DbSet<Ventas> Ventas { get; set; }
        public virtual DbSet<Detalle_ventas> Detalle_ventas { get; set; }
        public virtual DbSet<Articulos> Articulos { get; set; }
    }
}
