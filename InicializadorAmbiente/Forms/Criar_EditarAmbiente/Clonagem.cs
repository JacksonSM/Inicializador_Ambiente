using InicializadorAmbiente.Extensions;
using InicializadorAmbiente.Models;

namespace InicializadorAmbiente.Forms;
public partial class BaseCreateEdit
{
    private void ClonarBlocoSite(Aplicacao aplicacao)
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
        tb.Validating += TextBox_URL_Validating;
        tb.Validated += TextBox_URL_Validated;
        tb.Visible = true;
        tb.Parent = grupBox;

        var btn = btn_Site_Del.Clone();
        btn.Visible = true;
        btn.Click += DeletarBlocoAplicacao_Click;
        btn.Parent = grupBox;

        if (aplicacao != null)
        {
            tb.Text = aplicacao.Caminho;
        }
    }

    private void ClonarBlocoPrograma(Aplicacao aplicacao)
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
        btnDel.Click += DeletarBlocoAplicacao_Click;
        btnDel.Parent = grupBox;

        var btnBuscar = btn_Programa_Buscar.Clone();
        btnBuscar.Visible = true;
        btnBuscar.Click += BuscarAtalho_Click;
        btnBuscar.Parent = grupBox;

        if (aplicacao != null)
        {
            tb.Text = aplicacao.Caminho;
        }

    }

}
