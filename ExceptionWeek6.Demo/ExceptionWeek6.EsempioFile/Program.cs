using System;
using System.IO;

namespace ExceptionWeek6.EsempioFile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = null;
            string path = @"C:\Users\AntoniaSacchitella\Desktop\Week6-PreAcademyG\provaFile1.txt";
            //CONTROLLO PREVENTIVO
            if (File.Exists(path))
            {
                sr = new StreamReader(path);
                string content = sr.ReadToEnd();

                Console.WriteLine(content);
            }

            try
            {
                sr = new StreamReader(path);
                string content = sr.ReadToEnd();
                Console.WriteLine(content);
            }
            catch(FileNotFoundException ef)
            {
                Console.WriteLine("File non trovato");
            }
            catch(FileLoadException fLoad)
            {
                Console.WriteLine("Errore di caricamento");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Errore");
            }
            finally
            {
                if(sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
