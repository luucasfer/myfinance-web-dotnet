using myfinance_web_netcore_domain.Entities;

namespace myfinance_web_netcore_service.Interfaces
{
    public interface ITransacaoService
    {
        void Cadastrar(Transacao Entidade);
        void Excluir(int Id);
        List<Transacao> ListarRegistros();
        PlanoConta RetornarRegistro(int Id);

    }
}