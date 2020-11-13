using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class Pago
    {
        public Pago() {
            Persona = new Persona();
        }
        [Key]
        public int Codigo { get; set; }

        [Column(TypeName = "varchar(12)")]
        public string Tipo { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Fecha { get; set; }
        
        [Column(TypeName = "decimal(16)")]
        public decimal Valor { get; set; }

        [Column(TypeName = "decimal(10)")]
        public decimal Iva { get; set; }

        public Persona Persona { get; set; }  
    }
}