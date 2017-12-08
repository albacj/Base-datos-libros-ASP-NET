namespace LibrosMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Biblioteca")]
    public partial class Biblioteca
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string titulo { get; set; }

        [Required]
        [StringLength(50)]
        public string autor { get; set; }

        [Column(TypeName = "date")]
        public DateTime? publicacion { get; set; }
    }
}
