﻿using System.Collections.Generic;
using System.Linq;
using Fiap.Api.AspNet2.Data;
using Fiap.Api.AspNet2.Models;
using Fiap.Api.AspNet2.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.AspNet2.Repository
{

    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataContext _context;

        public UsuarioRepository(DataContext context)
        {
            _context = context;
        }

        public IList<UsuarioModel> FindAll()
        {
            return _context.Usuarios.AsNoTracking().ToList();
        }

        public UsuarioModel FindById(int id)
        {
            return _context.Usuarios.FirstOrDefault(x => x.UsuarioId == id);
        }

        public UsuarioModel FindByName(string name)
        {
            return _context.Usuarios.FirstOrDefault(x => x.NomeUsuario == name);
        }

        public IList<UsuarioModel> FindByRegra(string regra)
        {
            return _context.Usuarios.ToList();
        }

        public int Insert(UsuarioModel usuarioModel)
        {
            _context.Usuarios.Add(usuarioModel);
            _context.SaveChanges();
            return usuarioModel.UsuarioId;
        }

        public void Update(UsuarioModel usuarioModel)
        {
            _context.Usuarios.Update(usuarioModel);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var usuario = new UsuarioModel()
            {
                UsuarioId = id
            };

            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }
    }


}
