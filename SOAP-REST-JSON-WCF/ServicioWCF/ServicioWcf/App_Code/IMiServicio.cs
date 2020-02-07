using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ServiceModel.Web;
using System.ServiceModel;
using System.Linq;
using System.Text;
using System;

[ServiceContract]
public interface IMiServicio
{
    //Soap
    //[OperationContract]
    //string Bienvenido(string nombre);
    //[OperationContract]
    //public int[] Contar(string palabra1, string);

    //REST
    //[OperationContract]
    //[WebGet(UriTemplate = "/bienvenido/{nombre}")]
    //string Bienvenido(string nombre);

    //JSON
    [OperationContract]
    [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/bienvenido/{nombre}")]
    MensajeTexto Bienvenido(string nombre);
}


//JSON
[DataContract]
public class MensajeTexto
{
    [DataMember]
    public string Mensaje { get; set; }
}