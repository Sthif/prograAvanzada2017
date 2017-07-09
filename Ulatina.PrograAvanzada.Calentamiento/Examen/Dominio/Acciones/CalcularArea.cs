using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.Dominio.Acciones
{
    public class CalcularArea
    {
        public double CalcularAreaTriangulo(int lado1, int lado2, int lado3)
        {
            double elResultado = 0;
            var laEspecificacion = new Especificaciones.CalculeArea();
            elResultado = laEspecificacion.AreaTriangulo(lado1, lado2, lado3);
            return elResultado;
            //prueba
        }
    }
}