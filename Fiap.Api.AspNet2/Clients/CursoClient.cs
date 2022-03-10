using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Fiap.Api.AspNet2.Models;
using Newtonsoft.Json;

namespace Fiap.Api.AspNet2.Clients
{
    public class CursoClient
    {
        private readonly string endpoint = "https://5cb544bd07f233001424ceb8.mockapi.io/fiap/curso";

        private readonly HttpClient httpClient;

        public CursoClient()
        {
            httpClient = new HttpClient();
        }


        public async Task<IList<CursoModel>> Get()
        {
            var resposta = await httpClient.GetAsync(endpoint);

            if (resposta.IsSuccessStatusCode)
            {
                var conteudoJson = await resposta.Content.ReadAsStringAsync();
                var cursos = JsonConvert.DeserializeObject<List<CursoModel>>(conteudoJson);
                return cursos;
            }
            else
            {
                throw new Exception("Não foi possível efetuar a pesquisa de cursos");
            }

        }


        public async Task<CursoModel> Get(int id)
        {
            var resposta = await httpClient.GetAsync($"{endpoint}/{id}");

            if (resposta.IsSuccessStatusCode)
            {
                var conteudoJson = await resposta.Content.ReadAsStringAsync();
                var curso = JsonConvert.DeserializeObject<CursoModel>(conteudoJson);
                return curso;
            }
            else
            {
                throw new Exception("Curso não encontrado");
            }

        }


        public async Task<int> Post(CursoModel cursoModel)
        {

            var cursoJson = JsonConvert.SerializeObject(cursoModel);
            var cursoJsonString = new StringContent(cursoJson, Encoding.UTF8, "application/json");

            var resposta = await httpClient.PostAsync(endpoint, cursoJsonString);

            if ( ! resposta.IsSuccessStatusCode)
            {
                throw new Exception("Curso não cadastrado");
            } else
            {
                var conteudoJson = await resposta.Content.ReadAsStringAsync();
                var curso = JsonConvert.DeserializeObject<CursoModel>(conteudoJson);
                return curso.Id;
            }

        }

        public async 
        Task
Put(CursoModel cursoModel)
        {

            var cursoJson = JsonConvert.SerializeObject(cursoModel);
            var cursoJsonString = new StringContent(cursoJson, Encoding.UTF8, "application/json");

            var resposta = await httpClient.PutAsync($"{endpoint}/{cursoModel.Id}", cursoJsonString);

            if (!resposta.IsSuccessStatusCode)
            {
                throw new Exception("Curso não alterado");
            }

        }


        public async 

        Task
Delete(int id)
        {

            var resposta = await httpClient.DeleteAsync($"{endpoint}/{id}");

            if (!resposta.IsSuccessStatusCode)
            {
                throw new Exception("Curso não alterado");
            }

        }

    }
}
