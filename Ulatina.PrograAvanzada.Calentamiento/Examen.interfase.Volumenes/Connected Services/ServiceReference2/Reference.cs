﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examen.interfase.Volumenes.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/Examen")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PerimetroTriangulo", ReplyAction="http://tempuri.org/IService1/PerimetroTrianguloResponse")]
        double PerimetroTriangulo(double lado1, double lado2, double lado3);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PerimetroTriangulo", ReplyAction="http://tempuri.org/IService1/PerimetroTrianguloResponse")]
        System.Threading.Tasks.Task<double> PerimetroTrianguloAsync(double lado1, double lado2, double lado3);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PerimetroCuadrado", ReplyAction="http://tempuri.org/IService1/PerimetroCuadradoResponse")]
        double PerimetroCuadrado(double _lado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PerimetroCuadrado", ReplyAction="http://tempuri.org/IService1/PerimetroCuadradoResponse")]
        System.Threading.Tasks.Task<double> PerimetroCuadradoAsync(double _lado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AreaTriangulo", ReplyAction="http://tempuri.org/IService1/AreaTrianguloResponse")]
        double AreaTriangulo(double lado1, double lado2, double lado3);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AreaTriangulo", ReplyAction="http://tempuri.org/IService1/AreaTrianguloResponse")]
        System.Threading.Tasks.Task<double> AreaTrianguloAsync(double lado1, double lado2, double lado3);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AreaCuadrado", ReplyAction="http://tempuri.org/IService1/AreaCuadradoResponse")]
        double AreaCuadrado(double lado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AreaCuadrado", ReplyAction="http://tempuri.org/IService1/AreaCuadradoResponse")]
        System.Threading.Tasks.Task<double> AreaCuadradoAsync(double lado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AreaRectangulo", ReplyAction="http://tempuri.org/IService1/AreaRectanguloResponse")]
        double AreaRectangulo(double largo, double ancho);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AreaRectangulo", ReplyAction="http://tempuri.org/IService1/AreaRectanguloResponse")]
        System.Threading.Tasks.Task<double> AreaRectanguloAsync(double largo, double ancho);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AreaRombo", ReplyAction="http://tempuri.org/IService1/AreaRomboResponse")]
        double AreaRombo(double diagonalMayor, double diagonalMenor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AreaRombo", ReplyAction="http://tempuri.org/IService1/AreaRomboResponse")]
        System.Threading.Tasks.Task<double> AreaRomboAsync(double diagonalMayor, double diagonalMenor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AreaPoligonoRegular", ReplyAction="http://tempuri.org/IService1/AreaPoligonoRegularResponse")]
        double AreaPoligonoRegular(double lado, double apotema, int cantidadLados);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AreaPoligonoRegular", ReplyAction="http://tempuri.org/IService1/AreaPoligonoRegularResponse")]
        System.Threading.Tasks.Task<double> AreaPoligonoRegularAsync(double lado, double apotema, int cantidadLados);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AreaTrapecio", ReplyAction="http://tempuri.org/IService1/AreaTrapecioResponse")]
        double AreaTrapecio(double baseMayor, double baseMenor, double altura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AreaTrapecio", ReplyAction="http://tempuri.org/IService1/AreaTrapecioResponse")]
        System.Threading.Tasks.Task<double> AreaTrapecioAsync(double baseMayor, double baseMenor, double altura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AreaRomboide", ReplyAction="http://tempuri.org/IService1/AreaRomboideResponse")]
        double AreaRomboide(double baseRomboide, double altura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AreaRomboide", ReplyAction="http://tempuri.org/IService1/AreaRomboideResponse")]
        System.Threading.Tasks.Task<double> AreaRomboideAsync(double baseRomboide, double altura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VolumenCilindro", ReplyAction="http://tempuri.org/IService1/VolumenCilindroResponse")]
        double VolumenCilindro(double Radio, double Altura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VolumenCilindro", ReplyAction="http://tempuri.org/IService1/VolumenCilindroResponse")]
        System.Threading.Tasks.Task<double> VolumenCilindroAsync(double Radio, double Altura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VolumenEsfera", ReplyAction="http://tempuri.org/IService1/VolumenEsferaResponse")]
        double VolumenEsfera(double Radio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VolumenEsfera", ReplyAction="http://tempuri.org/IService1/VolumenEsferaResponse")]
        System.Threading.Tasks.Task<double> VolumenEsferaAsync(double Radio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VolumenCono", ReplyAction="http://tempuri.org/IService1/VolumenConoResponse")]
        double VolumenCono(double Radio, double Altura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VolumenCono", ReplyAction="http://tempuri.org/IService1/VolumenConoResponse")]
        System.Threading.Tasks.Task<double> VolumenConoAsync(double Radio, double Altura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VolumenCubo", ReplyAction="http://tempuri.org/IService1/VolumenCuboResponse")]
        double VolumenCubo(double Arista);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VolumenCubo", ReplyAction="http://tempuri.org/IService1/VolumenCuboResponse")]
        System.Threading.Tasks.Task<double> VolumenCuboAsync(double Arista);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VolumenPrisma", ReplyAction="http://tempuri.org/IService1/VolumenPrismaResponse")]
        double VolumenPrisma(double Largo, double Ancho, double Altura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VolumenPrisma", ReplyAction="http://tempuri.org/IService1/VolumenPrismaResponse")]
        System.Threading.Tasks.Task<double> VolumenPrismaAsync(double Largo, double Ancho, double Altura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VolumenPiramideCuadrada", ReplyAction="http://tempuri.org/IService1/VolumenPiramideCuadradaResponse")]
        double VolumenPiramideCuadrada(double LadoBase, double Altura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VolumenPiramideCuadrada", ReplyAction="http://tempuri.org/IService1/VolumenPiramideCuadradaResponse")]
        System.Threading.Tasks.Task<double> VolumenPiramideCuadradaAsync(double LadoBase, double Altura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VolumenPiramidePoligonal", ReplyAction="http://tempuri.org/IService1/VolumenPiramidePoligonalResponse")]
        double VolumenPiramidePoligonal(double Apotema, double Altura, double CantLadosBaseYLargo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VolumenPiramidePoligonal", ReplyAction="http://tempuri.org/IService1/VolumenPiramidePoligonalResponse")]
        System.Threading.Tasks.Task<double> VolumenPiramidePoligonalAsync(double Apotema, double Altura, double CantLadosBaseYLargo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        Examen.interfase.Volumenes.ServiceReference2.CompositeType GetDataUsingDataContract(Examen.interfase.Volumenes.ServiceReference2.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Examen.interfase.Volumenes.ServiceReference2.CompositeType> GetDataUsingDataContractAsync(Examen.interfase.Volumenes.ServiceReference2.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Examen.interfase.Volumenes.ServiceReference2.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Examen.interfase.Volumenes.ServiceReference2.IService1>, Examen.interfase.Volumenes.ServiceReference2.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double PerimetroTriangulo(double lado1, double lado2, double lado3) {
            return base.Channel.PerimetroTriangulo(lado1, lado2, lado3);
        }
        
        public System.Threading.Tasks.Task<double> PerimetroTrianguloAsync(double lado1, double lado2, double lado3) {
            return base.Channel.PerimetroTrianguloAsync(lado1, lado2, lado3);
        }
        
        public double PerimetroCuadrado(double _lado) {
            return base.Channel.PerimetroCuadrado(_lado);
        }
        
        public System.Threading.Tasks.Task<double> PerimetroCuadradoAsync(double _lado) {
            return base.Channel.PerimetroCuadradoAsync(_lado);
        }
        
        public double AreaTriangulo(double lado1, double lado2, double lado3) {
            return base.Channel.AreaTriangulo(lado1, lado2, lado3);
        }
        
        public System.Threading.Tasks.Task<double> AreaTrianguloAsync(double lado1, double lado2, double lado3) {
            return base.Channel.AreaTrianguloAsync(lado1, lado2, lado3);
        }
        
        public double AreaCuadrado(double lado) {
            return base.Channel.AreaCuadrado(lado);
        }
        
        public System.Threading.Tasks.Task<double> AreaCuadradoAsync(double lado) {
            return base.Channel.AreaCuadradoAsync(lado);
        }
        
        public double AreaRectangulo(double largo, double ancho) {
            return base.Channel.AreaRectangulo(largo, ancho);
        }
        
        public System.Threading.Tasks.Task<double> AreaRectanguloAsync(double largo, double ancho) {
            return base.Channel.AreaRectanguloAsync(largo, ancho);
        }
        
        public double AreaRombo(double diagonalMayor, double diagonalMenor) {
            return base.Channel.AreaRombo(diagonalMayor, diagonalMenor);
        }
        
        public System.Threading.Tasks.Task<double> AreaRomboAsync(double diagonalMayor, double diagonalMenor) {
            return base.Channel.AreaRomboAsync(diagonalMayor, diagonalMenor);
        }
        
        public double AreaPoligonoRegular(double lado, double apotema, int cantidadLados) {
            return base.Channel.AreaPoligonoRegular(lado, apotema, cantidadLados);
        }
        
        public System.Threading.Tasks.Task<double> AreaPoligonoRegularAsync(double lado, double apotema, int cantidadLados) {
            return base.Channel.AreaPoligonoRegularAsync(lado, apotema, cantidadLados);
        }
        
        public double AreaTrapecio(double baseMayor, double baseMenor, double altura) {
            return base.Channel.AreaTrapecio(baseMayor, baseMenor, altura);
        }
        
        public System.Threading.Tasks.Task<double> AreaTrapecioAsync(double baseMayor, double baseMenor, double altura) {
            return base.Channel.AreaTrapecioAsync(baseMayor, baseMenor, altura);
        }
        
        public double AreaRomboide(double baseRomboide, double altura) {
            return base.Channel.AreaRomboide(baseRomboide, altura);
        }
        
        public System.Threading.Tasks.Task<double> AreaRomboideAsync(double baseRomboide, double altura) {
            return base.Channel.AreaRomboideAsync(baseRomboide, altura);
        }
        
        public double VolumenCilindro(double Radio, double Altura) {
            return base.Channel.VolumenCilindro(Radio, Altura);
        }
        
        public System.Threading.Tasks.Task<double> VolumenCilindroAsync(double Radio, double Altura) {
            return base.Channel.VolumenCilindroAsync(Radio, Altura);
        }
        
        public double VolumenEsfera(double Radio) {
            return base.Channel.VolumenEsfera(Radio);
        }
        
        public System.Threading.Tasks.Task<double> VolumenEsferaAsync(double Radio) {
            return base.Channel.VolumenEsferaAsync(Radio);
        }
        
        public double VolumenCono(double Radio, double Altura) {
            return base.Channel.VolumenCono(Radio, Altura);
        }
        
        public System.Threading.Tasks.Task<double> VolumenConoAsync(double Radio, double Altura) {
            return base.Channel.VolumenConoAsync(Radio, Altura);
        }
        
        public double VolumenCubo(double Arista) {
            return base.Channel.VolumenCubo(Arista);
        }
        
        public System.Threading.Tasks.Task<double> VolumenCuboAsync(double Arista) {
            return base.Channel.VolumenCuboAsync(Arista);
        }
        
        public double VolumenPrisma(double Largo, double Ancho, double Altura) {
            return base.Channel.VolumenPrisma(Largo, Ancho, Altura);
        }
        
        public System.Threading.Tasks.Task<double> VolumenPrismaAsync(double Largo, double Ancho, double Altura) {
            return base.Channel.VolumenPrismaAsync(Largo, Ancho, Altura);
        }
        
        public double VolumenPiramideCuadrada(double LadoBase, double Altura) {
            return base.Channel.VolumenPiramideCuadrada(LadoBase, Altura);
        }
        
        public System.Threading.Tasks.Task<double> VolumenPiramideCuadradaAsync(double LadoBase, double Altura) {
            return base.Channel.VolumenPiramideCuadradaAsync(LadoBase, Altura);
        }
        
        public double VolumenPiramidePoligonal(double Apotema, double Altura, double CantLadosBaseYLargo) {
            return base.Channel.VolumenPiramidePoligonal(Apotema, Altura, CantLadosBaseYLargo);
        }
        
        public System.Threading.Tasks.Task<double> VolumenPiramidePoligonalAsync(double Apotema, double Altura, double CantLadosBaseYLargo) {
            return base.Channel.VolumenPiramidePoligonalAsync(Apotema, Altura, CantLadosBaseYLargo);
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public Examen.interfase.Volumenes.ServiceReference2.CompositeType GetDataUsingDataContract(Examen.interfase.Volumenes.ServiceReference2.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Examen.interfase.Volumenes.ServiceReference2.CompositeType> GetDataUsingDataContractAsync(Examen.interfase.Volumenes.ServiceReference2.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}