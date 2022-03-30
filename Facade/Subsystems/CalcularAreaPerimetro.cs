using System;

namespace Facade
{
    public class CalcularAreaPerimetro
    {
        Quadrado quadrado;
        Retangulo retangulo;
        Circulo circulo;

        public CalcularAreaPerimetro()
        {
            quadrado = new Quadrado();
            retangulo = new Retangulo();
            circulo = new Circulo();
        }

        public void AreaQuadrado()
        {
            Console.WriteLine("Área: " + quadrado.CalcularArea());
        }

        public void AreaRetangulo()
        {
            Console.WriteLine("Área: " + retangulo.CalcularArea());
        }

        public void AreaCirculo()
        {
            Console.WriteLine("Área: " + circulo.CalcularArea());
        }



        public void PerimetroQuadrado()
        {
            Console.WriteLine("Perímetro: " + quadrado.CalcularPerimetro());
        }

        public void PerimetroRetangulo()
        {
            Console.WriteLine("Perímetro: " + retangulo.CalcularPerimetro());
        }

        public void PerimetroCirculo()
        {
            Console.WriteLine("Perímetro: " + circulo.CalcularPerimetro());
        }
    }
}
