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
            elResultado = laAccion.CalcularAreaCuadrado(lado);
            return elResultado;
        }

        public double AreaRectangulo(double largo, double ancho)
        {
            double elResultado;
            var laAccion = new Dominio.Acciones.CalcularArea();
            elResultado = laAccion.CalcularAreaRectangulo(largo, ancho);
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

        // ********** VOLUMENES **********

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
