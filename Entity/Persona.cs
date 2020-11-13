using System;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class Persona
    {
        [Key]
        [Column(TypeName = "varchar(12)")]
        public string Identificacion { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Tipo { get; set; }
        
        [Column(TypeName = "varchar(30)")]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Direccion { get; set; }

        [Column(TypeName = "varchar(12)")]
        public string Telefono { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Pais { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Departamento { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Ciudad { get; set; }
    }
}
