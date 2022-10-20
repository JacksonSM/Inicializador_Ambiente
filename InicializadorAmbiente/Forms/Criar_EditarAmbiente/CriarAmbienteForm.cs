using InicializadorAmbiente.Data;

namespace InicializadorAmbiente.Forms;
public partial class BaseCreateEdit
{
    public BaseCreateEdit()
    {
        InitializeComponent();
        btnSalvar.Click += SalvarAmbiente;
        this.Text = "Criar Ambiente";
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

}
