using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.Dominio.Acciones
{
    public class CalcularPerimetro
    {
        public double CalcularPerimetroTriangulo(double lado1, double lado2, double lado3)
        {
            double elResultado = 0;
            var laEspecificacion = new Especificaciones.CalculePerimetro();
            elResultado = laEspecificacion.PerimetroTriangulo(lado1, lado2, lado3);
            return elResultado;
        }

        public double CalcularPerimetroCuadrado(double _lado)
        {
          double ElResultado =0;
            var laEpecificacion = new Especificaciones.CalculePerimetro();
            ElResultado = laEpecificacion.PerimetroCuadrado(_lado);
            return ElResultado;

        } 


    }
}