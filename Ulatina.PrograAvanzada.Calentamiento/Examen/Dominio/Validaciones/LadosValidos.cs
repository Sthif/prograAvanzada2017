using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.Dominio.Validaciones
{
    public class LadosValidos
    {
        public bool LadosTrianguloValidos(double lado1, double lado2, double lado3)
        {
            if ((lado3 > lado1) && (lado3 > lado2) && (lado3 > (lado1 + lado2)))
            {
                return true;
            }
            else if ((lado2 > lado1) && (lado2 > lado3) && (lado2 > (lado1 + lado3)))
                {
                    return true;
                }
                else if ((lado1 > lado2) && (lado1 > lado3) && (lado1 > (lado2 + lado3)))
                    {
                        return true;
                    }
            else 
            return false;
        }

        public bool LadosPositivos(double lado)
        {
            if (lado > 0)
            {
                return true;
            }
            else return false;
        }

		internal object LadosPositivos()
		{
			throw new NotImplementedException();
		}

		public bool LadosPositivos(double lado1, double lado2)
        {
            if ((lado1 > 0) && (lado2 > 0))
            {
                return true;
            }
            else return false;
        }

        public bool LadosPositivos(double lado1, double lado2, double lado3)
        {
            if ((lado1 > 0) && (lado2 > 0) && (lado3 > 0))
            {
                return true;
            }
            else return false;
        }

        public bool CantidadValida(double cantidadLados)
        {
            if (cantidadLados >= 5)
            {
                return true;
            }
            else return false;
        }
    }
}