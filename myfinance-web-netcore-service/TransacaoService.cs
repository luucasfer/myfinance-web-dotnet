﻿using myfinance_web_netcore_service.Interfaces;
using myfinance_web_netcore_domain.Entities;
using myfinance_web_netcore_infra;

namespace myfinance_web_netcore_service
{
    public class TransacaoService : ITransacaoService
    {
        private readonly MyFinanceDbContext _dbContext;

        public TransacaoService(MyFinanceDbContext dbContext)
        { 
            _dbContext = dbContext;
        }

        public void Cadastrar(Transacao Entidade)
        {
            var dbSet = _dbContext.Transacao;
            if (Entidade.Id == null)
            {
                dbSet.Add(Entidade);
            }
            else
            {
                dbSet.Attach(Entidade);
                _dbContext.Entry(Entidade).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void Excluir(int Id)
        {
            var Transacao = new Transacao() { Id = Id };
            _dbContext.Attach(Transacao);
            _dbContext.Remove(Transacao);
            _dbContext.SaveChanges(); 
        }

        public List<Transacao> ListarRegistros()
        {
            var dbSet = _dbContext.PlansConta;
            return dbSet.ToList();
        }

        public Transacao RetornarRegistro(int Id)
        {
            return _dbContext.Transacao.Where(x => x.Id == Id).First();
        }
    }
}