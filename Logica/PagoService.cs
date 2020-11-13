using System;
using System.Collections.Generic;
using Datos;
using Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Logica
{
    public class PagoService
    {
        private readonly Parcial2Context _context;
        public PagoService(Parcial2Context context){
            _context = context;
        }
        public GuardarPagoResponse Guardar(Pago pago)
        {
            try
            {
                _context.Pagos.Add(pago);
                _context.SaveChanges();
                return new GuardarPagoResponse(pago);
            }
            catch (Exception e)
            {
                return new GuardarPagoResponse($"Error de la Aplicacion: {e.Message}");
            }
            finally { }
        }
        public List<Pago> ConsultarTodos()
        {
            List<Pago> Pagos = _context.Pagos.Include(p => p.Persona).ToList();
            return Pagos;
        }
        /*
        public Persona BuscarxIdentificcion(string identificacion){
            return _context.Personas.Find(identificacion);
        }*/
    }
    public class GuardarPagoResponse 
    {
        public GuardarPagoResponse(Pago pago)
        {
            Error = false;
            Pago = pago;
        }
        public GuardarPagoResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Pago Pago { get; set; }
    }
}