﻿using lojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
    class UsuarioDao
    {
        private EntidadeContext contexto;

        public UsuarioDao()
        {
            contexto = new EntidadeContext();
        }

        public void Salva(Usuario usuario)
        {
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }

        public Usuario BuscaPorId(int id)
        {
            return contexto.Usuarios.FirstOrDefault(u => u.ID == id);
        }

        public void Remove(Usuario usuario)
        {
            contexto.Remove(usuario);
            contexto.SaveChanges();
        }
    }
}
