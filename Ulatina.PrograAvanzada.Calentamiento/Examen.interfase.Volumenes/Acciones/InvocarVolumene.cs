using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.interfase.Volumenes.ServiceReference1 
{
    public class InvocarVolumene
	{
        public string CalculeVolumenCilindro (string elOperandoUno, string elOperandoDos)
        {
			

			// llama el metodo de Calculo de Volumen Cilindro
			string elResultado;         
			// instanciar el wcf
			var elCliente = new ServiceReference1.Service1Client();   
            // invocar al mètodo del wcf
            var elResultadoNumerico = elCliente.VolumenCilindro(2.5,5);
            // convertir el resultado a string
            elResultado = elResultadoNumerico.ToString();
            // retornar
            return elResultado;







			


        }

        
    }
}