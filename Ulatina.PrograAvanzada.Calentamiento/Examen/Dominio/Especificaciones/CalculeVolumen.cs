using System;

namespace Examen.Dominio.Especificaciones
{
	internal class CalculeVolumen
	{
		public CalculeVolumen()
		{
		}

		internal double VolumendelCilindro(int radio, int altura)
		{

			double elResultado = 0;
			var laValidacion = new Validaciones.Positivos();
			bool IngresoValido = laValidacion.NumerosPositivos(radio);
			bool IngresoValido2 = laValidacion.NumerosPositivos(altura);

			if (IngresoValido == true && IngresoValido2 == true)
			{
				double elVolumen = Math.PI * Math.Pow(radio, 2) * altura;
				elResultado = elVolumen;
				return elResultado;
			}

			return elResultado;

		}

		internal double VolumendelEsfera(int radio)
		{
			double elResultado = 0;
			var laValidacion = new Validaciones.Positivos();
			bool IngresoValido = laValidacion.NumerosPositivos(radio);
			
			if (IngresoValido == true)
			{
				double elVolumen =(4/3)*Math.PI * Math.Pow(radio, 3);
				elResultado = elVolumen;
				return elResultado;
			}

			return elResultado;

		}

		internal double VolumendelCono(int radio, int altura)
		{
			double elResultado = 0;
			var laValidacion = new Validaciones.Positivos();
			bool IngresoValido = laValidacion.NumerosPositivos(radio);
			bool IngresoValido2 = laValidacion.NumerosPositivos(altura);

			if (IngresoValido == true && IngresoValido2 == true)
			{
				double elVolumen = (1 / 3) * Math.PI * Math.Pow(radio, 2)*altura;
				elResultado = elVolumen;
				return elResultado;
			}

			return elResultado;
		}

		internal double VolumendelCubo(int arista)
		{
			double elResultado = 0;
			var laValidacion = new Validaciones.Positivos();
			bool IngresoValido = laValidacion.NumerosPositivos(arista);

			if (IngresoValido == true)
			{
				double elVolumen = Math.Pow(arista, 3);
				elResultado = elVolumen;
				return elResultado;
			}

			return elResultado;
		}

		internal double VolumendelPrisma(int largo, int ancho, int altura)
		{
			double elResultado = 0;
			var laValidacion = new Validaciones.Positivos();
			bool IngresoValido = laValidacion.NumerosPositivos(largo);
			bool IngresoValido2 = laValidacion.NumerosPositivos(altura);
			bool IngresoValido3 = laValidacion.NumerosPositivos(ancho);

			if (IngresoValido == true && IngresoValido2 == true && IngresoValido3 == true)
			{

				double Area =  largo*ancho;// area Prim revisar
				double elVolumen = Area * altura;
				elResultado = elVolumen;
				return elResultado;
			}

			return elResultado;
		}

		internal double VolumendePiramidePoligonal(int apotema, int altura, int cantLadosBaseYLargo)
		{
			double elResultado = 0;
			var laValidacion = new Validaciones.Positivos();
			bool IngresoValido = laValidacion.NumerosPositivos(apotema);
			bool IngresoValido2 = laValidacion.NumerosPositivos(altura);
			bool IngresoValido3 = laValidacion.NumerosPositivos(cantLadosBaseYLargo);

			if (IngresoValido == true && IngresoValido2 == true && IngresoValido3 == true)
			{

				double Area = 1;// area Piramide
				double elVolumen = (1 / 3) * Area * altura;
				elResultado = elVolumen;
				return elResultado;
			}

			return elResultado;
		}

		internal double VolumendelPiramideCuadrado(int ladoBase, int altura)
		{
			double elResultado = 0;
			var laValidacion = new Validaciones.Positivos();
			bool IngresoValido = laValidacion.NumerosPositivos(ladoBase);
			bool IngresoValido2 = laValidacion.NumerosPositivos(altura);		

			if (IngresoValido == true && IngresoValido2 == true )
			{

				double elVolumen = (1/3)*Math.Pow(ladoBase, 2)*altura;
				elResultado = elVolumen;
				return elResultado;
			}

			return elResultado;
		}
	}
}