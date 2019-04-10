using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_14
{
    public class Karta<T>
    {
        public string[] suits;
        public T[] cartNumber { get; set; }
    }
}
