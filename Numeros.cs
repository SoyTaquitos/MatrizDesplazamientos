using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizDesplazamientos
{
    class Numeros
    {
        //Atributos
        private int n;
        //Constructor
        public Numeros() //inicial
        {
            n = 0;
        }
        public Numeros(int x)  //Parametrizado
        {
            n = x;
        }
        public Numeros(Numeros objeto) //Copia
        {
            n = objeto.n;
        }
        public void cargar(int x)
        {
            n = x;
        }
        public bool VerificarPar()
        {
            return (n % 2 == 0);
        }
    }
}
