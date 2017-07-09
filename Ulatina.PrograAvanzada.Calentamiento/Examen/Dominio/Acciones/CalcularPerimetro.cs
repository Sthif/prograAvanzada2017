using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.Dominio.Acciones
{
    public class CalcularPerimetro
    {
        public int CalcularPerimetroTriangulo(int lado1, int lado2, int lado3)
        {
            int elResultado = 0;
            var laEspecificacion = new Especificaciones.CalculePerimetro();
            elResultado = laEspecificacion.PerimetroTriangulo(lado1, lado2, lado3);
            return elResultado;
        }
    }
}