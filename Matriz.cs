using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizDesplazamientos
{
    class Matriz
    {
        //Atributos
        private int MAXF = 50;
        private int MAXC = 50;
        private int [,] m;
        private int f, c;
        //Constructor
        public Matriz()
        {
            m = new int[MAXF, MAXC];
            f = 0;
            c = 0;
        }

    }
}
