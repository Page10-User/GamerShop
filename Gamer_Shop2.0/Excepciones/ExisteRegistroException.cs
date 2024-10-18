using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer_Shop2._0.Excepciones
{
    public class ExisteRegistroException : Exception
    {

        public ExisteRegistroException(string message)
            : base(message)
        {
        }

        public ExisteRegistroException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
