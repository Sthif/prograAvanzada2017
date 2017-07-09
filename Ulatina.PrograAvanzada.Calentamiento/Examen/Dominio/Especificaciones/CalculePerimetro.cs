using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.Dominio.Especificaciones
{
    public class CalculePerimetro
    {
        public int PerimetroTriangulo(int lado1, int lado2, int lado3)
        {
            int elResultado = 0;
            var laValidacion = new Validaciones.Triangulo();
            bool ladosValidos = laValidacion.LadosTrianguloValidos(lado1, lado2, lado3);
            if (ladosValidos)
            {
                int elPerimetro = lado1 + lado2 + lado3;
                elResultado = elPerimetro;
            }
            return elResultado;
        }
    }
}