using System.ComponentModel.DataAnnotations;

namespace TESTE01.Models
{
    public class Motorista
    {
        public int MotoristaId { get; set; }
        [Required(ErrorMessage = "Informe o nome do motorista ")]
        [Display(Name = "Nome do Motorista")]
        [StringLength(30)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o Sobre nome do motorista ")]
        [Display(Name = "Sobrenome do Motorista")]
        [StringLength(50)]
        public string SobreNome { get; set; }
        [Display(Name = "Rua/Avenida")]
        [StringLength(100)]
        public string Endereco { get; set; }
        [Display(Name = "Referência/Localização/Regiao")]
        [StringLength(100)]
        public string Referencia { get; set; }
        [Display(Name = "Bairro")]
        [StringLength(50)]
        public string Bairro { get; set; }
        [Display(Name = "Número")]
        public int Numero { get; set; }
        [StringLength(50)]
        public string Complemento { get; set; }
        [StringLength(10)]
        public string CEP { get; set; }
        [Display(Name = "Município")]
        [StringLength(50)]
        public string Cidade { get; set; }
        [Display(Name = "UF")]
        [StringLength(2)]
        public string Estado { get; set; }
        [StringLength(50)]
        public string Pais { get; set; }
        public int VeiculoId { get; set; }
        public virtual Veiculo Veiculo { get; set; }
    }
}
