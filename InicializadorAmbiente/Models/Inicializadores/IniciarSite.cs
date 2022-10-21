using InicializadorAmbiente.Models.Contratcs;
using System.Diagnostics;

namespace InicializadorAmbiente.Models.Inicializadores;
public class IniciarSite : IAplicacao
{
    public IAplicacao Proximo { get; set; }

    public void Executar(Aplicacao aplicacao)
    {
        if (aplicacao.Tipo == "SITE")
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = aplicacao.Caminho,
                UseShellExecute = true
            };
            Process.Start(psInfo);
            return;
        }
        Proximo.Executar(aplicacao);
    }
}
