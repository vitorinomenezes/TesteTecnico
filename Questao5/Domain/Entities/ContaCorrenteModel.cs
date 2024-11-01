using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Questao5.Domain.Entities
{
    public class ContaCorrenteModel 
    {
        [Required(ErrorMessage = "Informe o número da conta")]
        public int IdContaCorrente { get; set; }


        [Required(ErrorMessage = "Informe o número da conta")]
        public int Numero { get; set; }
 
        public string Nome { get; set; }

        public int Ativo { get; set; }

      
    }
}
