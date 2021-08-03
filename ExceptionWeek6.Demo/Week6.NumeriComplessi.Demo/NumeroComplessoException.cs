using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Week6.NumeriComplessi.Demo
{
    public class NumeroComplessoException : Exception
    {
        public NumeroComplesso PrimoOperatore { get; set; }
        public NumeroComplesso SecondoOperatore { get; set; }

        public NumeroComplessoException()
        {
        }

        public NumeroComplessoException(string message) : base(message)
        {
        }

        public NumeroComplessoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NumeroComplessoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
