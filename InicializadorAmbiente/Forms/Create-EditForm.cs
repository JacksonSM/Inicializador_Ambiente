using InicializadorAmbiente.Data;
using InicializadorAmbiente.Extensions;
using InicializadorAmbiente.Models;

namespace InicializadorAmbiente.Forms;
public partial class Create_EditForm : Form
{
    private const string GB_SITE = "gbSite";
    private const string TB_SITE_URL = "tbURL";

    private const string GB_PROGRAMA = "gbPrograma";
    private const string TB_PROGRAMA_CAMINHO = "tb_Programa_Caminho";

    public Create_EditForm()
    {
        InitializeComponent();
    }

    internal void FormCriarAmbiente()
    {
        btnSalvar.Click += SalvarAmbiente;
        this.Text = "Criar Ambiente";
    }

    internal void FormAtualizarAmbiente(Ambiente ambiente)
    {
        btnSalvar.Click += AtualizarAmbiente;
        IdAmbienteAtualizar = ambiente.Id;
        this.Text = $"Atualizar: {ambiente.Nome}";
        btnDeletarAmbiente.Visible = true;
        PopularTela(ambiente);
    }

    private void adcSite_Click(object sender, EventArgs e)
    {
        ClonarGrupoSite(null);

        //TODO - Colocar cada bloco em classes tipadas que tem a funcao de clona os componentes.
    }

    private void adcPrograma_Click(object sender, EventArgs e)
    {
        ClonarGrupoPrograma(null);
    }

    private void DeletarAplicacao(object sender, EventArgs e)
    {
        var btn = sender as Button;
        btn.Parent.Dispose();
    }

    private void BuscarAtalho(object sender, EventArgs e)
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

    private async void SalvarAmbiente(object sender, EventArgs e)
    {
        if (ValidarDados(out string errorMessage))
        {

            var ambiente = CapturarDadosAmbiente();
            await AmbienteDao.SalvarNovoAmbiente(ambiente);

            this.Close();
        }
        else
        {
            MessageBox.Show(errorMessage);
        }
    }

    private int IdAmbienteAtualizar;
    private async void AtualizarAmbiente(object sender, EventArgs e)
    {
        if (ValidarDados(out string errorMessage))
        {

            var ambiente = CapturarDadosAmbiente();
            ambiente.Id = IdAmbienteAtualizar;
            await AmbienteDao.AtualizarAmbiente(ambiente);

            this.Close();
        }
        else
        {
            MessageBox.Show(errorMessage);
        }
    }

    private async void btnDeletarAmbiente_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox
            .Show("Desejar mesmo deletar o ambiente ?", "!!!!!!!!!", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            await AmbienteDao.DeletarAmbiente(IdAmbienteAtualizar);
            this.Close();
        }
    }

    private void PopularTela(Ambiente ambiente)
    {
        tbNomeAmbiente.Text = ambiente.Nome;
        numIntervalo.Value = ambiente.IntervaloEmSegundos;

        foreach (var aplicacao in ambiente.Aplicacoes)
        {
            if(aplicacao.Tipo == "SITE")
            {
                ClonarGrupoSite(aplicacao);
            }
            else
            {
                ClonarGrupoPrograma(aplicacao);
            }
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


    #region Clonagem

    private void ClonarGrupoSite(Aplicacao aplicacao)
    {
        var grupBox = template_gbSite.Clone();
        grupBox.Name = GB_SITE;
        grupBox.Visible = true;
        grupBox.Parent = flowAplicacoes;

        var lbl = lblURL.Clone();
        lbl.Visible = true;
        lbl.Parent = grupBox;

        var tb = template_tbURL.Clone();
        tb.Name = TB_SITE_URL;
        tb.Validating += tbURL_Validating;
        tb.Validated += tbURL_Validated;
        tb.Visible = true;
        tb.Parent = grupBox;

        var btn = btn_Site_Del.Clone();
        btn.Visible = true;
        btn.Click += DeletarAplicacao;
        btn.Parent = grupBox;

        if (aplicacao != null)
        {
            tb.Text = aplicacao.Caminho;
        }
    }

    private void ClonarGrupoPrograma(Aplicacao aplicacao)
    {
        var grupBox = template_gbPrograma.Clone();
        grupBox.Name = GB_PROGRAMA;
        grupBox.Visible = true;
        grupBox.Parent = flowAplicacoes;

        var lbl = lblCaminho.Clone();
        lbl.Visible = true;
        lbl.Parent = grupBox;

        var tb = template_tbPrograma_Caminho.Clone();
        tb.Name = TB_PROGRAMA_CAMINHO;
        tb.Visible = true;
        tb.Parent = grupBox;

        var btnDel = btn_Programa_Del.Clone();
        btnDel.Visible = true;
        btnDel.Click += DeletarAplicacao;
        btnDel.Parent = grupBox;

        var btnBuscar = btn_Programa_Buscar.Clone();
        btnBuscar.Visible = true;
        btnBuscar.Click += BuscarAtalho;
        btnBuscar.Parent = grupBox;

        if (aplicacao != null)
        {
            tb.Text = aplicacao.Caminho;
        }

    }
    #endregion


    #region Validacao
    private void tbURL_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        var text = (sender as TextBox).Text;

        if (!Uri.IsWellFormedUriString(text, UriKind.Absolute))
        {
            errorProvider1.SetError(sender as Control, "URL Invalido !!");
        }
    }

    private void tbURL_Validated(object sender, EventArgs e)
    {
        var text = (sender as TextBox).Text;

        if (Uri.IsWellFormedUriString(text, UriKind.Absolute))
        {
            errorProvider1.SetError(sender as Control, "");
        }
    }

    private bool ValidarDados(out string errorMessage)
    {

        if (string.IsNullOrEmpty(tbNomeAmbiente.Text))
        {
            errorMessage = "Nome do ambiente estar vazia !!";
            return false;
        }

        //Valida se existe aplicacao. Se for igual a 2 é por que nao tem aplicação.
        if (flowAplicacoes.Controls.Count == 2)
        {
            errorMessage = "Deve ter pelo menos uma aplicação no ambiente.";
            return false;
        }

        var sites = flowAplicacoes.Controls
            .OfType<GroupBox>().Where(x => x.Name == GB_SITE).ToList();

        List<TextBox> urls = new List<TextBox>();

        foreach (var url in sites)
        {
            urls.Add(url.Controls.OfType<TextBox>().FirstOrDefault(x => x.Name == TB_SITE_URL));
        }

        foreach (var tbUrl in urls)
        {
            if (string.IsNullOrEmpty(tbUrl.Text))
            {
                errorMessage = "Existe campos vazio.";
                return false;
            }

            if (!string.IsNullOrEmpty(errorProvider1.GetError(tbUrl)))
            {
                errorMessage = errorProvider1.GetError(tbUrl);
                return false;
            }
        }
        errorMessage = "";
        return true;
    }

    #endregion

}

