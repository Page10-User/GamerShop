using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer_Shop2._0.Excepciones
{
    public class NoModificationsException : Exception
    {
        public NoModificationsException(string message) : base(message)
        {
        }
    }
}
