using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TESTE01.Models
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }
        [Required(ErrorMessage = "Informe marca do caminhão ")]
        [Display(Name = "Marca do Caminhão")]
        [StringLength(30)]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Informe modelo do caminhão ")]
        [Display(Name = "Modelo Caminhão")]
        [StringLength(30)]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Informe placa do caminhão ")]
        [Display(Name = "Placa")]
        [StringLength(10)]
        public string Placa { get; set; }
        public int Eixos { get; set; }
        public List<Motorista> Motoristas { get; set; }

    }
}
