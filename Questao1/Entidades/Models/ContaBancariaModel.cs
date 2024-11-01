using System.ComponentModel.DataAnnotations;

namespace Questao1.Entidades.Models
{
    public class ContaBancariaModel
    {

        [Required(ErrorMessage = "Informe o número da conta")]
        public int NuConta { get; set; }

        [Required(ErrorMessage = "Informe o nome do titular da conta")]
        public string NomeTitular { get; set; }

        [Required(ErrorMessage = "Informe o tipo de transação")]
        public string TipoTransacao { get; set; }

        public double? ValorDeposito { get; set; }

    }
}
