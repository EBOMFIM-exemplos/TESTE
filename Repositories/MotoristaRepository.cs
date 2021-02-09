using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TESTE01.Context;
using TESTE01.Models;
using TESTE01.Repositories.Interfaces;

namespace TESTE01.Repositories
{
    public class MotoristaRepository : IMotoristaRepository
    {
        public readonly AppDbContext _context;

        public MotoristaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Motorista> Motoristas => _context.Motoristas.Include(m => m.Veiculo);

        public Motorista GetMotoristaById(int motoristaId)
        {
           return _context.Motoristas.FirstOrDefault( m => m.MotoristaId == motoristaId );
        }

        public Motorista GetMotoristaById(string nome)
        {
            return _context.Motoristas.FirstOrDefault(m => m.Nome == nome);
        }

    }
}
