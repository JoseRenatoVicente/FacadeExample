using System;

namespace Facade
{
    public class GeradorFormas
    {
        Quadrado quadrado;
        Retangulo retangulo;
        Circulo circulo;

        public GeradorFormas()
        {
            quadrado = new Quadrado();
            retangulo = new Retangulo();
            circulo = new Circulo();
        }        

        public void DesenharQuadrado()
        {
            Console.WriteLine(quadrado.Desenhar());
        }

        public void DesenharRetangulo()
        {
            Console.WriteLine(retangulo.Desenhar());
        }

        public void DesenharCirculo()
        {
            Console.WriteLine(circulo.Desenhar());
        }
    }
}
