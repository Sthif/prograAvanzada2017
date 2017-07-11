using System;

namespace Examen.Dominio.Acciones
{
	internal class CalcularVolumen
	{
		public CalcularVolumen()
		{
		}

		internal double Cilindro(double radio, double altura)
		{
			double elResultado = 0;
			var laEspecificacion = new Especificaciones.CalculeVolumen();
			elResultado = laEspecificacion.VolumendelCilindro(radio,altura);
			return elResultado;
		}

		internal double Esfera(double radio)
		{
			double elResultado = 0;
			var laEspecificacion = new Especificaciones.CalculeVolumen();
			elResultado = laEspecificacion.VolumendelEsfera(radio);
			return elResultado;
		}

		internal double Cono(double radio, double altura)
		{
			double elResultado = 0;
			var laEspecificacion = new Especificaciones.CalculeVolumen();
			elResultado = laEspecificacion.VolumendelCono(radio, altura);
			return elResultado;
		}

		internal double Cubo(double arista)
		{
			double elResultado = 0;
			var laEspecificacion = new Especificaciones.CalculeVolumen();
			elResultado = laEspecificacion.VolumendelCubo(arista);
			return elResultado;
		}

		internal double Prisma(double largo, double ancho, double altura)
		{
			double elResultado = 0;
			var laEspecificacion = new Especificaciones.CalculeVolumen();
			elResultado = laEspecificacion.VolumendelPrisma(largo,ancho,altura);
			return elResultado;
		}

		internal double Cuadrada(double ladoBase, double altura)
		{
			double elResultado = 0;
			var laEspecificacion = new Especificaciones.CalculeVolumen();
			elResultado = laEspecificacion.VolumendelPiramideCuadrado(ladoBase, altura);
			return elResultado;
		}

		internal double PiramidePoligonal(double apotema, double altura, double cantLadosBaseYLargo)
		{
			double elResultado = 0;
			var laEspecificacion = new Especificaciones.CalculeVolumen();
			elResultado = laEspecificacion.VolumendePiramidePoligonal(apotema, altura,cantLadosBaseYLargo);
			return elResultado;
		}
	}
}