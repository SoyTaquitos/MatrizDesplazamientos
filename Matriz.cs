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
        //Cargar y descargar 
        public void Cargar(int nf,int nc,int a,int b)
        {
            Random r = new Random();
            f = nf;
            c = nc;
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = 1; c1 <= c; c1++)
                {
                    m[f1, c1] = r.Next(a, b);
                }
            }
        }
        public string Descargar()
        {
            string s = "";
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = 1; c1 <= c; c1++)
                {
                    s = s + m[f1, c1] + "\x0009";
                }
                s = s + "\x000d" + "\x000a";
            }
            return s;
        }
        //Métodos de ayuda 
        public void Intercambiar(int f1,int c1,int f2,int c2)
        {
            int aux;
            aux = m[f1, c1];
            m[f1, c1] = m[f2, c2];
            m[f2, c2] = aux;
        }      
        public void DesplazamientoPorFilas() //De izquierda a derecha
        {
            int i = 1;
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = 1; c1 <= c; c1++)
                {
                    m[f1, c1] = i++;
                }                                       
            }
        }
        public void DesplazamientoPorColumnas() 
        {
            int i = 1;
            for (int c1 = 1; c1 <= c; c1++)
            {
                for (int f1 = 1; f1 <= f; f1++)
                {
                    m[f1, c1] = i++;
                }
            }
        }

    }
}
