using System;
using System.Collections.Generic;
using Entity;

namespace parcial2.Models
{
    public class PagoInputModel
    {
        public PagoInputModel(){
            
        }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Valor { get; set; }
        public decimal Iva { get; set; }
        public Persona Persona { get; set; }
    }
    public class PagoViewModel : PagoInputModel
    {
        public PagoViewModel()
        {
            Persona = new Persona();
        }
        public PagoViewModel(Pago pago)
        {
            Tipo = pago.Tipo;
            Fecha = pago.Fecha;
            Valor = pago.Valor;
            Iva = pago.Iva;   
            Persona = pago.Persona; 
        }
    }
}