namespace LibrosMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BibliotecaContext : DbContext
    {
        public BibliotecaContext()
            : base("name=BibliotecaContext")
        {
        }

        public virtual DbSet<Biblioteca> Biblioteca { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
