using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity_framework_lab.Models;

public class Produto
{
    [Key] // Define a propriedade Id como chave primária.
    public int Id { get; set; }
    
    [Required(ErrorMessage = "O nome do produto é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome do produto não pode exceder 100 caracteres.")]
    public required string Nome { get; set; }   
    
    [Required(ErrorMessage = "O preço do produto é obrigatório.")]
    [Range(0.01, 10000.00, ErrorMessage = "O preço deve estar entre 0.01 e 10000.00.")]
    [Column(TypeName = "decimal(10,2)")] // configura o tipo de coluna no banco de dados pois o db é SQlite.
    public required decimal Preco { get; set; }
}