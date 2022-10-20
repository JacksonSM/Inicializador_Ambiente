namespace InicializadorAmbiente.Forms;
public partial class BaseCreateEdit
{

    private void TextBox_URL_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        var text = (sender as TextBox).Text;

        if (!Uri.IsWellFormedUriString(text, UriKind.Absolute))
        {
            errorProvider1.SetError(sender as Control, "URL Invalido !!");
        }
    }

    private void TextBox_URL_Validated(object sender, EventArgs e)
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

        //Valida se existe aplicacao. Se for igual a 2 é por que nao tem aplicação. Devido aos componetes que estao para clonagem
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

}
