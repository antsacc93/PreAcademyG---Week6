using System;
using System.Data.SqlClient;

namespace Week6.Esercitazione2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci username");
            var username = Console.ReadLine();
            Console.WriteLine("Inserisci password");
            var password = Console.ReadLine();
            try
            {
                GetUserFromDB(username, password);
            }
            catch(UserNotValidException ex)
            {
                Console.WriteLine(ex.Message + "\n");
                Console.WriteLine($"Verifica l'utente {ex.Username} oppure la sua password");
            }
            
        }

        private static void GetUserFromDB(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(@"Server= .\SQLEXPRESS; Persist Security Info = False;
                    Integrated Security = true; Initial Catalog = UtentiSalvati"))
            {
                //Apro la connessione
                conn.Open();
                //Creo il comando
                SqlCommand userCommand = new SqlCommand();
                userCommand.Connection = conn;
                userCommand.CommandType = System.Data.CommandType.Text;
                userCommand.CommandText = "SELECT * FROM UTENTE WHERE username = @username AND password = @password";

                //Creo i parametri
                SqlParameter usernamePar = new SqlParameter()
                {
                    ParameterName = "@username",
                    Value = username
                };
                SqlParameter passwordPar = new SqlParameter()
                {
                    ParameterName = "@password",
                    Value = password
                };

                userCommand.Parameters.Add(usernamePar);
                userCommand.Parameters.Add(passwordPar);

                //Eseguo il comando
                SqlDataReader reader = userCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("Login effettuato con successo");
                }
                else
                {
                    //SOLLEVO ECCEZIONE CUSTOM
                    throw new UserNotValidException("Inserire username e password corretti") 
                    { 
                        Username = username,
                        Password = password
                    };
                }
            }
        }
    }
}
