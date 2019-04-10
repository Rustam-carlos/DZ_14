using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_14
{
    public class Player<T> : Karta<T>
    {
        public int[,] deck { get; set; }
        public int[] players { get; set; }
    }
}
