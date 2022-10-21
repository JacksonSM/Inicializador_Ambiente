using InicializadorAmbiente.Models;
using Newtonsoft.Json;

namespace InicializadorAmbiente.Data;
public class AmbienteDao
{
    private static readonly string Caminho = Application.UserAppDataPath;
    private const string NOME_AMBIENTE = "config_ambiente.txt";

    public static async Task SalvarNovoAmbiente(Ambiente novoAmbiente) 
    {
        var ambientes = ObterAmbientes();
        novoAmbiente.Id = GerarId(ambientes.Select(x => x.Id).ToArray());
   
        ambientes.Add(novoAmbiente);
        await SalvarArquivo(ambientes);
    }

    public static async Task AtualizarAmbiente(Ambiente ambienteAtualizado)
    {
        var ambientes = ObterAmbientes();

        ambientes.ForEach((ambienteLis) =>
        {
            if(ambienteLis.Id == ambienteAtualizado.Id)
            {
                ambienteLis.Atualizar(ambienteAtualizado);
            }
        });

        await SalvarArquivo(ambientes);
    }

    public static async Task DeletarAmbiente(int ambienteId)
    {
        var ambientes = ObterAmbientes();

        ambientes.RemoveAll(x => x.Id == ambienteId);

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

    private static int GerarId(int[] Ids)
    {
        var random = new Random();
        int idNovo;

        do
            //Gerar um valor aleatório de 0 a 2000, e caso ja tenha um mesmo id, 
            //vai gerar de novo, até encontrar um id que não exista.
            idNovo = random.Next(0, 2000);

        while (Ids.Contains(idNovo));

        return idNovo;
    }
}
