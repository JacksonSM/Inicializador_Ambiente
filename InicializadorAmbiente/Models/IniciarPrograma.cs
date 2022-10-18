using InicializadorAmbiente.Models.Contratcs;

namespace InicializadorAmbiente.Models;
public class IniciarPrograma : IAplicacao
{
    public IAplicacao Proximo { get; set; }

    public void Executar(Aplicacao aplicacao)
    {
        Proximo.Executar(aplicacao);
    }
}
