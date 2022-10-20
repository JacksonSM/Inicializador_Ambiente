using InicializadorAmbiente.Data;
using InicializadorAmbiente.Models;

namespace InicializadorAmbiente.Forms;
public partial class BaseCreateEdit
{
    private readonly int _ambienteId;

    public BaseCreateEdit(Ambiente ambiente)
    {
        InitializeComponent();
        btnSalvar.Click += AtualizarAmbiente;
        _ambienteId = ambiente.Id;
        this.Text = $"Atualizar: {ambiente.Nome}";
        btnDeletarAmbiente.Visible = true;
        PopularTela(ambiente);

    }

    private async void AtualizarAmbiente(object sender, EventArgs e)
    {
        if (ValidarDados(out string errorMessage))
        {

            var ambiente = CapturarDadosAmbiente();
            ambiente.Id = _ambienteId;
            await AmbienteDao.AtualizarAmbiente(ambiente);

            this.Close();
        }
        else
        {
            MessageBox.Show(errorMessage);
        }
    }

    private async void DeletarAmbiente(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox
            .Show("Desejar mesmo deletar o ambiente ?", "!!!!!!!!!", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            await AmbienteDao.DeletarAmbiente(_ambienteId);
            this.Close();
        }
    }

    private void PopularTela(Ambiente ambiente)
    {
        tbNomeAmbiente.Text = ambiente.Nome;
        numIntervalo.Value = ambiente.IntervaloEmSegundos;

        foreach (var aplicacao in ambiente.Aplicacoes)
        {
            if (aplicacao.Tipo == "SITE")
            {
                ClonarBlocoSite(aplicacao);
            }
            else
            {
                ClonarBlocoPrograma(aplicacao);
            }
        }
    }
}
