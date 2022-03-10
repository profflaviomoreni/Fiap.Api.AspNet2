using System.Collections.Generic;
using Fiap.Api.AspNet2.Models;

namespace Fiap.Api.AspNet2.Repository.Interface
{
    public interface ICategoriaRepository
    {
        public IList<CategoriaModel> FindAll();
        public CategoriaModel FindById(int id);
        public int Insert(CategoriaModel categoriaModel);
        public void Delete(int id);
        public void Update(CategoriaModel categoriaModel);
    }
}
