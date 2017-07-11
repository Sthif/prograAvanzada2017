using System;

namespace Examen.Dominio.Validaciones
{
	internal class Positivos
	{
		public Positivos()
		{

		}

		internal bool NumerosPositivos(double Numero)
		{

			if (Numero > 0) { return true; } else { return false; }

		}
	}
}