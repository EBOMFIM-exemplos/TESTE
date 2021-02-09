using System.Collections.Generic;
using TESTE01.Models;

namespace TESTE01.Repositories.Interfaces
{
    public interface IMotoristaRepository
    {
        IEnumerable<Motorista> Motoristas { get; }
        Motorista GetMotoristaById(int motoristaId);
        Motorista GetMotoristaById(string nome);

    }
}
