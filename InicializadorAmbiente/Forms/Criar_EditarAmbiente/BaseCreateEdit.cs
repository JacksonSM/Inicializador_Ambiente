using InicializadorAmbiente.Extensions;
using InicializadorAmbiente.Models;

namespace InicializadorAmbiente.Forms;
public partial class BaseCreateEdit : Form
{
    private const string GB_SITE = "gbSite";
    private const string TB_SITE_URL = "tbURL";

    private const string GB_PROGRAMA = "gbPrograma";
    private const string TB_PROGRAMA_CAMINHO = "tb_Programa_Caminho";


    private void AdicionarBlocoSite_Click(object sender, EventArgs e)
    {
        ClonarBlocoSite(null);

        //TODO - Colocar cada bloco em classes tipadas que tem a funcao de clona os componentes.
    }

    private void AdicionarBlocoPrograma_Click(object sender, EventArgs e)
    {
        ClonarBlocoPrograma(null);
    }

    private void DeletarBlocoAplicacao_Click(object sender, EventArgs e)
    {
        var btn = sender as Button;
        btn.Parent.Dispose();
    }

    private void BuscarAtalho_Click(object sender, EventArgs e)
    {
        var btn = sender as Button;
        var tbCampo = btn.Parent.Controls.OfType<TextBox>()
            .FirstOrDefault(x => x.Enabled == false);

        OpenFileDialog janela = new OpenFileDialog();
     
        
        if(janela.ShowDialog() == DialogResult.OK)
        {
            tbCampo.Text = janela.FileName;
        }
    }

    #region CapturarDados
    private Ambiente CapturarDadosAmbiente()
    {
        Ambiente ambiente = new Ambiente();
        ambiente.Nome = tbNomeAmbiente.Text;
        ambiente.IntervaloEmSegundos = numIntervalo.Value;

        var dadosSites = CapturarSites();
        var dadosPrograma = CapturarProgramas();

        ambiente.Aplicacoes.AddRange(dadosSites);
        ambiente.Aplicacoes.AddRange(dadosPrograma);

        return ambiente;
    }

    private List<Aplicacao> CapturarSites()
    {
        var sites = flowAplicacoes.Controls
            .OfType<GroupBox>().Where(x => x.Name == GB_SITE).ToList();

        List<Aplicacao> aplicacoes = new();
        foreach (var site in sites)
        {
            var url = site.Controls.OfType<TextBox>()
                .FirstOrDefault(x => x.Name == TB_SITE_URL).Text;
            aplicacoes.Add(Aplicacao.CriarSite(url));
        }
        return aplicacoes;
    }

    private List<Aplicacao> CapturarProgramas()
    {
        var sites = flowAplicacoes.Controls
            .OfType<GroupBox>().Where(x => x.Name == GB_PROGRAMA).ToList();

        List<Aplicacao> aplicacoes = new();
        foreach (var site in sites)
        {
            var url = site.Controls.OfType<TextBox>()
                .FirstOrDefault(x => x.Name == TB_PROGRAMA_CAMINHO).Text;

            aplicacoes.Add(Aplicacao.CriarPrograma(url));
        }
        return aplicacoes;
    }

    #endregion


}

