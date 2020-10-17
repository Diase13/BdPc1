using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pc1.Models
{   
    [Table("t_practica")]
    public class Practica
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Nombre")]
        [Display(Name="Nombre")]
        [Column("name")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Apellido")]
        [Display(Name="Apellido")]
        [Column("lastname")]
        public String LastName { get; set; }

        [Display(Name="Distrito")]
        [Column("district")]
        public String District { get; set; }

        [Display(Name="Banco")]
        [Column("bank")]
        public String Bank { get; set; }

        [Display(Name="Edad")]
        [Column("age")]
        public String Age { get; set; }

        [Display(Name="Genero")]
        [Column("gender")]
        public String Gender { get; set; }

        [Display(Name="Author")]
        [Column("author")]
        public String Author { get; set; }

        [NotMapped]
        public String Response { get; set; }

    }
}