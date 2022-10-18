namespace InicializadorAmbiente.Models.Contratcs;
public interface IAplicacao
{
    public IAplicacao Proximo { get; set; }

    public void Executar(Aplicacao aplicacao);
}
