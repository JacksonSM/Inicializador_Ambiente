namespace InicializadorAmbiente.Models;
public class Aplicacao
{
    private const string SITE = "SITE";
    private const string PROGRAMA = "PROGRAMA";

    public string Tipo { get; set; }
    public string Caminho { get;  set; }

    public Aplicacao(){}

    private Aplicacao(string tipo, string caminho)
    {
        Tipo = tipo;
        Caminho = caminho;
    }

    public static Aplicacao CriarSite(string caminho)
    {
        return new Aplicacao(SITE, caminho);
    }
    public static Aplicacao CriarPrograma(string caminho)
    {
        return new Aplicacao(PROGRAMA, caminho);
    }
}
