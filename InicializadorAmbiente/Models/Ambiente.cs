namespace InicializadorAmbiente.Models;
public class Ambiente
{
    public string Nome { get; set; }
    public decimal IntervaloEmSegundos { get; set; }
    public List<Aplicacao> Aplicacao { get; private set; } = new();
}
