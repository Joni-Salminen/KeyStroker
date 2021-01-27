﻿using KeyStroker.Logic;
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
        private static string _filePath = "";

        public static string SavePath { get { return _filePath; } set { _filePath = value; } }
        public static async Task SaveFile(List<Key> keyList)
        {
            string text = "";

            foreach (Key key in keyList)
            {
                text += key.ToString() + '\n';
            }

            byte[] encodedText = Encoding.Unicode.GetBytes(text);

            using (FileStream stream = new FileStream(_filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, bufferSize: encodedText.Length, useAsync: true))
            {
                await stream.WriteAsync(encodedText, 0, encodedText.Length);
            };
        }
        public static async Task<List<Key>> ReadFile()
        {
            List<Key> keyList = new List<Key>();

            using (StreamReader reader = File.OpenText(_filePath))
            {
                keyList.Add(CalculateKey(await reader.ReadLineAsync()));
            };
            return keyList;
        }
        private static Key CalculateKey(string v)
        {
            string[] splitted = v.Split(' ');
            
            char button = splitted[1].ToCharArray()[0];
            double time;
            bool isEnabled;

            Double.TryParse(splitted[0], out time);
            Boolean.TryParse(splitted[2], out isEnabled);

            Key key = new Key(button, time);
            key.IsEnabled = isEnabled;

            return key;
        }
    }
}
