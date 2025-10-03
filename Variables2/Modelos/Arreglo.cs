using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Variables2.Modelos
{
    public class Arreglo
    {
        public static int[] edades = new int[10];
        public static int pos = 0;
        private static int i;

        public static int GetPromedio()
        {
            int prom = 0;
            int suma = 0;

            foreach (int edad in edades)
            {
                suma += edad;

            }
            prom = suma / pos;
            return prom;
        }

        public static double GetPromedioD()
        {
            double prom = 0;
            double suma = 0;
            foreach (int edad in edades)
            {
                suma += edad;

            }
            prom = suma / pos;
            return prom;
        }
        public static int GetEdadMaxima()
        {
            int edadMaxima = 0;
            foreach (int edad in edades)
                if (edad > edadMaxima)
                {
                    edadMaxima = edad;
                }
            return edadMaxima;
        }
    

        public static int GetedadMinima()
        {
            int edadMinima = edades[0];
            for (int i = 1; i < pos; i++)
            {
                if (edades[i] < edadMinima) edadMinima = edades[i];
            }
            return edadMinima;
        }
        public static int GetMayorEdad()
        {
            int mayorEdad = 0;
            foreach (int edad in edades)
            {
                if (edad >= 18 && edad <= 100)
                {
                    mayorEdad++;
                }
                

            }
            return mayorEdad;
        }

        public static int GetMenorDeEdad()
        {
            int menorEdad = 0;
            foreach (int edad in edades)
                if (edad < 18 && edad > 0)
                {
                    menorEdad++;
                }
            return menorEdad;
        }
        



    } 
}
