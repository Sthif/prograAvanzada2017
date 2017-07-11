using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Examen
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        // perimetros **********************************************
        [OperationContract]
        double PerimetroTriangulo(double lado1, double lado2, double lado3);

        [OperationContract]
        double PerimetroCuadrado(double _lado);
        
        // areas ***************************************************
        [OperationContract]
        double AreaTriangulo(double lado1, double lado2, double lado3);
		[OperationContract]
		double AreaCuadrado(double lado);
		[OperationContract]
		double AreaRectangulo(double largo, double ancho);
		[OperationContract]
		double AreaRombo(double diagonalMayor, double diagonalMenor);
		[OperationContract]
		double AreaPoligonoRegular(double lado, double apotema, int cantidadLados);
		[OperationContract]
		double AreaTrapecio(double baseMayor, double baseMenor, double altura);
		[OperationContract]
		double AreaRomboide(double baseRomboide, double altura);

		// volumenes ***********************************************
		[OperationContract]		
		double VolumenCilindro(double Radio, double Altura);
		[OperationContract]
		double VolumenEsfera(double Radio);
		[OperationContract]
		double VolumenCono(double Radio, double Altura);
		[OperationContract]
		double VolumenCubo(double Arista);
		[OperationContract]
		double VolumenPrisma(double Largo, double Ancho, double Altura);
		[OperationContract]
		double VolumenPiramideCuadrada(double LadoBase, double Altura);
		[OperationContract]
		double VolumenPiramidePoligonal(double Apotema, double Altura, double CantLadosBaseYLargo);

		// sistema *************************************************
		[OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
