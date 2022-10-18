using InicializadorAmbiente.Models.Contratcs;
using System.Threading;

namespace InicializadorAmbiente.Models;
public class Inicializador
{
    public void Iniciar(Ambiente ambiente)
    {
        IAplicacao site = new IniciarSite();
        IAplicacao programa = new IniciarPrograma();
        IAplicacao appNaoIdentificado = new AplicacaoNaoIdentificada();

        site.Proximo = programa;
        programa.Proximo = appNaoIdentificado;

        foreach (var aplicacao in ambiente.Aplicacao)
        {
            Thread.Sleep(1000);
            site.Executar(aplicacao);
        }
    }
}
