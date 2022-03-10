using System.Collections.Generic;
using Fiap.Api.AspNet2.Models;

namespace Fiap.Api.AspNet2.Repository.Interface
{
    public interface IUsuarioRepository
    {
        public IList<UsuarioModel> FindAll();
        public UsuarioModel FindById(int id);
        public UsuarioModel FindByName(string name);
        public IList<UsuarioModel> FindByRegra(string regra);
        public int Insert(UsuarioModel usuarioModel);
        public void Delete(int id);
        public void Update(UsuarioModel usuarioModel);
    }
}
