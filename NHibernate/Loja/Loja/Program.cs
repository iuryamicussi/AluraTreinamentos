using Loja.DAO;
using Loja.Entidades;
using Loja.Infra;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Criando Tabelas do Banco de Dados
            //NHibernateHelper.GeraSchema();
            #endregion

            #region Inserindo um Usuário no Banco -- método Antigo
            /*Configuration cfg = NHibernateHelper.RecuperaConfiguracao();
            ISessionFactory sessionFactory = cfg.BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();

            Usuario novoUsuario = new Usuario
            {
                Nome = "Murilo"
            };

            ITransaction transacao = session.BeginTransaction();
            session.Save(novoUsuario);
            transacao.Commit();

            session.Close();*/
            #endregion

            ISession session = NHibernateHelper.AbreSession();
            UsuarioDAO usuarioDao = new UsuarioDAO(session);

            Usuario novoUsuario = new Usuario
            {
                Nome = "Murilo"
            };

            usuarioDao.Adiciona(novoUsuario);

            session.Close();

            Console.Read();
        }
    }
}
