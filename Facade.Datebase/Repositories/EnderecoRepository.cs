using Facade.Datebase.Entidades;
using Facade.Datebase.Repositories.Base;

namespace Facade.Datebase.Repositories
{
    public class EnderecoRepository : BaseRepository, IRepository
    {
        public Endereco Add(Endereco endereco)
        {
            string query = "INSERT INTO Endereco" +
     "(Id, Bairro, Cidade, Pais, CEP, Logradouro, Estado, Numero, Complemento) " +
    "VALUES(@id, @bairro, @cidade, @pais, @cep, @logradouro, @estado, @numero, @complemento)";
            var command = CreateCommand(query);

            command.Parameters.AddWithValue("@id", endereco.Id);
            command.Parameters.AddWithValue("@bairro", endereco.Bairro);
            command.Parameters.AddWithValue("@cidade", endereco.Cidade);
            command.Parameters.AddWithValue("@pais", endereco.Pais);
            command.Parameters.AddWithValue("@cep", endereco.CEP);
            command.Parameters.AddWithValue("@logradouro", endereco.Logradouro);
            command.Parameters.AddWithValue("@estado", endereco.Estado);
            command.Parameters.AddWithValue("@numero", endereco.Numero);
            command.Parameters.AddWithValue("@complemento", endereco.Complemento);

            command.ExecuteNonQuery();

            return endereco;
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
