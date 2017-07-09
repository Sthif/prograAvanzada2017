using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.Dominio.Acciones
{
    public class CalcularArea
    {
        public double CalcularAreaTriangulo(double lado1, double lado2, double lado3)
        {
            double elResultado = 0;
            var laEspecificacion = new Especificaciones.CalculeArea();
            elResultado = laEspecificacion.AreaTriangulo(lado1, lado2, lado3);
            return elResultado;            
        }

        public double CalcularAreaCuadrilatero(double lado1, double lado2)
        {
            double elResultado = 0;
            var laEspecificacion = new Especificaciones.CalculeArea();
            elResultado = laEspecificacion.AreaCuadrilatero(lado1, lado2);
            return elResultado;
        }

        public double CalcularAreaRombo(double diagonalMayor, double diagonalMenor)
        {
            double elResultado = 0;
            var laEspecificacion = new Especificaciones.CalculeArea();
            elResultado = laEspecificacion.AreaRombo(diagonalMayor, diagonalMenor);
            return elResultado;
        }

        public double CalcularAreaPoligonoRegular(double lado, double apotema, int cantidadLados)
        {
            double elResultado = 0;
            var laEspecificacion = new Especificaciones.CalculeArea();
            elResultado = laEspecificacion.AreaPoligonoRegular(lado, apotema, cantidadLados);
            return elResultado;
        }

        public double CalcularAreaTrapecio(double baseMayor, double baseMenor, double altura)
        {
            double elResultado = 0;
            var laEspecificacion = new Especificaciones.CalculeArea();
            elResultado = laEspecificacion.AreaTrapecio(baseMayor, baseMenor, altura);
            return elResultado;
        }
    }
}