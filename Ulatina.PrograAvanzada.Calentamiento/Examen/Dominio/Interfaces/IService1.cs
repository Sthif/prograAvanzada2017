﻿using System;
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
        int PerimetroTriangulo(int lado1, int lado2, int lado3);
        
        
        // areas ******************************************

        [OperationContract]
        double AreaTriangulo(int lado1, int lado2, int lado3);


	   // Volumenes ******************************************

	    [OperationContract]
        double VolumenCilindro(int Radio, int Altura);

		   [OperationContract]
        double VolumenEsfera(int Radio);

		   [OperationContract]
        double VolumenCono(int Radio, int Altura);

		   [OperationContract]
        double VolumenCubo(int Arista);

		   [OperationContract]
        double VolumenPrisma(int Largo, int Ancho, int Altura);

		   [OperationContract]
        double VolumenPiramideCuadrada(int LadoBase, int Altura);

		   [OperationContract]
        double VolumenPiramidePoligonal(int Apotema, int Altura ,int CantLadosBaseYLargo);



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
