using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11POO
{
    internal class Triangulo
    {
        private double ladoA, ladoB, ladoC;

        public Triangulo(double a, double b, double c)
        {
            ladoA = a;
            ladoB = b;
            ladoC = c;
        }

        public string ClassificarTriangulo()
        {
            if (ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA)
            {
                if (ladoA == ladoB && ladoB == ladoC)
                    return "Triângulo Equilátero";
                else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                    return "Triângulo Isósceles";
                else
                    return "Triângulo Escaleno";
            }
            else
            {
                return "Não forma um triângulo";
            }
        }
    }
}
