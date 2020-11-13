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
    public class PagoController:ControllerBase
    {
        private readonly PagoService _pagoService;
       
        public PagoController(Parcial2Context context)
        {
         _pagoService = new PagoService(context);
        }
        [HttpGet]
        public IEnumerable<PagoViewModel> Gets()
        {
            var pagos = _pagoService.ConsultarTodos().Select(p=>new PagoViewModel(p));
            return pagos;
        }
        // POST: api/Persona
        [HttpPost]
        public ActionResult<PagoViewModel> Post(PagoInputModel pagoInput)
        {
            Pago pago = MapearPago(pagoInput);
            var response = _pagoService.Guardar(pago);
            if (response.Error)
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Pago);
        }
        private Pago MapearPago(PagoInputModel pagoInput)
        {
            var pago = new Pago();
                pago.Tipo = pagoInput.Tipo;
                pago.Fecha = pagoInput.Fecha;
                pago.Valor = pagoInput.Valor;
                pago.Iva = pagoInput.Iva;
                pago.Persona.Identificacion = pagoInput.Persona.Identificacion;
                pago.Persona.Tipo = pagoInput.Persona.Tipo;
                pago.Persona.Nombre = pagoInput.Persona.Nombre;
                pago.Persona.Direccion = pagoInput.Persona.Direccion;
                pago.Persona.Telefono = pagoInput.Persona.Telefono;
                pago.Persona.Pais = pagoInput.Persona.Pais;
                pago.Persona.Departamento = pagoInput.Persona.Departamento;
                pago.Persona.Ciudad = pagoInput.Persona.Ciudad;

            return pago;
        }
    }
}