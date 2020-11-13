using System.Security.Permissions;
using System.Collections.Generic;
using System.Linq;
using Entity;
using Logica;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using parcial2.Models;
using Datos;

namespace parcial2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController:ControllerBase
    {
        private readonly PersonaService _personaService;
       
        public PersonaController(Parcial2Context context)
        {
         _personaService = new PersonaService(context);
        }
        // GET: api/Persona
        [HttpGet]
        public IEnumerable<PersonaViewModel> Gets()
        {
            var personas = _personaService.ConsultarTodos().Select(p=>new PersonaViewModel(p));
            return personas;
        }
        
        
        // POST: api/Persona
        [HttpPost]
        public ActionResult<PersonaViewModel> Post(PersonaInputModel personaInput)
        {
            Persona persona = MapearPersona(personaInput);
            var response = _personaService.Guardar(persona);
            if (response.Error)
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Persona);
        }
        
        private Persona MapearPersona(PersonaInputModel personaInput)
        {
            var persona = new Persona();
                persona.Tipo = personaInput.Tipo;
                persona.Identificacion = personaInput.Identificacion;
                persona.Nombre = personaInput.Nombre;
                persona.Direccion = personaInput.Direccion;
                persona.Telefono = personaInput.Telefono;
                persona.Pais = personaInput.Pais;
                persona.Departamento = personaInput.Departamento;
                persona.Ciudad = personaInput.Ciudad;
            return persona;
        }
    }
}