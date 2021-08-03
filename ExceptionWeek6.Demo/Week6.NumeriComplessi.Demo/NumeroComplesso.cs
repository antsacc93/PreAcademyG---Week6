using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.NumeriComplessi.Demo
{
    public class NumeroComplesso
    {
        public double ParteReale { get; set; }
        public double ParteImmaginaria { get; set; }

        public NumeroComplesso Divisione(NumeroComplesso value)
        {
            //a + ib
            //c + id
            // ((ac + bd)/(c^2+d^2)) + i((bc-ad)/(c^2 + d^2))
            double denom = Math.Pow(value.ParteReale, 2) + Math.Pow(value.ParteImmaginaria, 2);

            if (denom == 0)
            {
                //eccezione custom per gestire la divisione per 0
                throw new NumeroComplessoException("Non è possibile realizzare questa divisione, divisore uguale a zero")
                {
                    PrimoOperatore = this,
                    SecondoOperatore = value
                };
            }

            double risultatoReale = (ParteReale * value.ParteReale + ParteImmaginaria * value.ParteImmaginaria)
                / denom;
            double risultatoImmaginario = (ParteImmaginaria * value.ParteReale - ParteReale * value.ParteImmaginaria)
                / denom;

            return new NumeroComplesso
            {
                ParteReale = risultatoReale,
                ParteImmaginaria = risultatoImmaginario
            };
        }

        public override string ToString()
        {
            //a + ib -> a - ib
            if (ParteImmaginaria < 0)
            {
                return $"{ParteReale} - {ParteImmaginaria}i";
            }
            return $"{ParteReale} + {ParteImmaginaria}i";
        }
    }
}
