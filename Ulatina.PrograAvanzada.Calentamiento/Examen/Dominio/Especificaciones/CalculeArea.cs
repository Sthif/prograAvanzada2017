using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.Dominio.Especificaciones
{
    public class CalculeArea
    {
        public double AreaTriangulo(int lado1, int lado2, int lado3)
        {
            double elResultado = 0;
            var laValidacion = new Validaciones.Triangulo();
            bool ladosValidos = laValidacion.LadosTrianguloValidos(lado1, lado2, lado3);
            if (ladosValidos)
            {
                var elPerimetro = new CalculePerimetro();
                int elSemiPerimetro = elPerimetro.PerimetroTriangulo(lado1, lado2, lado3) / 2;
                int laSuma = elSemiPerimetro*(elSemiPerimetro-lado1)*(elSemiPerimetro-lado2)*(elSemiPerimetro-lado3);
                double elArea = Math.Sqrt(laSuma);
                elResultado = elArea;
            }
            return elResultado;
        }
    }
}