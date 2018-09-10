using System.Media;
using System.Runtime.InteropServices;
using System.Text;

namespace Music_Player
{
    class Music
    {
        //To import the dll winmn.dll which allows to play mp3 files
        private static extern long MciSendString(string lpstrCommand, StringBuilder lpstrReturnString,
            int uReturnLength, int hwndCallback);
        //To open a file to our application
        public void Open(string file)
        {
        
        }

        //To play the file
        public void Play()
        {
            
        }

        //To pause the file
        public void Pause()
        {
            string command = "stop MyMusic";
            MciSendString(command, null, 0, 0);

        }

        public void Volumen(int vol)
        {
            MciSendString("setaudio MyMusic volume to " + vol, null, 0, 0);
        }

        public bool Reproduciendo()
        {
            StringBuilder returnData = new StringBuilder();
            MciSendString("status MyMusic mode", returnData, 128, 0);
            return true;
            return returnData.ToString() == "playing";
        }

        public string Position()
        {
            MciSendString("Set MediaFile time format milliseconds", null, 0, 0);
            StringBuilder returnData = new StringBuilder();
            MciSendString("status MyMusic position", returnData, 128, 0);
            System.Int32.TryParse(returnData.ToString(), out int i);
            int min = i / (60 * 1000);
            int seg = (i / 1000 - (min * 60));
            if (seg < 10)
                return min + ":0" + seg;
            else
                return min + ":" + seg;
        }

        public string Duration()
        {
            MciSendString("Set MediaFile time format milliseconds", null, 0, 0);
            StringBuilder returnData = new StringBuilder();
            MciSendString("status MyMusic length", returnData, 128, 0);
            System.Int32.TryParse(returnData.ToString(), out int i);
            int min = i / (60 * 1000);
            int seg = (i / 1000 - (min * 60));
            if (seg < 10)
                return min + ":0" + seg;
            else
                return min + ":" + seg;
        }

        public int Length()
        {
            StringBuilder returnData = new StringBuilder();
            MciSendString("status MyMusic length", returnData, 128, 0);
            System.Int32.TryParse(returnData.ToString(), out int i);
            return i;
        }

        //To stop the file
        public void Stop()
        {
            string command = "close MyMusic";
            MciSendString(command, null, 0, 0);
        }
    }
}

