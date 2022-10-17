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
public partial class HomeForm : Form
{
    public HomeForm()
    {
        InitializeComponent();
    }

    private void btn_CriarAmbiente_Click(object sender, EventArgs e)
    {
        new Create_EditForm().Show();
    }
}
