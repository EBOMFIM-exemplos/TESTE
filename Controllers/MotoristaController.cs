using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using TESTE01.Repositories.Interfaces;

namespace TESTE01.Controllers
{
    public class MotoristaController : Controller
    {
        public IMotoristaRepository _motoristaRepository { get; }

        private readonly IVeiculoRepository _veiculoRepository;

        public MotoristaController(IMotoristaRepository motoristaRepository, IVeiculoRepository veiculoRepository)
        {
            _motoristaRepository = motoristaRepository;
            _veiculoRepository = veiculoRepository;

        }
        public IActionResult ListMotorista()
        {
            ViewBag.Motorista = "Motorista";
            ViewData["Veiculo"] = "Veiculo";

            var Motorista = _motoristaRepository.Motoristas;

            return View(Motorista);
        }
    }
}