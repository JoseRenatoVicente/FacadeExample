using System;

namespace Facade.Datebase
{
    internal class Program
    {
        static AeroportoService aeroportoService = new AeroportoService();
        static void Main(string[] args)
        {

            Console.WriteLine("Importar JSON Aeroportos");

            aeroportoService.AddFileAeroporto();
        }

        public static class Configuration
        {
            static string datasource = "JOSE";
            static string database = "FacadeAeroporto";
            static string username = "sa";
            static string password = "iuq4nge1";
            public static string ConnectionString
            {
                get
                {
                    return @$"Data Source={datasource};Initial Catalog={database};Persist Security Info=True;User ID={username};Password={password};";
                }
            }
        }
    }
}
