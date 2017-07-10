using System;

namespace Examen.Dominio.Acciones
{
	internal class CalcularVolumen
	{
		public CalcularVolumen()
		{
		}

		internal double Cilindro(int radio, int altura)
		{
			double elResultado = 0;
			var laEspecificacion = new Especificaciones.CalculeVolumen();
			elResultado = laEspecificacion.VolumendelCilindro(radio,altura);
			return elResultado;
		}

		internal double Esfera(int radio)
		{
			double elResultado = 0;
			var laEspecificacion = new Especificaciones.CalculeVolumen();
			elResultado = laEspecificacion.VolumendelEsfera(radio);
			return elResultado;
		}

		internal double Cono(int radio, int altura)
		{
			double elResultado = 0;
			var laEspecificacion = new Especificaciones.CalculeVolumen();
			elResultado = laEspecificacion.VolumendelCono(radio, altura);
			return elResultado;
		}

		internal double Cubo(int arista)
		{
			double elResultado = 0;
			var laEspecificacion = new Especificaciones.CalculeVolumen();
			elResultado = laEspecificacion.VolumendelCubo(arista);
			return elResultado;
		}

		internal double Prisma(int largo, int ancho, int altura)
		{
			double elResultado = 0;
			var laEspecificacion = new Especificaciones.CalculeVolumen();
			elResultado = laEspecificacion.VolumendelPrisma(largo,ancho,altura);
			return elResultado;
		}

		internal double Cuadrada(int ladoBase, int altura)
		{
			double elResultado = 0;
			var laEspecificacion = new Especificaciones.CalculeVolumen();
			elResultado = laEspecificacion.VolumendelPiramideCuadrado(ladoBase, altura);
			return elResultado;
		}

		internal double PiramidePoligonal(int apotema, int altura, int cantLadosBaseYLargo)
		{
			double elResultado = 0;
			var laEspecificacion = new Especificaciones.CalculeVolumen();
			elResultado = laEspecificacion.VolumendePiramidePoligonal(apotema, altura,cantLadosBaseYLargo);
			return elResultado;
		}
	}
}