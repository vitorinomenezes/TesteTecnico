using System.ComponentModel.DataAnnotations;

namespace Questao5.Domain.Entities
{
    public class MovimentoModel
    {
        [Required(ErrorMessage = "Informe o número da conta")]
        public int IdMovimento { get; set; }
        public int IdContaCorrente { get; set; }

        public string DataMovimento { get; set; }

        public string TipoMovimento { get; set; }

        public double Valor { get; set; }
    }
}
