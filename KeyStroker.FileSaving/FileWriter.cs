using KeyStroker.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyStroker.FileSaving
{
    public class FileWriter
    {
        private static string _filePath = "defaultProfile.txt";

        public static string SavePath { get { return _filePath; } set { _filePath = value; } }
        public static async Task<bool> SaveFile(List<ProgrammableButton> keyList)
        {
            string text = "";

            foreach (ProgrammableButton key in keyList)
            {
                text += key.ToString() + '\n';
            }

            byte[] encodedText = Encoding.ASCII.GetBytes(text);
            try
            {
                using (FileStream stream = new FileStream(_filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, bufferSize: encodedText.Length, useAsync: true))
                {
                    await stream.WriteAsync(encodedText, 0, encodedText.Length);
                };
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static async Task<List<ProgrammableButton>> ReadFile()
        {
            List<ProgrammableButton> keyList = new List<ProgrammableButton>();

            using (StreamReader reader = File.OpenText(_filePath))
            {
                while(!reader.EndOfStream)
                    keyList.Add(CalculateKey(await reader.ReadLineAsync()));
            };
            return keyList;
        }
        private static ProgrammableButton CalculateKey(string v)
        {
            string[] splitted = v.Split(' ');
            
            char button = splitted[1].ToCharArray()[0];
            double time;
            bool isEnabled;

            Double.TryParse(splitted[0], out time);
            Boolean.TryParse(splitted[2], out isEnabled);

            ProgrammableButton key = new ProgrammableButton(button, time);
            key.IsEnabled = isEnabled;

            return key;
        }
    }
}
