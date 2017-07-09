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
        
        // areas ***************************************************
        [OperationContract]
        double AreaTriangulo(double lado1, double lado2, double lado3);

        double AreaCuadrado(double lado);

        double AreaRectangulo(double largo, double ancho);

        double AreaRombo(double diagonalMayor, double diagonalMenor);

        double AreaPoligonoRegular(double lado, double apotema, int cantidadLados);

        double AreaTrapecio(double baseMayor, double baseMenor, double altura);

        double AreaRomboide(double baseRomboide, double altura);

        // volumenes ***********************************************
        
        
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
