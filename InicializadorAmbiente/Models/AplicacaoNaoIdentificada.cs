using InicializadorAmbiente.Models.Contratcs;

namespace InicializadorAmbiente.Models;
public class AplicacaoNaoIdentificada : IAplicacao
{
    public IAplicacao Proximo { get; set; }

    public void Executar(Aplicacao aplicacao)
    {
        
    }
}
