﻿using lojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
    class CategoriaDao
    {
        private EntidadeContext contexto;

        public CategoriaDao()
        {
            contexto = new EntidadeContext();
        }

        public void Salva(Categoria categoria)
        {
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }

        public Categoria BuscaPorId(int id)
        {
            return contexto.Categorias.FirstOrDefault(u => u.ID == id);
        }

        public void Remove(Categoria categoria)
        {
            contexto.Remove(categoria);
            contexto.SaveChanges();
        }
    }
}
