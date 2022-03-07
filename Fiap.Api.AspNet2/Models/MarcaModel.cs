using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Api.AspNet2.Models
{
    [Table("Marcas")]
    public class MarcaModel
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MarcaId { get; set; }

        [Required]
        [MaxLength(40, ErrorMessage = "Nome da Marca precisa ter até {0} caracteres")]
        public String NomeMarca { get; set; }


        public MarcaModel()
        {
        }

        public MarcaModel(int marcaId, string nomeMarca)
        {
            MarcaId = marcaId;
            NomeMarca = nomeMarca;
        }

    }
}
