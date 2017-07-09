using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Examen
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int PerimetroTriangulo(int lado1, int lado2, int lado3)
        {
            int elResultado;
            var laAccion = new Dominio.Acciones.CalcularPerimetro();
            elResultado = laAccion.CalcularPerimetroTriangulo(lado1, lado2, lado3);
            return elResultado;
        }

        public double AreaTriangulo(int lado1, int lado2, int lado3)
        {
            double elResultado;
            var laAccion = new Dominio.Acciones.CalcularArea();
            elResultado = laAccion.CalcularAreaTriangulo(lado1, lado2, lado3);
            return elResultado; 
        }



		// Seccion de  Volumenes  

		  public double VolumenCilindro(int Radio, int Altura)
        {
            double elResultado;
            var laAccion = new Dominio.Acciones.CalcularVolumen();
            elResultado = laAccion.CalcularVolumenCilindro(Radio,Altura);
            return elResultado; 
        }

		  public double VolumenEsfera(int Radio)
        {
            double elResultado;
            var laAccion = new Dominio.Acciones.CalcularVolumen();
            elResultado = laAccion.CalcularVolumenEsfera(Radio);
            return elResultado; 
        }

		  public double VolumenCono(int Radio, int Altura)
        {
           double elResultado;
            var laAccion = new Dominio.Acciones.CalcularVolumen();
            elResultado = laAccion.CalcularVolumenCono(Radio,Altura);
            return elResultado;  
        }

		  public double VolumenCubo(int Arista)
        { 
		    double elResultado;
            var laAccion = new Dominio.Acciones.CalcularVolumen();
            elResultado = laAccion.CalcularVolumenCubo(Arista);
            return elResultado;  
        }

		  public double VolumenPrisma(int Largo, int Ancho, int Altura)
        {
             double elResultado;
            var laAccion = new Dominio.Acciones.CalcularVolumen();
            elResultado = laAccion.CalcularVolumenPrisma(Largo,Ancho,Altura);
            return elResultado; 
        }

		  public double VolumenPiramideCuadrada(int LadoBase, int Altura)
        {
             double elResultado;
            var laAccion = new Dominio.Acciones.CalcularVolumen();
            elResultado = laAccion.CalcularVolumenCuadrada(LadoBase,Altura);
            return elResultado; 
        }		

		  public double VolumenPiramidePoligonal(int Apotema, int Altura ,int CantLadosBaseYLargo)
        {
            double elResultado;
            var laAccion = new Dominio.Acciones.CalcularVolumen();
            elResultado = laAccion.CalcularVolumenPiramidePoligonal(Apotema,Altura,CantLadosBaseYLargo);
            return elResultado; 
        }

		// fin de volumenes 
		

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
               
    }
}
