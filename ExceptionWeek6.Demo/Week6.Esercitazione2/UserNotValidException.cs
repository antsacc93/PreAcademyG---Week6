using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Esercitazione2
{
    public class UserNotValidException : Exception
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public UserNotValidException()
        {
        }

        public UserNotValidException(string message) : base(message)
        {
        }

        public UserNotValidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UserNotValidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
