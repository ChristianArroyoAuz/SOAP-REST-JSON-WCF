using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Net;
using System;

namespace ClienteRest
{
    public partial class Form1 : Form
    {
        private WebClient cliente = new WebClient();
        private XNamespace espacioXML = XNamespace.Get("http://schemas.microsoft.com/2003/10/Serialization/");

        public Form1()
        {
            InitializeComponent();
            cliente.DownloadStringCompleted += new DownloadStringCompletedEventHandler(cliente_DescargaCompleta);
        }

        private void cliente_DescargaCompleta(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                XDocument respuestaXml = XDocument.Parse(e.Result);
                MessageBox.Show(respuestaXml.Element(espacioXML + "string").Value, "Bienvenido");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            cliente.DownloadStringAsync(new Uri("http://localhost:11616/Service.svc/bienvenido/" + txtNombre.Text));
        }
    }
}