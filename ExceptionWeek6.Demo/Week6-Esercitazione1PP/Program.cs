using System;
using System.IO;

namespace Week6_Esercitazione1PP
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProgrammazionePreventiva();
            //ProgrammazioneConEccezioni();
            try
            {
                ExceptionThrowing();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ExceptionThrowing()
        {
            int[] arrayInteri = new int[5];
            string path = @"C:\Users\AntoniaSacchitella\Desktop\Week6-PreAcademyG\provaFile.txt";
            Console.WriteLine("Inserisci il numero da aggiungere");
            bool successValue = int.TryParse(Console.ReadLine(), out int value);
            Console.WriteLine("Inserisci la posizione da popolare");
            bool successIndex = int.TryParse(Console.ReadLine(), out int index);
            ControlloInput(successValue, successIndex, value, index, path, arrayInteri);          
        }

        private static void ControlloInput(bool successValue, bool successIndex, int value, int index, string path, int[] arrayInteri)
        {
            if (successValue && successIndex)
            {
                //LA CONVERSIONE E' ANDATA A BUON FINE
                if (index > 0 && index < arrayInteri.Length)
                {
                    //l'utente ha inserito un valore corretto per la posizione
                    arrayInteri[index] = value;
                    if (File.Exists(path))
                    {
                        //se il file esiste
                        StreamWriter sw = new StreamWriter(path);
                        for (int i = 0; i < arrayInteri.Length; i++)
                        {
                            sw.WriteLine(arrayInteri[i]);
                        }
                        sw.Close();
                    }
                    else
                    {
                        throw new FileNotFoundException();
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            else
            {
                throw new FormatException();
            }
        }

        static void ProgrammazioneConEccezioni()
        {
            int[] arrayInteri = new int[5];
            string path = @"C:\Users\AntoniaSacchitella\Desktop\Week6-PreAcademyG\provaFile.txt";
            StreamWriter sw = null;
            try
            {
                Console.WriteLine("Inserisci il numero da aggiungere");
                int value = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci posizione da popolare");
                int index = int.Parse(Console.ReadLine());
                arrayInteri[index] = value;
                sw = new StreamWriter(path);
                for(int i = 0; i < arrayInteri.Length; i++)
                {
                    sw.WriteLine(arrayInteri[i]);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File non trovato");
            }
            catch (FileLoadException)
            {
                Console.WriteLine("Errore di caricamento");
            }
            catch (FormatException)
            {
                Console.WriteLine("Puoi inserire solo numeri");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Puoi inserire solo numeri tra {0} e {1}", int.MinValue, int.MaxValue);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("La posizione inserita non è valida");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(sw != null)
                    sw.Close();
            }
        }

        static void ProgrammazionePreventiva()
        {
            //Dichiariamo un array di 5 elementi
            int[] arrayInteri = new int[5];
            string path = @"C:\Users\AntoniaSacchitella\Desktop\Week6-PreAcademyG\provaFile.txt";
            Console.WriteLine("Inserisci il numero da aggiungere");
            //INPUT UTENTE
            bool successValue = int.TryParse(Console.ReadLine(), out int value);
            Console.WriteLine("Inserisci posizione da occupare");
            //INPUT UTENTE
            bool successIndex = int.TryParse(Console.ReadLine(), out int index);
            //if(successValue == true && successIndex == true)
            if (successValue && successIndex)
            {
                if (index > 0 && index < arrayInteri.Length)
                {
                    arrayInteri[index] = value;
                    if (File.Exists(path))
                    {
                        using (StreamWriter sw = new StreamWriter(path))
                        {
                            for (int i = 0; i < arrayInteri.Length; i++)
                            {
                                sw.WriteLine(arrayInteri[i]);
                            }
                        }


                        //sw.Close();
                    }
                }
            }
        }
    }
}
