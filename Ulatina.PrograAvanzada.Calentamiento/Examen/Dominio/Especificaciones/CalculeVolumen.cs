using System;

namespace Examen.Dominio.Especificaciones
{
	internal class CalculeVolumen
	{
		public CalculeVolumen()
		{
		}

		internal double VolumendelCilindro(double radio, double altura)
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

		internal double VolumendelEsfera(double radio)
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

		internal double VolumendelCono(double radio, double altura)
		{
			double elResultado = 0;
			var laValidacion = new Validaciones.Positivos();
			bool IngresoValido = laValidacion.NumerosPositivos(radio);
			bool IngresoValido2 = laValidacion.NumerosPositivos(altura);

			if (IngresoValido == true && IngresoValido2 == true)
			{
				double elVolumen = (radio * radio * altura * Math.PI) / 3;
				elResultado = elVolumen;
				return elResultado;
			}

			return elResultado;
		}

		internal double VolumendelCubo(double arista)
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

		internal double VolumendelPrisma(double largo, double ancho, double altura)
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

		internal double VolumendePiramidePoligonal(double apotema, double altura, double cantLadosBaseYLargo)
		{
			double elResultado = 0;
			var laValidacion = new Validaciones.Positivos();
			bool IngresoValido = laValidacion.NumerosPositivos(apotema);
			bool IngresoValido2 = laValidacion.NumerosPositivos(altura);
			bool IngresoValido3 = laValidacion.NumerosPositivos(cantLadosBaseYLargo);

			if (IngresoValido == true && IngresoValido2 == true && IngresoValido3 == true)
			{

				double Area = 1;// area Piramide
				double elVolumen =  (Area * altura)/3;
				elResultado = elVolumen;
				return elResultado;
			}

			return elResultado;
		}

		internal double VolumendelPiramideCuadrado(double ladoBase, double altura)
		{
			double elResultado = 0;
			var laValidacion = new Validaciones.Positivos();
			bool IngresoValido = laValidacion.NumerosPositivos(ladoBase);
			bool IngresoValido2 = laValidacion.NumerosPositivos(altura);		

			if (IngresoValido == true && IngresoValido2 == true )
			{

				double elVolumen = (ladoBase * ladoBase * altura) / 3;
				elResultado = elVolumen;
				return elResultado;
			}

			return elResultado;
		}
	}
}