using Facade.Datebase.Repositories;
using System;

namespace Facade.Datebase
{
    public class AeroportoService
    {
        AeroportoRepository aeroportoRepository = new AeroportoRepository();
        ReadFileJson readFileJson = new ReadFileJson();

        public void AddFileAeroporto()
        {
            Console.WriteLine("Digite o caminho do arquivo Ex: C:\\aeroportos.json");
            var aeroportos = readFileJson.GetDataAeroporto(Console.ReadLine());

            aeroportoRepository.AddRange(aeroportos);
        }
    }
}
