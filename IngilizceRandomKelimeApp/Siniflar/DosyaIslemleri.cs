using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace IngilizceRandomKelimeApp.Siniflar
{
    public class DosyaIslemleri
    {
        public static bool CreateFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                    using (FileStream fs = File.Create(filePath)) { }
                return true;
            }
            catch (System.Exception) { return false; }
        }

        public static void RemoveFile(string filePath)
        {
            if (File.Exists(filePath))
                File.Delete(filePath);
        }

        public static void CopyFile(string filePath, string CopyFilePath)
        {
            if (File.Exists(filePath))
            {
                if (File.Exists(CopyFilePath))
                    File.Delete(CopyFilePath);
                File.Copy(filePath, CopyFilePath);            
            }
        }

        public static string ReadFile(string filePath)
        {
            string text;
            Encoding encoding = Encoding.UTF8;
            using (StreamReader streamReader = new StreamReader(filePath, encoding))
                text = streamReader.ReadToEnd();
            return text;
        }

        public static List<string> ReadLinesOffFile(string filePath)
        {           
            List<string> lines = new List<string>();
            Encoding encoding = Encoding.UTF8;
            using (StreamReader reader = new StreamReader(filePath, encoding))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    lines.Add(line);
            }
            return lines;
        }

        public static void WriteTofile(string filePath, string text, bool writeContinueFile)
        {
            if (File.Exists(filePath))
            {
                using (StreamWriter sw = new StreamWriter(filePath, writeContinueFile))
                    sw.Write(text);
            }
        }

        public static void WriteLinesToFile(string dosyaYolu, List<string> satirlar)
        {
            string metin = "";
            foreach (string satir in satirlar)
                metin += satir + "\n";

            WriteTofile(dosyaYolu, metin, false);
        }
    }
}