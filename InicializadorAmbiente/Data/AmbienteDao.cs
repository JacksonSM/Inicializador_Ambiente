using InicializadorAmbiente.Models;
using Newtonsoft.Json;

namespace InicializadorAmbiente.Data;
public class AmbienteDao
{
    private static string Caminho = Application.UserAppDataPath;
    private const string NOME_AMBIENTE = "config_ambiente.txt";
    public static async Task SalvarAmiente(Ambiente ambiente) 
    { 
        var ambienteSerializado = JsonConvert.SerializeObject(ambiente);

        string folder = Caminho;
        string arquivo = Path.Combine(folder, NOME_AMBIENTE);
        
        Directory.CreateDirectory(folder);

        File.Create(arquivo).Dispose();

        await File.WriteAllTextAsync(arquivo, ambienteSerializado);
    }
}
