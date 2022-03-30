using Facade.Datebase.Entidades;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Facade.Datebase
{
    public class ReadFileJson
    {
        public List<Aeroporto>? GetDataAeroporto(string pathFile)
        {
            string jsonString = new StreamReader(pathFile).ReadToEnd();

            if (File.Exists(pathFile))
                return JsonConvert.DeserializeObject<List<Aeroporto>>(jsonString);

            return null;
        }
    }
}
