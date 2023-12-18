namespace myfinance_web_netcore_domain;

public class Transacao
{
    public int? Id { get; set; }
    public string Historico { get; set;}
    public Datetime Data { get; set; }
    public decimal Valor { get; set; }
    public int PlanoContaId { get; set; }
    public PlanoConta PlanoConta { get; set; }
}
