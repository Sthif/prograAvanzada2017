using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.Dominio.Especificaciones
{
    public class CalculeArea
    {
        public double AreaTriangulo(double lado1, double lado2, double lado3)
        {
            double elResultado = 0;
            var laValidacion = new Validaciones.LadosValidos();
            bool ladosValidos = laValidacion.LadosTrianguloValidos(lado1, lado2, lado3);
            if (ladosValidos)
            {
                var elPerimetro = new CalculePerimetro();
                double elSemiPerimetro = elPerimetro.PerimetroTriangulo(lado1, lado2, lado3) / 2;
                double laSuma = elSemiPerimetro*(elSemiPerimetro-lado1)*(elSemiPerimetro-lado2)*(elSemiPerimetro-lado3);
                double elArea = Math.Sqrt(laSuma);
                elResultado = elArea;
            }
            return elResultado;
        }

        public double AreaCuadrilatero(double lado1, double lado2)
        {
            double elResultado = 0;
            var laValidacion = new Validaciones.LadosValidos();
            bool ladosValidos = laValidacion.LadosPositivos(lado1, lado2);
            if (ladosValidos)
            {
                double elArea = lado1 * lado2;
                elResultado = elArea;
            }
            return elResultado;
        }

        public double AreaRombo(double diagonalMayor, double diagonalMenor)
        {
            double elResultado = 0;
            var laValidacion = new Validaciones.LadosValidos();
            bool ladosValidos = laValidacion.LadosPositivos(diagonalMayor, diagonalMenor);
            if (ladosValidos)
            {
                double elArea = (diagonalMayor * diagonalMenor) / 2;
                elResultado = elArea;
            }
            return elResultado;
        }

        public double AreaPoligonoRegular(double lado, double apotema, int cantidadLados)
        {
            double elResultado = 0;
            var laValidacion = new Validaciones.LadosValidos();
            bool ladosValidos = laValidacion.LadosPositivos(lado, apotema);
            bool cantidadValida = laValidacion.CantidadValida(cantidadLados);
            if (ladosValidos && cantidadValida)
            {
                double elArea = (cantidadLados * lado * apotema) / 2;
                elResultado = elArea;
            }
            return elResultado;
        }

        internal double AreaTrapecio(double baseMayor, double baseMenor, double altura)
        {
            double elResultado = 0;
            var laValidacion = new Validaciones.LadosValidos();
            bool ladosValidos = laValidacion.LadosPositivos(baseMayor, baseMenor, altura);
            if (ladosValidos)
            {
                double elArea = altura * ((baseMayor + baseMenor) / 2);
                elResultado = elArea;
            }
            return elResultado;
        }
    }
}