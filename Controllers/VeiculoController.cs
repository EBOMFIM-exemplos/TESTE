using Microsoft.AspNetCore.Mvc;
using TESTE01.Repositories.Interfaces;

namespace TESTE01.Controllers
{
    public class VeiculoController : Controller
    {
        
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculoController(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public IActionResult CadatrarVeiculo()
        {
            ViewData["Veiculo"] = "Veiculo";
            var veiculos = _veiculoRepository.Veiculos;
            return View(veiculos);

        }

        public IActionResult ListVeiculo()
        {
            ViewData["Veiculo"] = "Veiculo";
            var veiculos = _veiculoRepository.Veiculos;
            return View(veiculos);
        }
    }
}