using InicializadorAmbiente.Data;
using InicializadorAmbiente.Extensions;
using InicializadorAmbiente.Models;

namespace InicializadorAmbiente.Forms;
public partial class HomeForm : Form
{
    public List<Ambiente> Ambiente { get; set; }
    public HomeForm()
    {
        InitializeComponent();   
    }

    public void AtualizarInicializadores()
    {
        flpAmbientes.Controls.Clear();
        var ambientes = AmbienteDao.ObterAmbientes();
        foreach (var abt in ambientes)
        {
            CriarInicializador(abt);
        }
    }
    private void CriarInicializador(Ambiente ambiente)
    {
        var inicializador = btnTemplateInicializador.Clone();
        inicializador.Text = ambiente.Nome;
        inicializador.Tag = ambiente;
        inicializador.Click += IniciarAmbiente;
        inicializador.Visible = true;
        inicializador.Parent = flpAmbientes;
    }

    private void btn_CriarAmbiente_Click(object sender, EventArgs e)
    {
        var formCriarAmbiente = new Create_EditForm();
        formCriarAmbiente.FormClosed += HomeForm_Load;
        formCriarAmbiente.Show();
    }
    private void IniciarAmbiente(object sender, EventArgs e)
    {
        var ambiente = (sender as Button).Tag as Ambiente;
        
    }

    private void HomeForm_Load(object sender, EventArgs e)
    {
        AtualizarInicializadores();
    }
}
