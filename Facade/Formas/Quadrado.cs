using System;

namespace Facade
{
    public class Quadrado : IFormaGeometrica
    {
        public int Lado { get; set; } = 4;

        public double CalcularArea()
        {
            return Lado * Lado;
        }

        public double CalcularPerimetro()
        {
            return Lado + Lado;
        }

        public string Desenhar()
        {
            return @"
  ______
 |      |
 |      |
 |______|
";
        }

        public string TipoForma()
        {
            return "Paralelogramo";
        }
    }
}
