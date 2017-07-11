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
        // ********** PERIMETROS ********** 
        public double PerimetroTriangulo(double lado1, double lado2, double lado3)
        {
            double elResultado;
            var laAccion = new Dominio.Acciones.CalcularPerimetro();
            elResultado = laAccion.CalcularPerimetroTriangulo(lado1, lado2, lado3);
            return elResultado;
        }

        //public double PerimetroCuadrado(int _lado)
        //{
        
        //    //double ElResultado;
        //    //var LaAccion = new Dominio.Acciones.CalcularPerimetro();
        //    //ElResultado = LaAccion.CalcularPerimetroCuadrado(_lado);
        //    //return ElResultado;
        //}                                                 


        // ********** AREAS **********
        public double AreaTriangulo(double lado1, double lado2, double lado3)
        {
            double elResultado;
            var laAccion = new Dominio.Acciones.CalcularArea();
            elResultado = laAccion.CalcularAreaTriangulo(lado1, lado2, lado3);
            return elResultado; 
        }

        public double AreaCuadrado(double lado)
        {
            double elResultado;
            var laAccion = new Dominio.Acciones.CalcularArea();
            elResultado = laAccion.CalcularAreaCuadrilatero(lado, lado);
            return elResultado;
        }

        public double AreaRectangulo(double largo, double ancho)
        {
            double elResultado;
            var laAccion = new Dominio.Acciones.CalcularArea();
            elResultado = laAccion.CalcularAreaCuadrilatero(largo, ancho);
            return elResultado;
        }

        public double AreaRombo(double diagonalMayor, double diagonalMenor)
        {
            double elResultado;
            var laAccion = new Dominio.Acciones.CalcularArea();
            elResultado = laAccion.CalcularAreaRombo(diagonalMayor, diagonalMenor);
            return elResultado;
        }

        public double AreaPoligonoRegular(double lado, double apotema, int cantidadLados)
        {
            double elResultado;
            var laAccion = new Dominio.Acciones.CalcularArea();
            elResultado = laAccion.CalcularAreaPoligonoRegular(lado, apotema, cantidadLados);
            return elResultado;
        }

        public double AreaTrapecio(double baseMayor, double baseMenor, double altura)
        {
            double elResultado;
            var laAccion = new Dominio.Acciones.CalcularArea();
            elResultado = laAccion.CalcularAreaTrapecio(baseMayor, baseMenor, altura);
            return elResultado;
        }

        public double AreaRomboide(double baseRomboide, double altura)
        {
            double elResultado;
            var laAccion = new Dominio.Acciones.CalcularArea();
            elResultado = laAccion.CalcularAreaCuadrilatero(baseRomboide, altura);
            return elResultado;
        }

		// ********** VOLUMENES **********

		public double VolumenCilindro(double Radio, double Altura)
		{
			double elResultado;
			var laAccion = new Dominio.Acciones.CalcularVolumen();
			elResultado = laAccion.Cilindro(Radio, Altura);
			return elResultado;
		}

		public double VolumenEsfera(double Radio)
		{
			double elResultado;
			var laAccion = new Dominio.Acciones.CalcularVolumen();
			elResultado = laAccion.Esfera(Radio);
			return elResultado;
		}

		public double VolumenCono(double Radio, double Altura)
		{
			double elResultado;
			var laAccion = new Dominio.Acciones.CalcularVolumen();
			elResultado = laAccion.Cono(Radio, Altura);
			return elResultado;
		}

		public double VolumenCubo(double Arista)
		{
			double elResultado;
			var laAccion = new Dominio.Acciones.CalcularVolumen();
			elResultado = laAccion.Cubo(Arista);
			return elResultado;
		}

		public double VolumenPrisma(double Largo, double Ancho, double Altura)
		{
			double elResultado;
			var laAccion = new Dominio.Acciones.CalcularVolumen();
			elResultado = laAccion.Prisma(Largo, Ancho, Altura);
			return elResultado;
		}

		public double VolumenPiramideCuadrada(double LadoBase, double Altura)
		{
			double elResultado;
			var laAccion = new Dominio.Acciones.CalcularVolumen();
			elResultado = laAccion.Cuadrada(LadoBase, Altura);
			return elResultado;
		}

		public double VolumenPiramidePoligonal(double Apotema, double Altura, double CantLadosBaseYLargo)
		{
			double elResultado;
			var laAccion = new Dominio.Acciones.CalcularVolumen();
			elResultado = laAccion.PiramidePoligonal(Apotema, Altura, CantLadosBaseYLargo);
			return elResultado;
		}



		// ********** SISTEMA **********
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

		public double PerimetroCuadrado(double _lado)
		{
			throw new NotImplementedException();
		}
	}
}
