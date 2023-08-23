using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do lado A: ");
            double ladoA = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do lado B: ");
            double ladoB = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do lado C: ");
            double ladoC = double.Parse(Console.ReadLine());

            Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC);
            string classificacao = triangulo.ClassificarTriangulo();
            Console.WriteLine($"Classificação do triângulo: {classificacao}");
        }
    }
}
