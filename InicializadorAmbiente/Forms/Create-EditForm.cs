using InicializadorAmbiente.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicializadorAmbiente.Forms;
public partial class Create_EditForm : Form
{
    public Create_EditForm()
    {
        InitializeComponent();
    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void adcSite_Click(object sender, EventArgs e)
    {
        var grupBox = gbSite.Clone();
        grupBox.Visible = true;
        grupBox.Parent = flowAplicacoes;

        var lbl = lblURL.Clone();
        lbl.Visible = true;
        lbl.Parent = grupBox;

        var tb = tbSite.Clone();
        tb.Visible = true;
        tb.Parent = grupBox;

        var btn = btn_Site_Del.Clone();
        btn.Visible = true;
        btn.Click += DeletarAplicacao;
        btn.Parent = grupBox;

        //TODO - Colocar cada bloco em classes tipadas que tem a funcao de clona os componentes.
    }
    private void adcPrograma_Click(object sender, EventArgs e)
    {
        var grupBox = gbPrograma.Clone();
        grupBox.Visible = true;
        grupBox.Parent = flowAplicacoes;

        var lbl = lblCaminho.Clone();
        lbl.Visible = true;
        lbl.Parent = grupBox;

        var tb = tb_Programa_Caminho.Clone();
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
}
