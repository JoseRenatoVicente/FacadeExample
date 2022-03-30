using Facade.Datebase.Entidades;
using Facade.Datebase.Repositories.Base;
using System.Collections.Generic;
using System.Data.SqlClient;
using static Facade.Datebase.Program;

namespace Facade.Datebase.Repositories
{
    public class AeroportoRepository: BaseRepository, IRepository
    {
        EnderecoRepository enderecoRepository = new EnderecoRepository();

        public Aeroporto Add(Aeroporto aeroporto)
        {
            enderecoRepository.Add(aeroporto.Endereco);

            string query = "INSERT INTO Aeroporto" +
                 "(Sigla, Nome, EnderecoId) " +
                "VALUES(@sigla, @nome, @enderecoId)";
            var command = CreateCommand(query);

            command.Parameters.AddWithValue("@sigla", aeroporto.Sigla);
            command.Parameters.AddWithValue("@nome", aeroporto.Nome);
            command.Parameters.AddWithValue("@enderecoId", aeroporto.Endereco.Id);

            command.ExecuteNonQuery();

            return aeroporto;
        }

        public List<Aeroporto> AddRange(List<Aeroporto> aeroportos)
        {
            aeroportos.ForEach(e => Add(e));
            return aeroportos;
        }

        public void Atualizar()
        {
            throw new System.NotImplementedException();
        }

        public void PegarTodos()
        {
            throw new System.NotImplementedException();
        }

        public void Remover()
        {
            throw new System.NotImplementedException();
        }
    }
}
