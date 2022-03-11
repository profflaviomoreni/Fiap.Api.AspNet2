using System;
using Newtonsoft.Json;

namespace Fiap.Api.AspNet2.Models
{
    public class CursoModel
    {
        public CursoModel()
        {
        }


        public int Id { get; set; }

        public double Preco { get; set; }

        public string Nome { get; set; }

        public string Nivel { get; set; }

        public string Conteudo { get; set; }

        public bool Concluido { get; set; }

        //public double PercentualConclusao { get; set; }
        [JsonProperty("PercentualConclusao")]
        public double Percentual { get; set; }

    }
}
