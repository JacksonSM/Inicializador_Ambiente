using InicializadorAmbiente.Models;
using Newtonsoft.Json;

namespace InicializadorAmbiente.Data;
public class AmbienteDao
{
    private static string Caminho = Application.UserAppDataPath;
    private const string NOME_AMBIENTE = "config_ambiente.txt";

    public static async Task SalvarAmiente(Ambiente novoAmbiente) 
    {
        var ambientes = ObterAmbientes();
        ambientes.Add(novoAmbiente);
        await SalvarArquivo(ambientes);
    }

    public static List<Ambiente> ObterAmbientes()
    {
        string folder = Caminho;
        string arquivo = Path.Combine(folder, NOME_AMBIENTE);

        if (!File.Exists(arquivo))      
            return new List<Ambiente>();

        var ambientesJson = File.ReadAllText(arquivo);

        var teste = JsonConvert.DeserializeObject<List<Ambiente>>(ambientesJson);

        return teste;
    }

    private static async Task SalvarArquivo(List<Ambiente> ambientes)
    {
        string folder = Caminho;
        string arquivo = Path.Combine(folder, NOME_AMBIENTE);

        Directory.CreateDirectory(folder);

        File.Create(arquivo).Dispose();

        var ambientesSerializado = JsonConvert.SerializeObject(ambientes);

        await File.WriteAllTextAsync(arquivo, ambientesSerializado);
    }
}
