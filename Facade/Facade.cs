namespace Facade
{
    public static class Facade
    {
        private static GeradorFormas _geradorFormas = new GeradorFormas();
        private static CalcularAreaPerimetro _calcularArea = new CalcularAreaPerimetro();
        public static void DesenharParelogramosPropriedades()
        {
            _geradorFormas.DesenharRetangulo();
            _calcularArea.AreaRetangulo();
            _calcularArea.PerimetroRetangulo();

            _geradorFormas.DesenharQuadrado();
            _calcularArea.AreaQuadrado();
            _calcularArea.PerimetroQuadrado();
        }
        public static void DesenharTodasFormasPropriedades()
        {
            DesenharParelogramosPropriedades();

            _geradorFormas.DesenharCirculo();
            _calcularArea.AreaCirculo();
            _calcularArea.PerimetroCirculo();
        }


        public static void DesenharParelogramos()
        {
            _geradorFormas.DesenharRetangulo();

            _geradorFormas.DesenharQuadrado();
        }

        public static void DesenharTodasFormas()
        {
            DesenharParelogramos();
            _geradorFormas.DesenharCirculo();
        }

    }
}
