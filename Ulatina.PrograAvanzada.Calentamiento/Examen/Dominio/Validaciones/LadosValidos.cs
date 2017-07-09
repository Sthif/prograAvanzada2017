using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.Dominio.Validaciones
{
    public class LadosValidos
    {
        public bool LadosTrianguloValidos(int lado1, int lado2, int lado3) // lado 3 es el mas largo 
        {
            if (lado3 > lado1  && lado3 > lado2 && lado3 > (lado1 + lado2))
            {
                return true;
            }
            else if (lado2 > lado1 && lado2 > lado3 && lado2 > (lado1 + lado3))
                {
                    return true;
                }
                else if (lado1 > lado2 && lado1 > lado3 && lado1 > (lado2 + lado3))
                    {
                        return true;
                    }
            else 
            return false;
        }
    }
}