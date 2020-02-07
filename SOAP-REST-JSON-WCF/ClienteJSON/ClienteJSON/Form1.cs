using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System;

namespace ClienteJSON
{
    public partial class Form1 : Form
    {
        private WebClient cliente = new WebClient();

        public Form1()
        {
            InitializeComponent();
            cliente.DownloadStringCompleted += new DownloadStringCompletedEventHandler(cliente_DescargaCompleta);
        }

        private void cliente_DescargaCompleta(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                DataContractJsonSerializer serializadorJson = new DataContractJsonSerializer(typeof(MensajeTexto));
                MensajeTexto mensaje = (MensajeTexto)serializadorJson.ReadObject(new MemoryStream(Encoding.Unicode.GetBytes(e.Result)));
                MessageBox.Show(mensaje.Mensaje, "Bienvenido");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            cliente.DownloadStringAsync(new Uri("http://localhost:11616/Service.svc/bienvenido/" + txtNombre.Text));
        }

        [Serializable]
        public class MensajeTexto
        {
            public string Mensaje;
        }
    }
}