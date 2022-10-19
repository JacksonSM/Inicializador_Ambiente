namespace InicializadorAmbiente.Models;
public class Ambiente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal IntervaloEmSegundos { get; set; }
    public List<Aplicacao> Aplicacoes { get; private set; } = new();

    public void Atualizar(Ambiente ambiente)
    {
        Nome = ambiente.Nome;
        IntervaloEmSegundos = ambiente.IntervaloEmSegundos;
        Aplicacoes = ambiente.Aplicacoes;
    }
}
