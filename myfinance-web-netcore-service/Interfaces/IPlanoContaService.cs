using myfinance_web_netcore_domain.Entities;

namespace myfinance_web_netcore_service.Interfaces
{
    public interface IPlanoContaService
    {
        void Cadastrar(PlanoConta Entidade);
        void Excluir(int Id);
        List<PlanoConta> ListarRegistros();
        PlanoConta RetornarRegistro(int Id);

    }                               
}