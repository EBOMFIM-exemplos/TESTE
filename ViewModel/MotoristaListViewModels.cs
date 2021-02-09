using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTE01.Models;

namespace TESTE01.ViewModel
{
    public class MotoristaListViewModels
    {
        public IEnumerable<Motorista> Motoristas { get; set; }
        public string veiculoAtual { get; set; }
    }
}
