using System.Collections.Generic;
using TESTE01.Context;
using TESTE01.Models;
using TESTE01.Repositories.Interfaces;

namespace TESTE01.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly AppDbContext _context;

        public VeiculoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Veiculo> Veiculos => _context.Veiculos;
    }
}
