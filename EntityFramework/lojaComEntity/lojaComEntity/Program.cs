using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using lojaComEntity.Entidades;
using Microsoft.Data.Entity;

namespace lojaComEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            var contexto = new EntidadeContext();

            
            #region Criando Venda e ProdutoVendas
            /*
            var usuarioDAO = new UsuarioDao();
            var renan = usuarioDAO.BuscaPorId(1);

            var v = new Venda
            {
                Cliente = renan
            };

            contexto.Vendas.Add(v);

            var produtoDAO = new ProdutoDao(contexto);
            var p1 = produtoDAO.BuscaPorId(1);
            var p2 = produtoDAO.BuscaPorId(2);

            var pv1 = new ProdutoVenda()
            {
                Venda = v,
                Produto =p1
            };

            var pv2 = new ProdutoVenda
            {
                Venda = v,
                Produto = p2
            };

            contexto.Vendas.Add(v);
            contexto.ProdutoVenda.Add(pv1);
            contexto.ProdutoVenda.Add(pv2);
            contexto.SaveChanges();
            contexto.Dispose();
            */
            #endregion

            #region Buscando Venda c/ Include e ThenInclude
            /*
            var v = contexto.Vendas.Include(ve=>ve.ProdutoVenda).ThenInclude(pv => pv.Produto).FirstOrDefault(ve => ve.ID == 1);

            foreach(var pv in v.ProdutoVenda)
            {
                Console.WriteLine(pv.Produto.Nome);
            }
            Console.ReadLine();
            */
            #endregion

            var pf = new PessoaFisica
            {
                Nome = "Guilherme2",
                CPF = "123456",
                Senha = "123"
            };

            //contexto.PessoasFisicas.Add(pf);

            var pj = new PessoaJuridica
            {
                Nome = "Alura2",
                CNPJ = "789",
                Senha = "123"
            };

            //contexto.PessoasJuridicas.Add(pj);

            Usuario us1 = pf;
            Usuario us2 = pj;

            contexto.Usuarios.Add(us1);
            contexto.Usuarios.Add(us2);

            contexto.SaveChanges();
        }
    }
}
