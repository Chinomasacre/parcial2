using System;
using System.Collections.Generic;
using Entity;

namespace parcial2.Models
{
    public class PersonaInputModel
    {
        public PersonaInputModel(){
            
        }
        public string Identificacion { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Pais { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
       
    }
    public class PersonaViewModel : PersonaInputModel
    {
        public PersonaViewModel(Persona persona)
        {
            Identificacion = persona.Identificacion;
            Tipo = persona.Tipo;
            Nombre = persona.Nombre;
            Direccion = persona.Direccion;
            Telefono = persona.Telefono;   
            Pais = persona.Pais;
            Departamento = persona.Departamento;   
            Ciudad = persona.Ciudad;  
        }
    }
}