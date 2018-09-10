using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);
        private Music cancion = null;
        internal Music Cancion { get => cancion; set => cancion = value; }
        public string[] archivos;
        public string Nombre = "";
        string Dir = "C:\\Users\\fedem\\OneDrive - Universidad Nacional de la Matanza\\Música\\Media Go\\Callejeros";
//        string Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

        public Form1()
        {
            InitializeComponent();
        }

        public async void Reproducir()
        {

            Nombre = archivos[(new Random()).Next(archivos.Length)];
            await Task.Delay(100);
            Cancion.Open(Nombre);
            await Task.Delay(100);
            Cancion.Play();
        }

        private void CargaDeDatos(bool op)
        {
            if (!op)
                if (File.Exists("Lista.dat"))
                {
                    archivos = File.ReadAllLines("Lista.dat");
                }
                else Carga();
            else
                Carga();
        }

        private void Carga()
        {
            string[] aux = new string[0];
            foreach (string line in Directory.GetDirectories(Dir))
            {
                Text = "Se cargaron " + aux.Length + " canciones hasta el momento";
                aux = Agregararchivos(aux, line);
                foreach (string temp in Directory.GetDirectories(line))
                {
                    Text = "Se cargaron " + aux.Length + " canciones hasta el momento";
                    aux = Agregararchivos(aux, temp);
                    foreach (string temp2 in Directory.GetDirectories(temp))
                    {
                        aux = Agregararchivos(aux, temp2);
                        Text = "Se cargaron " + aux.Length + " canciones hasta el momento";
                    }
                }
            }
            if (archivos != aux)
            {
                archivos = aux;
                File.WriteAllLines("Lista.dat", archivos);
            }
        }

        private void Reproducir2()
        {
            string[] infos = new string[5];
            infos[0] = "";
            string Nombre = "";
            while (infos == null || infos[0] == "" || infos[0] == null)
            {
                Nombre = archivos[(new Random()).Next(archivos.Length)];
                infos = GetAudioFileInfo(Nombre);
            }

            Text = infos[0].TrimEnd().TrimStart() + " - " + infos[2].TrimEnd().TrimStart() + " - " + infos[1].TrimEnd().TrimStart() + " - " + infos[3].TrimEnd().TrimStart();
            Cancion.Open(Nombre);
            Cancion.Play();
        }

        private static string[] Agregararchivos(string[] archivos, string line)
        {
            string[] temp = archivos;
            string[] aux = Directory.GetFiles(line);
            int i = 0;
            int tamaux = 0;
            foreach (string song in aux)
                if (song != null && song.Length > 2 && (song.Contains(".mp3") || song.Contains(".m4a") || song.Contains(".mp3")))
                    tamaux++;

            archivos = new string[tamaux + temp.Length];
            foreach (string song in aux)
                if (song != null && song.Length > 2 && (song.Contains(".mp3") || song.Contains(".m4a") || song.Contains(".mp3")))
                    archivos[i++] = song;

            foreach (string song in temp)
                if (song != null && song.Length > 2 && (song.Contains(".mp3") || song.Contains(".m4a") || song.Contains(".mp3")))
                    archivos[i++] = song;

            return archivos;
        }

        public string[] GetAudioFileInfo(string path)
        {
            path = Uri.UnescapeDataString(path);

            string[] infos = null; //Title; Singer; Album; Year; Comm;

            //Read bytes
            try
            {
                string cad = File.ReadAllLines(path).Last();
                if (!cad.Contains("TAG"))
                    return null;
                cad = cad.Substring(cad.LastIndexOf("TAG") + 3);
                //Set flag
                if (cad.Contains("TAG"))
                {
                    infos = cad.Split(' ');
                }
            }
            catch (UnauthorizedAccessException ex) { ex.ToString(); }
            catch (IOException ex) { ex.ToString(); }

            return infos;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Reproducir();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cancion = new Music();
            archivos = new string[0];
            CargaDeDatos(false);
            TextoAsync();
        //    Reproducir();

            if (!File.Exists("Dias.txt") || File.ReadAllText("Dias.txt").ToLower().Contains(DateTime.Now.ToLongDateString().Split(',')[0].ToLower()))
            {
                //ArrancarAReproducir();
        //        Reproducir();
                Volumen();
                AAAAHH_REEE_LOCOOO();
            }
            Cerrar();
        }

        public async void Cerrar()
        {
            await Task.Delay((new TimeSpan(3, 0, 0)));
            Application.Exit();
        }

        public async void Actualizar()
        {
            await Task.Delay(4 * 60 * 1000);
            CargaDeDatos(true);
        }

        public async void ArrancarAReproducir()
        {
            int i = 0;
            while (true)
            {
                await Task.Delay(200);
                if (!cancion.Reproduciendo())
                {
                    if (i == 10)
                    {
                        Reproducir();
                        i = 0;
                    }
                    i++;
                }
            }
        }

        public async void Volumen()
        {
            int i = 100;
            while (i-- != 0)
            {
                keybd_event((byte)Keys.VolumeUp, 0, 0, 0);
                await Task.Delay(100);
            }
        }

        public async void TextoAsync()
        {
            while (true)
            {
                await Task.Delay(100);
                string nomb = Nombre.Substring(Nombre.LastIndexOf('\\') + 1);
                if (nomb.Length > 1)
                    Text = nomb.Remove(nomb.LastIndexOf('.')) + "   " + cancion.Position() + " / " + cancion.Duration();
            }
        }

        public async void AAAAHH_REEE_LOCOOO()
        {
            while (true)
            {
                await Task.Delay(100);
                button1.BackColor = System.Drawing.Color.FromArgb(new Random().Next(Int32.MaxValue / 200) * 200);
            }
        }
    }
}
