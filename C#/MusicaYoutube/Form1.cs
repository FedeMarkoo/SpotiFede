using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicaYoutube
{
    public partial class Form1 : Form
    {
        private Hashtable hash = new Hashtable();

        public Form1()
        {
            InitializeComponent();
        }

        private void reproducir_Click(object sender, EventArgs e)
        {
            String texto = artista.Text + " " + album.Text + " " + cancion.Text;
            String link = "http://www.google.com/search?q=youtube " + texto + "&btnI";
            hash.Add(texto, link);
            lista.Items.Add(texto);
            if (lista.SelectedIndex == lista.Items.Count - 2)
            {
                Reproducir();
            }
        }

        private void Reproducir()
        {
            lista.SelectedIndex++;
            string clave = lista.SelectedItem.ToString();
            webBrowser1.Navigate((String)hash[clave]);
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string v = webBrowser1.Url.ToString();
            string key = (String)hash[lista.SelectedItem];
            if (key.EndsWith("&btnI"))
            {
                hash[lista.SelectedItem] = key = v;
            }
            if ((key.Contains("watch?v=") && key != v))
            {
                string item = webBrowser1.DocumentTitle.Replace(" - YouTube", "");
                if (!hash.ContainsKey(item) && !hash.ContainsValue(v))
                {
                    lista.Items.Add(item);
                    lista.SelectedIndex++;
                    hash.Add(item, v);
                }
            }
        }

        private void lista_SelectedIndexChanged(object sender, MouseEventArgs e)
        {
            string clave = lista.SelectedItem.ToString();
            webBrowser1.Navigate((String)hash[clave]);
        }
    }
}
