namespace Facade
{
    public class Retangulo : IFormaGeometrica
    {
        public int Base { get; set; } = 6;
        public int Altura { get; set; } = 18;

        public double CalcularArea()
        {
            return Base * Altura;
        }

        public double CalcularPerimetro()
        {
            return Base + Altura;
        }

        public string Desenhar()
        {
            return @"
  __________________
 |                  |
 |                  |
 |                  |
 |__________________|
";
        }

        public string TipoForma()
        {
            return "Paralelogramo";
        }
    }
}
