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
        public void DesplazamientoPorFilas() //De izq-der
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
        public void DesplazamientoPorColumnas() //De arriba hacia abajo izq-der
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
        public void DesplazamientoPorColumna2()
        {
            int i = 1;
            for (int c1 = c; c1 >= 1; c1--)
            {
                for (int f1 = 1; f1 <= f; f1++)
                {
                    m[f1, c1] = i++;
                }
            }
        }
        public void DesplazamientoPorFila2()
        {
            int i = 1;
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = c; c1 >= 1; c1--)
                {
                    m[f1, c1] = i++;
                }
            }
        }
        public void DesplazamientoPorFilaInfIzq()
        {
            int i = 1;
            for (int f1 = f; f1 >= 1; f1--)
            {
                for (int c1 = 1; c1 <= c; c1++)
                {
                    m[f1, c1] = i++;
                }
            }
        }
        public void DesplazamientoPorColumnaInfIzq()
        {
            int i = 1;
            for (int c1 = 1; c1 <= c; c1++)
            {
                for (int f1 = f; f1 >= 1; f1--)
                {
                    m[f1, c1] = i++;
                }
            }
        }
        public void DesplazamientoPorFilaInfDer()
        {
            int i = 1;
            for (int f1 = f; f1 >= 1; f1--)
            {
                for (int c1 = c; c1 >= 1; c1--)
                {
                    m[f1, c1] = i++;
                }
            }
        }
        public void DesplazamientoPorColumnaInfDer()
        {
            int i = 1;
            for (int c1 = c; c1 >= 1; c1--)
            {
                for (int f1 = f; f1 >= 1; f1--)
                {
                    m[f1, c1] = i++;
                }
            }
        }

        public void DiagonalPrincipal()
        {
            int i = 1;
            for (int d = 1; d <= f; d++)
            {
                m[d, d] = i++;
            }
        }
        public void DiagonalPrincipal2()
        {
            int i = 1;
            for (int d = f; d >= 1; d--)
            {
                m[d, d] = i++;
            }
        }     
        public void DiagonalSecundaria()
        {
            int i = 1;
            for (int d = 1; d <= f; d++)
            {
                m[d,c-d+1] = i++; 
                // d = desplazamiento de las filas , c = nc , " c - d + 1 " mantiene "orden columnas ascendente 1,2,3,4"
            }
        }
        public void DiagonalSecundaria2()
        {
            int i = 1;
            for (int d = 1; d <= c; d++)
            {
                m[f - d + 1, d] = i++;
                // d = desplazamiento de las columnas, f = nf, " f - d + 1" mantiene "orden de filas descendente 4,3,2,1 "
            }
        }
        public void TriangulInfIzq()
        {
            int i = 1;
            for (int f1 = 2; f1 <= f; f1++)
            {
                for (int c1 = 1; c1 <= f1 -1; c1++)
                {
                    m[f1, c1] = i++;
                }
            }
        }

        public void OrdenamientoDeMatriz()
        {
            int i;
            for (int fp = 1; fp <= f; fp++)
            {
                for (int cp = 1; cp <= c; cp++)
                {
                    for (int fd = fp; fd <= f; fd++)
                    {
                        if (fd == fp)
                        {
                            i = cp;
                        }
                        else
                        {
                            i = 1;
                        }
                        for (int cd = i; cd <= c; cd++)
                        {
                            if(m[fd,cd] < m[fp,cp])
                            {
                                this.Intercambiar(fd, cd, fp, cp);
                            }
                        }
                    }
                }
            }
        }
        public void OrdenSen()
        {
            this.OrdenamientoColumna();
            for (int c1 = 1; c1 <= c; c1++)
            {
                if (c1 % 2 == 1)
                {
                    this.InterCol(c1);
                }
            }
        }
        public void OrdenamientoColumna()
        {
            int i;
            for (int cp = 1; cp <= c; cp++)
            {
                for (int fp = 1; fp <= f; fp++)
                {
                    for (int cd = cp; cd <= c; cd++)
                    {
                        if (cp == cd)
                        {
                            i = fp;
                        }
                        else
                        {
                            i = 1;
                        }
                        for (int fd = i; fd <= f; fd++)
                        {
                            if(m[fd,cd] < m[fp,cp])
                            {
                                this.Intercambiar(fd, cd, fp, cp);
                            }
                            
                        }
                    }
                }
            }           
        }
        public void InterCol(int columna)
        {
            for (int f1 = 1; f1 <= f - 1; f1++)
            {
                for (int f2 = f; f2 >= f1 + 1; f2--)
                {
                    if(m[f2,columna] > m[f2 -1,columna])
                    {
                        this.Intercambiar(f2, columna, f2 -1, columna);
                    }
                }
            }
        }      
        public void OrdenSen2()
        {
            this.OrdenamientoDeMatriz2();
            for (int f1 = 1; f1 <= f; f1++)
            {
                if (f1 % 2 == 1)
                {
                    this.OrdenarFila(f1);
                }
            }
        }
        public void OrdenamientoDeMatriz2()
        {
            int i;
            for (int fp = 1; fp <= f; fp++)
            {
                for (int cp = 1; cp <= c; cp++)
                {
                    for (int fd = fp; fd <= f; fd++)
                    {
                        if (fd == fp)
                        {
                            i = cp;
                        }
                        else
                        {
                            i = 1;
                        }
                        for (int cd = i; cd <= c; cd++)
                        {
                            if (m[fd, cd] > m[fp, cp])
                            {
                                this.Intercambiar(fd, cd, fp, cp);
                            }
                        }
                    }
                }
            }
        }
        public void OrdenarFila(int f1)
        {
            for (int i = 1; i <= c; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    if (m[f1, i] < m[f1,j] )
                    {
                        this.Intercambiar(f1, i, f1, j);
                    }
                }
            }
        }         
        //Triangulares  
        public void TriangularInferiorDerechaIzq_Der()
        {
            int co;
            for (int f1 = 2; f1 <= f; f1++)
            {
                for (int c1 = c - f1 + 2; c1 <= c; c1++)
                {
                    for (int f2 = f1; f2 <= f; f2++)
                    {
                        co = (f2 == f1) ? (c1) : (c - f2 + 2);
                        for (int c2 = co; c2 <= c; c2++)
                        {
                            if (m[f1,c1] > m[f2,c2])
                            {
                                this.Intercambiar(f1, c1, f2, c2);
                            }
                        }
                    }
                }
            }
        }//Triangulares Superiores Derecha 
        public void TriangularSuperiorDerecha1()
        {
            int dig;
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = f1 + 1; c1 <= c; c1++)
                {
                    for (int f2 = f1; f2 <= f; f2++)
                    {
                        dig = (f2 == f1) ? (c1) : (f2 +1);
                        for (int c2 = dig; c2 <= c; c2++)
                        {
                            if(m[f1,c1] > m[f2,c2])
                            {
                                this.Intercambiar(f1, c1, f2, c2);
                            }
                        }
                    }
                }
            }
            
        }
        public void TriangularSuperiorDerecha2()
        {
            int dig;
            for (int f1 = f - 1; f1 >= 1; f1--)
            {
                for (int c1 = f1 + 1; c1 <= c; c1--)
                {
                    for (int f2 = f1; f2 >= 1; f2--)
                    {
                        dig = (f2 == f1) ? (c1) : (f2 + 1);
                        for (int c2 = dig; c2 <= c ; c2++)
                        {
                            if (m[f1,c1] > m[f2,c2])
                            {
                                this.Intercambiar(f1, c1, f2, c2);
                            }
                        }
                    }
                }
            }
        }
        public void ChuflinesParcial()
        {
            int i;
            for (int fp = f - 1; fp >= 1; fp--)
            {
                for (int cp = 1; cp <= c - fp; cp++)
                {
                    for (int fd = fp; fd >= 1; fd--)
                    {
                        i = (fp == fd) ? (cp) : (1);
                        for (int cd = i; cd <= c - fd; cd++)
                        {
                            if ((!(m[fp, cp] % 2 == 0) && (m[fd, cd] % 2 == 0)) ||
                             (!(m[fp, cp] % 2 == 0) && !(m[fd, cd] % 2 == 0) && m[fd, cd] < m[fp, cp]) || (
                               (m[fp, cp] % 2 == 0) && (m[fp, cp] % 2 == 0) && m[fd, cd] < m[fp, cp]))

                                this.Intercambiar(fd, cd, fp, cp);
                        }
                    }
                }
            }
        }  
        
        
                                                                                            
    }
}
