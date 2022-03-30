using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Datebase.Repositories.Base
{
    public interface IRepository
    {
        void PegarTodos();
        void Atualizar();
        void Remover();
    }
}
