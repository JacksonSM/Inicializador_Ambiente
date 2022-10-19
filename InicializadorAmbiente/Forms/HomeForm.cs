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

    private void CriarAmbiente(object sender, EventArgs e)
    {
        var form = new Create_EditForm();
        form.FormCriarAmbiente();
        form.FormClosed += HomeForm_Load;
        form.Show();
    }

    private void IniciarAmbiente(object sender, EventArgs e)
    {
        var ambiente = (sender as Button).Tag as Ambiente;
        var inicializador = new Inicializador();
        inicializador.Iniciar(ambiente);
    }

    private void HomeForm_Load(object sender, EventArgs e)
    {
        AtualizarInicializadores();
        PopularMenuEditar();
    }

    private void PopularMenuEditar()
    {
        btn_Editar.DropDownItems.Clear();
        var inicializadores = flpAmbientes.Controls.OfType<Button>().ToList();

        List<Ambiente> ambientes = new List<Ambiente>();

        foreach (var button in inicializadores)
        {
            ambientes.Add(button.Tag as Ambiente);
        }

        ambientes.ForEach((ambiente) =>
        {
            var menuItem = new ToolStripMenuItem();
            menuItem.Text = ambiente.Nome;
            menuItem.Click += AtualizarInicializador;
            menuItem.Tag = ambiente;

            btn_Editar.DropDownItems.Add(menuItem);
        });
    }

    private void AtualizarInicializador(object sender, EventArgs e)
    {
        var form = new Create_EditForm();

        form.FormAtualizarAmbiente((sender as ToolStripMenuItem).Tag as Ambiente);
        form.FormClosed += HomeForm_Load;
        form.Show();
    }
}
