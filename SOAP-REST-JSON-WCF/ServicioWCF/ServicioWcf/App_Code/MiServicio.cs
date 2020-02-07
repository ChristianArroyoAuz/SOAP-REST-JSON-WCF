using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class MiServicio : IMiServicio
{
    //Soap
    // public string Bienvenido(string nombre)
    //{
    //    return String.Format("Bienvenido al primer Servicio Web WCF usando SOAP de {0}", nombre);
    //}

    //public int[] Contar(string palabra1, string palabra2)
    // {
    //    int[] resultado = [palabra1.Count(), palabra2.Count()];
    // }

    //REST
    //public string Bienvenido(string nombre)
    //{
    //    return String.Format("Bienvenido al segundo Servicio Web WCF usando REST de {0}", nombre);
    //}

    //JSON
    public MensajeTexto Bienvenido(String nombre)
    {
        MensajeTexto miMensaje = new MensajeTexto();
        miMensaje.Mensaje = String.Format("Bienvenido al tercer Servicio web con WCF, basado en REST y JSON: {0}", nombre);
        return miMensaje;
    }
}