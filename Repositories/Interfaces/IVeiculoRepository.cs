using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTE01.Models;

namespace TESTE01.Repositories.Interfaces
{
    public interface IVeiculoRepository
    {
        IEnumerable<Veiculo> Veiculos { get; }
    }
}
