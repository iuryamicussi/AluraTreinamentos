using lojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
    public class ProdutoDao
    {
        private EntidadeContext contexto;

        public ProdutoDao(EntidadeContext contexto)
        {
            this.contexto = contexto;
        }

        public IList<Produto> BuscaPorNomePrecoNomeCategoria(string nome,decimal preco, string nomeCategoria)
        {
            var busca = from p in contexto.Produtos select p;

            if (!string.IsNullOrEmpty(nome))
            {
                /* busca = from p in busca
                         where p.Nome == nome
                         select p; */
                busca = busca.Where(p => p.Nome == nome);
            }

            if (preco > 0.0m)
            {
                /*busca = from p in busca
                        where p.Preco == preco
                        select p; */
                busca = busca.Where(p => p.Preco == preco);
            }

            if (!string.IsNullOrEmpty(nomeCategoria))
            {
                /*busca = from p in busca
                        where p.Categoria.Nome == nomeCategoria
                        select p; */
                busca = busca.Where(p => p.Categoria.Nome == nomeCategoria);
            }

            return busca.ToList();
        }

        public void Salva(Produto produto)
        {
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }

        public Produto BuscaPorId(int id)
        {
            return contexto.Produtos.FirstOrDefault(u => u.ID == id);
        }

        public void Remove(Produto produto)
        {
            contexto.Remove(produto);
            contexto.SaveChanges();
        }
    }
}
